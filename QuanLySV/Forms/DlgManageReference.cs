using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLySV.Data;
using QuanLySV.Helpers;
using QuanLySV.Models;

namespace QuanLySV.Forms
{
	public enum ReferenceTab
	{
		Class = 0,
		SchoolYear = 1,
		Subject = 2
	}

	public partial class DlgManageReference : Form
	{
		private const int COL_CLASS_ID = 0;
		private const int COL_CLASS_NAME = 1;
		private const int COL_CLASS_DESC = 2;

		private const int COL_SYEAR_ID = 0;
		private const int COL_SYEAR_NAME = 1;
		private const int COL_SYEAR_START = 2;
		private const int COL_SYEAR_END = 3;

		private const int COL_SUB_ID = 0;
		private const int COL_SUB_NAME = 1;
		private const int COL_SUB_CREDITS = 2;
		private const int COL_SUB_DESC = 3;

		private string _OriginalClassId = string.Empty;
		private string _OriginalSchoolYearId = string.Empty;
		private string _OriginalSubjectId = string.Empty;

		public string SelectedId { get; set; }

		public DlgManageReference(ReferenceTab initialTab = ReferenceTab.Class)
		{
			InitializeComponent();
			ApplyAppColors();

			SetupGridViews();
			LoadAllData();

			switch (initialTab)
			{
				case ReferenceTab.Class:
					TabReference.SelectedTab = TpgClass;
					break;
				case ReferenceTab.SchoolYear:
					TabReference.SelectedTab = TpgSchoolYear;
					break;
				case ReferenceTab.Subject:
					TabReference.SelectedTab = TpgSubject;
					break;
			}
		}

		private void ApplyAppColors()
		{
			// Class Tab
			AppColor.ApplyButtonAdd(BtnAddClass);
			AppColor.ApplyButtonEdit(BtnEditClass);
			AppColor.ApplyButtonDelete(BtnDeleteClass);
			AppColor.ApplyButtonCancel(BtnClearClass);

			// School Year Tab
			AppColor.ApplyButtonAdd(BtnAddSchoolYear);
			AppColor.ApplyButtonEdit(BtnEditSchoolYear);
			AppColor.ApplyButtonDelete(BtnDeleteSchoolYear);
			AppColor.ApplyButtonCancel(BtnClearSchoolYear);

			// Subject Tab
			AppColor.ApplyButtonAdd(BtnAddSubject);
			AppColor.ApplyButtonEdit(BtnEditSubject);
			AppColor.ApplyButtonDelete(BtnDeleteSubject);
			AppColor.ApplyButtonCancel(BtnClearSubject);

			// Dialog Footer Buttons
			AppColor.ApplyButtonSave(BtnSelect);
			AppColor.ApplyButtonCancel(BtnClose);
		}

