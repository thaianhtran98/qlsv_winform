using System.Collections.Generic;

namespace QuanLySV.Models
{
	public class SaveResult
	{
		public int Success { get; set; }
		public int Failed { get; set; }
		public int Total { get { return Success + Failed; } }
		public List<string> Errors { get; set; }

		public bool HasSuccess { get { return Success > 0; } }

		public SaveResult()
		{
			Errors = new List<string>();
		}

		public override string ToString()
		{
			return string.Format("Thành công: {0} / {1}  |  Lỗi: {2}", Success, Total, Failed);
		}
	}
}
