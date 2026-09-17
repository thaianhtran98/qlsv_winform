namespace QuanLySV.Controls
{
	partial class UcStudentAcademic
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		private void InitializeComponent()
		{
			this.PnlAcademicToolbar = new System.Windows.Forms.Panel();
			this.BtnAddAcademic = new System.Windows.Forms.Button();
			this.BtnEditAcademic = new System.Windows.Forms.Button();
			this.BtnDeleteAcademic = new System.Windows.Forms.Button();
			this.BtnSaveToDb = new System.Windows.Forms.Button();
			this.LblPendingAcademic = new System.Windows.Forms.Label();
			this.DgvAcademic = new System.Windows.Forms.DataGridView();
			this.GdvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GdvSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GdvSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GdvSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GdvScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GdvScoreLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PnlAcademicForm = new System.Windows.Forms.Panel();
			this.LblClass = new System.Windows.Forms.Label();
			this.CbxClass = new System.Windows.Forms.ComboBox();
			this.BtnAddClass = new System.Windows.Forms.Button();
			this.LblSchoolYear = new System.Windows.Forms.Label();
			this.CbxSchoolYear = new System.Windows.Forms.ComboBox();
			this.BtnAddSchoolYear = new System.Windows.Forms.Button();
			this.LblSubject = new System.Windows.Forms.Label();
			this.CbxSubject = new System.Windows.Forms.ComboBox();
			this.BtnAddSubject = new System.Windows.Forms.Button();
			this.LblSemester = new System.Windows.Forms.Label();
			this.CbxSemester = new System.Windows.Forms.ComboBox();
			this.LblScore = new System.Windows.Forms.Label();
			this.TbxScore = new System.Windows.Forms.TextBox();
			this.LblScoreLetter = new System.Windows.Forms.Label();
			this.TbxScoreLetter = new System.Windows.Forms.TextBox();
			this.LblAcademicNote = new System.Windows.Forms.Label();
			this.TbxAcademicNote = new System.Windows.Forms.TextBox();
			this.BtnSaveTempAcademic = new System.Windows.Forms.Button();
			this.BtnCancelAcademic = new System.Windows.Forms.Button();
			this.LblFormName = new System.Windows.Forms.Label();
			this.PnlAcademicToolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvAcademic)).BeginInit();
			this.PnlAcademicForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlAcademicToolbar
			// 
			this.PnlAcademicToolbar.Controls.Add(this.BtnAddAcademic);
			this.PnlAcademicToolbar.Controls.Add(this.BtnEditAcademic);
			this.PnlAcademicToolbar.Controls.Add(this.BtnDeleteAcademic);
			this.PnlAcademicToolbar.Controls.Add(this.BtnSaveToDb);
			this.PnlAcademicToolbar.Controls.Add(this.LblPendingAcademic);
			this.PnlAcademicToolbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlAcademicToolbar.Location = new System.Drawing.Point(0, 0);
			this.PnlAcademicToolbar.Name = "PnlAcademicToolbar";
			this.PnlAcademicToolbar.Size = new System.Drawing.Size(726, 35);
			this.PnlAcademicToolbar.TabIndex = 0;
			// 
			// BtnAddAcademic
			// 
			this.BtnAddAcademic.ForeColor = System.Drawing.Color.Blue;
			this.BtnAddAcademic.Location = new System.Drawing.Point(5, 5);
			this.BtnAddAcademic.Name = "BtnAddAcademic";
			this.BtnAddAcademic.Size = new System.Drawing.Size(75, 25);
			this.BtnAddAcademic.TabIndex = 0;
			this.BtnAddAcademic.Text = "Thêm";
			this.BtnAddAcademic.UseVisualStyleBackColor = true;
			this.BtnAddAcademic.Click += new System.EventHandler(this.BtnAddAcademic_Click);
			// 
			// BtnEditAcademic
			// 
			this.BtnEditAcademic.Enabled = false;
			this.BtnEditAcademic.ForeColor = System.Drawing.Color.Black;
			this.BtnEditAcademic.Location = new System.Drawing.Point(85, 5);
			this.BtnEditAcademic.Name = "BtnEditAcademic";
			this.BtnEditAcademic.Size = new System.Drawing.Size(75, 25);
			this.BtnEditAcademic.TabIndex = 1;
			this.BtnEditAcademic.Text = "Sửa";
			this.BtnEditAcademic.UseVisualStyleBackColor = true;
			this.BtnEditAcademic.Click += new System.EventHandler(this.BtnEditAcademic_Click);
			// 
			// BtnDeleteAcademic
			// 
			this.BtnDeleteAcademic.Enabled = false;
			this.BtnDeleteAcademic.ForeColor = System.Drawing.Color.Red;
			this.BtnDeleteAcademic.Location = new System.Drawing.Point(165, 5);
			this.BtnDeleteAcademic.Name = "BtnDeleteAcademic";
			this.BtnDeleteAcademic.Size = new System.Drawing.Size(75, 25);
			this.BtnDeleteAcademic.TabIndex = 2;
			this.BtnDeleteAcademic.Text = "Xóa";
			this.BtnDeleteAcademic.UseVisualStyleBackColor = true;
			this.BtnDeleteAcademic.Click += new System.EventHandler(this.BtnDeleteAcademic_Click);
			// 
			// BtnSaveToDb
			// 
			this.BtnSaveToDb.ForeColor = System.Drawing.Color.Blue;
			this.BtnSaveToDb.Location = new System.Drawing.Point(245, 5);
			this.BtnSaveToDb.Name = "BtnSaveToDb";
			this.BtnSaveToDb.Size = new System.Drawing.Size(115, 25);
			this.BtnSaveToDb.TabIndex = 3;
			this.BtnSaveToDb.Text = "Lưu vào DB";
			this.BtnSaveToDb.UseVisualStyleBackColor = true;
			this.BtnSaveToDb.Click += new System.EventHandler(this.BtnSaveToDb_Click);
			// 
			// LblPendingAcademic
			// 
			this.LblPendingAcademic.AutoSize = false;
			this.LblPendingAcademic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPendingAcademic.ForeColor = System.Drawing.Color.DarkOrange;
			this.LblPendingAcademic.Location = new System.Drawing.Point(365, 10);
			this.LblPendingAcademic.Name = "LblPendingAcademic";
			this.LblPendingAcademic.Size = new System.Drawing.Size(0, 13);
			this.LblPendingAcademic.TabIndex = 4;
			// 
			// DgvAcademic
			// 
			this.DgvAcademic.AllowUserToAddRows = false;
			this.DgvAcademic.AllowUserToDeleteRows = false;
			this.DgvAcademic.AllowUserToResizeRows = false;
			this.DgvAcademic.BackgroundColor = System.Drawing.Color.White;
			this.DgvAcademic.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DgvAcademic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
				this.GdvClass,
				this.GdvSchoolYear,
				this.GdvSubject,
				this.GdvSemester,
				this.GdvScore,
				this.GdvScoreLetter});
			this.DgvAcademic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvAcademic.Location = new System.Drawing.Point(0, 35);
			this.DgvAcademic.MultiSelect = false;
			this.DgvAcademic.Name = "DgvAcademic";
			this.DgvAcademic.ReadOnly = true;
			this.DgvAcademic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvAcademic.Size = new System.Drawing.Size(726, 192);
			this.DgvAcademic.TabIndex = 1;
			this.DgvAcademic.SelectionChanged += new System.EventHandler(this.DgvAcademic_SelectionChanged);
			// 
			// GdvClass
			// 
			this.GdvClass.HeaderText = "Lớp học";
			this.GdvClass.Name = "GdvClass";
			this.GdvClass.ReadOnly = true;
			this.GdvClass.Width = 120;
			// 
			// GdvSchoolYear
			// 
			this.GdvSchoolYear.HeaderText = "Năm học";
			this.GdvSchoolYear.Name = "GdvSchoolYear";
			this.GdvSchoolYear.ReadOnly = true;
			this.GdvSchoolYear.Width = 120;
			// 
			// GdvSubject
			// 
			this.GdvSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.GdvSubject.HeaderText = "Môn học";
			this.GdvSubject.Name = "GdvSubject";
			this.GdvSubject.ReadOnly = true;
			// 
			// GdvSemester
			// 
			this.GdvSemester.HeaderText = "Học kỳ";
			this.GdvSemester.Name = "GdvSemester";
			this.GdvSemester.ReadOnly = true;
			this.GdvSemester.Width = 70;
			// 
			// GdvScore
			// 
			this.GdvScore.HeaderText = "Điểm";
			this.GdvScore.Name = "GdvScore";
			this.GdvScore.ReadOnly = true;
			this.GdvScore.Width = 70;
			// 
			// GdvScoreLetter
			// 
			this.GdvScoreLetter.HeaderText = "Xếp loại";
			this.GdvScoreLetter.Name = "GdvScoreLetter";
			this.GdvScoreLetter.ReadOnly = true;
			this.GdvScoreLetter.Width = 70;
			// 
			// PnlAcademicForm
			// 
			this.PnlAcademicForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PnlAcademicForm.Controls.Add(this.LblFormName);
			this.PnlAcademicForm.Controls.Add(this.LblClass);
			this.PnlAcademicForm.Controls.Add(this.CbxClass);
			this.PnlAcademicForm.Controls.Add(this.BtnAddClass);
			this.PnlAcademicForm.Controls.Add(this.LblSchoolYear);
			this.PnlAcademicForm.Controls.Add(this.CbxSchoolYear);
			this.PnlAcademicForm.Controls.Add(this.BtnAddSchoolYear);
			this.PnlAcademicForm.Controls.Add(this.LblSubject);
			this.PnlAcademicForm.Controls.Add(this.CbxSubject);
			this.PnlAcademicForm.Controls.Add(this.BtnAddSubject);
			this.PnlAcademicForm.Controls.Add(this.LblSemester);
			this.PnlAcademicForm.Controls.Add(this.CbxSemester);
			this.PnlAcademicForm.Controls.Add(this.LblScore);
			this.PnlAcademicForm.Controls.Add(this.TbxScore);
			this.PnlAcademicForm.Controls.Add(this.LblScoreLetter);
			this.PnlAcademicForm.Controls.Add(this.TbxScoreLetter);
			this.PnlAcademicForm.Controls.Add(this.LblAcademicNote);
			this.PnlAcademicForm.Controls.Add(this.TbxAcademicNote);
			this.PnlAcademicForm.Controls.Add(this.BtnSaveTempAcademic);
			this.PnlAcademicForm.Controls.Add(this.BtnCancelAcademic);
			this.PnlAcademicForm.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlAcademicForm.Location = new System.Drawing.Point(0, 227);
			this.PnlAcademicForm.Name = "PnlAcademicForm";
			this.PnlAcademicForm.Size = new System.Drawing.Size(726, 235);
			this.PnlAcademicForm.TabIndex = 2;
			this.PnlAcademicForm.Visible = false;
			// 
			// LblClass
			// 
			this.LblClass.AutoSize = false;
			this.LblClass.Location = new System.Drawing.Point(3, 37);
			this.LblClass.Name = "LblClass";
			this.LblClass.Size = new System.Drawing.Size(100, 15);
			this.LblClass.TabIndex = 0;
			this.LblClass.Text = "Lớp học:";
			// 
			// CbxClass
			// 
			this.CbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxClass.Location = new System.Drawing.Point(3, 55);
			this.CbxClass.Name = "CbxClass";
			this.CbxClass.Size = new System.Drawing.Size(320, 21);
			this.CbxClass.TabIndex = 1;
			// 
			// BtnAddClass
			// 
			this.BtnAddClass.ForeColor = System.Drawing.Color.Blue;
			this.BtnAddClass.Location = new System.Drawing.Point(330, 55);
			this.BtnAddClass.Name = "BtnAddClass";
			this.BtnAddClass.Size = new System.Drawing.Size(25, 25);
			this.BtnAddClass.TabIndex = 2;
			this.BtnAddClass.Text = "+";
			this.BtnAddClass.UseVisualStyleBackColor = true;
			this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
			// 
			// LblSchoolYear
			// 
			this.LblSchoolYear.AutoSize = false;
			this.LblSchoolYear.Location = new System.Drawing.Point(369, 37);
			this.LblSchoolYear.Name = "LblSchoolYear";
			this.LblSchoolYear.Size = new System.Drawing.Size(100, 15);
			this.LblSchoolYear.TabIndex = 3;
			this.LblSchoolYear.Text = "Năm học:";
			// 
			// CbxSchoolYear
			// 
			this.CbxSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxSchoolYear.Location = new System.Drawing.Point(369, 55);
			this.CbxSchoolYear.Name = "CbxSchoolYear";
			this.CbxSchoolYear.Size = new System.Drawing.Size(315, 21);
			this.CbxSchoolYear.TabIndex = 4;
			// 
			// BtnAddSchoolYear
			// 
			this.BtnAddSchoolYear.ForeColor = System.Drawing.Color.Blue;
			this.BtnAddSchoolYear.Location = new System.Drawing.Point(690, 55);
			this.BtnAddSchoolYear.Name = "BtnAddSchoolYear";
			this.BtnAddSchoolYear.Size = new System.Drawing.Size(25, 25);
			this.BtnAddSchoolYear.TabIndex = 5;
			this.BtnAddSchoolYear.Text = "+";
			this.BtnAddSchoolYear.UseVisualStyleBackColor = true;
			this.BtnAddSchoolYear.Click += new System.EventHandler(this.BtnAddSchoolYear_Click);
			// 
			// LblSubject
			// 
			this.LblSubject.AutoSize = false;
			this.LblSubject.Location = new System.Drawing.Point(3, 77);
			this.LblSubject.Name = "LblSubject";
			this.LblSubject.Size = new System.Drawing.Size(100, 15);
			this.LblSubject.TabIndex = 6;
			this.LblSubject.Text = "Môn học:";
			// 
			// CbxSubject
			// 
			this.CbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxSubject.Location = new System.Drawing.Point(3, 95);
			this.CbxSubject.Name = "CbxSubject";
			this.CbxSubject.Size = new System.Drawing.Size(320, 21);
			this.CbxSubject.TabIndex = 7;
			// 
			// BtnAddSubject
			// 
			this.BtnAddSubject.ForeColor = System.Drawing.Color.Blue;
			this.BtnAddSubject.Location = new System.Drawing.Point(330, 95);
			this.BtnAddSubject.Name = "BtnAddSubject";
			this.BtnAddSubject.Size = new System.Drawing.Size(25, 25);
			this.BtnAddSubject.TabIndex = 8;
			this.BtnAddSubject.Text = "+";
			this.BtnAddSubject.UseVisualStyleBackColor = true;
			this.BtnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
			// 
			// LblSemester
			// 
			this.LblSemester.AutoSize = false;
			this.LblSemester.Location = new System.Drawing.Point(369, 77);
			this.LblSemester.Name = "LblSemester";
			this.LblSemester.Size = new System.Drawing.Size(100, 15);
			this.LblSemester.TabIndex = 9;
			this.LblSemester.Text = "Học kỳ:";
			// 
			// CbxSemester
			// 
			this.CbxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.CbxSemester.Location = new System.Drawing.Point(369, 95);
			this.CbxSemester.Name = "CbxSemester";
			this.CbxSemester.Size = new System.Drawing.Size(120, 21);
			this.CbxSemester.TabIndex = 10;
			// 
			// LblScore
			// 
			this.LblScore.AutoSize = false;
			this.LblScore.Location = new System.Drawing.Point(3, 117);
			this.LblScore.Name = "LblScore";
			this.LblScore.Size = new System.Drawing.Size(80, 15);
			this.LblScore.TabIndex = 11;
			this.LblScore.Text = "Điểm số:";
			// 
			// TbxScore
			// 
			this.TbxScore.Location = new System.Drawing.Point(3, 135);
			this.TbxScore.Name = "TbxScore";
			this.TbxScore.Size = new System.Drawing.Size(80, 20);
			this.TbxScore.TabIndex = 12;
			// 
			// LblScoreLetter
			// 
			this.LblScoreLetter.AutoSize = false;
			this.LblScoreLetter.Location = new System.Drawing.Point(103, 117);
			this.LblScoreLetter.Name = "LblScoreLetter";
			this.LblScoreLetter.Size = new System.Drawing.Size(80, 15);
			this.LblScoreLetter.TabIndex = 13;
			this.LblScoreLetter.Text = "Xếp loại:";
			// 
			// TbxScoreLetter
			// 
			this.TbxScoreLetter.Location = new System.Drawing.Point(103, 135);
			this.TbxScoreLetter.Name = "TbxScoreLetter";
			this.TbxScoreLetter.Size = new System.Drawing.Size(60, 20);
			this.TbxScoreLetter.TabIndex = 14;
			// 
			// LblAcademicNote
			// 
			this.LblAcademicNote.AutoSize = false;
			this.LblAcademicNote.Location = new System.Drawing.Point(3, 157);
			this.LblAcademicNote.Name = "LblAcademicNote";
			this.LblAcademicNote.Size = new System.Drawing.Size(60, 15);
			this.LblAcademicNote.TabIndex = 15;
			this.LblAcademicNote.Text = "Ghi chú:";
			// 
			// TbxAcademicNote
			// 
			this.TbxAcademicNote.Location = new System.Drawing.Point(3, 175);
			this.TbxAcademicNote.Name = "TbxAcademicNote";
			this.TbxAcademicNote.Size = new System.Drawing.Size(710, 20);
			this.TbxAcademicNote.TabIndex = 16;
			// 
			// BtnSaveTempAcademic
			// 
			this.BtnSaveTempAcademic.ForeColor = System.Drawing.Color.Blue;
			this.BtnSaveTempAcademic.Location = new System.Drawing.Point(625, 195);
			this.BtnSaveTempAcademic.Name = "BtnSaveTempAcademic";
			this.BtnSaveTempAcademic.Size = new System.Drawing.Size(90, 25);
			this.BtnSaveTempAcademic.TabIndex = 17;
			this.BtnSaveTempAcademic.Text = "Lưu tạm";
			this.BtnSaveTempAcademic.UseVisualStyleBackColor = true;
			this.BtnSaveTempAcademic.Click += new System.EventHandler(this.BtnSaveTempAcademic_Click);
			// 
			// BtnCancelAcademic
			// 
			this.BtnCancelAcademic.ForeColor = System.Drawing.Color.Black;
			this.BtnCancelAcademic.Location = new System.Drawing.Point(540, 195);
			this.BtnCancelAcademic.Name = "BtnCancelAcademic";
			this.BtnCancelAcademic.Size = new System.Drawing.Size(75, 25);
			this.BtnCancelAcademic.TabIndex = 18;
			this.BtnCancelAcademic.Text = "Hủy";
			this.BtnCancelAcademic.UseVisualStyleBackColor = true;
			this.BtnCancelAcademic.Click += new System.EventHandler(this.BtnCancelAcademic_Click);
			// 
			// LblFormName
			// 
			this.LblFormName.AutoSize = false;
			this.LblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.LblFormName.Location = new System.Drawing.Point(3, 4);
			this.LblFormName.Name = "LblFormName";
			this.LblFormName.Size = new System.Drawing.Size(176, 17);
			this.LblFormName.TabIndex = 19;
			this.LblFormName.Text = "Thêm thông tin học tập";
			// 
			// UcStudentAcademic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.DgvAcademic);
			this.Controls.Add(this.PnlAcademicForm);
			this.Controls.Add(this.PnlAcademicToolbar);
			this.Name = "UcStudentAcademic";
			this.Size = new System.Drawing.Size(726, 462);
			this.PnlAcademicToolbar.ResumeLayout(false);
			this.PnlAcademicToolbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvAcademic)).EndInit();
			this.PnlAcademicForm.ResumeLayout(false);
			this.PnlAcademicForm.PerformLayout();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Panel PnlAcademicToolbar;
		public System.Windows.Forms.Button BtnAddAcademic;
		public System.Windows.Forms.Button BtnEditAcademic;
		public System.Windows.Forms.Button BtnDeleteAcademic;
		public System.Windows.Forms.Button BtnSaveToDb;
		public System.Windows.Forms.Label LblPendingAcademic;
		public System.Windows.Forms.DataGridView DgvAcademic;
		public System.Windows.Forms.Panel PnlAcademicForm;
		public System.Windows.Forms.Label LblClass;
		public System.Windows.Forms.ComboBox CbxClass;
		public System.Windows.Forms.Button BtnAddClass;
		public System.Windows.Forms.Label LblSchoolYear;
		public System.Windows.Forms.ComboBox CbxSchoolYear;
		public System.Windows.Forms.Button BtnAddSchoolYear;
		public System.Windows.Forms.Label LblSubject;
		public System.Windows.Forms.ComboBox CbxSubject;
		public System.Windows.Forms.Button BtnAddSubject;
		public System.Windows.Forms.Label LblSemester;
		public System.Windows.Forms.ComboBox CbxSemester;
		public System.Windows.Forms.Label LblScore;
		public System.Windows.Forms.TextBox TbxScore;
		public System.Windows.Forms.Label LblScoreLetter;
		public System.Windows.Forms.TextBox TbxScoreLetter;
		public System.Windows.Forms.Label LblAcademicNote;
		public System.Windows.Forms.TextBox TbxAcademicNote;
		public System.Windows.Forms.Button BtnSaveTempAcademic;
		public System.Windows.Forms.Button BtnCancelAcademic;
		public System.Windows.Forms.DataGridViewTextBoxColumn ColClass;
		public System.Windows.Forms.DataGridViewTextBoxColumn ColSchoolYear;
		public System.Windows.Forms.DataGridViewTextBoxColumn ColSubject;
		public System.Windows.Forms.DataGridViewTextBoxColumn ColSemester;
		public System.Windows.Forms.DataGridViewTextBoxColumn ColScore;
		public System.Windows.Forms.DataGridViewTextBoxColumn ColScoreLetter;
		public System.Windows.Forms.DataGridViewTextBoxColumn GdvClass;
		public System.Windows.Forms.DataGridViewTextBoxColumn GdvSchoolYear;
		public System.Windows.Forms.DataGridViewTextBoxColumn GdvSubject;
		public System.Windows.Forms.DataGridViewTextBoxColumn GdvSemester;
		public System.Windows.Forms.DataGridViewTextBoxColumn GdvScore;
		public System.Windows.Forms.DataGridViewTextBoxColumn GdvScoreLetter;
		private System.Windows.Forms.Label LblFormName;
	}
}
