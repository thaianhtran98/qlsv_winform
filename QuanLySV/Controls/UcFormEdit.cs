using System;
using System.Data;
using System.Windows.Forms;
using QuanLySV.Data;
using QuanLySV.Models;
using QuanLySV.Services;

namespace QuanLySV.Controls
{
	public partial class UcFormEdit : UserControl
	{
		private string _studentId = null;
		private bool _isEdit = false;
		private bool _isSaved = false;

		public UcFormEdit(string studentId, bool isEdit)
		{
			InitializeComponent();
			_studentId = studentId;
			_isEdit = isEdit;
			_isSaved = isEdit;

			// Tab 1: Binding sinh viên vào StudentDataSet.BindingSource
			SetupStudentBinding(studentId, isEdit);

			// Tab 2: Khởi tạo thông tin sinh viên cho UC học tập
			if (isEdit && !string.IsNullOrEmpty(studentId))
			{
				ucStudentAcademic.LoadData(studentId);
			}

			TabMain.SelectedIndexChanged += TabMain_SelectedIndexChanged;
		}

		private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TabMain.SelectedTab == TabPageAcademic)
			{
				string sid = TbxStudentId.Text.Trim();
				if (string.IsNullOrEmpty(sid))
				{
					MessageBox.Show("Vui lòng nhập mã số sinh viên trước khi xem hoặc thêm thông tin học tập.",
					    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					TabMain.SelectedTab = TabPageStudent;
					TbxStudentId.Focus();
					return;
				}

				ucStudentAcademic.LoadData(sid);
			}
		}

