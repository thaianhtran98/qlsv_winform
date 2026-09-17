using QuanLySV.Adapters;
using QuanLySV.Data;
using QuanLySV.Helpers;
using QuanLySV.Models;
using QuanLySV.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV.Controls
{
	public partial class UcList : UserControl
	{
		private const int COL_EDIT = 12;
		private const int COL_DELETE = 13;
		private GridViewHelper GridViewHelper;

		public UcList()
		{
			InitializeComponent();
			GridViewHelper = new GridViewHelper();
			ConfigGridView();
			DgvListSV.CellContentClick += EditStudent;
			DgvListSV.CellContentClick += DeleteStudent;
			LoadStudent();
			LoadComboBox();
		}

		public void LoadStudent(int status = -1, int sex = -1)
		{
			DgvListSV.Rows.Clear();
			StudentDataSet ds = StudentDataSet.Instance;
			ds.Fill(status, sex);

			DataTable studentTable = ds.StudentTable;
			if (studentTable == null || studentTable.Rows.Count == 0) return;

			Student student = null;
			int rowIndex = 0;
			foreach (DataRow row in studentTable.Rows)
			{
				student = StudentAdapter.MapRowToStudent(row);
				rowIndex = DgvListSV.Rows.Add(
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
					student.Status == Student.ACTIVE ? "Sửa" : null,
            			student.Status == Student.ACTIVE ? "Xóa" : null
				);

				if (student.Status != Student.ACTIVE)
				{
					DgvListSV.Rows[rowIndex].Cells[COL_EDIT] = new DataGridViewTextBoxCell();
					DgvListSV.Rows[rowIndex].Cells[COL_EDIT].ReadOnly = true;
                         DgvListSV.Rows[rowIndex].Cells[COL_DELETE] = new DataGridViewTextBoxCell();
					DgvListSV.Rows[rowIndex].Cells[COL_DELETE].ReadOnly = true;
                    }
				DgvListSV.Rows[rowIndex].Tag = student;
			}
		}

		private void EditStudent(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == COL_EDIT)
			{
				Student student = DgvListSV.Rows[e.RowIndex].Tag as Student;
				if (student != null && student.Status == Student.ACTIVE)
				{
					FrmMain mainForm = this.FindForm() as FrmMain;
					if (mainForm != null)
					{
						mainForm.ShowUc(new UcFormEdit(student.StudentId, true));
					}
				}
			}
		}

		private void DeleteStudent(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == COL_DELETE)
			{
				Student student = DgvListSV.Rows[e.RowIndex].Tag as Student;
				if (student != null && student.Status == Student.ACTIVE)
				{
					if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						StudentService.DeleteStudent(student.StudentId);
						FilterStudents();
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
			DgvListSV.AllowUserToAddRows = false;
			DgvListSV.AllowUserToDeleteRows = false;
			DgvListSV.AllowUserToResizeRows = false;
			DgvListSV.BackgroundColor = AppColor.Surface;
			DgvListSV.BorderStyle = BorderStyle.None;
			DgvListSV.DefaultCellStyle.SelectionBackColor = AppColor.Selection;
			DgvListSV.DefaultCellStyle.SelectionForeColor = AppColor.TextDark;
			DgvListSV.ColumnHeadersDefaultCellStyle.BackColor = AppColor.GridHeader;
			DgvListSV.ColumnHeadersDefaultCellStyle.ForeColor = AppColor.TextDark;
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["MSSV"], 65);
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvSex"], 70);
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvBirthOfDate"], 90);
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvVneId"], 100);
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvDateOfIssue"], 90);
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvNumberPhone"], 100);
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvStatus"], 115);
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvActionEdit"], 60);
			GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvActionDelete"], 60);

			GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvName"], 130, 120);
			GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvBirthLocal"], 100, 100);
			GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvLocalOfIssue"], 100, 100);
			GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvLocal"], 100, 100);
			GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvPlaceOfResidence"], 180, 180);
		}
	}
}
