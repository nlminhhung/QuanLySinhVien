namespace QuanLySinhVien
{
    partial class FormScore
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScore));
            this.tb_points = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bandDiem = new System.Windows.Forms.DataGridView();
            this.gradeCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.firstDBDataSet = new QuanLySinhVien.firstDBDataSet();
            this.firstDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstDBDataSet1 = new QuanLySinhVien.firstDBDataSet1();
            this.firstDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new QuanLySinhVien.firstDBDataSet1TableAdapters.CourseTableAdapter();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTableAdapter = new QuanLySinhVien.firstDBDataSet1TableAdapters.GradeTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_chosenStudent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new QuanLySinhVien.firstDBDataSetTableAdapters.StudentTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cb_chosenCourse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.firstDBDataSet2 = new QuanLySinhVien.firstDBDataSet2();
            this.courseBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter1 = new QuanLySinhVien.firstDBDataSet2TableAdapters.CourseTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEACHERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELOADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.c = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtnGuna2 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Updatebtnguna2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.bandDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_points
            // 
            this.tb_points.Location = new System.Drawing.Point(140, 23);
            this.tb_points.Margin = new System.Windows.Forms.Padding(4);
            this.tb_points.Name = "tb_points";
            this.tb_points.Size = new System.Drawing.Size(265, 22);
            this.tb_points.TabIndex = 17;
            this.tb_points.TextChanged += new System.EventHandler(this.tb_points_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Points";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(256, 489);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1199, 272);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scores Board";
            // 
            // bandDiem
            // 
            this.bandDiem.AllowUserToAddRows = false;
            this.bandDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradeCol});
            this.bandDiem.Location = new System.Drawing.Point(264, 523);
            this.bandDiem.Margin = new System.Windows.Forms.Padding(4);
            this.bandDiem.Name = "bandDiem";
            this.bandDiem.RowHeadersWidth = 51;
            this.bandDiem.Size = new System.Drawing.Size(1183, 212);
            this.bandDiem.TabIndex = 0;
            this.bandDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bandDiem_CellContentClick);
            // 
            // gradeCol
            // 
            this.gradeCol.FalseValue = "false";
            this.gradeCol.HeaderText = "Choose";
            this.gradeCol.MinimumWidth = 6;
            this.gradeCol.Name = "gradeCol";
            this.gradeCol.TrueValue = "true";
            this.gradeCol.Width = 125;
            // 
            // firstDBDataSet
            // 
            this.firstDBDataSet.DataSetName = "firstDBDataSet";
            this.firstDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstDBDataSetBindingSource
            // 
            this.firstDBDataSetBindingSource.DataSource = this.firstDBDataSet;
            this.firstDBDataSetBindingSource.Position = 0;
            // 
            // firstDBDataSet1
            // 
            this.firstDBDataSet1.DataSetName = "firstDBDataSet1";
            this.firstDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstDBDataSet1BindingSource
            // 
            this.firstDBDataSet1BindingSource.DataSource = this.firstDBDataSet1;
            this.firstDBDataSet1BindingSource.Position = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.firstDBDataSet1BindingSource;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataMember = "Grade";
            this.gradeBindingSource.DataSource = this.firstDBDataSet1BindingSource;
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 54);
            this.label2.TabIndex = 23;
            this.label2.Text = "Scores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_chosenStudent,
            this.studentIDCol,
            this.nameCol,
            this.addressCol,
            this.dateCol});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(757, 185);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_chosenStudent
            // 
            this.cb_chosenStudent.FalseValue = "false";
            this.cb_chosenStudent.HeaderText = "Choose";
            this.cb_chosenStudent.MinimumWidth = 6;
            this.cb_chosenStudent.Name = "cb_chosenStudent";
            this.cb_chosenStudent.TrueValue = "true";
            this.cb_chosenStudent.Width = 125;
            // 
            // studentIDCol
            // 
            this.studentIDCol.DataPropertyName = "StudentID";
            this.studentIDCol.HeaderText = "Student ID";
            this.studentIDCol.MinimumWidth = 6;
            this.studentIDCol.Name = "studentIDCol";
            this.studentIDCol.Width = 125;
            // 
            // nameCol
            // 
            this.nameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameCol.DataPropertyName = "Name";
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.Width = 73;
            // 
            // addressCol
            // 
            this.addressCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressCol.DataPropertyName = "Address";
            this.addressCol.HeaderText = "Address";
            this.addressCol.MinimumWidth = 6;
            this.addressCol.Name = "addressCol";
            this.addressCol.Width = 87;
            // 
            // dateCol
            // 
            this.dateCol.DataPropertyName = "DateOfBirth";
            this.dateCol.HeaderText = "Date Of Birth";
            this.dateCol.MinimumWidth = 6;
            this.dateCol.Name = "dateCol";
            this.dateCol.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.firstDBDataSetBindingSource;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_chosenCourse});
            this.dataGridView2.Location = new System.Drawing.Point(8, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(785, 193);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cb_chosenCourse
            // 
            this.cb_chosenCourse.FalseValue = "false";
            this.cb_chosenCourse.HeaderText = "Choose";
            this.cb_chosenCourse.MinimumWidth = 6;
            this.cb_chosenCourse.Name = "cb_chosenCourse";
            this.cb_chosenCourse.TrueValue = "true";
            this.cb_chosenCourse.Width = 125;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.firstDBDataSet1BindingSource;
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.firstDBDataSet1BindingSource;
            // 
            // courseBindingSource3
            // 
            this.courseBindingSource3.DataMember = "Course";
            this.courseBindingSource3.DataSource = this.firstDBDataSet1BindingSource;
            // 
            // courseBindingSource4
            // 
            this.courseBindingSource4.DataMember = "Course";
            this.courseBindingSource4.DataSource = this.firstDBDataSet1BindingSource;
            // 
            // firstDBDataSet2
            // 
            this.firstDBDataSet2.DataSetName = "firstDBDataSet2";
            this.firstDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource5
            // 
            this.courseBindingSource5.DataMember = "Course";
            this.courseBindingSource5.DataSource = this.firstDBDataSet2;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(16, 246);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(784, 235);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Student";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(839, 246);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(801, 235);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose Course";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.rELOADToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1660, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.cOURSEToolStripMenuItem,
            this.tEACHERToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.selectToolStripMenuItem.Text = "FILE";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            this.sTUDENTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTToolStripMenuItem_Click);
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            this.cOURSEToolStripMenuItem.Click += new System.EventHandler(this.cOURSEToolStripMenuItem_Click);
            // 
            // tEACHERToolStripMenuItem
            // 
            this.tEACHERToolStripMenuItem.Name = "tEACHERToolStripMenuItem";
            this.tEACHERToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.tEACHERToolStripMenuItem.Text = "TEACHER";
            this.tEACHERToolStripMenuItem.Click += new System.EventHandler(this.tEACHERToolStripMenuItem_Click);
            // 
            // rELOADToolStripMenuItem
            // 
            this.rELOADToolStripMenuItem.Name = "rELOADToolStripMenuItem";
            this.rELOADToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.rELOADToolStripMenuItem.Text = "RELOAD";
            this.rELOADToolStripMenuItem.Click += new System.EventHandler(this.rELOADToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Snow;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 33);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(462, 205);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // c
            // 
            this.c.CheckedState.Parent = this.c;
            this.c.CustomImages.Parent = this.c;
            this.c.FillColor = System.Drawing.Color.Azure;
            this.c.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c.ForeColor = System.Drawing.Color.Black;
            this.c.HoverState.Parent = this.c;
            this.c.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c.Location = new System.Drawing.Point(30, 53);
            this.c.Margin = new System.Windows.Forms.Padding(4);
            this.c.Name = "c";
            this.c.ShadowDecoration.Parent = this.c;
            this.c.Size = new System.Drawing.Size(100, 47);
            this.c.TabIndex = 32;
            this.c.Text = "ADD";
            this.c.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DeleteBtnGuna2
            // 
            this.DeleteBtnGuna2.CheckedState.Parent = this.DeleteBtnGuna2;
            this.DeleteBtnGuna2.CustomImages.Parent = this.DeleteBtnGuna2;
            this.DeleteBtnGuna2.FillColor = System.Drawing.Color.Azure;
            this.DeleteBtnGuna2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtnGuna2.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtnGuna2.HoverState.Parent = this.DeleteBtnGuna2;
            this.DeleteBtnGuna2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DeleteBtnGuna2.Location = new System.Drawing.Point(167, 53);
            this.DeleteBtnGuna2.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtnGuna2.Name = "DeleteBtnGuna2";
            this.DeleteBtnGuna2.ShadowDecoration.Parent = this.DeleteBtnGuna2;
            this.DeleteBtnGuna2.Size = new System.Drawing.Size(100, 47);
            this.DeleteBtnGuna2.TabIndex = 33;
            this.DeleteBtnGuna2.Text = "DELETE";
            this.DeleteBtnGuna2.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Updatebtnguna2);
            this.groupBox4.Controls.Add(this.DeleteBtnGuna2);
            this.groupBox4.Controls.Add(this.c);
            this.groupBox4.Controls.Add(this.tb_points);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(640, 130);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(415, 108);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enter Points";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Updatebtnguna2
            // 
            this.Updatebtnguna2.CheckedState.Parent = this.Updatebtnguna2;
            this.Updatebtnguna2.CustomImages.Parent = this.Updatebtnguna2;
            this.Updatebtnguna2.FillColor = System.Drawing.Color.Azure;
            this.Updatebtnguna2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Updatebtnguna2.ForeColor = System.Drawing.Color.Black;
            this.Updatebtnguna2.HoverState.Parent = this.Updatebtnguna2;
            this.Updatebtnguna2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Updatebtnguna2.Location = new System.Drawing.Point(305, 53);
            this.Updatebtnguna2.Margin = new System.Windows.Forms.Padding(4);
            this.Updatebtnguna2.Name = "Updatebtnguna2";
            this.Updatebtnguna2.ShadowDecoration.Parent = this.Updatebtnguna2;
            this.Updatebtnguna2.Size = new System.Drawing.Size(100, 47);
            this.Updatebtnguna2.TabIndex = 34;
            this.Updatebtnguna2.Text = "UPDATE";
            this.Updatebtnguna2.Click += new System.EventHandler(this.Updatebtnguna2_Click);
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1660, 774);
            this.Controls.Add(this.bandDiem);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormScore";
            this.Text = "SCORES";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bandDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_points;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource firstDBDataSetBindingSource;
        private firstDBDataSet firstDBDataSet;
        private System.Windows.Forms.DataGridView bandDiem;
        private System.Windows.Forms.BindingSource firstDBDataSet1BindingSource;
        private firstDBDataSet1 firstDBDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private firstDBDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private firstDBDataSet1TableAdapters.GradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private firstDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.BindingSource courseBindingSource3;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private System.Windows.Forms.BindingSource courseBindingSource4;
        private firstDBDataSet2 firstDBDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource5;
        private firstDBDataSet2TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb_chosenStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb_chosenCourse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gradeCol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELOADToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEACHERToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button c;
        private Guna.UI2.WinForms.Guna2Button DeleteBtnGuna2;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button Updatebtnguna2;
    }
}