		private void SetupGridViews()
		{
			SetupGrid(DgvClass);
			DgvClass.Columns.Add("CLASSID", "Mã lớp");
			DgvClass.Columns.Add("CLASSNAME", "Tên lớp");
			DgvClass.Columns.Add("DESCRIPTION", "Mô tả");
			DgvClass.Columns[COL_CLASS_ID].Width = 130;
			DgvClass.Columns[COL_CLASS_NAME].Width = 220;
			DgvClass.Columns[COL_CLASS_DESC].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			SetupGrid(DgvSchoolYear);
			DgvSchoolYear.Columns.Add("SCHOOLYEARID", "Mã năm học");
			DgvSchoolYear.Columns.Add("SCHOOLYEARNAME", "Tên năm học");
			DgvSchoolYear.Columns.Add("START_YEAR", "Năm bắt đầu");
			DgvSchoolYear.Columns.Add("END_YEAR", "Năm kết thúc");
			DgvSchoolYear.Columns[COL_SYEAR_ID].Width = 140;
			DgvSchoolYear.Columns[COL_SYEAR_NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			DgvSchoolYear.Columns[COL_SYEAR_START].Width = 110;
			DgvSchoolYear.Columns[COL_SYEAR_END].Width = 110;

			SetupGrid(DgvSubject);
			DgvSubject.Columns.Add("SUBJECTID", "Mã môn học");
			DgvSubject.Columns.Add("SUBJECTNAME", "Tên môn học");
			DgvSubject.Columns.Add("CREDIT", "Tín chỉ");
			DgvSubject.Columns.Add("DESCRIPTION", "Mô tả");
			DgvSubject.Columns[COL_SUB_ID].Width = 130;
			DgvSubject.Columns[COL_SUB_NAME].Width = 220;
			DgvSubject.Columns[COL_SUB_CREDITS].Width = 90;
			DgvSubject.Columns[COL_SUB_DESC].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void SetupGrid(DataGridView grid)
		{
			grid.EnableHeadersVisualStyles = false;
			grid.ColumnHeadersDefaultCellStyle.BackColor = AppColor.GridHeader;
			grid.ColumnHeadersDefaultCellStyle.ForeColor = AppColor.TextDark;
			grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			grid.ColumnHeadersHeight = 32;
			grid.RowTemplate.Height = 28;
			grid.DefaultCellStyle.SelectionBackColor = AppColor.Selection;
			grid.DefaultCellStyle.SelectionForeColor = AppColor.TextDark;
			grid.BackgroundColor = AppColor.Surface;
		}

		private void LoadAllData()
		{
			ReferenceDataSet.Instance.FillAll();
			FillClassList();
			FillSchoolYearList();
			FillSubjectList();
		}

		// ====================================================================
		// 1. CLASS
		// ====================================================================

		private void FillClassList()
		{
			DgvClass.Rows.Clear();
			DataTable dt = ReferenceDataSet.Instance.ClassTable;
			foreach (DataRow row in dt.Rows)
			{
				int rindex = DgvClass.Rows.Add(
					row["CLASSID"]?.ToString(),
					row["CLASSNAME"]?.ToString(),
					row["DESCRIPTION"]?.ToString()
				);
				DgvClass.Rows[rindex].Tag = row["CLASSID"]?.ToString();
			}
			ClearClassInputs();
		}

		private void DgvClass_SelectionChanged(object sender, EventArgs e)
		{
			if (DgvClass.SelectedRows.Count == 0) return;
			DataGridViewRow srow = DgvClass.SelectedRows[0];
			_OriginalClassId = srow.Cells[COL_CLASS_ID].Value?.ToString() ?? string.Empty;
			TbxClassId.Text = _OriginalClassId;
			TbxClassName.Text = srow.Cells[COL_CLASS_NAME].Value?.ToString() ?? string.Empty;
			TbxClassDesc.Text = srow.Cells[COL_CLASS_DESC].Value?.ToString() ?? string.Empty;
			SelectedId = _OriginalClassId;
			
			BtnAddClass.Enabled = false;
		}

		private void BtnAddClass_Click(object sender, EventArgs e)
		{
			string classid = TbxClassId.Text.Trim();
			string classname = TbxClassName.Text.Trim();
			string classdesc = TbxClassDesc.Text.Trim();

			if (string.IsNullOrEmpty(classid))
			{
				MessageBox.Show("Vui lòng nhập mã lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxClassId.Focus();
				return;
			}
			if (string.IsNullOrEmpty(classname))
			{
				MessageBox.Show("Vui lòng nhập tên lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxClassName.Focus();
				return;
			}

			ClassInfo cls = new ClassInfo
			{
				ClassId = classid,
				ClassName = classname,
				Description = classdesc,
				Status = ClassInfo.ACTIVE
			};

			bool ok = ReferenceDataSet.Instance.Adapter.SaveClass(cls, true);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadClass();
				FillClassList();
				SelectedId = classid;
				MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Thêm lớp học thất bại. Vui lòng kiểm tra lại mã lớp có bị trùng không.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnEditClass_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_OriginalClassId))
			{
				MessageBox.Show("Vui lòng chọn lớp học từ danh sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string classname = TbxClassName.Text.Trim();
			string classdesc = TbxClassDesc.Text.Trim();

			if (string.IsNullOrEmpty(classname))
			{
				MessageBox.Show("Vui lòng nhập tên lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxClassName.Focus();
				return;
			}

			ClassInfo cls = new ClassInfo
			{
				ClassId = _OriginalClassId,
				ClassName = classname,
				Description = classdesc,
				Status = ClassInfo.ACTIVE
			};

			bool ok = ReferenceDataSet.Instance.Adapter.SaveClass(cls, false, _OriginalClassId);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadClass();
				FillClassList();
				SelectedId = _OriginalClassId;
				MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Cập nhật lớp học thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnDeleteClass_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_OriginalClassId))
			{
				MessageBox.Show("Vui lòng chọn lớp học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa lớp " + _OriginalClassId + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			bool ok = ReferenceDataSet.Instance.Adapter.DeleteClass(_OriginalClassId);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadClass();
				FillClassList();
				MessageBox.Show("Đã xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Xóa lớp học thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnClearClass_Click(object sender, EventArgs e)
		{
			ClearClassInputs();
		}

		private void ClearClassInputs()
		{
			_OriginalClassId = string.Empty;
			TbxClassId.Text = string.Empty;
			TbxClassName.Text = string.Empty;
			TbxClassDesc.Text = string.Empty;
			DgvClass.ClearSelection();
			BtnAddClass.Enabled = true;
		}

		// ====================================================================
		// 2. SCHOOL YEAR
		// ====================================================================

		private void FillSchoolYearList()
		{
			DgvSchoolYear.Rows.Clear();
			DataTable dt = ReferenceDataSet.Instance.SchoolYearTable;
			foreach (DataRow row in dt.Rows)
			{
				int rindex = DgvSchoolYear.Rows.Add(
					row["SCHOOLYEARID"]?.ToString(),
					row["SCHOOLYEARNAME"]?.ToString(),
					row["START_YEAR"]?.ToString(),
					row["END_YEAR"]?.ToString()
				);
				DgvSchoolYear.Rows[rindex].Tag = row["SCHOOLYEARID"]?.ToString();
			}
			ClearSchoolYearInputs();
		}

		private void DgvSchoolYear_SelectionChanged(object sender, EventArgs e)
		{
			if (DgvSchoolYear.SelectedRows.Count == 0) return;
			DataGridViewRow srow = DgvSchoolYear.SelectedRows[0];
			_OriginalSchoolYearId = srow.Cells[COL_SYEAR_ID].Value?.ToString() ?? string.Empty;
			TbxSchoolYearId.Text = _OriginalSchoolYearId;
			TbxSchoolYearName.Text = srow.Cells[COL_SYEAR_NAME].Value?.ToString() ?? string.Empty;

			if (int.TryParse(srow.Cells[COL_SYEAR_START].Value?.ToString(), out int syear))
			{
				NumStartYear.Value = Math.Max(NumStartYear.Minimum, Math.Min(NumStartYear.Maximum, syear));
			}
			if (int.TryParse(srow.Cells[COL_SYEAR_END].Value?.ToString(), out int eyear))
			{
				NumEndYear.Value = Math.Max(NumEndYear.Minimum, Math.Min(NumEndYear.Maximum, eyear));
			}

			SelectedId = _OriginalSchoolYearId;
			BtnAddSchoolYear.Enabled = false;
		}

		private void NumStartYear_ValueChanged(object sender, EventArgs e)
		{
			int syear = (int)NumStartYear.Value;
			if (NumEndYear.Value <= syear)
			{
				NumEndYear.Value = syear + 1;
			}
			if (string.IsNullOrEmpty(_OriginalSchoolYearId))
			{
				TbxSchoolYearId.Text = syear + "-" + (syear + 1);
				TbxSchoolYearName.Text = "Năm học " + syear + "-" + (syear + 1);
			}
		}

		private void BtnAddSchoolYear_Click(object sender, EventArgs e)
		{
			string syearid = TbxSchoolYearId.Text.Trim();
			string syearname = TbxSchoolYearName.Text.Trim();
			int syear = (int)NumStartYear.Value;
			int eyear = (int)NumEndYear.Value;

			if (string.IsNullOrEmpty(syearid))
			{
				MessageBox.Show("Vui lòng nhập mã năm học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxSchoolYearId.Focus();
				return;
			}
			if (string.IsNullOrEmpty(syearname))
			{
				MessageBox.Show("Vui lòng nhập tên năm học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxSchoolYearName.Focus();
				return;
			}
			if (syear >= eyear)
			{
				MessageBox.Show("Năm bắt đầu phải nhỏ hơn năm kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			SchoolYear sy = new SchoolYear
			{
				SchoolYearId = syearid,
				SchoolYearName = syearname,
				StartYear = syear,
				EndYear = eyear,
				Status = SchoolYear.ACTIVE
			};

			bool ok = ReferenceDataSet.Instance.Adapter.SaveSchoolYear(sy, true);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadSchoolYear();
				FillSchoolYearList();
				SelectedId = syearid;
				MessageBox.Show("Thêm năm học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Thêm năm học thất bại. Vui lòng kiểm tra lại mã năm học có bị trùng không.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnEditSchoolYear_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_OriginalSchoolYearId))
			{
				MessageBox.Show("Vui lòng chọn năm học từ danh sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string syearname = TbxSchoolYearName.Text.Trim();
			int syear = (int)NumStartYear.Value;
			int eyear = (int)NumEndYear.Value;

			if (string.IsNullOrEmpty(syearname))
			{
				MessageBox.Show("Vui lòng nhập tên năm học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxSchoolYearName.Focus();
				return;
			}

			SchoolYear sy = new SchoolYear
			{
				SchoolYearId = _OriginalSchoolYearId,
				SchoolYearName = syearname,
				StartYear = syear,
				EndYear = eyear,
				Status = SchoolYear.ACTIVE
			};

			bool ok = ReferenceDataSet.Instance.Adapter.SaveSchoolYear(sy, false, _OriginalSchoolYearId);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadSchoolYear();
				FillSchoolYearList();
				SelectedId = _OriginalSchoolYearId;
				MessageBox.Show("Cập nhật năm học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Cập nhật năm học thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnDeleteSchoolYear_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_OriginalSchoolYearId))
			{
				MessageBox.Show("Vui lòng chọn năm học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa năm học " + _OriginalSchoolYearId + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			bool ok = ReferenceDataSet.Instance.Adapter.DeleteSchoolYear(_OriginalSchoolYearId);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadSchoolYear();
				FillSchoolYearList();
				MessageBox.Show("Đã xóa năm học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Xóa năm học thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnClearSchoolYear_Click(object sender, EventArgs e)
		{
			ClearSchoolYearInputs();
		}

		private void ClearSchoolYearInputs()
		{
			_OriginalSchoolYearId = string.Empty;
			TbxSchoolYearId.Text = string.Empty;
			TbxSchoolYearName.Text = string.Empty;
			NumStartYear.Value = DateTime.Now.Year;
			NumEndYear.Value = DateTime.Now.Year + 1;
			DgvSchoolYear.ClearSelection();
			BtnAddSchoolYear.Enabled = true;
		}

		// ====================================================================
		// 3. SUBJECT
		// ====================================================================

		private void FillSubjectList()
		{
			DgvSubject.Rows.Clear();
			DataTable dt = ReferenceDataSet.Instance.SubjectTable;
			foreach (DataRow row in dt.Rows)
			{
				int rindex = DgvSubject.Rows.Add(
					row["SUBJECTID"]?.ToString(),
					row["SUBJECTNAME"]?.ToString(),
					row["CREDIT"]?.ToString(),
					row["DESCRIPTION"]?.ToString()
				);
				DgvSubject.Rows[rindex].Tag = row["SUBJECTID"]?.ToString();
			}
			ClearSubjectInputs();
		}

		private void DgvSubject_SelectionChanged(object sender, EventArgs e)
		{
			if (DgvSubject.SelectedRows.Count == 0) return;
			DataGridViewRow srow = DgvSubject.SelectedRows[0];
			_OriginalSubjectId = srow.Cells[COL_SUB_ID].Value?.ToString() ?? string.Empty;
			TbxSubjectId.Text = _OriginalSubjectId;
			TbxSubjectName.Text = srow.Cells[COL_SUB_NAME].Value?.ToString() ?? string.Empty;

			if (int.TryParse(srow.Cells[COL_SUB_CREDITS].Value?.ToString(), out int creds))
				NumCredits.Value = Math.Max(NumCredits.Minimum, Math.Min(NumCredits.Maximum, creds));

			TbxSubjectDesc.Text = srow.Cells[COL_SUB_DESC].Value?.ToString() ?? string.Empty;
			SelectedId = _OriginalSubjectId;
			
			BtnAddSubject.Enabled = false;
		}

		private void BtnAddSubject_Click(object sender, EventArgs e)
		{
			string subid = TbxSubjectId.Text.Trim();
			string subname = TbxSubjectName.Text.Trim();
			int creds = (int)NumCredits.Value;
			string subdesc = TbxSubjectDesc.Text.Trim();

			if (string.IsNullOrEmpty(subid))
			{
				MessageBox.Show("Vui lòng nhập mã môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxSubjectId.Focus();
				return;
			}
			if (string.IsNullOrEmpty(subname))
			{
				MessageBox.Show("Vui lòng nhập tên môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxSubjectName.Focus();
				return;
			}

			Subject sub = new Subject
			{
				SubjectId = subid,
				SubjectName = subname,
				Credits = creds,
				Description = subdesc,
				Status = Subject.ACTIVE
			};

			bool ok = ReferenceDataSet.Instance.Adapter.SaveSubject(sub, true);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadSubject();
				FillSubjectList();
				SelectedId = subid;
				MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Thêm môn học thất bại. Vui lòng kiểm tra lại mã môn học có bị trùng không.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnEditSubject_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_OriginalSubjectId))
			{
				MessageBox.Show("Vui lòng chọn môn học từ danh sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string subname = TbxSubjectName.Text.Trim();
			int creds = (int)NumCredits.Value;
			string subdesc = TbxSubjectDesc.Text.Trim();

			if (string.IsNullOrEmpty(subname))
			{
				MessageBox.Show("Vui lòng nhập tên môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TbxSubjectName.Focus();
				return;
			}

			Subject sub = new Subject
			{
				SubjectId = _OriginalSubjectId,
				SubjectName = subname,
				Credits = creds,
				Description = subdesc,
				Status = Subject.ACTIVE
			};

			bool ok = ReferenceDataSet.Instance.Adapter.SaveSubject(sub, false, _OriginalSubjectId);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadSubject();
				FillSubjectList();
				SelectedId = _OriginalSubjectId;
				MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Cập nhật môn học thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnDeleteSubject_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_OriginalSubjectId))
			{
				MessageBox.Show("Vui lòng chọn môn học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn học " + _OriginalSubjectId + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			bool ok = ReferenceDataSet.Instance.Adapter.DeleteSubject(_OriginalSubjectId);
			if (ok)
			{
				ReferenceDataSet.Instance.ReloadSubject();
				FillSubjectList();
				MessageBox.Show("Đã xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Xóa môn học thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnClearSubject_Click(object sender, EventArgs e)
		{
			ClearSubjectInputs();
		}

		private void ClearSubjectInputs()
		{
			_OriginalSubjectId = string.Empty;
			TbxSubjectId.Text = string.Empty;
			TbxSubjectName.Text = string.Empty;
			NumCredits.Value = 3;
			TbxSubjectDesc.Text = string.Empty;
			DgvSubject.ClearSelection();
			BtnAddSubject.Enabled = true;
		}

		// ====================================================================
		// FOOTER / SELECTION
		// ====================================================================
		private void TabReference_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateSelectedIdFromCurrentTab();
		}

		private void UpdateSelectedIdFromCurrentTab()
		{
			if (TabReference.SelectedTab == TpgClass)
			{
				SelectedId = _OriginalClassId;
			}
			else if (TabReference.SelectedTab == TpgSchoolYear)
			{
				SelectedId = _OriginalSchoolYearId;
			}
			else if (TabReference.SelectedTab == TpgSubject)
			{
				SelectedId = _OriginalSubjectId;
			}
		}

		private void BtnSelect_Click(object sender, EventArgs e)
		{
			UpdateSelectedIdFromCurrentTab();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}

