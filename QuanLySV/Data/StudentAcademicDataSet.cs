using System;
using System.Data;
using System.Windows.Forms;
using QuanLySV.Adapters;
using QuanLySV.Models;

namespace QuanLySV.Data
{
	public sealed class StudentAcademicDataSet
	{
		// ── Singleton ─────────────────────────────────────────────────
		private static readonly StudentAcademicDataSet _Instance = new StudentAcademicDataSet();
		public static StudentAcademicDataSet Instance { get { return _Instance; } }

		// ── Core objects ──────────────────────────────────────────────
		public DataTable StudentAcademicTable { get; private set; }
		public BindingSource BindingSource { get; private set; }

		// ── Internal adapter ──────────────────────────────────────────
		private readonly StudentAcademicAdapter _Adapter = new StudentAcademicAdapter();
		public StudentAcademicAdapter Adapter { get { return _Adapter; } }

		// ── Constructor ───────────────────────────────────────────────
		private StudentAcademicDataSet()
		{
			StudentAcademicTable = BuildStudentAcademicTable();
			BindingSource = new BindingSource { DataSource = StudentAcademicTable };
		}

		private DataTable BuildStudentAcademicTable()
		{
			DataTable table = new DataTable("STUDENT_ACADEMIC");
			table.Columns.Add("ACADEMICID", typeof(string));
			table.Columns.Add("STUDENTID", typeof(string));
			table.Columns.Add("CLASSID", typeof(string));
			table.Columns.Add("CLASSNAME", typeof(string));
			table.Columns.Add("SCHOOLYEARID", typeof(string));
			table.Columns.Add("SCHOOLYEARNAME", typeof(string));
			table.Columns.Add("SUBJECTID", typeof(string));
			table.Columns.Add("SUBJECTNAME", typeof(string));
			table.Columns.Add("SCORE", typeof(string));
			table.Columns.Add("SCORE_LETTER", typeof(string));
			table.Columns.Add("SEMESTER", typeof(int));
			table.Columns.Add("NOTE", typeof(string));
			table.Columns.Add("STATUS", typeof(string));

			return table;
		}

		public void FillStudentAcademic(string studentId = null)
		{
			_Adapter.FillStudentAcademic(StudentAcademicTable, studentId);
		}

		public void ClearStudentAcademic()
		{
			if (StudentAcademicTable != null)
			{
				StudentAcademicTable.Rows.Clear();
			}
		}

		// =============================================
		// Helper methods
		// =============================================
		private long GetNextTempId()
		{
			long minId = 0;
			long id = 0;
			foreach (DataRow row in StudentAcademicTable.Rows)
			{
				if (row.RowState == DataRowState.Deleted)
				{
					continue;
				}

				if (row["ACADEMICID"] != DBNull.Value && long.TryParse(row["ACADEMICID"].ToString(), out id))
				{
					if (id < minId)
					{
						minId = id;
					}
				}
			}
			return minId - 1;
		}

		public int PendingCount
		{
			get
			{
				DataTable changes = StudentAcademicTable.GetChanges();
				return changes != null ? changes.Rows.Count : 0;
			}
		}

		public void AddNewRow()
		{
			if (BindingSource != null)
			{
				BindingSource.CancelEdit();
			}

			long newId = GetNextTempId();
			DataRowView drv = BindingSource.AddNew() as DataRowView;
			if (drv != null)
			{
				drv["ACADEMICID"] = newId;
				drv["STUDENTID"] = string.Empty;
				drv["CLASSID"] = string.Empty;
				drv["SCHOOLYEARID"] = string.Empty;
				drv["SUBJECTID"] = string.Empty;
				drv["CLASSNAME"] = string.Empty;
				drv["SCHOOLYEARNAME"] = string.Empty;
				drv["SUBJECTNAME"] = string.Empty;
				drv["SCORE"] = DBNull.Value;
				drv["SCORE_LETTER"] = string.Empty;
				drv["SEMESTER"] = DBNull.Value;
				drv["NOTE"] = string.Empty;
				drv["STATUS"] = string.Empty;
			}
		}

		public void CancelPendingRow()
		{
			if (BindingSource != null)
			{
				BindingSource.CancelEdit();
			}

			DataRow row = null;
			for (int i = StudentAcademicTable.Rows.Count - 1; i >= 0; i--)
			{
				row = StudentAcademicTable.Rows[i];
				if (row.RowState == DataRowState.Added)
				{
					if (row["CLASSID"] == DBNull.Value || string.IsNullOrWhiteSpace(row["CLASSID"].ToString()))
					{
						row.Delete();
					}
				}
			}
		}

		public bool NavigateTo(long academicId)
		{
			DataView view = (DataView)BindingSource.List;
			string targetId = academicId.ToString();
			for (int i = 0; i < view.Count; i++)
			{
				if (view[i]["ACADEMICID"].ToString() == targetId)
				{
					BindingSource.Position = i;
					return true;
				}
			}
			return false;
		}

		public DataRow CurrentRow
		{
			get
			{
				DataRowView drv = BindingSource.Current as DataRowView;
				return drv != null ? drv.Row : null;
			}
		}
	}
}
