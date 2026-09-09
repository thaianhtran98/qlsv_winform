using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using QuanLySV.Services;
using QuanLySV.Models;

namespace QuanLySV.Controls
{
	public partial class UcList : UserControl
	{
		/// <summary>Edit</summary>
		private const int COL_EDIT = 12;
		/// <summary>Delete</summary>
		private const int COL_DELETE = 13;

		public UcList()
		{
			InitializeComponent();
			ConfigGridView();
			DgvListSV.CellContentClick += EditStudent;
			DgvListSV.CellContentClick += DeleteStudent;
			LoadStudent();
			LoadComboBox();
		}

		public void LoadStudent(int status = -1, int sex = -1)
		{
			DgvListSV.Rows.Clear();
			ArrayList students = StudentService.FillStudent(status, sex);
			if (students == null) return;

			foreach (Student student in students)
			{
				int rowIndex = DgvListSV.Rows.Add(
					student.StudentId,
					student.Name,
					student.Sex == Student.MALE ? "Nam" : "Nữ",
					student.BirthOfDate.ToString("dd/MM/yyyy"),
					student.BirthLocal,
					student.VneId,
					student.DateOfIssue.ToString("dd/MM/yyyy"),
					student.LocalOfIssue,
					student.Local,
					student.PlaceOfResidence,
					student.NumberPhone,
					student.Status == Student.ACTIVE ? "Đang hoạt động" : "Ngưng hoạt động",
					"Sửa",
					"Xóa"
				);

				DgvListSV.Rows[rowIndex].Tag = student;
			}
		}

		private void EditStudent(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == COL_EDIT)
			{
				Student student = DgvListSV.Rows[e.RowIndex].Tag as Student;
				if (student != null)
				{
					Form1 mainForm = this.FindForm() as Form1;
					if (mainForm != null)
					{
						mainForm.ShowUc(new UcFormEdit(student.StudentId, true));
					}
					else if (this.Parent != null)
					{
						Control parentContainer = this.Parent;
						while (parentContainer.Controls.Count > 0)
						{
							var oldControl = parentContainer.Controls[0];
							parentContainer.Controls.RemoveAt(0);
							oldControl.Dispose();
						}

						UcFormEdit ucFormEdit = new UcFormEdit(student.StudentId, true);
						ucFormEdit.Dock = DockStyle.Fill;
						parentContainer.Controls.Add(ucFormEdit);
					}
				}
			}
		}

		private void DeleteStudent(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == COL_DELETE)
			{
				Student student = DgvListSV.Rows[e.RowIndex].Tag as Student;
				if (student != null)
				{
					if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						StudentService.DeleteStudent(student.StudentId);
						LoadStudent();
					}
				}
			}
		}

		private void LoadComboBox()
		{
			var listStatus = new List<object>
			{
				new { Value = -1, Text = "Tất cả" },
				new { Value = Student.ACTIVE, Text = "Đang hoạt động" },
				new { Value = Student.INACTIVE, Text = "Ngưng hoạt động" }
			};

			CbxStatus.DisplayMember = "Text";   
			CbxStatus.ValueMember = "Value";   
			CbxStatus.DataSource = listStatus;
			CbxStatus.SelectedValue = Student.ACTIVE;

			var listSex = new List<object>
			{
				new { Value = -1, Text = "Tất cả" },
				new { Value = Student.MALE, Text = "Nam" },
				new { Value = Student.FEMALE, Text = "Nữ" }
			};

			CbxSex.DisplayMember = "Text";
			CbxSex.ValueMember = "Value";
			CbxSex.DataSource = listSex;
		}

		private void FilterStudents()
		{
			if (CbxStatus.SelectedValue == null || CbxSex.SelectedValue == null) return;

			int status;
			int sex;
			if (int.TryParse(CbxStatus.SelectedValue.ToString(), out status) && int.TryParse(CbxSex.SelectedValue.ToString(), out sex))
			{
				LoadStudent(status, sex);
			}
		}

		private void CbxStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			FilterStudents();
		}

		private void CbxSex_SelectedIndexChanged(object sender, EventArgs e)
		{
			FilterStudents();
		}

		private void ConfigGridView()
		{
			// 1. Xử lý vùng trống phía dưới: Đổi nền xám thành màu trắng cho đẹp mắt, hiện đại
			DgvListSV.BackgroundColor = Color.White;
			DgvListSV.BorderStyle = BorderStyle.None;
			// 2. Cấu hình các cột cố định (giữ nguyên kích thước chuẩn, không bị dãn thô khi fullscreen)
			SetFixedColumn(DgvListSV.Columns["MSSV"], 65);
			SetFixedColumn(DgvListSV.Columns["GgvSex"], 70);
			SetFixedColumn(DgvListSV.Columns["GgvBirthOfDate"], 90);
			SetFixedColumn(DgvListSV.Columns["GgvVneId"], 100);
			SetFixedColumn(DgvListSV.Columns["GgvDateOfIssue"], 90);
			SetFixedColumn(DgvListSV.Columns["GgvNumberPhone"], 100);
			SetFixedColumn(DgvListSV.Columns["GgvStatus"], 115);
			SetFixedColumn(DgvListSV.Columns["GgvActionEdit"], 60);
			SetFixedColumn(DgvListSV.Columns["GgvActionDelete"], 60);
			// 3. Cấu hình các cột dữ liệu dài: Tự động dãn (Fill) khi fullscreen,
			//    nhưng khi màn hình nhỏ sẽ không bao giờ co nhỏ hơn MinimumWidth
			SetFillColumn(DgvListSV.Columns["GgvName"], 130, 120);            // Họ và tên
			SetFillColumn(DgvListSV.Columns["GgvBirthLocal"], 100, 100);       // Quê quán
			SetFillColumn(DgvListSV.Columns["GgvLocalOfIssue"], 100, 100);     // Nơi cấp
			SetFillColumn(DgvListSV.Columns["GgvLocal"], 100, 100);            // Tỉnh/Thành phố
			SetFillColumn(DgvListSV.Columns["GgvPlaceOfResidence"], 180, 180); // Địa chỉ thường trú (dãn nhiều nhất)
		}

		// Hàm hỗ trợ cột cố định
		private void SetFixedColumn(DataGridViewColumn col, int width)
		{
			if (col == null) return;
			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			col.Width = width;
			col.MinimumWidth = width;
		}

		// Hàm hỗ trợ cột co dãn linh hoạt
		private void SetFillColumn(DataGridViewColumn col, int minWidth, float fillWeight)
		{
			if (col == null) return;
			col.MinimumWidth = minWidth; // Giữ nguyên độ rộng này khi ở màn hình nhỏ
			col.FillWeight = fillWeight; // Tỉ lệ chia sẻ khoảng trống khi Fullscreen
			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

	}
}