		private void SetupStudentBinding(string studentId, bool isEdit)
		{
			// Instance StudentDataSet
			StudentDataSet ds = StudentDataSet.Instance;

			if (isEdit)
			{
				bool found = ds.NavigateTo(studentId);
				if (!found)
				{
					MessageBox.Show("Không tìm thấy sinh viên trong DataSet. Vui lòng refresh.",
					    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				TbxStudentId.ReadOnly = true;

				// Instantiate ucStudentAcademic with the current student ID
				StudentAcademicDataSet studentAcademicDataSet = StudentAcademicDataSet.Instance;
				if (studentAcademicDataSet != null)
				{
					studentAcademicDataSet.FillStudentAcademic(studentId);
				}
			}
			else
			{
				ds.AddNewRow();
			}

			BindControl(TbxStudentId, "Text", "STUDENTID");
			BindControl(TbxName, "Text", "NAME");
			BindControl(TbxBirthLocal, "Text", "BIRTHLOCAL");
			BindControl(TbxVneId, "Text", "VNEID");
			BindControl(TbxLocalOfIssue, "Text", "LOCALOFISSUE");
			BindControl(TbxLocal, "Text", "LOCAL");
			BindControl(TbxPlaceOfResidence, "Text", "PLACEOFRESIDENCE");
			BindControl(MskNumberPhone, "Text", "NUMBERPHONE");
			BindControl(DtpBirthOfDate, "Value", "BIRTHOFDATE");
			BindControl(DtpDateOfIssue, "Value", "DATEOFISSUE");

			LoadSexRadioButton();
			RbtMale.CheckedChanged += RbtSex_CheckedChanged;
			RbtFemale.CheckedChanged += RbtSex_CheckedChanged;
		}

		private void BindControl(Control control, string property, string column)
		{
			control.DataBindings.Clear();
			Binding b = new Binding(property, StudentDataSet.Instance.BindingSource, column, true, DataSourceUpdateMode.OnPropertyChanged);
			if (column == "STUDENTID")
			{
				b.NullValue = string.Empty;
				b.Parse += (s, ev) =>
				{
					if (ev.Value == null || ev.Value == DBNull.Value)
						ev.Value = string.Empty;
				};
			}
			control.DataBindings.Add(b);
		}

		public void ClearStudentBindings()
		{
			TbxStudentId.DataBindings.Clear();
			TbxName.DataBindings.Clear();
			TbxBirthLocal.DataBindings.Clear();
			TbxVneId.DataBindings.Clear();
			TbxLocalOfIssue.DataBindings.Clear();
			TbxLocal.DataBindings.Clear();
			TbxPlaceOfResidence.DataBindings.Clear();
			MskNumberPhone.DataBindings.Clear();
			DtpBirthOfDate.DataBindings.Clear();
			DtpDateOfIssue.DataBindings.Clear();
		}

		public void CancelEdit()
		{
			if (!_isSaved)
			{
				ClearStudentBindings();
				StudentDataSet.Instance.CancelPendingRow();
			}
		}

		private void LoadSexRadioButton()
		{
			DataRow row = StudentDataSet.Instance.CurrentRow;
			if (row == null) return;

			int sex = row["SEX"] != DBNull.Value ? Convert.ToInt32(row["SEX"]) : Student.MALE;
			RbtMale.Checked = (sex == Student.MALE);
			RbtFemale.Checked = (sex == Student.FEMALE);
		}

		private void RbtSex_CheckedChanged(object sender, EventArgs e)
		{
			DataRow row = StudentDataSet.Instance.CurrentRow;
			if (row == null) return;

			row.BeginEdit();
			row["SEX"] = RbtMale.Checked ? Student.MALE : Student.FEMALE;
			row.EndEdit();
		}

		private void BtnSaveTemp_Click(object sender, EventArgs e)
		{
			if (!ValidateStudentForm()) return;

			string sid = TbxStudentId.Text.Trim();
			StudentDataSet ds = StudentDataSet.Instance;
			DataRow row = ds.CurrentRow;
			if (row != null)
			{
				row.BeginEdit();
				row["STUDENTID"] = sid;
				row["NAME"] = TbxName.Text.Trim();
				row["STATUS"] = Student.ACTIVE;
				string phone = MskNumberPhone.Text.Replace("-", "").Trim();
				row["NUMBERPHONE"] = phone.Length > 0 ? (object)MskNumberPhone.Text.Trim() : DBNull.Value;
				row.EndEdit();
			}

			ds.BindingSource.EndEdit();
			_isSaved = true;

			MessageBox.Show("Đã lưu tạm vào DataSet. Nhấn 'Lưu' để lưu xuống DB.",
			    "Lưu tạm", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private bool SaveStudentDirect()
		{
			if (!ValidateStudentForm()) return false;

			string sid = TbxStudentId.Text.Trim();

			if (!_isEdit && StudentService.ExistsStudent(sid))
			{
				MessageBox.Show("Mã sinh viên '" + sid + "' đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập mã sinh viên khác.",
					"Trùng mã sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxStudentId.Focus();
				return false;
			}

			StudentDataSet ds = StudentDataSet.Instance;
			DataRow row = ds.CurrentRow;
			if (row == null) return false;

			row["STUDENTID"] = sid;
			row["NAME"] = TbxName.Text.Trim();
			row["STATUS"] = Student.ACTIVE;

			string phone = MskNumberPhone.Text.Replace("-", "").Trim();
			row["NUMBERPHONE"] = phone.Length > 0 ? (object)MskNumberPhone.Text.Trim() : DBNull.Value;

			ds.BindingSource.EndEdit();

			string errorMessage;
			bool saved = ds.Adapter.SaveStudent(row, !_isEdit, _isEdit ? _studentId : null, out errorMessage);

			if (saved)
			{
				_isSaved = true;
				_isEdit = true;
				_studentId = sid;
				TbxStudentId.ReadOnly = true;
				return true;
			}
			else
			{
				MessageBox.Show("Lưu sinh viên thất bại!\n" + (errorMessage ?? "Vui lòng kiểm tra lại dữ liệu."), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}

		private void SaveStudent(object sender, EventArgs e)
		{
			bool wasEdit = _isEdit;
			if (SaveStudentDirect())
			{
				string prefix = wasEdit ? "Cập nhật" : "Thêm";
				MessageBox.Show(prefix + " sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				string sid = TbxStudentId.Text.Trim();
				ucStudentAcademic.LoadData(sid);
			}
		}

		private bool ValidateStudentForm()
		{
			if (string.IsNullOrWhiteSpace(TbxStudentId.Text))
			{
				MessageBox.Show("Vui lòng nhập mã số sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxStudentId.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(TbxName.Text))
			{
				MessageBox.Show("Vui lòng nhập họ và tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxName.Focus();
				return false;
			}
			return true;
		}
	}
}

