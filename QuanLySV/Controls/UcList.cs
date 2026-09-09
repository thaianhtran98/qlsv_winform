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
using QuanLySV.Helpers;

namespace QuanLySV.Controls
{
	public partial class UcList : UserControl
	{
		/// <summary>Edit</summary>
		private const int COL_EDIT = 12;
		/// <summary>Delete</summary>
		private const int COL_DELETE = 13;
		private GridViewHelper _GridViewHelper;

		public UcList()
		{
			InitializeComponent();
			_GridViewHelper = new GridViewHelper();
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
			DgvListSV.BackgroundColor = Color.White;
			DgvListSV.BorderStyle = BorderStyle.None;
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["MSSV"], 65);
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvSex"], 70);
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvBirthOfDate"], 90);
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvVneId"], 100);
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvDateOfIssue"], 90);
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvNumberPhone"], 100);
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvStatus"], 115);
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvActionEdit"], 60);
			_GridViewHelper.SetFixedColumn(DgvListSV.Columns["GgvActionDelete"], 60);

			_GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvName"], 130, 120);
			_GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvBirthLocal"], 100, 100);
			_GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvLocalOfIssue"], 100, 100);
			_GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvLocal"], 100, 100);
			_GridViewHelper.SetFillColumn(DgvListSV.Columns["GgvPlaceOfResidence"], 180, 180);
		}
	}
}
