using System;
using System.Data;
using System.Windows.Forms;
using QuanLySV.Adapters;

namespace QuanLySV.Data
{
	public sealed class ReferenceDataSet
	{
		private static readonly ReferenceDataSet _Instance = new ReferenceDataSet();
		public static ReferenceDataSet Instance { get { return _Instance; } }

		// DataTables
		public DataTable ClassTable { get; private set; }
		public DataTable SchoolYearTable { get; private set; }
		public DataTable SubjectTable { get; private set; }

		// BindingSources for ComboBox binding
		public BindingSource ClassBindingSource { get; private set; }
		public BindingSource SchoolYearBindingSource { get; private set; }
		public BindingSource SubjectBindingSource { get; private set; }

		private readonly ReferenceAdapter _Adapter = new ReferenceAdapter();

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

		public ReferenceAdapter Adapter { get { return _Adapter; } }

		public void FillAll()
		{
			_Adapter.FillClass(ClassTable);
			_Adapter.FillSchoolYear(SchoolYearTable);
			_Adapter.FillSubject(SubjectTable);
		}

		public void ReloadClass()
		{
			_Adapter.FillClass(ClassTable);
		}

		public void ReloadSchoolYear()
		{
			_Adapter.FillSchoolYear(SchoolYearTable);
		}

		public void ReloadSubject()
		{
			_Adapter.FillSubject(SubjectTable);
		}
	}
}

