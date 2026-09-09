using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySV.Models;
using QuanLySV.Helpers;
using System.Collections;
using QuanLySV.Services;

namespace QuanLySV.Controls
{
	public partial class UcFormEdit : UserControl
	{
		private bool _isLoading = false;
		private ArrayList StudentList;
		private Student CurrentStudent;
		private bool _isEdit = false;

		public UcFormEdit(string StudentId, bool isEdit)
		{
			InitializeComponent();
			ResetForm();
			_isEdit = isEdit;
			StudentList = new ArrayList();
			CurrentStudent = new Student();
			if (!string.IsNullOrEmpty(StudentId))
			{
				GetStudentByStudentId(StudentId);
			}
          }

		private void SaveStudent(object sender, EventArgs e)
		{
			if (StudentService.GetStudentByStudentId(CurrentStudent.StudentId) != null && !_isEdit)
			{
				MessageBox.Show("Sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (TbxStudentId.Text == String.Empty)
			{
				MessageBox.Show("Vui lòng nhập mã số sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (TbxName.Text == String.Empty)
			{
				MessageBox.Show("Vui lòng nhập họ và tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Student newStudent = new Student
			{
				StudentId = TbxStudentId.Text,
				Name = TbxName.Text,
				Sex = RbtFemale.Checked ? Student.FEMALE : Student.MALE,
				BirthOfDate = DateTime.Parse(DtpBirthOfDate.Value.ToString()),
				BirthLocal = TbxBirthLocal.Text,
				VneId = TbxVneId.Text,
				DateOfIssue = DateTime.Parse(DtpDateOfIssue.Value.ToString()),
				LocalOfIssue = TbxLocalOfIssue.Text,
				Local = TbxLocal.Text,
				PlaceOfResidence = TbxPlaceOfResidence.Text,
				NumberPhone = MskNumberPhone.Text,
				Status = Student.ACTIVE
			};

			bool result = false;
			string messagePrefix = _isEdit ? "Cập nhật " : "Thêm ";
			if (_isEdit)
			{
				result = StudentService.UpdateStudent(CurrentStudent.StudentId, newStudent);
			}
			else
			{
				result = StudentService.InsertStudent(newStudent);
			}

			if (result)
			{
				MessageBox.Show(messagePrefix + "sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(messagePrefix + "sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			if(!_isEdit && result)
			{
				ResetForm();
			}
		}

		private Student GetStudentByStudentId(string studentId)
		{
			CurrentStudent = StudentService.GetStudentByStudentId(studentId);
			if (_isEdit && CurrentStudent != null)
			{
				TbxStudentId.Text = CurrentStudent.StudentId;
				TbxName.Text = CurrentStudent.Name;

				if (CurrentStudent.Sex == Student.MALE)
				{
					RbtMale.Checked = true;
					RbtFemale.Checked = false;
				}
				else
				{
					RbtMale.Checked = false;
					RbtFemale.Checked = true;
				}
				DtpBirthOfDate.Value = CurrentStudent.BirthOfDate;
				TbxBirthLocal.Text = CurrentStudent.BirthLocal;
				TbxVneId.Text = CurrentStudent.VneId;
				DtpDateOfIssue.Value = CurrentStudent.DateOfIssue;
				TbxLocalOfIssue.Text = CurrentStudent.LocalOfIssue;
				TbxLocal.Text = CurrentStudent.Local;
				TbxPlaceOfResidence.Text = CurrentStudent.PlaceOfResidence;
				MskNumberPhone.Text = CurrentStudent.NumberPhone;
			}

			return CurrentStudent;
		}

		private void ResetForm()
		{
			TbxStudentId.Text = "";
			TbxName.Text = "";
			RbtMale.Checked = true;
			DtpBirthOfDate.Value = DateTime.Now;
			TbxBirthLocal.Text = "";
			TbxVneId.Text = "";
			DtpDateOfIssue.Value = DateTime.Now;
			TbxLocalOfIssue.Text = "";
			TbxLocal.Text = "";
			TbxPlaceOfResidence.Text = "";
			MskNumberPhone.Text = "";
		}
	}
}
