using QuanLySV.Adapters;
using QuanLySV.Data;
using QuanLySV.Forms;
using QuanLySV.Helpers;
using QuanLySV.Models;
using QuanLySV.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
namespace QuanLySV.Controls
{
	public partial class UcStudentAcademic : UserControl
	{
		private const int COL_CLASS_NAME = 0;
		private const int COL_SYEAR_NAME = 1;
		private const int COL_SUB_NAME = 2;
		private const int COL_SEMESTER = 3;
		private const int COL_SCORE = 4;
		private const int COL_SCORE_LETER = 5;
		private string StudentId = string.Empty;
		private StudentAcademic CurrentAcademic = null;
		private bool IsAddAcademic = false;
		private readonly List<StudentAcademic> AcademicList = new List<StudentAcademic>();

		public UcStudentAcademic()
		{
			InitializeComponent();
			ApplyAppColors();
			LoadComboBoxesFromDataSet();

			DgvAcademic.MouseDown += DgvAcademic_MouseDown;
			this.MouseDown += (s, e) => ClearAcademicSelection();
			PnlAcademicToolbar.MouseDown += (s, e) => ClearAcademicSelection();
		}

		private void ApplyAppColors()
		{
			AppColor.ApplyButtonAdd(BtnAddAcademic);
			AppColor.ApplyButtonEdit(BtnEditAcademic);
			AppColor.ApplyButtonDelete(BtnDeleteAcademic);
			AppColor.ApplyButtonSave(BtnSaveToDb);
			AppColor.ApplyButtonSave(BtnSaveTempAcademic);
			AppColor.ApplyButtonCancel(BtnCancelAcademic);
			AppColor.ApplyButtonAdd(BtnAddClass);
			AppColor.ApplyButtonAdd(BtnAddSchoolYear);
			AppColor.ApplyButtonAdd(BtnAddSubject);
			LblPendingAcademic.ForeColor = AppColor.WarningText;
		}

		public void LoadData(string studentId)
		{
			StudentId = studentId;

			// Ensure references are loaded (run at runtime, not in constructor)
			if (ReferenceDataSet.Instance.ClassTable.Rows.Count == 0)
			{
				ReferenceDataSet.Instance.FillAll();
			}

			FillAcademicList(StudentId);
			ShowAcademicForm(false);
			ResetAcademicForm();
		}

		public void ClearData()
		{
			StudentId = string.Empty;
			StudentAcademicDataSet.Instance.ClearStudentAcademic();
			DgvAcademic.Rows.Clear();
			ShowAcademicForm(false);
			ResetAcademicForm();
			ClearAcademicSelection();
		}

		// =============================================
		// ComboBox DataBinding according to FDS Pattern
		// =============================================
		private void LoadComboBoxesFromDataSet()
		{
			ReferenceDataSet ds = ReferenceDataSet.Instance;

			// Bind Class
			CbxClass.DisplayMember = "CLASSNAME";
			CbxClass.ValueMember = "CLASSID";
			CbxClass.DataSource = ds.ClassBindingSource;
			CbxClass.SelectedIndex = -1;

			// Bind School Year
			CbxSchoolYear.DisplayMember = "SCHOOLYEARNAME";
			CbxSchoolYear.ValueMember = "SCHOOLYEARID";
			CbxSchoolYear.DataSource = ds.SchoolYearBindingSource;
			CbxSchoolYear.SelectedIndex = -1;

			// Bind Subject
			CbxSubject.DisplayMember = "SUBJECTNAME";
			CbxSubject.ValueMember = "SUBJECTID";
			CbxSubject.DataSource = ds.SubjectBindingSource;
			CbxSubject.SelectedIndex = -1;
		}

		// =============================================
		// Fill List
		// =============================================
		private void FillAcademicList(string studentId)
		{
			DgvAcademic.Rows.Clear();
			if (string.IsNullOrEmpty(studentId)) return;

			StudentAcademicDataSet ds = StudentAcademicDataSet.Instance;
			DataTable studentAcademicTable = ds.StudentAcademicTable;
			if (studentAcademicTable == null || studentAcademicTable.Rows.Count == 0) return;

			StudentAcademic studentAcademic = null;
			int rowIdx = 0;
			foreach (DataRow row in studentAcademicTable.Rows)
			{
				studentAcademic = StudentAcademicAdapter.MapRowToStudentAcademic(row);
				if (studentAcademic == null)
				{
					continue;
				}

				rowIdx = DgvAcademic.Rows.Add(
					studentAcademic.ClassName,
					studentAcademic.SchoolYearName,
					studentAcademic.SubjectName,
					studentAcademic.Semester > 0 ? "HK" + studentAcademic.Semester : string.Empty,
					studentAcademic.Score.HasValue ? studentAcademic.Score.Value.ToString("0.##") : string.Empty,
					studentAcademic.ScoreLetter,
					studentAcademic.Note
				);

				DgvAcademic.Rows[rowIdx].Tag = studentAcademic;
			}
			ClearAcademicSelection();
		}

