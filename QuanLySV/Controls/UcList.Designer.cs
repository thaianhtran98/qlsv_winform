namespace QuanLySV.Controls
{
	partial class UcList
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PnlHeader = new System.Windows.Forms.Panel();
			this.LblStatus = new System.Windows.Forms.Label();
			this.LblSex = new System.Windows.Forms.Label();
			this.CbxStatus = new System.Windows.Forms.ComboBox();
			this.CbxSex = new System.Windows.Forms.ComboBox();
			this.pnlBody = new System.Windows.Forms.Panel();
			this.DgvListSV = new System.Windows.Forms.DataGridView();
			this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvBirthOfDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvBirthLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvVneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvDateOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvLocalOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvPlaceOfResidence = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvNumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GgvActionEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.GgvActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.PnlHeader.SuspendLayout();
			this.pnlBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvListSV)).BeginInit();
			this.SuspendLayout();
			// 
			// PnlHeader
			// 
			this.PnlHeader.Controls.Add(this.LblStatus);
			this.PnlHeader.Controls.Add(this.LblSex);
			this.PnlHeader.Controls.Add(this.CbxStatus);
			this.PnlHeader.Controls.Add(this.CbxSex);
			this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlHeader.Location = new System.Drawing.Point(0, 0);
			this.PnlHeader.Name = "PnlHeader";
			this.PnlHeader.Size = new System.Drawing.Size(1254, 30);
			this.PnlHeader.TabIndex = 0;
			// 
			// LblStatus
			// 
			this.LblStatus.AutoSize = true;
			this.LblStatus.Location = new System.Drawing.Point(245, 10);
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(107, 13);
			this.LblStatus.TabIndex = 3;
			this.LblStatus.Text = "Tình trạng hoạt động";
			// 
			// LblSex
			// 
			this.LblSex.AutoSize = true;
			this.LblSex.Location = new System.Drawing.Point(10, 10);
			this.LblSex.Name = "LblSex";
			this.LblSex.Size = new System.Drawing.Size(47, 13);
			this.LblSex.TabIndex = 2;
			this.LblSex.Text = "Giới tính";
			// 
			// CbxStatus
			// 
			this.CbxStatus.FormattingEnabled = true;
			this.CbxStatus.Location = new System.Drawing.Point(355, 5);
			this.CbxStatus.Name = "CbxStatus";
			this.CbxStatus.Size = new System.Drawing.Size(121, 21);
			this.CbxStatus.TabIndex = 1;
			this.CbxStatus.SelectedIndexChanged += new System.EventHandler(this.CbxStatus_SelectedIndexChanged);
			// 
			// CbxSex
			// 
			this.CbxSex.FormattingEnabled = true;
			this.CbxSex.Location = new System.Drawing.Point(60, 5);
			this.CbxSex.Name = "CbxSex";
			this.CbxSex.Size = new System.Drawing.Size(121, 21);
			this.CbxSex.TabIndex = 0;
			this.CbxSex.SelectedIndexChanged += new System.EventHandler(this.CbxSex_SelectedIndexChanged);
			// 
			// pnlBody
			// 
			this.pnlBody.Controls.Add(this.DgvListSV);
			this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBody.Location = new System.Drawing.Point(0, 30);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Size = new System.Drawing.Size(1254, 344);
			this.pnlBody.TabIndex = 1;
			// 
			// DgvListSV
			// 
			this.DgvListSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvListSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			  this.MSSV,
			  this.GgvName,
			  this.GgvSex,
			  this.GgvBirthOfDate,
			  this.GgvBirthLocal,
			  this.GgvVneId,
			  this.GgvDateOfIssue,
			  this.GgvLocalOfIssue,
			  this.GgvLocal,
			  this.GgvPlaceOfResidence,
			  this.GgvNumberPhone,
			  this.GgvStatus,
			  this.GgvActionEdit,
			  this.GgvActionDelete});
			this.DgvListSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvListSV.Location = new System.Drawing.Point(0, 0);
			this.DgvListSV.Name = "DgvListSV";
			this.DgvListSV.Size = new System.Drawing.Size(1254, 344);
			this.DgvListSV.TabIndex = 4;
			// 
			// MSSV
			// 
			this.MSSV.HeaderText = "MSSV";
			this.MSSV.Name = "MSSV";
			// 
			// GgvName
			// 
			this.GgvName.HeaderText = "Họ và tên";
			this.GgvName.Name = "GgvName";
			this.GgvName.ReadOnly = true;
			// 
			// GgvSex
			// 
			this.GgvSex.HeaderText = "Giới tính";
			this.GgvSex.Name = "GgvSex";
			this.GgvSex.ReadOnly = true;
			// 
			// GgvBirthOfDate
			// 
			this.GgvBirthOfDate.HeaderText = "Ngày sinh";
			this.GgvBirthOfDate.Name = "GgvBirthOfDate";
			this.GgvBirthOfDate.ReadOnly = true;
			// 
			// GgvBirthLocal
			// 
			this.GgvBirthLocal.HeaderText = "Quê quán";
			this.GgvBirthLocal.Name = "GgvBirthLocal";
			this.GgvBirthLocal.ReadOnly = true;
			// 
			// GgvVneId
			// 
			this.GgvVneId.HeaderText = "Số CCCD";
			this.GgvVneId.Name = "GgvVneId";
			this.GgvVneId.ReadOnly = true;
			// 
			// GgvDateOfIssue
			// 
			this.GgvDateOfIssue.HeaderText = "Ngày cấp";
			this.GgvDateOfIssue.Name = "GgvDateOfIssue";
			this.GgvDateOfIssue.ReadOnly = true;
			// 
			// GgvLocalOfIssue
			// 
			this.GgvLocalOfIssue.HeaderText = "Nơi cấp";
			this.GgvLocalOfIssue.Name = "GgvLocalOfIssue";
			this.GgvLocalOfIssue.ReadOnly = true;
			// 
			// GgvLocal
			// 
			this.GgvLocal.HeaderText = "Tỉnh/Thành phố";
			this.GgvLocal.Name = "GgvLocal";
			this.GgvLocal.ReadOnly = true;
			// 
			// GgvPlaceOfResidence
			// 
			this.GgvPlaceOfResidence.HeaderText = "Địa chỉ thường trú";
			this.GgvPlaceOfResidence.Name = "GgvPlaceOfResidence";
			this.GgvPlaceOfResidence.ReadOnly = true;
			// 
			// GgvNumberPhone
			// 
			this.GgvNumberPhone.HeaderText = "Số điện thoại";
			this.GgvNumberPhone.Name = "GgvNumberPhone";
			this.GgvNumberPhone.ReadOnly = true;
			// 
			// GgvStatus
			// 
			this.GgvStatus.HeaderText = "Trạng thái";
			this.GgvStatus.Name = "GgvStatus";
			this.GgvStatus.ReadOnly = true;
			// 
			// GgvActionEdit
			// 
			this.GgvActionEdit.HeaderText = "";
			this.GgvActionEdit.Name = "GgvActionEdit";
			// 
			// GgvActionDelete
			// 
			this.GgvActionDelete.HeaderText = "";
			this.GgvActionDelete.Name = "GgvActionDelete";
			// 
			// UcList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlBody);
			this.Controls.Add(this.PnlHeader);
			this.Name = "UcList";
			this.Size = new System.Drawing.Size(1254, 374);
			this.PnlHeader.ResumeLayout(false);
			this.PnlHeader.PerformLayout();
			this.pnlBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DgvListSV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlHeader;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.ComboBox CbxStatus;
		private System.Windows.Forms.ComboBox CbxSex;
		private System.Windows.Forms.Label LblStatus;
		private System.Windows.Forms.Label LblSex;
		private System.Windows.Forms.DataGridView DgvListSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvName;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvSex;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvBirthOfDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvBirthLocal;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvVneId;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvDateOfIssue;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvLocalOfIssue;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvLocal;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvPlaceOfResidence;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvNumberPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn GgvStatus;
		private System.Windows.Forms.DataGridViewButtonColumn GgvActionEdit;
		private System.Windows.Forms.DataGridViewButtonColumn GgvActionDelete;
	}
}
