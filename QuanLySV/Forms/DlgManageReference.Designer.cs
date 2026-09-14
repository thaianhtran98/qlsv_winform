namespace QuanLySV.Forms
{
	partial class DlgManageReference
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

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.TabReference = new System.Windows.Forms.TabControl();
			this.TpgClass = new System.Windows.Forms.TabPage();
			this.DgvClass = new System.Windows.Forms.DataGridView();
			this.PnlClassInput = new System.Windows.Forms.Panel();
			this.BtnClearClass = new System.Windows.Forms.Button();
			this.BtnDeleteClass = new System.Windows.Forms.Button();
			this.BtnEditClass = new System.Windows.Forms.Button();
			this.BtnAddClass = new System.Windows.Forms.Button();
			this.TbxClassDesc = new System.Windows.Forms.TextBox();
			this.LblClassDesc = new System.Windows.Forms.Label();
			this.TbxClassName = new System.Windows.Forms.TextBox();
			this.LblClassName = new System.Windows.Forms.Label();
			this.TbxClassId = new System.Windows.Forms.TextBox();
			this.LblClassId = new System.Windows.Forms.Label();
			this.TpgSchoolYear = new System.Windows.Forms.TabPage();
			this.DgvSchoolYear = new System.Windows.Forms.DataGridView();
			this.PnlSchoolYearInput = new System.Windows.Forms.Panel();
			this.BtnClearSchoolYear = new System.Windows.Forms.Button();
			this.BtnDeleteSchoolYear = new System.Windows.Forms.Button();
			this.BtnEditSchoolYear = new System.Windows.Forms.Button();
			this.BtnAddSchoolYear = new System.Windows.Forms.Button();
			this.NumEndYear = new System.Windows.Forms.NumericUpDown();
			this.LblEndYear = new System.Windows.Forms.Label();
			this.NumStartYear = new System.Windows.Forms.NumericUpDown();
			this.LblStartYear = new System.Windows.Forms.Label();
			this.TbxSchoolYearName = new System.Windows.Forms.TextBox();
			this.LblSchoolYearName = new System.Windows.Forms.Label();
			this.TbxSchoolYearId = new System.Windows.Forms.TextBox();
			this.LblSchoolYearId = new System.Windows.Forms.Label();
			this.TpgSubject = new System.Windows.Forms.TabPage();
			this.DgvSubject = new System.Windows.Forms.DataGridView();
			this.PnlSubjectInput = new System.Windows.Forms.Panel();
			this.BtnClearSubject = new System.Windows.Forms.Button();
			this.BtnDeleteSubject = new System.Windows.Forms.Button();
			this.BtnEditSubject = new System.Windows.Forms.Button();
			this.BtnAddSubject = new System.Windows.Forms.Button();
			this.NumCredits = new System.Windows.Forms.NumericUpDown();
			this.LblCredits = new System.Windows.Forms.Label();
			this.TbxSubjectDesc = new System.Windows.Forms.TextBox();
			this.LblSubjectDesc = new System.Windows.Forms.Label();
			this.TbxSubjectName = new System.Windows.Forms.TextBox();
			this.LblSubjectName = new System.Windows.Forms.Label();
			this.TbxSubjectId = new System.Windows.Forms.TextBox();
			this.LblSubjectId = new System.Windows.Forms.Label();
			this.PnlDialogFooter = new System.Windows.Forms.Panel();
			this.BtnSelect = new System.Windows.Forms.Button();
			this.BtnClose = new System.Windows.Forms.Button();
			this.TabReference.SuspendLayout();
			this.TpgClass.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvClass)).BeginInit();
			this.PnlClassInput.SuspendLayout();
			this.TpgSchoolYear.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvSchoolYear)).BeginInit();
			this.PnlSchoolYearInput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumEndYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumStartYear)).BeginInit();
			this.TpgSubject.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvSubject)).BeginInit();
			this.PnlSubjectInput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumCredits)).BeginInit();
			this.PnlDialogFooter.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabReference
			// 
			this.TabReference.Controls.Add(this.TpgClass);
			this.TabReference.Controls.Add(this.TpgSchoolYear);
			this.TabReference.Controls.Add(this.TpgSubject);
			this.TabReference.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabReference.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabReference.Location = new System.Drawing.Point(0, 0);
			this.TabReference.Name = "TabReference";
			this.TabReference.SelectedIndex = 0;
			this.TabReference.Size = new System.Drawing.Size(764, 469);
			this.TabReference.TabIndex = 0;
			this.TabReference.SelectedIndexChanged += new System.EventHandler(this.TabReference_SelectedIndexChanged);
			// 
			// TpgClass
			// 
			this.TpgClass.Controls.Add(this.DgvClass);
			this.TpgClass.Controls.Add(this.PnlClassInput);
			this.TpgClass.Location = new System.Drawing.Point(4, 24);
			this.TpgClass.Name = "TpgClass";
			this.TpgClass.Padding = new System.Windows.Forms.Padding(6);
			this.TpgClass.Size = new System.Drawing.Size(756, 441);
			this.TpgClass.TabIndex = 0;
			this.TpgClass.Text = "🏫 Lớp học";
			this.TpgClass.UseVisualStyleBackColor = true;
			// 
			// DgvClass
			// 
			this.DgvClass.AllowUserToAddRows = false;
			this.DgvClass.AllowUserToDeleteRows = false;
			this.DgvClass.AllowUserToResizeRows = false;
			this.DgvClass.BackgroundColor = System.Drawing.Color.White;
			this.DgvClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DgvClass.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvClass.Location = new System.Drawing.Point(6, 126);
			this.DgvClass.MultiSelect = false;
			this.DgvClass.Name = "DgvClass";
			this.DgvClass.ReadOnly = true;
			this.DgvClass.RowHeadersVisible = false;
			this.DgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvClass.Size = new System.Drawing.Size(744, 309);
			this.DgvClass.TabIndex = 1;
			this.DgvClass.SelectionChanged += new System.EventHandler(this.DgvClass_SelectionChanged);
			// 
			// PnlClassInput
			// 
			this.PnlClassInput.Controls.Add(this.BtnClearClass);
			this.PnlClassInput.Controls.Add(this.BtnDeleteClass);
			this.PnlClassInput.Controls.Add(this.BtnEditClass);
			this.PnlClassInput.Controls.Add(this.BtnAddClass);
			this.PnlClassInput.Controls.Add(this.TbxClassDesc);
			this.PnlClassInput.Controls.Add(this.LblClassDesc);
			this.PnlClassInput.Controls.Add(this.TbxClassName);
			this.PnlClassInput.Controls.Add(this.LblClassName);
			this.PnlClassInput.Controls.Add(this.TbxClassId);
			this.PnlClassInput.Controls.Add(this.LblClassId);
			this.PnlClassInput.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlClassInput.Location = new System.Drawing.Point(6, 6);
			this.PnlClassInput.Name = "PnlClassInput";
			this.PnlClassInput.Size = new System.Drawing.Size(744, 120);
			this.PnlClassInput.TabIndex = 0;
			// 
			// BtnClearClass
			// 
			this.BtnClearClass.Location = new System.Drawing.Point(390, 80);
			this.BtnClearClass.Name = "BtnClearClass";
			this.BtnClearClass.Size = new System.Drawing.Size(90, 28);
			this.BtnClearClass.TabIndex = 9;
			this.BtnClearClass.Text = "🔄 Làm mới";
			this.BtnClearClass.UseVisualStyleBackColor = true;
			this.BtnClearClass.Click += new System.EventHandler(this.BtnClearClass_Click);
			// 
			// BtnDeleteClass
			// 
			this.BtnDeleteClass.Location = new System.Drawing.Point(290, 80);
			this.BtnDeleteClass.Name = "BtnDeleteClass";
			this.BtnDeleteClass.Size = new System.Drawing.Size(90, 28);
			this.BtnDeleteClass.TabIndex = 8;
			this.BtnDeleteClass.Text = "✖ Xóa";
			this.BtnDeleteClass.UseVisualStyleBackColor = true;
			this.BtnDeleteClass.Click += new System.EventHandler(this.BtnDeleteClass_Click);
			// 
			// BtnEditClass
			// 
			this.BtnEditClass.Location = new System.Drawing.Point(190, 80);
			this.BtnEditClass.Name = "BtnEditClass";
			this.BtnEditClass.Size = new System.Drawing.Size(90, 28);
			this.BtnEditClass.TabIndex = 7;
			this.BtnEditClass.Text = "✏ Cập nhật";
			this.BtnEditClass.UseVisualStyleBackColor = true;
			this.BtnEditClass.Click += new System.EventHandler(this.BtnEditClass_Click);
			// 
			// BtnAddClass
			// 
			this.BtnAddClass.Location = new System.Drawing.Point(90, 80);
			this.BtnAddClass.Name = "BtnAddClass";
			this.BtnAddClass.Size = new System.Drawing.Size(90, 28);
			this.BtnAddClass.TabIndex = 6;
			this.BtnAddClass.Text = "➕ Thêm mới";
			this.BtnAddClass.UseVisualStyleBackColor = true;
			this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
			// 
			// TbxClassDesc
			// 
			this.TbxClassDesc.Location = new System.Drawing.Point(90, 45);
			this.TbxClassDesc.Name = "TbxClassDesc";
			this.TbxClassDesc.Size = new System.Drawing.Size(635, 23);
			this.TbxClassDesc.TabIndex = 5;
			// 
			// LblClassDesc
			// 
			this.LblClassDesc.AutoSize = true;
			this.LblClassDesc.Location = new System.Drawing.Point(12, 48);
			this.LblClassDesc.Name = "LblClassDesc";
			this.LblClassDesc.Size = new System.Drawing.Size(41, 15);
			this.LblClassDesc.TabIndex = 4;
			this.LblClassDesc.Text = "Mô tả:";
			// 
			// TbxClassName
			// 
			this.TbxClassName.Location = new System.Drawing.Point(325, 12);
			this.TbxClassName.Name = "TbxClassName";
			this.TbxClassName.Size = new System.Drawing.Size(400, 23);
			this.TbxClassName.TabIndex = 3;
			// 
			// LblClassName
			// 
			this.LblClassName.AutoSize = true;
			this.LblClassName.Location = new System.Drawing.Point(250, 15);
			this.LblClassName.Name = "LblClassName";
			this.LblClassName.Size = new System.Drawing.Size(48, 15);
			this.LblClassName.TabIndex = 2;
			this.LblClassName.Text = "Tên lớp:";
			// 
			// TbxClassId
			// 
			this.TbxClassId.Location = new System.Drawing.Point(90, 12);
			this.TbxClassId.Name = "TbxClassId";
			this.TbxClassId.Size = new System.Drawing.Size(140, 23);
			this.TbxClassId.TabIndex = 1;
			// 
			// LblClassId
			// 
			this.LblClassId.AutoSize = true;
			this.LblClassId.Location = new System.Drawing.Point(12, 15);
			this.LblClassId.Name = "LblClassId";
			this.LblClassId.Size = new System.Drawing.Size(46, 15);
			this.LblClassId.TabIndex = 0;
			this.LblClassId.Text = "Mã lớp:";
			// 
			// TpgSchoolYear
			// 
			this.TpgSchoolYear.Controls.Add(this.DgvSchoolYear);
			this.TpgSchoolYear.Controls.Add(this.PnlSchoolYearInput);
			this.TpgSchoolYear.Location = new System.Drawing.Point(4, 24);
			this.TpgSchoolYear.Name = "TpgSchoolYear";
			this.TpgSchoolYear.Padding = new System.Windows.Forms.Padding(6);
			this.TpgSchoolYear.Size = new System.Drawing.Size(756, 441);
			this.TpgSchoolYear.TabIndex = 1;
			this.TpgSchoolYear.Text = "📅 Năm học";
			this.TpgSchoolYear.UseVisualStyleBackColor = true;
			// 
			// DgvSchoolYear
			// 
			this.DgvSchoolYear.AllowUserToAddRows = false;
			this.DgvSchoolYear.AllowUserToDeleteRows = false;
			this.DgvSchoolYear.AllowUserToResizeRows = false;
			this.DgvSchoolYear.BackgroundColor = System.Drawing.Color.White;
			this.DgvSchoolYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DgvSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvSchoolYear.Location = new System.Drawing.Point(6, 126);
			this.DgvSchoolYear.MultiSelect = false;
			this.DgvSchoolYear.Name = "DgvSchoolYear";
			this.DgvSchoolYear.ReadOnly = true;
			this.DgvSchoolYear.RowHeadersVisible = false;
			this.DgvSchoolYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvSchoolYear.Size = new System.Drawing.Size(744, 309);
			this.DgvSchoolYear.TabIndex = 1;
			this.DgvSchoolYear.SelectionChanged += new System.EventHandler(this.DgvSchoolYear_SelectionChanged);
			// 
			// PnlSchoolYearInput
			// 
			this.PnlSchoolYearInput.Controls.Add(this.BtnClearSchoolYear);
			this.PnlSchoolYearInput.Controls.Add(this.BtnDeleteSchoolYear);
			this.PnlSchoolYearInput.Controls.Add(this.BtnEditSchoolYear);
			this.PnlSchoolYearInput.Controls.Add(this.BtnAddSchoolYear);
			this.PnlSchoolYearInput.Controls.Add(this.NumEndYear);
			this.PnlSchoolYearInput.Controls.Add(this.LblEndYear);
			this.PnlSchoolYearInput.Controls.Add(this.NumStartYear);
			this.PnlSchoolYearInput.Controls.Add(this.LblStartYear);
			this.PnlSchoolYearInput.Controls.Add(this.TbxSchoolYearName);
			this.PnlSchoolYearInput.Controls.Add(this.LblSchoolYearName);
			this.PnlSchoolYearInput.Controls.Add(this.TbxSchoolYearId);
			this.PnlSchoolYearInput.Controls.Add(this.LblSchoolYearId);
			this.PnlSchoolYearInput.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlSchoolYearInput.Location = new System.Drawing.Point(6, 6);
			this.PnlSchoolYearInput.Name = "PnlSchoolYearInput";
			this.PnlSchoolYearInput.Size = new System.Drawing.Size(744, 120);
			this.PnlSchoolYearInput.TabIndex = 0;
			// 
			// BtnClearSchoolYear
			// 
			this.BtnClearSchoolYear.Location = new System.Drawing.Point(410, 80);
			this.BtnClearSchoolYear.Name = "BtnClearSchoolYear";
			this.BtnClearSchoolYear.Size = new System.Drawing.Size(90, 28);
			this.BtnClearSchoolYear.TabIndex = 11;
			this.BtnClearSchoolYear.Text = "🔄 Làm mới";
			this.BtnClearSchoolYear.UseVisualStyleBackColor = true;
			this.BtnClearSchoolYear.Click += new System.EventHandler(this.BtnClearSchoolYear_Click);
			// 
			// BtnDeleteSchoolYear
			// 
			this.BtnDeleteSchoolYear.Location = new System.Drawing.Point(310, 80);
			this.BtnDeleteSchoolYear.Name = "BtnDeleteSchoolYear";
			this.BtnDeleteSchoolYear.Size = new System.Drawing.Size(90, 28);
			this.BtnDeleteSchoolYear.TabIndex = 10;
			this.BtnDeleteSchoolYear.Text = "✖ Xóa";
			this.BtnDeleteSchoolYear.UseVisualStyleBackColor = true;
			this.BtnDeleteSchoolYear.Click += new System.EventHandler(this.BtnDeleteSchoolYear_Click);
			// 
			// BtnEditSchoolYear
			// 
			this.BtnEditSchoolYear.Location = new System.Drawing.Point(210, 80);
			this.BtnEditSchoolYear.Name = "BtnEditSchoolYear";
			this.BtnEditSchoolYear.Size = new System.Drawing.Size(90, 28);
			this.BtnEditSchoolYear.TabIndex = 9;
			this.BtnEditSchoolYear.Text = "✏ Cập nhật";
			this.BtnEditSchoolYear.UseVisualStyleBackColor = true;
			this.BtnEditSchoolYear.Click += new System.EventHandler(this.BtnEditSchoolYear_Click);
			// 
			// BtnAddSchoolYear
			// 
			this.BtnAddSchoolYear.Location = new System.Drawing.Point(110, 80);
			this.BtnAddSchoolYear.Name = "BtnAddSchoolYear";
			this.BtnAddSchoolYear.Size = new System.Drawing.Size(90, 28);
			this.BtnAddSchoolYear.TabIndex = 8;
			this.BtnAddSchoolYear.Text = "➕ Thêm mới";
			this.BtnAddSchoolYear.UseVisualStyleBackColor = true;
			this.BtnAddSchoolYear.Click += new System.EventHandler(this.BtnAddSchoolYear_Click);
			// 
			// NumEndYear
			// 
			this.NumEndYear.Location = new System.Drawing.Point(345, 45);
			this.NumEndYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
			this.NumEndYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
			this.NumEndYear.Name = "NumEndYear";
			this.NumEndYear.Size = new System.Drawing.Size(100, 23);
			this.NumEndYear.TabIndex = 7;
			this.NumEndYear.Value = new decimal(new int[] { 2025, 0, 0, 0 });
			// 
			// LblEndYear
			// 
			this.LblEndYear.AutoSize = true;
			this.LblEndYear.Location = new System.Drawing.Point(255, 48);
			this.LblEndYear.Name = "LblEndYear";
			this.LblEndYear.Size = new System.Drawing.Size(83, 15);
			this.LblEndYear.TabIndex = 6;
			this.LblEndYear.Text = "Năm kết thúc:";
			// 
			// NumStartYear
			// 
			this.NumStartYear.Location = new System.Drawing.Point(110, 45);
			this.NumStartYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
			this.NumStartYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
			this.NumStartYear.Name = "NumStartYear";
			this.NumStartYear.Size = new System.Drawing.Size(100, 23);
			this.NumStartYear.TabIndex = 5;
			this.NumStartYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
			this.NumStartYear.ValueChanged += new System.EventHandler(this.NumStartYear_ValueChanged);
			// 
			// LblStartYear
			// 
			this.LblStartYear.AutoSize = true;
			this.LblStartYear.Location = new System.Drawing.Point(12, 48);
			this.LblStartYear.Name = "LblStartYear";
			this.LblStartYear.Size = new System.Drawing.Size(81, 15);
			this.LblStartYear.TabIndex = 4;
			this.LblStartYear.Text = "Năm bắt đầu:";
			// 
			// TbxSchoolYearName
			// 
			this.TbxSchoolYearName.Location = new System.Drawing.Point(345, 12);
			this.TbxSchoolYearName.Name = "TbxSchoolYearName";
			this.TbxSchoolYearName.Size = new System.Drawing.Size(380, 23);
			this.TbxSchoolYearName.TabIndex = 3;
			// 
			// LblSchoolYearName
			// 
			this.LblSchoolYearName.AutoSize = true;
			this.LblSchoolYearName.Location = new System.Drawing.Point(255, 15);
			this.LblSchoolYearName.Name = "LblSchoolYearName";
			this.LblSchoolYearName.Size = new System.Drawing.Size(78, 15);
			this.LblSchoolYearName.TabIndex = 2;
			this.LblSchoolYearName.Text = "Tên năm học:";
			// 
			// TbxSchoolYearId
			// 
			this.TbxSchoolYearId.Location = new System.Drawing.Point(110, 12);
			this.TbxSchoolYearId.Name = "TbxSchoolYearId";
			this.TbxSchoolYearId.Size = new System.Drawing.Size(130, 23);
			this.TbxSchoolYearId.TabIndex = 1;
			// 
			// LblSchoolYearId
			// 
			this.LblSchoolYearId.AutoSize = true;
			this.LblSchoolYearId.Location = new System.Drawing.Point(12, 15);
			this.LblSchoolYearId.Name = "LblSchoolYearId";
			this.LblSchoolYearId.Size = new System.Drawing.Size(76, 15);
			this.LblSchoolYearId.TabIndex = 0;
			this.LblSchoolYearId.Text = "Mã năm học:";
			// 
			// TpgSubject
			// 
			this.TpgSubject.Controls.Add(this.DgvSubject);
			this.TpgSubject.Controls.Add(this.PnlSubjectInput);
			this.TpgSubject.Location = new System.Drawing.Point(4, 24);
			this.TpgSubject.Name = "TpgSubject";
			this.TpgSubject.Padding = new System.Windows.Forms.Padding(6);
			this.TpgSubject.Size = new System.Drawing.Size(756, 441);
			this.TpgSubject.TabIndex = 2;
			this.TpgSubject.Text = "📚 Môn học";
			this.TpgSubject.UseVisualStyleBackColor = true;
			// 
			// DgvSubject
			// 
			this.DgvSubject.AllowUserToAddRows = false;
			this.DgvSubject.AllowUserToDeleteRows = false;
			this.DgvSubject.AllowUserToResizeRows = false;
			this.DgvSubject.BackgroundColor = System.Drawing.Color.White;
			this.DgvSubject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DgvSubject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvSubject.Location = new System.Drawing.Point(6, 126);
			this.DgvSubject.MultiSelect = false;
			this.DgvSubject.Name = "DgvSubject";
			this.DgvSubject.ReadOnly = true;
			this.DgvSubject.RowHeadersVisible = false;
			this.DgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvSubject.Size = new System.Drawing.Size(744, 309);
			this.DgvSubject.TabIndex = 1;
			this.DgvSubject.SelectionChanged += new System.EventHandler(this.DgvSubject_SelectionChanged);
			// 
			// PnlSubjectInput
			// 
			this.PnlSubjectInput.Controls.Add(this.BtnClearSubject);
			this.PnlSubjectInput.Controls.Add(this.BtnDeleteSubject);
			this.PnlSubjectInput.Controls.Add(this.BtnEditSubject);
			this.PnlSubjectInput.Controls.Add(this.BtnAddSubject);
			this.PnlSubjectInput.Controls.Add(this.NumCredits);
			this.PnlSubjectInput.Controls.Add(this.LblCredits);
			this.PnlSubjectInput.Controls.Add(this.TbxSubjectDesc);
			this.PnlSubjectInput.Controls.Add(this.LblSubjectDesc);
			this.PnlSubjectInput.Controls.Add(this.TbxSubjectName);
			this.PnlSubjectInput.Controls.Add(this.LblSubjectName);
			this.PnlSubjectInput.Controls.Add(this.TbxSubjectId);
			this.PnlSubjectInput.Controls.Add(this.LblSubjectId);
			this.PnlSubjectInput.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlSubjectInput.Location = new System.Drawing.Point(6, 6);
			this.PnlSubjectInput.Name = "PnlSubjectInput";
			this.PnlSubjectInput.Size = new System.Drawing.Size(744, 120);
			this.PnlSubjectInput.TabIndex = 0;
			// 
			// BtnClearSubject
			// 
			this.BtnClearSubject.Location = new System.Drawing.Point(400, 80);
			this.BtnClearSubject.Name = "BtnClearSubject";
			this.BtnClearSubject.Size = new System.Drawing.Size(90, 28);
			this.BtnClearSubject.TabIndex = 11;
			this.BtnClearSubject.Text = "🔄 Làm mới";
			this.BtnClearSubject.UseVisualStyleBackColor = true;
			this.BtnClearSubject.Click += new System.EventHandler(this.BtnClearSubject_Click);
			// 
			// BtnDeleteSubject
			// 
			this.BtnDeleteSubject.Location = new System.Drawing.Point(300, 80);
			this.BtnDeleteSubject.Name = "BtnDeleteSubject";
			this.BtnDeleteSubject.Size = new System.Drawing.Size(90, 28);
			this.BtnDeleteSubject.TabIndex = 10;
			this.BtnDeleteSubject.Text = "✖ Xóa";
			this.BtnDeleteSubject.UseVisualStyleBackColor = true;
			this.BtnDeleteSubject.Click += new System.EventHandler(this.BtnDeleteSubject_Click);
			// 
			// BtnEditSubject
			// 
			this.BtnEditSubject.Location = new System.Drawing.Point(200, 80);
			this.BtnEditSubject.Name = "BtnEditSubject";
			this.BtnEditSubject.Size = new System.Drawing.Size(90, 28);
			this.BtnEditSubject.TabIndex = 9;
			this.BtnEditSubject.Text = "✏ Cập nhật";
			this.BtnEditSubject.UseVisualStyleBackColor = true;
			this.BtnEditSubject.Click += new System.EventHandler(this.BtnEditSubject_Click);
			// 
			// BtnAddSubject
			// 
			this.BtnAddSubject.Location = new System.Drawing.Point(100, 80);
			this.BtnAddSubject.Name = "BtnAddSubject";
			this.BtnAddSubject.Size = new System.Drawing.Size(90, 28);
			this.BtnAddSubject.TabIndex = 8;
			this.BtnAddSubject.Text = "➕ Thêm mới";
			this.BtnAddSubject.UseVisualStyleBackColor = true;
			this.BtnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
			// 
			// NumCredits
			// 
			this.NumCredits.Location = new System.Drawing.Point(645, 12);
			this.NumCredits.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			this.NumCredits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.NumCredits.Name = "NumCredits";
			this.NumCredits.Size = new System.Drawing.Size(80, 23);
			this.NumCredits.TabIndex = 7;
			this.NumCredits.Value = new decimal(new int[] { 3, 0, 0, 0 });
			// 
			// LblCredits
			// 
			this.LblCredits.AutoSize = true;
			this.LblCredits.Location = new System.Drawing.Point(585, 15);
			this.LblCredits.Name = "LblCredits";
			this.LblCredits.Size = new System.Drawing.Size(46, 15);
			this.LblCredits.TabIndex = 6;
			this.LblCredits.Text = "Tín chỉ:";
			// 
			// TbxSubjectDesc
			// 
			this.TbxSubjectDesc.Location = new System.Drawing.Point(100, 45);
			this.TbxSubjectDesc.Name = "TbxSubjectDesc";
			this.TbxSubjectDesc.Size = new System.Drawing.Size(625, 23);
			this.TbxSubjectDesc.TabIndex = 5;
			// 
			// LblSubjectDesc
			// 
			this.LblSubjectDesc.AutoSize = true;
			this.LblSubjectDesc.Location = new System.Drawing.Point(12, 48);
			this.LblSubjectDesc.Name = "LblSubjectDesc";
			this.LblSubjectDesc.Size = new System.Drawing.Size(41, 15);
			this.LblSubjectDesc.TabIndex = 4;
			this.LblSubjectDesc.Text = "Mô tả:";
			// 
			// TbxSubjectName
			// 
			this.TbxSubjectName.Location = new System.Drawing.Point(330, 12);
			this.TbxSubjectName.Name = "TbxSubjectName";
			this.TbxSubjectName.Size = new System.Drawing.Size(240, 23);
			this.TbxSubjectName.TabIndex = 3;
			// 
			// LblSubjectName
			// 
			this.LblSubjectName.AutoSize = true;
			this.LblSubjectName.Location = new System.Drawing.Point(245, 15);
			this.LblSubjectName.Name = "LblSubjectName";
			this.LblSubjectName.Size = new System.Drawing.Size(80, 15);
			this.LblSubjectName.TabIndex = 2;
			this.LblSubjectName.Text = "Tên môn học:";
			// 
			// TbxSubjectId
			// 
			this.TbxSubjectId.Location = new System.Drawing.Point(100, 12);
			this.TbxSubjectId.Name = "TbxSubjectId";
			this.TbxSubjectId.Size = new System.Drawing.Size(130, 23);
			this.TbxSubjectId.TabIndex = 1;
			// 
			// LblSubjectId
			// 
			this.LblSubjectId.AutoSize = true;
			this.LblSubjectId.Location = new System.Drawing.Point(12, 15);
			this.LblSubjectId.Name = "LblSubjectId";
			this.LblSubjectId.Size = new System.Drawing.Size(78, 15);
			this.LblSubjectId.TabIndex = 0;
			this.LblSubjectId.Text = "Mã môn học:";
			// 
			// PnlDialogFooter
			// 
			this.PnlDialogFooter.Controls.Add(this.BtnSelect);
			this.PnlDialogFooter.Controls.Add(this.BtnClose);
			this.PnlDialogFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlDialogFooter.Location = new System.Drawing.Point(0, 469);
			this.PnlDialogFooter.Name = "PnlDialogFooter";
			this.PnlDialogFooter.Size = new System.Drawing.Size(764, 42);
			this.PnlDialogFooter.TabIndex = 1;
			// 
			// BtnSelect
			// 
			this.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSelect.Location = new System.Drawing.Point(575, 7);
			this.BtnSelect.Name = "BtnSelect";
			this.BtnSelect.Size = new System.Drawing.Size(85, 28);
			this.BtnSelect.TabIndex = 1;
			this.BtnSelect.Text = "✔ Chọn";
			this.BtnSelect.UseVisualStyleBackColor = true;
			this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
			// 
			// BtnClose
			// 
			this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnClose.Location = new System.Drawing.Point(667, 7);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(85, 28);
			this.BtnClose.TabIndex = 0;
			this.BtnClose.Text = "Đóng";
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// DlgManageReference
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnClose;
			this.ClientSize = new System.Drawing.Size(764, 511);
			this.Controls.Add(this.TabReference);
			this.Controls.Add(this.PnlDialogFooter);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DlgManageReference";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quản lý danh mục Năm học, Lớp học, Môn học";
			this.TabReference.ResumeLayout(false);
			this.TpgClass.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DgvClass)).EndInit();
			this.PnlClassInput.ResumeLayout(false);
			this.PnlClassInput.PerformLayout();
			this.TpgSchoolYear.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DgvSchoolYear)).EndInit();
			this.PnlSchoolYearInput.ResumeLayout(false);
			this.PnlSchoolYearInput.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumEndYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumStartYear)).EndInit();
			this.TpgSubject.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DgvSubject)).EndInit();
			this.PnlSubjectInput.ResumeLayout(false);
			this.PnlSubjectInput.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumCredits)).EndInit();
			this.PnlDialogFooter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabReference;
		private System.Windows.Forms.TabPage TpgClass;
		private System.Windows.Forms.TabPage TpgSchoolYear;
		private System.Windows.Forms.TabPage TpgSubject;
		private System.Windows.Forms.Panel PnlClassInput;
		private System.Windows.Forms.Label LblClassId;
		private System.Windows.Forms.TextBox TbxClassId;
		private System.Windows.Forms.Label LblClassName;
		private System.Windows.Forms.TextBox TbxClassName;
		private System.Windows.Forms.Label LblClassDesc;
		private System.Windows.Forms.TextBox TbxClassDesc;
		private System.Windows.Forms.Button BtnAddClass;
		private System.Windows.Forms.Button BtnEditClass;
		private System.Windows.Forms.Button BtnDeleteClass;
		private System.Windows.Forms.Button BtnClearClass;
		private System.Windows.Forms.DataGridView DgvClass;
		private System.Windows.Forms.Panel PnlSchoolYearInput;
		private System.Windows.Forms.Label LblSchoolYearId;
		private System.Windows.Forms.TextBox TbxSchoolYearId;
		private System.Windows.Forms.Label LblSchoolYearName;
		private System.Windows.Forms.TextBox TbxSchoolYearName;
		private System.Windows.Forms.Label LblStartYear;
		private System.Windows.Forms.NumericUpDown NumStartYear;
		private System.Windows.Forms.Label LblEndYear;
		private System.Windows.Forms.NumericUpDown NumEndYear;
		private System.Windows.Forms.Button BtnAddSchoolYear;
		private System.Windows.Forms.Button BtnEditSchoolYear;
		private System.Windows.Forms.Button BtnDeleteSchoolYear;
		private System.Windows.Forms.Button BtnClearSchoolYear;
		private System.Windows.Forms.DataGridView DgvSchoolYear;
		private System.Windows.Forms.Panel PnlSubjectInput;
		private System.Windows.Forms.Label LblSubjectId;
		private System.Windows.Forms.TextBox TbxSubjectId;
		private System.Windows.Forms.Label LblSubjectName;
		private System.Windows.Forms.TextBox TbxSubjectName;
		private System.Windows.Forms.Label LblCredits;
		private System.Windows.Forms.NumericUpDown NumCredits;
		private System.Windows.Forms.Label LblSubjectDesc;
		private System.Windows.Forms.TextBox TbxSubjectDesc;
		private System.Windows.Forms.Button BtnAddSubject;
		private System.Windows.Forms.Button BtnEditSubject;
		private System.Windows.Forms.Button BtnDeleteSubject;
		private System.Windows.Forms.Button BtnClearSubject;
		private System.Windows.Forms.DataGridView DgvSubject;
		private System.Windows.Forms.Panel PnlDialogFooter;
		private System.Windows.Forms.Button BtnSelect;
		private System.Windows.Forms.Button BtnClose;
	}
}

