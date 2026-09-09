using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV.Models
{
	public class Student
	{
		public static int MALE = 1;
		public static int FEMALE = 0;
		public static int ACTIVE = 1;
		public static int INACTIVE = 0;

		public string Name { get; set; }
		public string StudentId { get; set; }
		public int Sex { get; set; }
		public int Status { get; set; }
		public DateTime BirthOfDate { get; set; }
		public DateTime DateOfIssue { get; set; }
		public string BirthLocal { get; set; }
		public string VneId { get; set; }
		public string LocalOfIssue { get; set; }
		public string Local { get; set; }
		public string PlaceOfResidence { get; set; }
		public string NumberPhone { get; set; }
	}
}
