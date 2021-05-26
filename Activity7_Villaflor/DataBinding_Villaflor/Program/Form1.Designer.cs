
namespace Program
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bSCSToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCSToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.samalToolStrip = new System.Windows.Forms.ToolStrip();
            this.samalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bSITToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSITToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._2nd_YrToolStrip = new System.Windows.Forms.ToolStrip();
            this._2nd_YrToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._2BToolStrip = new System.Windows.Forms.ToolStrip();
            this._2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lname_that_Starts_with_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lname_that_Starts_with_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fname_that_Starts_with_Consonant_LettersToolStrip = new System.Windows.Forms.ToolStrip();
            this.fname_that_Starts_with_Consonant_LettersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._3rd_YrToolStrip = new System.Windows.Forms.ToolStrip();
            this._3rd_YrToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._4th_YrToolStrip = new System.Windows.Forms.ToolStrip();
            this._4th_YrToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new studentsDataSet();
            this.tblStudent_InfoTableAdapter = new studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bSCSToolStrip.SuspendLayout();
            this.refreshToolStrip.SuspendLayout();
            this.samalToolStrip.SuspendLayout();
            this.bSITToolStrip.SuspendLayout();
            this._2nd_YrToolStrip.SuspendLayout();
            this._2BToolStrip.SuspendLayout();
            this.lname_that_Starts_with_A_and_CToolStrip.SuspendLayout();
            this.fname_that_Starts_with_Consonant_LettersToolStrip.SuspendLayout();
            this._3rd_YrToolStrip.SuspendLayout();
            this._4th_YrToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Records Monitoring System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 308);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bSCSToolStrip
            // 
            this.bSCSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCSToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bSCSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCSToolStripButton});
            this.bSCSToolStrip.Location = new System.Drawing.Point(733, 126);
            this.bSCSToolStrip.Name = "bSCSToolStrip";
            this.bSCSToolStrip.Size = new System.Drawing.Size(60, 27);
            this.bSCSToolStrip.TabIndex = 0;
            this.bSCSToolStrip.Text = "bSCSToolStrip";
            // 
            // bSCSToolStripButton
            // 
            this.bSCSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCSToolStripButton.Name = "bSCSToolStripButton";
            this.bSCSToolStripButton.Size = new System.Drawing.Size(47, 24);
            this.bSCSToolStripButton.Text = "BSCS";
            this.bSCSToolStripButton.Click += new System.EventHandler(this.bSCSToolStripButton_Click);
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(31, 419);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(75, 27);
            this.refreshToolStrip.TabIndex = 2;
            this.refreshToolStrip.Text = "refreshToolStrip";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(62, 24);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // samalToolStrip
            // 
            this.samalToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.samalToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.samalToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samalToolStripButton});
            this.samalToolStrip.Location = new System.Drawing.Point(146, 419);
            this.samalToolStrip.Name = "samalToolStrip";
            this.samalToolStrip.Size = new System.Drawing.Size(67, 27);
            this.samalToolStrip.TabIndex = 3;
            this.samalToolStrip.Text = "samalToolStrip";
            // 
            // samalToolStripButton
            // 
            this.samalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.samalToolStripButton.Name = "samalToolStripButton";
            this.samalToolStripButton.Size = new System.Drawing.Size(54, 24);
            this.samalToolStripButton.Text = "Samal";
            this.samalToolStripButton.Click += new System.EventHandler(this.samalToolStripButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Program     Year     Section";
            // 
            // bSITToolStrip
            // 
            this.bSITToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSITToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bSITToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSITToolStripButton});
            this.bSITToolStrip.Location = new System.Drawing.Point(733, 165);
            this.bSITToolStrip.Name = "bSITToolStrip";
            this.bSITToolStrip.Size = new System.Drawing.Size(60, 30);
            this.bSITToolStrip.TabIndex = 5;
            this.bSITToolStrip.Text = "bSITToolStrip";
            // 
            // bSITToolStripButton
            // 
            this.bSITToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSITToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSITToolStripButton.Name = "bSITToolStripButton";
            this.bSITToolStripButton.Size = new System.Drawing.Size(47, 27);
            this.bSITToolStripButton.Text = "BSIT";
            this.bSITToolStripButton.Click += new System.EventHandler(this.bSITToolStripButton_Click);
            // 
            // _2nd_YrToolStrip
            // 
            this._2nd_YrToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2nd_YrToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._2nd_YrToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2nd_YrToolStripButton});
            this._2nd_YrToolStrip.Location = new System.Drawing.Point(829, 126);
            this._2nd_YrToolStrip.Name = "_2nd_YrToolStrip";
            this._2nd_YrToolStrip.Size = new System.Drawing.Size(69, 27);
            this._2nd_YrToolStrip.TabIndex = 6;
            this._2nd_YrToolStrip.Text = "_2nd_YrToolStrip";
            // 
            // _2nd_YrToolStripButton
            // 
            this._2nd_YrToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2nd_YrToolStripButton.Name = "_2nd_YrToolStripButton";
            this._2nd_YrToolStripButton.Size = new System.Drawing.Size(56, 24);
            this._2nd_YrToolStripButton.Text = "2nd_Yr";
            this._2nd_YrToolStripButton.Click += new System.EventHandler(this._2nd_YrToolStripButton_Click);
            // 
            // _2BToolStrip
            // 
            this._2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2BToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2BToolStripButton});
            this._2BToolStrip.Location = new System.Drawing.Point(924, 126);
            this._2BToolStrip.Name = "_2BToolStrip";
            this._2BToolStrip.Size = new System.Drawing.Size(43, 27);
            this._2BToolStrip.TabIndex = 7;
            this._2BToolStrip.Text = "_2BToolStrip";
            // 
            // _2BToolStripButton
            // 
            this._2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2BToolStripButton.Name = "_2BToolStripButton";
            this._2BToolStripButton.Size = new System.Drawing.Size(30, 24);
            this._2BToolStripButton.Text = "2B";
            this._2BToolStripButton.ToolTipText = "2B";
            this._2BToolStripButton.Click += new System.EventHandler(this._2BToolStripButton_Click);
            // 
            // lname_that_Starts_with_A_and_CToolStrip
            // 
            this.lname_that_Starts_with_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lname_that_Starts_with_A_and_CToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lname_that_Starts_with_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lname_that_Starts_with_A_and_CToolStripButton});
            this.lname_that_Starts_with_A_and_CToolStrip.Location = new System.Drawing.Point(259, 419);
            this.lname_that_Starts_with_A_and_CToolStrip.Name = "lname_that_Starts_with_A_and_CToolStrip";
            this.lname_that_Starts_with_A_and_CToolStrip.Size = new System.Drawing.Size(241, 27);
            this.lname_that_Starts_with_A_and_CToolStrip.TabIndex = 8;
            this.lname_that_Starts_with_A_and_CToolStrip.Text = "lname_that_Starts_with_A_and_CToolStrip";
            // 
            // lname_that_Starts_with_A_and_CToolStripButton
            // 
            this.lname_that_Starts_with_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lname_that_Starts_with_A_and_CToolStripButton.Name = "lname_that_Starts_with_A_and_CToolStripButton";
            this.lname_that_Starts_with_A_and_CToolStripButton.Size = new System.Drawing.Size(228, 24);
            this.lname_that_Starts_with_A_and_CToolStripButton.Text = "Lname_that_Starts_with_A_and_C";
            this.lname_that_Starts_with_A_and_CToolStripButton.Click += new System.EventHandler(this.lname_that_Starts_with_A_and_CToolStripButton_Click);
            // 
            // fname_that_Starts_with_Consonant_LettersToolStrip
            // 
            this.fname_that_Starts_with_Consonant_LettersToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fname_that_Starts_with_Consonant_LettersToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fname_that_Starts_with_Consonant_LettersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fname_that_Starts_with_Consonant_LettersToolStripButton});
            this.fname_that_Starts_with_Consonant_LettersToolStrip.Location = new System.Drawing.Point(554, 419);
            this.fname_that_Starts_with_Consonant_LettersToolStrip.Name = "fname_that_Starts_with_Consonant_LettersToolStrip";
            this.fname_that_Starts_with_Consonant_LettersToolStrip.Size = new System.Drawing.Size(305, 27);
            this.fname_that_Starts_with_Consonant_LettersToolStrip.TabIndex = 9;
            this.fname_that_Starts_with_Consonant_LettersToolStrip.Text = "fname_that_Starts_with_Consonant_LettersToolStrip";
            // 
            // fname_that_Starts_with_Consonant_LettersToolStripButton
            // 
            this.fname_that_Starts_with_Consonant_LettersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fname_that_Starts_with_Consonant_LettersToolStripButton.Name = "fname_that_Starts_with_Consonant_LettersToolStripButton";
            this.fname_that_Starts_with_Consonant_LettersToolStripButton.Size = new System.Drawing.Size(292, 24);
            this.fname_that_Starts_with_Consonant_LettersToolStripButton.Text = "Fname_that_Starts_with_Consonant_Letters";
            this.fname_that_Starts_with_Consonant_LettersToolStripButton.Click += new System.EventHandler(this.fname_that_Starts_with_Consonant_LettersToolStripButton_Click);
            // 
            // _3rd_YrToolStrip
            // 
            this._3rd_YrToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._3rd_YrToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._3rd_YrToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._3rd_YrToolStripButton});
            this._3rd_YrToolStrip.Location = new System.Drawing.Point(829, 165);
            this._3rd_YrToolStrip.Name = "_3rd_YrToolStrip";
            this._3rd_YrToolStrip.Size = new System.Drawing.Size(66, 27);
            this._3rd_YrToolStrip.TabIndex = 10;
            this._3rd_YrToolStrip.Text = "_3rd_YrToolStrip";
            // 
            // _3rd_YrToolStripButton
            // 
            this._3rd_YrToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._3rd_YrToolStripButton.Name = "_3rd_YrToolStripButton";
            this._3rd_YrToolStripButton.Size = new System.Drawing.Size(53, 24);
            this._3rd_YrToolStripButton.Text = "3rd_Yr";
            this._3rd_YrToolStripButton.Click += new System.EventHandler(this._3rd_YrToolStripButton_Click);
            // 
            // _4th_YrToolStrip
            // 
            this._4th_YrToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._4th_YrToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._4th_YrToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._4th_YrToolStripButton});
            this._4th_YrToolStrip.Location = new System.Drawing.Point(829, 203);
            this._4th_YrToolStrip.Name = "_4th_YrToolStrip";
            this._4th_YrToolStrip.Size = new System.Drawing.Size(65, 27);
            this._4th_YrToolStrip.TabIndex = 11;
            this._4th_YrToolStrip.Text = "_4th_YrToolStrip";
            // 
            // _4th_YrToolStripButton
            // 
            this._4th_YrToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._4th_YrToolStripButton.Name = "_4th_YrToolStripButton";
            this._4th_YrToolStripButton.Size = new System.Drawing.Size(52, 24);
            this._4th_YrToolStripButton.Text = "4th_Yr";
            this._4th_YrToolStripButton.ToolTipText = "4th_Yr";
            this._4th_YrToolStripButton.Click += new System.EventHandler(this._4th_YrToolStripButton_Click);
            // 
            // studIDDataGridViewTextBoxColumn
            // 
            this.studIDDataGridViewTextBoxColumn.DataPropertyName = "StudID";
            this.studIDDataGridViewTextBoxColumn.HeaderText = "StudID";
            this.studIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studIDDataGridViewTextBoxColumn.Name = "studIDDataGridViewTextBoxColumn";
            this.studIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            this.programDataGridViewTextBoxColumn.Width = 125;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearLevelDataGridViewTextBoxColumn
            // 
            this.yearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearLevelDataGridViewTextBoxColumn.Name = "yearLevelDataGridViewTextBoxColumn";
            this.yearLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tblStudent_Info";
            this.tblStudentInfoBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudent_InfoTableAdapter
            // 
            this.tblStudent_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 494);
            this.Controls.Add(this._4th_YrToolStrip);
            this.Controls.Add(this._3rd_YrToolStrip);
            this.Controls.Add(this.fname_that_Starts_with_Consonant_LettersToolStrip);
            this.Controls.Add(this.lname_that_Starts_with_A_and_CToolStrip);
            this.Controls.Add(this._2BToolStrip);
            this.Controls.Add(this._2nd_YrToolStrip);
            this.Controls.Add(this.bSITToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.samalToolStrip);
            this.Controls.Add(this.refreshToolStrip);
            this.Controls.Add(this.bSCSToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Data Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bSCSToolStrip.ResumeLayout(false);
            this.bSCSToolStrip.PerformLayout();
            this.refreshToolStrip.ResumeLayout(false);
            this.refreshToolStrip.PerformLayout();
            this.samalToolStrip.ResumeLayout(false);
            this.samalToolStrip.PerformLayout();
            this.bSITToolStrip.ResumeLayout(false);
            this.bSITToolStrip.PerformLayout();
            this._2nd_YrToolStrip.ResumeLayout(false);
            this._2nd_YrToolStrip.PerformLayout();
            this._2BToolStrip.ResumeLayout(false);
            this._2BToolStrip.PerformLayout();
            this.lname_that_Starts_with_A_and_CToolStrip.ResumeLayout(false);
            this.lname_that_Starts_with_A_and_CToolStrip.PerformLayout();
            this.fname_that_Starts_with_Consonant_LettersToolStrip.ResumeLayout(false);
            this.fname_that_Starts_with_Consonant_LettersToolStrip.PerformLayout();
            this._3rd_YrToolStrip.ResumeLayout(false);
            this._3rd_YrToolStrip.PerformLayout();
            this._4th_YrToolStrip.ResumeLayout(false);
            this._4th_YrToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private studentsDataSetTableAdapters.tblStudent_InfoTableAdapter tblStudent_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip bSCSToolStrip;
        private System.Windows.Forms.ToolStripButton bSCSToolStripButton;
        private System.Windows.Forms.ToolStrip refreshToolStrip;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStrip samalToolStrip;
        private System.Windows.Forms.ToolStripButton samalToolStripButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip bSITToolStrip;
        private System.Windows.Forms.ToolStripButton bSITToolStripButton;
        private System.Windows.Forms.ToolStrip _2nd_YrToolStrip;
        private System.Windows.Forms.ToolStripButton _2nd_YrToolStripButton;
        private System.Windows.Forms.ToolStrip _2BToolStrip;
        private System.Windows.Forms.ToolStripButton _2BToolStripButton;
        private System.Windows.Forms.ToolStrip lname_that_Starts_with_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton lname_that_Starts_with_A_and_CToolStripButton;
        private System.Windows.Forms.ToolStrip fname_that_Starts_with_Consonant_LettersToolStrip;
        private System.Windows.Forms.ToolStripButton fname_that_Starts_with_Consonant_LettersToolStripButton;
        private System.Windows.Forms.ToolStrip _3rd_YrToolStrip;
        private System.Windows.Forms.ToolStripButton _3rd_YrToolStripButton;
        private System.Windows.Forms.ToolStrip _4th_YrToolStrip;
        private System.Windows.Forms.ToolStripButton _4th_YrToolStripButton;
    }
}