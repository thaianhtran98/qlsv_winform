using System;
using System.Data;
using System.Windows.Forms;
using QuanLySV.Adapters;
using QuanLySV.Models;

namespace QuanLySV.Data
{
	public sealed class StudentDataSet
	{
		// ── Singleton ─────────────────────────────────────────────────
		private static readonly StudentDataSet _Instance = new StudentDataSet();
		public static StudentDataSet Instance { get { return _Instance; } }

		// ── Core objects ──────────────────────────────────────────────
		public DataTable StudentTable { get; private set; }

		public BindingSource BindingSource { get; private set; }

		// ── Internal adapter ──────────────────────────────────────────
		private readonly StudentAdapter _Adapter = new StudentAdapter();
		public StudentAdapter Adapter { get { return _Adapter; } }

		// ── Constructor ───────────────────────────────────────────────
		private StudentDataSet()
		{
			StudentTable = BuildStudentTable();
			BindingSource = new BindingSource { DataSource = StudentTable };
		}

		// =============================================
		// Schema definition
		// =============================================
		private DataTable BuildStudentTable()
		{
			DataTable table = new DataTable("STUDENT");
			DataColumn colid = table.Columns.Add("STUDENTID", typeof(string));
			colid.DefaultValue = string.Empty;
			table.Columns.Add("NAME", typeof(string));
			table.Columns.Add("SEX", typeof(int));
			table.Columns.Add("BIRTHOFDATE", typeof(DateTime));
			table.Columns.Add("BIRTHLOCAL", typeof(string));
			table.Columns.Add("VNEID", typeof(string));
			table.Columns.Add("DATEOFISSUE", typeof(DateTime));
			table.Columns.Add("LOCALOFISSUE", typeof(string));
			table.Columns.Add("LOCAL", typeof(string));
			table.Columns.Add("PLACEOFRESIDENCE", typeof(string));
			table.Columns.Add("NUMBERPHONE", typeof(string));
			table.Columns.Add("STATUS", typeof(int));

			// Set PrimaryKey so that Find() works
			table.PrimaryKey = new DataColumn[] { colid };
			return table;
		}

		// =============================================
		// DB ──► DataTable (Fill)
		// =============================================

		public void Fill(int status = -1, int sex = -1)
		{
			_Adapter.Fill(StudentTable, status, sex);
		}

		// =============================================
		// DataTable ──► DB (SaveAll)
		// =============================================
		public SaveResult SaveAll()
		{
			DataTable changes = StudentTable.GetChanges();
			SaveResult result = _Adapter.SaveChanges(changes);

			if (result.HasSuccess)
			{
				StudentTable.AcceptChanges();
			}
			return result;
		}

		// =============================================
		// Helper methods
		// =============================================

		public int PendingCount
		{
			get
			{
				DataTable changes = StudentTable.GetChanges();
				return changes != null ? changes.Rows.Count : 0;
			}
		}

		public void AddNewRow()
		{
			CancelPendingRow();
			DataRowView drv = (DataRowView)BindingSource.AddNew();
			if (drv != null)
			{
				drv["STUDENTID"] = string.Empty;
				drv["SEX"] = Student.MALE;
				drv["STATUS"] = Student.ACTIVE;
				drv["BIRTHOFDATE"] = DateTime.Today;
				drv["DATEOFISSUE"] = DateTime.Today;
			}
		}

		public void CancelPendingRow()
		{
			if (BindingSource != null)
			{
				BindingSource.CancelEdit();
			}

			DataRow row = null;
			for (int i = StudentTable.Rows.Count - 1; i >= 0; i--)
			{
				row = StudentTable.Rows[i];
				if (row.RowState == DataRowState.Added)
				{
					if (row["STUDENTID"] == DBNull.Value || string.IsNullOrWhiteSpace(row["STUDENTID"].ToString()))
					{
						row.Delete();
					}
				}
			}
		}

		public bool NavigateTo(string studentId)
		{
			DataRow found = StudentTable.Rows.Find(studentId);
			if (found == null)
			{
				return false;
			}

			DataView view = (DataView)BindingSource.List;
			for (int i = 0; i < view.Count; i++)
			{
				if (view[i]["STUDENTID"].ToString() == studentId)
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
