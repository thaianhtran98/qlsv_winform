namespace QuanLySV.Controls
{
	partial class UcFormEdit
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.BtnSave = new System.Windows.Forms.Button();
			this.MskNumberPhone = new System.Windows.Forms.MaskedTextBox();
			this.LblNumberPhone = new System.Windows.Forms.Label();
			this.TbxPlaceOfResidence = new System.Windows.Forms.TextBox();
			this.LblPlaceOfResidence = new System.Windows.Forms.Label();
			this.TbxLocalOfIssue = new System.Windows.Forms.TextBox();
			this.LblLocalOfIssue = new System.Windows.Forms.Label();
			this.DtpDateOfIssue = new System.Windows.Forms.DateTimePicker();
			this.LblDateOfIssue = new System.Windows.Forms.Label();
			this.TbxStudentId = new System.Windows.Forms.TextBox();
			this.LblStudentId = new System.Windows.Forms.Label();
			this.TbxVneId = new System.Windows.Forms.TextBox();
			this.LblVneID = new System.Windows.Forms.Label();
			this.TbxLocal = new System.Windows.Forms.TextBox();
			this.LblLocal = new System.Windows.Forms.Label();
			this.TbxBirthLocal = new System.Windows.Forms.TextBox();
			this.LblBirthLocal = new System.Windows.Forms.Label();
			this.RbtFemale = new System.Windows.Forms.RadioButton();
			this.RbtMale = new System.Windows.Forms.RadioButton();
			this.LblSex = new System.Windows.Forms.Label();
			this.DtpBirthOfDate = new System.Windows.Forms.DateTimePicker();
			this.TbxName = new System.Windows.Forms.TextBox();
			this.LblBirthOfDate = new System.Windows.Forms.Label();
			this.LblName = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.BtnSave);
			this.panel1.Controls.Add(this.MskNumberPhone);
			this.panel1.Controls.Add(this.LblNumberPhone);
			this.panel1.Controls.Add(this.TbxPlaceOfResidence);
			this.panel1.Controls.Add(this.LblPlaceOfResidence);
			this.panel1.Controls.Add(this.TbxLocalOfIssue);
			this.panel1.Controls.Add(this.LblLocalOfIssue);
			this.panel1.Controls.Add(this.DtpDateOfIssue);
			this.panel1.Controls.Add(this.LblDateOfIssue);
			this.panel1.Controls.Add(this.TbxStudentId);
			this.panel1.Controls.Add(this.LblStudentId);
			this.panel1.Controls.Add(this.TbxVneId);
			this.panel1.Controls.Add(this.LblVneID);
			this.panel1.Controls.Add(this.TbxLocal);
			this.panel1.Controls.Add(this.LblLocal);
			this.panel1.Controls.Add(this.TbxBirthLocal);
			this.panel1.Controls.Add(this.LblBirthLocal);
			this.panel1.Controls.Add(this.RbtFemale);
			this.panel1.Controls.Add(this.RbtMale);
			this.panel1.Controls.Add(this.LblSex);
			this.panel1.Controls.Add(this.DtpBirthOfDate);
			this.panel1.Controls.Add(this.TbxName);
			this.panel1.Controls.Add(this.LblBirthOfDate);
			this.panel1.Controls.Add(this.LblName);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(545, 398);
			this.panel1.TabIndex = 0;
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(464, 370);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 47;
			this.BtnSave.Text = "Lưu";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.SaveStudent);
			// 
			// MskNumberPhone
			// 
			this.MskNumberPhone.Location = new System.Drawing.Point(4, 340);
			this.MskNumberPhone.Mask = "9999-999-999";
			this.MskNumberPhone.Name = "MskNumberPhone";
			this.MskNumberPhone.Size = new System.Drawing.Size(80, 20);
			this.MskNumberPhone.TabIndex = 46;
			// 
			// LblNumberPhone
			// 
			this.LblNumberPhone.Location = new System.Drawing.Point(4, 325);
			this.LblNumberPhone.Name = "LblNumberPhone";
			this.LblNumberPhone.Size = new System.Drawing.Size(131, 15);
			this.LblNumberPhone.TabIndex = 45;
			this.LblNumberPhone.Text = "Số điện thoại:";
			// 
			// TbxPlaceOfResidence
			// 
			this.TbxPlaceOfResidence.Location = new System.Drawing.Point(4, 300);
			this.TbxPlaceOfResidence.Name = "TbxPlaceOfResidence";
			this.TbxPlaceOfResidence.Size = new System.Drawing.Size(537, 20);
			this.TbxPlaceOfResidence.TabIndex = 44;
			// 
			// LblPlaceOfResidence
			// 
			this.LblPlaceOfResidence.Location = new System.Drawing.Point(4, 285);
			this.LblPlaceOfResidence.Name = "LblPlaceOfResidence";
			this.LblPlaceOfResidence.Size = new System.Drawing.Size(131, 15);
			this.LblPlaceOfResidence.TabIndex = 43;
			this.LblPlaceOfResidence.Text = "Nơi thường trú/Nơi cư trú: ";
			// 
			// TbxLocalOfIssue
			// 
			this.TbxLocalOfIssue.Location = new System.Drawing.Point(4, 220);
			this.TbxLocalOfIssue.Name = "TbxLocalOfIssue";
			this.TbxLocalOfIssue.Size = new System.Drawing.Size(537, 20);
			this.TbxLocalOfIssue.TabIndex = 40;
			// 
			// LblLocalOfIssue
			// 
			this.LblLocalOfIssue.Location = new System.Drawing.Point(4, 205);
			this.LblLocalOfIssue.Name = "LblLocalOfIssue";
			this.LblLocalOfIssue.Size = new System.Drawing.Size(131, 15);
			this.LblLocalOfIssue.TabIndex = 39;
			this.LblLocalOfIssue.Text = "Nơi cấp:";
			// 
			// DtpDateOfIssue
			// 
			this.DtpDateOfIssue.CustomFormat = "yyyy/MM/dd";
			this.DtpDateOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DtpDateOfIssue.Location = new System.Drawing.Point(174, 180);
			this.DtpDateOfIssue.Name = "DtpDateOfIssue";
			this.DtpDateOfIssue.Size = new System.Drawing.Size(211, 20);
			this.DtpDateOfIssue.TabIndex = 38;
			// 
			// LblDateOfIssue
			// 
			this.LblDateOfIssue.Location = new System.Drawing.Point(174, 165);
			this.LblDateOfIssue.Name = "LblDateOfIssue";
			this.LblDateOfIssue.Size = new System.Drawing.Size(65, 15);
			this.LblDateOfIssue.TabIndex = 37;
			this.LblDateOfIssue.Text = "Ngày cấp:";
			// 
			// TbxStudentId
			// 
			this.TbxStudentId.Location = new System.Drawing.Point(4, 20);
			this.TbxStudentId.Name = "TbxStudentId";
			this.TbxStudentId.Size = new System.Drawing.Size(537, 20);
			this.TbxStudentId.TabIndex = 25;
			// 
			// LblStudentId
			// 
			this.LblStudentId.Location = new System.Drawing.Point(4, 5);
			this.LblStudentId.Name = "LblStudentId";
			this.LblStudentId.Size = new System.Drawing.Size(90, 15);
			this.LblStudentId.TabIndex = 24;
			this.LblStudentId.Text = "Mã số sinh viên:";
			// 
			// TbxVneId
			// 
			this.TbxVneId.Location = new System.Drawing.Point(4, 180);
			this.TbxVneId.Name = "TbxVneId";
			this.TbxVneId.Size = new System.Drawing.Size(165, 20);
			this.TbxVneId.TabIndex = 36;
			// 
			// LblVneID
			// 
			this.LblVneID.Location = new System.Drawing.Point(4, 165);
			this.LblVneID.Name = "LblVneID";
			this.LblVneID.Size = new System.Drawing.Size(105, 15);
			this.LblVneID.TabIndex = 35;
			this.LblVneID.Text = "Căn cước công dân:";
			// 
			// TbxLocal
			// 
			this.TbxLocal.Location = new System.Drawing.Point(4, 260);
			this.TbxLocal.Name = "TbxLocal";
			this.TbxLocal.Size = new System.Drawing.Size(537, 20);
			this.TbxLocal.TabIndex = 42;
			// 
			// LblLocal
			// 
			this.LblLocal.Location = new System.Drawing.Point(4, 245);
			this.LblLocal.Name = "LblLocal";
			this.LblLocal.Size = new System.Drawing.Size(131, 15);
			this.LblLocal.TabIndex = 41;
			this.LblLocal.Text = "Quê quán/Nguyên quán: ";
			// 
			// TbxBirthLocal
			// 
			this.TbxBirthLocal.Location = new System.Drawing.Point(4, 140);
			this.TbxBirthLocal.Name = "TbxBirthLocal";
			this.TbxBirthLocal.Size = new System.Drawing.Size(537, 20);
			this.TbxBirthLocal.TabIndex = 34;
			// 
			// LblBirthLocal
			// 
			this.LblBirthLocal.Location = new System.Drawing.Point(4, 125);
			this.LblBirthLocal.Name = "LblBirthLocal";
			this.LblBirthLocal.Size = new System.Drawing.Size(65, 15);
			this.LblBirthLocal.TabIndex = 33;
			this.LblBirthLocal.Text = "Nơi sinh:";
			// 
			// RbtFemale
			// 
			this.RbtFemale.AutoSize = true;
			this.RbtFemale.Location = new System.Drawing.Point(54, 100);
			this.RbtFemale.Name = "RbtFemale";
			this.RbtFemale.Size = new System.Drawing.Size(39, 17);
			this.RbtFemale.TabIndex = 30;
			this.RbtFemale.Text = "Nữ";
			this.RbtFemale.UseVisualStyleBackColor = true;
			// 
			// RbtMale
			// 
			this.RbtMale.AutoSize = true;
			this.RbtMale.Checked = true;
			this.RbtMale.Location = new System.Drawing.Point(4, 100);
			this.RbtMale.Name = "RbtMale";
			this.RbtMale.Size = new System.Drawing.Size(47, 17);
			this.RbtMale.TabIndex = 29;
			this.RbtMale.TabStop = true;
			this.RbtMale.Text = "Nam";
			this.RbtMale.UseVisualStyleBackColor = true;
			// 
			// LblSex
			// 
			this.LblSex.Location = new System.Drawing.Point(4, 85);
			this.LblSex.Name = "LblSex";
			this.LblSex.Size = new System.Drawing.Size(65, 15);
			this.LblSex.TabIndex = 28;
			this.LblSex.Text = "Giới tính:";
			// 
			// DtpBirthOfDate
			// 
			this.DtpBirthOfDate.Checked = false;
			this.DtpBirthOfDate.CustomFormat = "yyyy/MM/dd";
			this.DtpBirthOfDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DtpBirthOfDate.Location = new System.Drawing.Point(174, 100);
			this.DtpBirthOfDate.Name = "DtpBirthOfDate";
			this.DtpBirthOfDate.Size = new System.Drawing.Size(211, 20);
			this.DtpBirthOfDate.TabIndex = 32;
			// 
			// TbxName
			// 
			this.TbxName.Location = new System.Drawing.Point(4, 60);
			this.TbxName.Name = "TbxName";
			this.TbxName.Size = new System.Drawing.Size(537, 20);
			this.TbxName.TabIndex = 27;
			// 
			// LblBirthOfDate
			// 
			this.LblBirthOfDate.Location = new System.Drawing.Point(174, 85);
			this.LblBirthOfDate.Name = "LblBirthOfDate";
			this.LblBirthOfDate.Size = new System.Drawing.Size(65, 15);
			this.LblBirthOfDate.TabIndex = 31;
			this.LblBirthOfDate.Text = "Sinh nhật:";
			// 
			// LblName
			// 
			this.LblName.Location = new System.Drawing.Point(4, 45);
			this.LblName.Name = "LblName";
			this.LblName.Size = new System.Drawing.Size(65, 15);
			this.LblName.TabIndex = 26;
			this.LblName.Text = "Họ và tên:";
			// 
			// UcFormEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.panel1);
			this.Name = "UcFormEdit";
			this.Size = new System.Drawing.Size(545, 398);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.MaskedTextBox MskNumberPhone;
		private System.Windows.Forms.Label LblNumberPhone;
		private System.Windows.Forms.TextBox TbxPlaceOfResidence;
		private System.Windows.Forms.Label LblPlaceOfResidence;
		private System.Windows.Forms.TextBox TbxLocalOfIssue;
		private System.Windows.Forms.Label LblLocalOfIssue;
		private System.Windows.Forms.DateTimePicker DtpDateOfIssue;
		private System.Windows.Forms.Label LblDateOfIssue;
		private System.Windows.Forms.TextBox TbxStudentId;
		private System.Windows.Forms.Label LblStudentId;
		private System.Windows.Forms.TextBox TbxVneId;
		private System.Windows.Forms.Label LblVneID;
		private System.Windows.Forms.TextBox TbxLocal;
		private System.Windows.Forms.Label LblLocal;
		private System.Windows.Forms.TextBox TbxBirthLocal;
		private System.Windows.Forms.Label LblBirthLocal;
		private System.Windows.Forms.RadioButton RbtFemale;
		private System.Windows.Forms.RadioButton RbtMale;
		private System.Windows.Forms.Label LblSex;
		private System.Windows.Forms.DateTimePicker DtpBirthOfDate;
		private System.Windows.Forms.TextBox TbxName;
		private System.Windows.Forms.Label LblBirthOfDate;
		private System.Windows.Forms.Label LblName;
	}
}
