using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySV.Controls;
using QuanLySV.Data;
using QuanLySV.Helpers;

namespace QuanLySV
{
	public partial class Form1 : Form
	{
		private UserControl UserControlCurrent = null;

		public Form1()
		{
			InitializeComponent();
			this.Load += Form1_Load;
			UserControlCurrent = new UcList();
			ShowUc(UserControlCurrent);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ReferenceDataSet.Instance.FillAll();
		}

		public void ShowUcList()
		{
			ShowUc(new UcList());
		}

		public void ShowUcFormEdit(string studentId, bool isEdit)
		{
			ShowUc(new UcFormEdit(studentId, isEdit));
		}

		public void ShowUc(UserControl control)
		{
			while (PnlBody.Controls.Count > 0)
			{
				var oldControl = PnlBody.Controls[0];
				PnlBody.Controls.RemoveAt(0);
				oldControl.Dispose();
			}

			control.Dock = DockStyle.Fill;
			control.Margin = Padding.Empty;
			PnlBody.Controls.Add(control);
			control.Focus();
          }

		private void BtnList_Click(object sender, EventArgs e)
		{
			ShowUc(new UcList());
		}

		private void BtnCreate_Cick(object sender, EventArgs e)
		{
			ShowUc(new UcFormEdit(String.Empty, false));
		}

		private void BtnManageReference_Click(object sender, EventArgs e)
		{
			using (QuanLySV.Forms.DlgManageReference dlg = new QuanLySV.Forms.DlgManageReference())
			{
				dlg.ShowDialog(this);
			}
		}
	}
}