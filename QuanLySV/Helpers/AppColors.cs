using System.Drawing;

namespace QuanLySV.Helpers
{
	/// <summary>
	/// Modern and bright standard color palette.
	/// </summary>
	public static class AppColors
    {
		// 1. Menu & Navigation Header
		public static readonly Color HeaderBackground = Color.FromArgb(255, 255, 255);      // Crisp clean white
		public static readonly Color MenuButton = Color.FromArgb(29, 78, 216);
		public static readonly Color MenuButtonHover = Color.FromArgb(30, 64, 175);

		// 2. Background & Surface
		public static readonly Color Background = Color.FromArgb(241, 245, 249);            // Very light blue-gray, elegant and easy on the eyes
		public static readonly Color Surface = Color.FromArgb(255, 255, 255);               // Pure white background for cards and tables

		// 3. Typography
		public static readonly Color TextLight = Color.White;                               // White text for colored backgrounds
		public static readonly Color TextDark = Color.FromArgb(30, 41, 59);                 // Dark slate text for high readability
		public static readonly Color TextMuted = Color.FromArgb(71, 85, 105);

		// 4. Status & Actions
		public static readonly Color Success = Color.FromArgb(21, 128, 61);
		public static readonly Color SuccessLight = Color.FromArgb(220, 252, 231);         // Light bright mint green (Empty table)

		public static readonly Color Danger = Color.FromArgb(185, 28, 28);
		public static readonly Color DangerLight = Color.FromArgb(254, 226, 226);          // Light soft pink

		public static readonly Color Warning = Color.FromArgb(245, 158, 11);                // Amber orange (Warning, Pending)
		public static readonly Color WarningLight = Color.FromArgb(254, 243, 199);         // Bright cream yellow (Occupied table)

		public static readonly Color Info = Color.FromArgb(14, 116, 144);
		public static readonly Color Primary = Color.FromArgb(29, 78, 216);
		public static readonly Color QrPayment = Color.FromArgb(3, 105, 161);

		public static readonly Color SidebarBackground = Color.FromArgb(15, 23, 42);
		public static readonly Color SidebarHover = Color.FromArgb(30, 41, 59);
		public static readonly Color SidebarSelected = Color.FromArgb(30, 64, 175);
		public static readonly Color Border = Color.FromArgb(203, 213, 225);
		public static readonly Color GridHeader = Color.FromArgb(226, 232, 240);
		public static readonly Color Selection = Color.FromArgb(219, 234, 254);
	}
}
