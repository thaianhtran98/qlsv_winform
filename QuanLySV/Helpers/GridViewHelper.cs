using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV.Helpers
{
	public class GridViewHelper
	{
		public void SetFixedColumn(DataGridViewColumn col, int width)
		{
			if (col == null) return;
			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			col.Width = width;
			col.MinimumWidth = width;
		}

		public void SetFillColumn(DataGridViewColumn col, int minWidth, float fillWeight)
		{
			if (col == null) return;
			col.MinimumWidth = minWidth;
			col.FillWeight = fillWeight;
			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}
	}
}
