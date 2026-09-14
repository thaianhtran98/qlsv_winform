using System;

namespace QuanLySV.Models
{
	public class StudentAcademic
	{
		public static int ACTIVE = 1;
		public static int INACTIVE = 0;

		public long AcademicId { get; set; }
		public string StudentId { get; set; }
		public string ClassId { get; set; }
		public string ClassName { get; set; }       // join display
		public string SchoolYearId { get; set; }
		public string SchoolYearName { get; set; }  // join display
		public string SubjectId { get; set; }
		public string SubjectName { get; set; }     // join display
		public decimal? Score { get; set; }
		public string ScoreLetter { get; set; }
		public int Semester { get; set; }
		public string Note { get; set; }
		public int Status { get; set; }
	}
}
