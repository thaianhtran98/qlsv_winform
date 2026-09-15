using QuanLySV.Data;
using QuanLySV.Forms;
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
		private string _studentId;
		private StudentAcademic _currentAcademic;
		private bool _isAddAcademic = false;
		private List<StudentAcademic> _academicList = new List<StudentAcademic>();

		public UcStudentAcademic()
		{
			InitializeComponent();
			LoadComboBoxesFromDataSet();
		}

		public void LoadData(string studentId)
		{
			_studentId = studentId;

			// Đảm bảo danh mục đã được nạp (chỉ chạy lúc runtime, không chạy trong constructor)
			if (ReferenceDataSet.Instance.ClassTable.Rows.Count == 0)
			{
				ReferenceDataSet.Instance.FillAll();
			}

			FillAcademicList(_studentId);
			ShowAcademicForm(false);
			ResetAcademicForm();
		}

		// =============================================
		// ComboBox DataBinding theo FDS Pattern
		// =============================================
		private void LoadComboBoxesFromDataSet()
		{
			ReferenceDataSet ds = ReferenceDataSet.Instance;

			// Bind Lớp học
			CbxClass.DisplayMember = "CLASSNAME";
			CbxClass.ValueMember = "CLASSID";
			CbxClass.DataSource = ds.ClassBindingSource;
			CbxClass.SelectedIndex = -1;

			// Bind Năm học
			CbxSchoolYear.DisplayMember = "SCHOOLYEARNAME";
			CbxSchoolYear.ValueMember = "SCHOOLYEARID";
			CbxSchoolYear.DataSource = ds.SchoolYearBindingSource;
			CbxSchoolYear.SelectedIndex = -1;

			// Bind Môn học
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
			DataTable studentAcdemicTable = ds.StudentAcademicTable;
			if (studentAcdemicTable == null || studentAcdemicTable.Rows.Count == 0) return;

			foreach (DataRow row in studentAcdemicTable.Rows)
			{
				decimal? scoreValue = null;
				object scoreObj = row["SCORE"];
				if (scoreObj != DBNull.Value)
				{
					string scoreStr = scoreObj?.ToString();
					if (!string.IsNullOrWhiteSpace(scoreStr) && decimal.TryParse(scoreStr, out decimal tmpScore))
					{
						scoreValue = tmpScore;
					}
				}

				StudentAcademic studentAcademic = new StudentAcademic
				{
					AcademicId = row["ACADEMICID"] != DBNull.Value ? Convert.ToInt64(row["ACADEMICID"]) : 0,
					StudentId = row["STUDENTID"]?.ToString(),
					ClassId = row["CLASSID"]?.ToString(),
					ClassName = row["CLASSNAME"]?.ToString(),
					SchoolYearId = row["SCHOOLYEARID"]?.ToString(),
					SchoolYearName = row["SCHOOLYEARNAME"]?.ToString(),
					SubjectId = row["SUBJECTID"]?.ToString(),
					SubjectName = row["SUBJECTNAME"]?.ToString(),
					Semester = row["SEMESTER"] != DBNull.Value ? Convert.ToInt32(row["SEMESTER"]) : 0,
					Score = scoreValue,
					ScoreLetter = row["SCORE_LETTER"]?.ToString(),
					Note = row["NOTE"]?.ToString(),
					Status = row["STATUS"] != DBNull.Value ? Convert.ToInt32(row["STATUS"]) : 0
				};

				int rowIdx = DgvAcademic.Rows.Add(
					studentAcademic.ClassName,
					studentAcademic.SchoolYearName,
					studentAcademic.SubjectName,
					studentAcademic.Semester.ToString() != null ? "HK" + studentAcademic.Semester : "",
					studentAcademic.Score?.ToString("0.##"),
					studentAcademic.ScoreLetter,
					studentAcademic.Note
				);

				DgvAcademic.Rows[rowIdx].Tag = studentAcademic;
			}
		}

		private StudentAcademic GetAcademicListItem(int rowIndex)
		{
			if (rowIndex < 0 || rowIndex >= DgvAcademic.Rows.Count) return null;
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
				_currentAcademic = GetAcademicListItem(DgvAcademic.SelectedRows[0].Index);
			}
		}

		private void BtnAddAcademic_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(_studentId))
			{
				MessageBox.Show("Vui lòng nhập mã sinh viên trước khi thêm thông tin học tập.",
				    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_isAddAcademic = true;
			LblFormName.Text = "Thêm thông tin học tập";
			_currentAcademic = null;
			ResetAcademicForm();
			ShowAcademicForm(true);
		}

		private void BtnSaveToDb_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in DgvAcademic.Rows)
			{
				StudentAcademic ac = row.Tag as StudentAcademic;
				if (ac != null)
				{
					decimal? score = null;
					if (ac.Score != null)
					{
						if (!decimal.TryParse(ac.Score.ToString().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed))
						{
							MessageBox.Show("Điểm số không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}
						score = parsed;
					}
					ac.Score = score;

					bool ok = false;
					if (ac.AcademicId == null || ac.AcademicId == 0)
					{
						ok = AcademicService.InsertStudentAcademic(ac);
					}
					else
					{
						ok = AcademicService.UpdateStudentAcademic(ac);
					}
					if (!ok)
					{
						MessageBox.Show("Lưu thất bại cho bản ghi học tập: " + ac.ClassName + " - " + ac.SubjectName,
						    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
			}

			StudentAcademicDataSet ds = StudentAcademicDataSet.Instance;
			ds.FillStudentAcademic(_studentId);

			FillAcademicList(_studentId);
			ShowAcademicForm(false);
		}

		private void BtnEditAcademic_Click(object sender, EventArgs e)
		{
			if (_currentAcademic == null) return;
			_isAddAcademic = false;
			LblFormName.Text = "Sửa thông tin học tập";
			PopulateAcademicForm(_currentAcademic);
			ShowAcademicForm(true);
		}

		private void BtnDeleteAcademic_Click(object sender, EventArgs e)
		{
			if (_currentAcademic == null) return;

			if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi học tập này?",
			    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

			bool ok = AcademicService.DeleteStudentAcademic(_currentAcademic.AcademicId);
			if (ok) FillAcademicList(_studentId);
			else MessageBox.Show("Xóa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void BtnSaveAcademic_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(_studentId))
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

			if (_isAddAcademic)
			{
				decimal? score = null;
				if (!string.IsNullOrWhiteSpace(TbxScore.Text))
				{
					if (!decimal.TryParse(TbxScore.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed))
					{
						MessageBox.Show("Điểm số không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					score = parsed;
				}
				StudentAcademic ac = new StudentAcademic
				{
					StudentId = _studentId,
					ClassId = CbxClass.SelectedValue?.ToString(),
					ClassName = CbxClass.Text,
					SchoolYearId = CbxSchoolYear.SelectedValue?.ToString(),
					SchoolYearName = CbxSchoolYear.Text,
					SubjectId = CbxSubject.SelectedValue?.ToString(),
					SubjectName = CbxSubject.Text,
					Semester = CbxSemester.SelectedIndex >= 0 ? CbxSemester.SelectedIndex + 1 : 0,
					Score = score,
					ScoreLetter = TbxScoreLetter.Text.Trim(),
					Note = TbxAcademicNote.Text.Trim(),
					Status = StudentAcademic.ACTIVE
				};
				_academicList.Add(ac);
				int rowIdx = DgvAcademic.Rows.Add(
				    ac.ClassName,
				    ac.SchoolYearName,
				    ac.SubjectName,
				    ac.Semester > 0 ? "HK " + ac.Semester : "",
				    ac.Score.HasValue ? ac.Score.Value.ToString("0.##") : "",
				    ac.ScoreLetter ?? ""
				);
				DgvAcademic.Rows[rowIdx].Tag = ac;

				DgvAcademic.Rows[rowIdx].DefaultCellStyle.BackColor = Color.LightYellow;
			}
			else
			{
				if (DgvAcademic.CurrentRow != null)
				{
					DataGridViewRow currentRow = DgvAcademic.CurrentRow;
					StudentAcademic sa = currentRow.Tag as StudentAcademic;
					if (sa != null)
					{
						decimal? score = null;
						if (!string.IsNullOrWhiteSpace(TbxScore.Text))
						{
							if (!decimal.TryParse(TbxScore.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed))
							{
								MessageBox.Show("Điểm số không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
							score = parsed;
						}

						sa.ClassId = CbxClass.SelectedValue.ToString();
						sa.ClassName = CbxClass.Text;
						sa.SchoolYearId = CbxSchoolYear.SelectedValue.ToString();
						sa.SchoolYearName = CbxSchoolYear.Text;
						sa.SubjectId = CbxSubject.SelectedValue.ToString();
						sa.SubjectName = CbxSubject.Text;
						sa.Semester = CbxSemester.SelectedIndex >= 0 ? CbxSemester.SelectedIndex + 1 : 0;
						sa.Score = score;
						sa.ScoreLetter = TbxScoreLetter.Text.Trim();
						sa.Note = TbxAcademicNote.Text.Trim();
						currentRow.Tag = sa;

						currentRow.Cells[COL_CLASS_NAME].Value = sa.ClassName;
						currentRow.Cells[COL_SYEAR_NAME].Value = sa.SchoolYearName;
						currentRow.Cells[COL_SUB_NAME].Value = sa.SubjectName;
						currentRow.Cells[COL_SEMESTER].Value = sa.Semester > 0 ? "HK " + sa.Semester : "";
						currentRow.Cells[COL_SCORE].Value = sa.Score.HasValue ? sa.Score.Value.ToString("0.##") : "";
						currentRow.Cells[COL_SCORE_LETER].Value = sa.ScoreLetter ?? "";

						currentRow.DefaultCellStyle.BackColor = Color.LightYellow;
						ShowAcademicForm(false);
						ResetAcademicForm();
					}
				}
			}
		}

		private void BtnCancelAcademic_Click(object sender, EventArgs e)
		{
			ShowAcademicForm(false);
			ResetAcademicForm();
			DgvAcademic.ClearSelection();
		}

		// =============================================
		// Nút thêm danh mục (Mở Form DlgManageReference)
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

