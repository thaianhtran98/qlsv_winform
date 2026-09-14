using System;

namespace QuanLySV.Models
{
	public class ClassInfo
	{
		public static int ACTIVE = 1;
		public static int INACTIVE = 0;

		public string ClassId { get; set; }
		public string ClassName { get; set; }
		public string Description { get; set; }
		public int Status { get; set; }

		public override string ToString() { return ClassName; }
	}
}