		private StudentAcademic GetAcademicListItem(int rowIndex)
		{
			if (rowIndex < 0 || rowIndex >= DgvAcademic.Rows.Count)
			{
				return null;
			}
			return DgvAcademic.Rows[rowIndex].Tag as StudentAcademic;
		}

		// =============================================
		// Form Toggle & Populate
		// =============================================
		private void ShowAcademicForm(bool visible)
		{
			PnlAcademicForm.Visible = visible;
			DgvAcademic.Height = visible ? this.Height - PnlAcademicForm.Height - PnlAcademicToolbar.Height : this.Height - PnlAcademicToolbar.Height;
		}

		private void ResetAcademicForm()
		{
			CbxClass.SelectedIndex = -1;
			CbxSchoolYear.SelectedIndex = -1;
			CbxSubject.SelectedIndex = -1;
			CbxSemester.SelectedIndex = -1;
			TbxScore.Text = "";
			TbxScoreLetter.Text = "";
			TbxAcademicNote.Text = "";
		}

		private void PopulateAcademicForm(StudentAcademic ac)
		{
			CbxClass.SelectedValue = ac.ClassId ?? (object)DBNull.Value;
			CbxSchoolYear.SelectedValue = ac.SchoolYearId ?? (object)DBNull.Value;
			CbxSubject.SelectedValue = ac.SubjectId ?? (object)DBNull.Value;

			CbxSemester.SelectedIndex = (ac.Semester >= 1 && ac.Semester <= 3) ? ac.Semester - 1 : -1;

			TbxScore.Text = ac.Score.HasValue ? ac.Score.Value.ToString("0.##") : "";
			TbxScoreLetter.Text = ac.ScoreLetter ?? "";
			TbxAcademicNote.Text = ac.Note ?? "";
		}

		private void ClearAcademicSelection()
		{
			DgvAcademic.ClearSelection();
			DgvAcademic.CurrentCell = null;
			CurrentAcademic = null;

			BtnEditAcademic.Enabled = false;
			BtnDeleteAcademic.Enabled = false;
			BtnAddAcademic.Enabled = true;

			ShowAcademicForm(false);
			ResetAcademicForm();
		}

		private void DgvAcademic_MouseDown(object sender, MouseEventArgs e)
		{
			DataGridView.HitTestInfo hit = DgvAcademic.HitTest(e.X, e.Y);

			if (hit.Type == DataGridViewHitTestType.None)
			{
				ClearAcademicSelection();
			}
		}

		// =============================================
		// Events
		// =============================================
		private void DgvAcademic_SelectionChanged(object sender, EventArgs e)
		{
			bool has = DgvAcademic.SelectedRows.Count > 0;
			BtnEditAcademic.Enabled = has;
			BtnDeleteAcademic.Enabled = has;
			BtnAddAcademic.Enabled = !has;

			if (has)
			{
				CurrentAcademic = GetAcademicListItem(DgvAcademic.SelectedRows[0].Index);
			}
		}

