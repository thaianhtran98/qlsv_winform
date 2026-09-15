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
		private static readonly StudentAcademicDataSet _instance = new StudentAcademicDataSet();
		public static StudentAcademicDataSet Instance { get { return _instance; } }

		// ── Core objects ──────────────────────────────────────────────
		public DataTable StudentAcademicTable { get; private set; }

		// ── Internal adapter ──────────────────────────────────────────
		private readonly StudentAcademicAdapter _adapter = new StudentAcademicAdapter();
		public StudentAcademicAdapter Adapter { get { return _adapter; } }

		// ── Constructor ───────────────────────────────────────────────
		private StudentAcademicDataSet()
		{
			ClearStudentAcademic();
			StudentAcademicTable = BuildStudentAcademicTable();
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

			table.PrimaryKey = new DataColumn[] { table.Columns["ACADEMICID"] };
			return table;
		}

		public void FillStudentAcademic(string studentId = null)
		{
			_adapter.FillStudentAcademic(StudentAcademicTable, studentId);
		}

		public void ClearStudentAcademic()
		{
			if (StudentAcademicTable != null)
			{
				StudentAcademicTable.Rows.Clear();
			}
		}
	}
}
