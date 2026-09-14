using System;

namespace QuanLySV.Models
{
	public class Subject
	{
		public static int ACTIVE = 1;
		public static int INACTIVE = 0;

		public string SubjectId { get; set; }
		public string SubjectName { get; set; }
		public int Credits { get; set; }
		public string Description { get; set; }
		public int Status { get; set; }

		public override string ToString() { return SubjectName; }
	}
}
