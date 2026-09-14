using System;
using System.Data;
using System.Windows.Forms;
using QuanLySV.Adapters;

namespace QuanLySV.Data
{
	public sealed class ReferenceDataSet
	{
		private static readonly ReferenceDataSet _instance = new ReferenceDataSet();
		public static ReferenceDataSet Instance { get { return _instance; } }

		// DataTables
		public DataTable ClassTable { get; private set; }
		public DataTable SchoolYearTable { get; private set; }
		public DataTable SubjectTable { get; private set; }

		// BindingSources cho các ComboBox bind vào
		public BindingSource ClassBindingSource { get; private set; }
		public BindingSource SchoolYearBindingSource { get; private set; }
		public BindingSource SubjectBindingSource { get; private set; }

		private readonly ReferenceAdapter _adapter = new ReferenceAdapter();

		private ReferenceDataSet()
		{
			ClassTable = BuildClassTable();
			SchoolYearTable = BuildSchoolYearTable();
			SubjectTable = BuildSubjectTable();

			ClassBindingSource = new BindingSource { DataSource = ClassTable };
			SchoolYearBindingSource = new BindingSource { DataSource = SchoolYearTable };
			SubjectBindingSource = new BindingSource { DataSource = SubjectTable };
		}

		private DataTable BuildClassTable()
		{
			DataTable table = new DataTable("CLASS");
			table.Columns.Add("CLASSID", typeof(string));
			table.Columns.Add("CLASSNAME", typeof(string));
			table.Columns.Add("DESCRIPTION", typeof(string));
			table.Columns.Add("STATUS", typeof(int));
			table.PrimaryKey = new DataColumn[] { table.Columns["CLASSID"] };
			return table;
		}

		private DataTable BuildSchoolYearTable()
		{
			DataTable table = new DataTable("SCHOOL_YEAR");
			table.Columns.Add("SCHOOLYEARID", typeof(string));
			table.Columns.Add("SCHOOLYEARNAME", typeof(string));
			table.Columns.Add("START_YEAR", typeof(int));
			table.Columns.Add("END_YEAR", typeof(int));
			table.Columns.Add("STATUS", typeof(int));
			table.PrimaryKey = new DataColumn[] { table.Columns["SCHOOLYEARID"] };
			return table;
		}

		private DataTable BuildSubjectTable()
		{
			DataTable table = new DataTable("SUBJECT");
			table.Columns.Add("SUBJECTID", typeof(string));
			table.Columns.Add("SUBJECTNAME", typeof(string));
			table.Columns.Add("CREDIT", typeof(int));
			table.Columns.Add("DESCRIPTION", typeof(string));
			table.Columns.Add("STATUS", typeof(int));
			table.PrimaryKey = new DataColumn[] { table.Columns["SUBJECTID"] };
			return table;
		}

		public ReferenceAdapter Adapter { get { return _adapter; } }

		public void FillAll()
		{
			_adapter.FillClass(ClassTable);
			_adapter.FillSchoolYear(SchoolYearTable);
			_adapter.FillSubject(SubjectTable);
		}

		public void ReloadClass()
		{
			_adapter.FillClass(ClassTable);
		}

		public void ReloadSchoolYear()
		{
			_adapter.FillSchoolYear(SchoolYearTable);
		}

		public void ReloadSubject()
		{
			_adapter.FillSubject(SubjectTable);
		}
	}
}

