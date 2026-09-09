namespace QuanLySV
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.PnlHeader = new System.Windows.Forms.Panel();
			this.BtnCreate = new System.Windows.Forms.Button();
			this.BtnList = new System.Windows.Forms.Button();
			this.PnlBody = new System.Windows.Forms.Panel();
			this.PnlHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlHeader
			// 
			this.PnlHeader.Controls.Add(this.BtnCreate);
			this.PnlHeader.Controls.Add(this.BtnList);
			this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlHeader.Location = new System.Drawing.Point(0, 0);
			this.PnlHeader.Name = "PnlHeader";
			this.PnlHeader.Size = new System.Drawing.Size(578, 35);
			this.PnlHeader.TabIndex = 0;
			// 
			// BtnCreate
			// 
			this.BtnCreate.Location = new System.Drawing.Point(75, 5);
			this.BtnCreate.Name = "BtnCreate";
			this.BtnCreate.Size = new System.Drawing.Size(75, 23);
			this.BtnCreate.TabIndex = 1;
			this.BtnCreate.Text = "Thêm mới";
			this.BtnCreate.UseVisualStyleBackColor = true;
			this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Cick);
			// 
			// BtnList
			// 
			this.BtnList.Location = new System.Drawing.Point(0, 5);
			this.BtnList.Name = "BtnList";
			this.BtnList.Size = new System.Drawing.Size(75, 23);
			this.BtnList.TabIndex = 0;
			this.BtnList.Text = "Danh sách";
			this.BtnList.UseVisualStyleBackColor = true;
			this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
			// 
			// PnlBody
			// 
			this.PnlBody.AutoScroll = true;
			this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlBody.Location = new System.Drawing.Point(0, 35);
			this.PnlBody.Name = "PnlBody";
			this.PnlBody.Size = new System.Drawing.Size(578, 295);
			this.PnlBody.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 330);
			this.Controls.Add(this.PnlBody);
			this.Controls.Add(this.PnlHeader);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý sinh viên";
			this.PnlHeader.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel PnlHeader;
		private System.Windows.Forms.Button BtnCreate;
		private System.Windows.Forms.Button BtnList;
		private System.Windows.Forms.Panel PnlBody;
	}
}

