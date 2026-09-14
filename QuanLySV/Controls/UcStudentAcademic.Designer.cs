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
			this.DgvAcademic = new System.Windows.Forms.DataGridView();
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
			this.BtnSaveAcademic = new System.Windows.Forms.Button();
			this.BtnCancelAcademic = new System.Windows.Forms.Button();
			this.BtnSaveToDb = new System.Windows.Forms.Button();
			this.LblPendingAcademic = new System.Windows.Forms.Label();

			this.PnlAcademicToolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvAcademic)).BeginInit();
			this.PnlAcademicForm.SuspendLayout();
			this.SuspendLayout();

			// PnlAcademicToolbar
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

			// BtnAddAcademic
			this.BtnAddAcademic.Location = new System.Drawing.Point(4, 6);
			this.BtnAddAcademic.Name = "BtnAddAcademic";
			this.BtnAddAcademic.Size = new System.Drawing.Size(75, 23);
			this.BtnAddAcademic.TabIndex = 0;
			this.BtnAddAcademic.Text = "➕ Thêm";
			this.BtnAddAcademic.UseVisualStyleBackColor = true;
			this.BtnAddAcademic.Click += new System.EventHandler(this.BtnAddAcademic_Click);

			// BtnEditAcademic
			this.BtnEditAcademic.Enabled = false;
			this.BtnEditAcademic.Location = new System.Drawing.Point(88, 6);
			this.BtnEditAcademic.Name = "BtnEditAcademic";
			this.BtnEditAcademic.Size = new System.Drawing.Size(75, 23);
			this.BtnEditAcademic.TabIndex = 1;
			this.BtnEditAcademic.Text = "✏ Sửa";
			this.BtnEditAcademic.UseVisualStyleBackColor = true;
			this.BtnEditAcademic.Click += new System.EventHandler(this.BtnEditAcademic_Click);

			// BtnDeleteAcademic
			this.BtnDeleteAcademic.Enabled = false;
			this.BtnDeleteAcademic.Location = new System.Drawing.Point(171, 6);
			this.BtnDeleteAcademic.Name = "BtnDeleteAcademic";
			this.BtnDeleteAcademic.Size = new System.Drawing.Size(75, 23);
			this.BtnDeleteAcademic.TabIndex = 2;
			this.BtnDeleteAcademic.Text = "✖ Xóa";
			this.BtnDeleteAcademic.UseVisualStyleBackColor = true;
			this.BtnDeleteAcademic.Click += new System.EventHandler(this.BtnDeleteAcademic_Click);

			// BtnSaveToDb
			this.BtnSaveToDb.Location = new System.Drawing.Point(260, 6);
			this.BtnSaveToDb.Name = "BtnSaveToDb";
			this.BtnSaveToDb.Size = new System.Drawing.Size(115, 23);
			this.BtnSaveToDb.TabIndex = 3;
			this.BtnSaveToDb.Text = "💾 Lưu vào DB";
			this.BtnSaveToDb.UseVisualStyleBackColor = true;
			this.BtnSaveToDb.Click += new System.EventHandler(this.BtnSaveToDb_Click);

			// LblPendingAcademic
			this.LblPendingAcademic.AutoSize = true;
			this.LblPendingAcademic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPendingAcademic.ForeColor = System.Drawing.Color.DarkOrange;
			this.LblPendingAcademic.Location = new System.Drawing.Point(390, 11);
			this.LblPendingAcademic.Name = "LblPendingAcademic";
			this.LblPendingAcademic.Size = new System.Drawing.Size(0, 13);
			this.LblPendingAcademic.TabIndex = 4;

			// DgvAcademic
			this.DgvAcademic.AllowUserToAddRows = false;
			this.DgvAcademic.AllowUserToDeleteRows = false;
			this.DgvAcademic.AllowUserToResizeRows = false;
			this.DgvAcademic.BackgroundColor = System.Drawing.Color.White;
			this.DgvAcademic.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DgvAcademic.ReadOnly = true;
			this.DgvAcademic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvAcademic.MultiSelect = false;
			this.DgvAcademic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvAcademic.Location = new System.Drawing.Point(0, 35);
			this.DgvAcademic.Name = "DgvAcademic";
			this.DgvAcademic.Size = new System.Drawing.Size(726, 427);
			this.DgvAcademic.TabIndex = 1;
			this.DgvAcademic.SelectionChanged += new System.EventHandler(this.DgvAcademic_SelectionChanged);

			this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colClass.Name = "GdvClass";
			this.colClass.HeaderText = "Lớp học";
			this.colClass.Width = 120;
			this.colClass.ReadOnly = true;

			this.colSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSchoolYear.Name = "GdvSchoolYear";
			this.colSchoolYear.HeaderText = "Năm học";
			this.colSchoolYear.Width = 120;
			this.colSchoolYear.ReadOnly = true;

			this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubject.Name = "GdvSubject";
			this.colSubject.HeaderText = "Môn học";
			this.colSubject.FillWeight = 100;
			this.colSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSubject.ReadOnly = true;

			this.colSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSemester.Name = "GdvSemester";
			this.colSemester.HeaderText = "Học kỳ";
			this.colSemester.Width = 70;
			this.colSemester.ReadOnly = true;

			this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colScore.Name = "GdvScore";
			this.colScore.HeaderText = "Điểm";
			this.colScore.Width = 70;
			this.colScore.ReadOnly = true;

			this.colScoreLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colScoreLetter.Name = "GdvScoreLetter";
			this.colScoreLetter.HeaderText = "Xếp loại";
			this.colScoreLetter.Width = 70;
			this.colScoreLetter.ReadOnly = true;

			this.DgvAcademic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colClass,
			this.colSchoolYear,
			this.colSubject,
			this.colSemester,
			this.colScore,
			this.colScoreLetter});

			// PnlAcademicForm
			this.PnlAcademicForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			this.PnlAcademicForm.Controls.Add(this.BtnSaveAcademic);
			this.PnlAcademicForm.Controls.Add(this.BtnCancelAcademic);
			this.PnlAcademicForm.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlAcademicForm.Location = new System.Drawing.Point(0, 242);
			this.PnlAcademicForm.Name = "PnlAcademicForm";
			this.PnlAcademicForm.Size = new System.Drawing.Size(726, 220);
			this.PnlAcademicForm.TabIndex = 2;
			this.PnlAcademicForm.Visible = false;

			// Row 1
			this.LblClass.Location = new System.Drawing.Point(4, 8);
			this.LblClass.Name = "LblClass";
			this.LblClass.Size = new System.Drawing.Size(100, 15);
			this.LblClass.Text = "Lớp học:";
			this.CbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxClass.Location = new System.Drawing.Point(4, 26);
			this.CbxClass.Name = "CbxClass";
			this.CbxClass.Size = new System.Drawing.Size(320, 22);
			this.BtnAddClass.Location = new System.Drawing.Point(329, 26);
			this.BtnAddClass.Size = new System.Drawing.Size(25, 23);
			this.BtnAddClass.Text = "+";
			this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);

			this.LblSchoolYear.Location = new System.Drawing.Point(370, 8);
			this.LblSchoolYear.Name = "LblSchoolYear";
			this.LblSchoolYear.Size = new System.Drawing.Size(100, 15);
			this.LblSchoolYear.Text = "Năm học:";
			this.CbxSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxSchoolYear.Location = new System.Drawing.Point(370, 26);
			this.CbxSchoolYear.Name = "CbxSchoolYear";
			this.CbxSchoolYear.Size = new System.Drawing.Size(315, 22);
			this.BtnAddSchoolYear.Location = new System.Drawing.Point(690, 26);
			this.BtnAddSchoolYear.Size = new System.Drawing.Size(25, 23);
			this.BtnAddSchoolYear.Text = "+";
			this.BtnAddSchoolYear.Click += new System.EventHandler(this.BtnAddSchoolYear_Click);

			// Row 2
			this.LblSubject.Location = new System.Drawing.Point(4, 48);
			this.LblSubject.Name = "LblSubject";
			this.LblSubject.Size = new System.Drawing.Size(100, 15);
			this.LblSubject.Text = "Môn học:";
			this.CbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxSubject.Location = new System.Drawing.Point(4, 66);
			this.CbxSubject.Name = "CbxSubject";
			this.CbxSubject.Size = new System.Drawing.Size(320, 22);
			this.BtnAddSubject.Location = new System.Drawing.Point(329, 66);
			this.BtnAddSubject.Size = new System.Drawing.Size(25, 23);
			this.BtnAddSubject.Text = "+";
			this.BtnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);

			this.LblSemester.Location = new System.Drawing.Point(370, 48);
			this.LblSemester.Name = "LblSemester";
			this.LblSemester.Size = new System.Drawing.Size(100, 15);
			this.LblSemester.Text = "Học kỳ:";
			this.CbxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxSemester.Location = new System.Drawing.Point(370, 66);
			this.CbxSemester.Name = "CbxSemester";
			this.CbxSemester.Size = new System.Drawing.Size(120, 22);
			this.CbxSemester.Items.AddRange(new object[] { "1", "2", "3" });

			// Row 3
			this.LblScore.Location = new System.Drawing.Point(4, 88);
			this.LblScore.Name = "LblScore";
			this.LblScore.Size = new System.Drawing.Size(80, 15);
			this.LblScore.Text = "Điểm số:";
			this.TbxScore.Location = new System.Drawing.Point(4, 106);
			this.TbxScore.Name = "TbxScore";
			this.TbxScore.Size = new System.Drawing.Size(80, 20);

			this.LblScoreLetter.Location = new System.Drawing.Point(104, 88);
			this.LblScoreLetter.Name = "LblScoreLetter";
			this.LblScoreLetter.Size = new System.Drawing.Size(80, 15);
			this.LblScoreLetter.Text = "Xếp loại:";
			this.TbxScoreLetter.Location = new System.Drawing.Point(104, 106);
			this.TbxScoreLetter.Name = "TbxScoreLetter";
			this.TbxScoreLetter.Size = new System.Drawing.Size(60, 20);

			// Row 4
			this.LblAcademicNote.Location = new System.Drawing.Point(4, 128);
			this.LblAcademicNote.Name = "LblAcademicNote";
			this.LblAcademicNote.Size = new System.Drawing.Size(60, 15);
			this.LblAcademicNote.Text = "Ghi chú:";
			this.TbxAcademicNote.Location = new System.Drawing.Point(4, 146);
			this.TbxAcademicNote.Name = "TbxAcademicNote";
			this.TbxAcademicNote.Size = new System.Drawing.Size(710, 20);

			// Buttons
			this.BtnSaveAcademic.Location = new System.Drawing.Point(625, 168);
			this.BtnSaveAcademic.Name = "BtnSaveAcademic";
			this.BtnSaveAcademic.Size = new System.Drawing.Size(90, 23);
			this.BtnSaveAcademic.Text = "✔ Lưu tạm";
			this.BtnSaveAcademic.Click += new System.EventHandler(this.BtnSaveAcademic_Click);

			this.BtnCancelAcademic.Location = new System.Drawing.Point(540, 168);
			this.BtnCancelAcademic.Name = "BtnCancelAcademic";
			this.BtnCancelAcademic.Size = new System.Drawing.Size(75, 23);
			this.BtnCancelAcademic.Text = "Hủy";
			this.BtnCancelAcademic.Click += new System.EventHandler(this.BtnCancelAcademic_Click);

			// UcStudentAcademic
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.DgvAcademic);
			this.Controls.Add(this.PnlAcademicForm);
			this.Controls.Add(this.PnlAcademicToolbar);
			this.Name = "UcStudentAcademic";
			this.Size = new System.Drawing.Size(726, 462);
			this.PnlAcademicToolbar.ResumeLayout(false);
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
		public System.Windows.Forms.Button BtnSaveAcademic;
		public System.Windows.Forms.Button BtnCancelAcademic;
		public System.Windows.Forms.DataGridViewTextBoxColumn colClass;
		public System.Windows.Forms.DataGridViewTextBoxColumn colSchoolYear;
		public System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
		public System.Windows.Forms.DataGridViewTextBoxColumn colSemester;
		public System.Windows.Forms.DataGridViewTextBoxColumn colScore;
		public System.Windows.Forms.DataGridViewTextBoxColumn colScoreLetter;
	}
}