		private void BtnAddAcademic_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(StudentId))
			{
				MessageBox.Show("Vui lòng nhập mã sinh viên trước khi thêm thông tin học tập.",
				    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			IsAddAcademic = true;
			LblFormName.Text = "Thêm thông tin học tập";
			CurrentAcademic = null;
			ResetAcademicForm();
			ShowAcademicForm(true);
		}

		public bool SaveAcademicsToDb(string studentId, out string errorMessage)
		{
			errorMessage = null;
			StudentId = studentId;

			StudentAcademic ac = null;
			bool ok = false;
			foreach (DataGridViewRow row in DgvAcademic.Rows)
			{
				ac = row.Tag as StudentAcademic;
				if (ac == null)
				{
					continue;
				}

				ac.StudentId = studentId;

				if (ac.AcademicId <= 0)
				{
					ok = AcademicService.InsertStudentAcademic(ac);
				}
				else
				{
					ok = AcademicService.UpdateStudentAcademic(ac);
				}

				if (!ok)
				{
					errorMessage = "Lưu thất bại cho bản ghi học tập: " + ac.ClassName + " - " + ac.SubjectName;
					return false;
				}
			}

			StudentAcademicDataSet ds = StudentAcademicDataSet.Instance;
			ds.FillStudentAcademic(StudentId);

			FillAcademicList(StudentId);
			ShowAcademicForm(false);
			return true;
		}

		private void BtnSaveToDb_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(StudentId))
			{
				MessageBox.Show("Vui lòng chọn hoặc lưu sinh viên trước khi lưu thông tin học tập.",
				    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (SaveAcademicsToDb(StudentId, out string errorMessage))
			{
				MessageBox.Show("Lưu thông tin học tập vào CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(errorMessage ?? "Lưu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnEditAcademic_Click(object sender, EventArgs e)
		{
			if (CurrentAcademic == null) return;
			IsAddAcademic = false;
			LblFormName.Text = "Sửa thông tin học tập";
			PopulateAcademicForm(CurrentAcademic);
			ShowAcademicForm(true);
		}

		private void BtnDeleteAcademic_Click(object sender, EventArgs e)
		{
			if (CurrentAcademic == null) return;

			if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi học tập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

			if (CurrentAcademic.AcademicId <= 0)
			{
				StudentAcademicDataSet ds = StudentAcademicDataSet.Instance;
				DataRow row = null;
				string currentIdStr = CurrentAcademic.AcademicId.ToString();
				for (int i = ds.StudentAcademicTable.Rows.Count - 1; i >= 0; i--)
				{
					row = ds.StudentAcademicTable.Rows[i];
					if (row.RowState != DataRowState.Deleted &&
					    row["ACADEMICID"].ToString() == currentIdStr)
					{
						row.Delete();
						break;
					}
				}
				FillAcademicList(StudentId);
				return;
			}

			bool ok = AcademicService.DeleteStudentAcademic(CurrentAcademic.AcademicId);
			if (ok)
			{
				FillAcademicList(StudentId);
			}
			else 
			{ 
				MessageBox.Show("Xóa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnSaveTempAcademic_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(StudentId))
			{
				MessageBox.Show("Vui lòng chọn hoặc lưu sinh viên trước khi thêm thông tin học tập.",
				    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (CbxClass.SelectedValue == null || CbxSchoolYear.SelectedValue == null || CbxSubject.SelectedValue == null)
			{
				MessageBox.Show("Vui lòng chọn đầy đủ lớp học, năm học và môn học.",
				    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			decimal? score = null;
			decimal parsed = 0;
			if (!string.IsNullOrWhiteSpace(TbxScore.Text))
			{
				if (!decimal.TryParse(TbxScore.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out parsed))
				{
					MessageBox.Show("Điểm số không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					TbxScore.Focus();
					return;
				}
				score = parsed;
			}

			StudentAcademicDataSet ds = StudentAcademicDataSet.Instance;

			if (IsAddAcademic)
			{
				ds.AddNewRow();
			} 
			else
			{
				bool found = ds.NavigateTo(CurrentAcademic.AcademicId);
				if (!found)
				{
					MessageBox.Show("Không tìm thấy dữ liệu. Vui lòng refresh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			DataRow row = ds.CurrentRow;
			if (row != null)
			{
				row.BeginEdit();
				row["STUDENTID"] = StudentId;
				row["CLASSID"] = CbxClass.SelectedValue.ToString();
				row["CLASSNAME"] = CbxClass.Text;
				row["SCHOOLYEARID"] = CbxSchoolYear.SelectedValue.ToString();
				row["SCHOOLYEARNAME"] = CbxSchoolYear.Text;
				row["SUBJECTID"] = CbxSubject.SelectedValue.ToString();
				row["SUBJECTNAME"] = CbxSubject.Text;
				row["SEMESTER"] = CbxSemester.SelectedIndex >= 0 ? (object)(CbxSemester.SelectedIndex + 1) : DBNull.Value;
				row["SCORE"] = score.HasValue ? (object)score.Value.ToString("0.##", CultureInfo.InvariantCulture) : (object)DBNull.Value;
				row["SCORE_LETTER"] = TbxScoreLetter.Text.Trim();
				row["NOTE"] = TbxAcademicNote.Text.Trim();
				row["STATUS"] = StudentAcademic.ACTIVE.ToString();
				row.EndEdit();
			}
			ds.BindingSource.EndEdit();

			FillAcademicList(StudentId);
			ShowAcademicForm(false);
			ResetAcademicForm();
			MessageBox.Show("Đã lưu tạm thông tin học tập. Hãy nhấn 'Lưu vào DB' để lưu vĩnh viễn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			BtnAddAcademic.Enabled = true;
		}

		private void BtnCancelAcademic_Click(object sender, EventArgs e)
		{
			StudentAcademicDataSet ds = StudentAcademicDataSet.Instance;
			ds.CancelPendingRow();
			ShowAcademicForm(false);
			ResetAcademicForm();
			DgvAcademic.ClearSelection();
		}

		// =============================================
		// Add reference buttons (Open DlgManageReference dialog)
		// =============================================
		private void BtnAddClass_Click(object sender, EventArgs e)
		{
			using (DlgManageReference dlg = new DlgManageReference(ReferenceTab.Class))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(dlg.SelectedId))
				{
					CbxClass.SelectedValue = dlg.SelectedId;
				}
			}
		}

		private void BtnAddSchoolYear_Click(object sender, EventArgs e)
		{
			using (DlgManageReference dlg = new DlgManageReference(ReferenceTab.SchoolYear))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(dlg.SelectedId))
				{
					CbxSchoolYear.SelectedValue = dlg.SelectedId;
				}
			}
		}

		private void BtnAddSubject_Click(object sender, EventArgs e)
		{
			using (DlgManageReference dlg = new DlgManageReference(ReferenceTab.Subject))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(dlg.SelectedId))
				{
					CbxSubject.SelectedValue = dlg.SelectedId;
				}
			}
		}
	}
}

