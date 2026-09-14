using System;

namespace QuanLySV.Models
{
	public class SchoolYear
	{
		public static int ACTIVE = 1;
		public static int INACTIVE = 0;

		public string SchoolYearId { get; set; }
		public string SchoolYearName { get; set; }
		public int StartYear { get; set; }
		public int EndYear { get; set; }
		public int Status { get; set; }

		public override string ToString() { return SchoolYearName; }
	}
}
