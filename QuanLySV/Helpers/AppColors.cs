using System.Drawing;
using System.Windows.Forms;

namespace QuanLySV.Helpers
{
	/// <summary>
	/// Centralized color management for the entire application following FDS standards.
	/// Use this class across all Forms/UserControls for easy maintenance and consistent UI.
	/// </summary>
	public static class AppColor
	{
		// ====================================================================
		// 1. FDS Button Color Standards (ForeColor by function)
		// ====================================================================
		/// <summary>
		/// Blue color for buttons: Confirm, Execute, Save, Print, Add.
		/// </summary>
		public static readonly Color BtnBlue = Color.Blue;
		public static readonly Color BtnSave = Color.Blue;
		public static readonly Color BtnAdd = Color.Blue;
		public static readonly Color BtnConfirm = Color.Blue;
		public static readonly Color BtnExecute = Color.Blue;
		public static readonly Color BtnPrint = Color.Blue;

		/// <summary>
		/// Black color for buttons: Cancel, Copy, Edit, Close.
		/// </summary>
		public static readonly Color BtnBlack = Color.Black;
		public static readonly Color BtnCancel = Color.Black;
		public static readonly Color BtnEdit = Color.Black;
		public static readonly Color BtnCopy = Color.Black;
		public static readonly Color BtnClose = Color.Black;

		/// <summary>
		/// Red color for buttons: Delete, Exit.
		/// </summary>
		public static readonly Color BtnRed = Color.Red;
		public static readonly Color BtnDelete = Color.Red;
		public static readonly Color BtnExit = Color.Red;

		// ====================================================================
		// 2. Status & Highlight Colors (Status & Pending)
		// ====================================================================
		public static readonly Color PendingRow = Color.LightYellow;
		public static readonly Color WarningText = Color.DarkOrange;
		public static readonly Color Success = Color.FromArgb(21, 128, 61);
		public static readonly Color SuccessLight = Color.FromArgb(220, 252, 231);
		public static readonly Color Danger = Color.FromArgb(185, 28, 28);
		public static readonly Color DangerLight = Color.FromArgb(254, 226, 226);
		public static readonly Color Warning = Color.FromArgb(245, 158, 11);
		public static readonly Color WarningLight = Color.FromArgb(254, 243, 199);
		public static readonly Color Info = Color.FromArgb(14, 116, 144);
		public static readonly Color Primary = Color.FromArgb(29, 78, 216);

		// ====================================================================
		// 3. Grid & Table Controls
		// ====================================================================
		public static readonly Color GridHeader = Color.FromArgb(226, 232, 240);
		public static readonly Color Selection = Color.FromArgb(219, 234, 254);
		public static readonly Color Border = Color.FromArgb(203, 213, 225);
		public static readonly Color White = Color.White;

		// ====================================================================
		// 4. Background & Surface
		// ====================================================================
		public static readonly Color Background = Color.FromArgb(241, 245, 249);
		public static readonly Color Surface = Color.FromArgb(255, 255, 255);
		public static readonly Color HeaderBackground = Color.FromArgb(255, 255, 255);
		public static readonly Color SidebarBackground = Color.FromArgb(15, 23, 42);
		public static readonly Color SidebarHover = Color.FromArgb(30, 41, 59);
		public static readonly Color SidebarSelected = Color.FromArgb(30, 64, 175);
		public static readonly Color MenuButton = Color.FromArgb(29, 78, 216);
		public static readonly Color MenuButtonHover = Color.FromArgb(30, 64, 175);
		public static readonly Color QrPayment = Color.FromArgb(3, 105, 161);

		// ====================================================================
		// 5. Typography
		// ====================================================================
		public static readonly Color TextLight = Color.White;
		public static readonly Color TextDark = Color.FromArgb(30, 41, 59);
		public static readonly Color TextMuted = Color.FromArgb(71, 85, 105);

		// ====================================================================
		// 6. Helper Methods to quickly apply button colors by FDS standards
		// ====================================================================
		public static void ApplyButtonSave(Button btn)
		{
			if (btn != null)
			{
				btn.ForeColor = BtnSave;
				btn.UseVisualStyleBackColor = true;
			}
		}

		public static void ApplyButtonAdd(Button btn)
		{
			if (btn != null)
			{
				btn.ForeColor = BtnAdd;
				btn.UseVisualStyleBackColor = true;
			}
		}

		public static void ApplyButtonEdit(Button btn)
		{
			if (btn != null)
			{
				btn.ForeColor = BtnEdit;
				btn.UseVisualStyleBackColor = true;
			}
		}

		public static void ApplyButtonDelete(Button btn)
		{
			if (btn != null)
			{
				btn.ForeColor = BtnDelete;
				btn.UseVisualStyleBackColor = true;
			}
		}

		public static void ApplyButtonCancel(Button btn)
		{
			if (btn != null)
			{
				btn.ForeColor = BtnCancel;
				btn.UseVisualStyleBackColor = true;
			}
		}
	}

	/// <summary>
	/// Alias for backwards compatibility with legacy code referencing AppColors.
	/// </summary>
	public static class AppColors
	{
		public static Color BtnBlue => AppColor.BtnBlue;
		public static Color BtnSave => AppColor.BtnSave;
		public static Color BtnAdd => AppColor.BtnAdd;
		public static Color BtnConfirm => AppColor.BtnConfirm;
		public static Color BtnExecute => AppColor.BtnExecute;
		public static Color BtnPrint => AppColor.BtnPrint;

		public static Color BtnBlack => AppColor.BtnBlack;
		public static Color BtnCancel => AppColor.BtnCancel;
		public static Color BtnEdit => AppColor.BtnEdit;
		public static Color BtnCopy => AppColor.BtnCopy;
		public static Color BtnClose => AppColor.BtnClose;

		public static Color BtnRed => AppColor.BtnRed;
		public static Color BtnDelete => AppColor.BtnDelete;
		public static Color BtnExit => AppColor.BtnExit;

		public static Color PendingRow => AppColor.PendingRow;
		public static Color WarningText => AppColor.WarningText;
		public static Color Success => AppColor.Success;
		public static Color SuccessLight => AppColor.SuccessLight;
		public static Color Danger => AppColor.Danger;
		public static Color DangerLight => AppColor.DangerLight;
		public static Color Warning => AppColor.Warning;
		public static Color WarningLight => AppColor.WarningLight;
		public static Color Info => AppColor.Info;
		public static Color Primary => AppColor.Primary;

		public static Color GridHeader => AppColor.GridHeader;
		public static Color Selection => AppColor.Selection;
		public static Color Border => AppColor.Border;

		public static Color Background => AppColor.Background;
		public static Color Surface => AppColor.Surface;
		public static Color HeaderBackground => AppColor.HeaderBackground;
		public static Color SidebarBackground => AppColor.SidebarBackground;
		public static Color SidebarHover => AppColor.SidebarHover;
		public static Color SidebarSelected => AppColor.SidebarSelected;
		public static Color MenuButton => AppColor.MenuButton;
		public static Color MenuButtonHover => AppColor.MenuButtonHover;
		public static Color QrPayment => AppColor.QrPayment;

		public static Color TextLight => AppColor.TextLight;
		public static Color TextDark => AppColor.TextDark;
		public static Color TextMuted => AppColor.TextMuted;
	}
}
