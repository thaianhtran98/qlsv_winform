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
using QuanLySV.Helpers;

namespace QuanLySV
{
	public partial class Form1 : Form
	{
		private UserControl UserControlCurrent = null;
		private Button _selectedNavigationButton;

		public Form1()
		{
			InitializeComponent();
			UserControlCurrent = new UcList();
			ShowUc(UserControlCurrent);
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
	}
}
