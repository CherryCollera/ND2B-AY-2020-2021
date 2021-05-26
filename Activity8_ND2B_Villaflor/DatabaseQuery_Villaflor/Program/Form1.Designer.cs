
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradePointAverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartmanCollegeDataSet = new Program.CartmanCollegeDataSet();
            this.tblStudentsTableAdapter = new Program.CartmanCollegeDataSetTableAdapters.tblStudentsTableAdapter();
            this.btn_HighGPA = new System.Windows.Forms.Button();
            this.listBox_WithHighGPA = new System.Windows.Forms.ListBox();
            this.btn_ShowRecords = new System.Windows.Forms.Button();
            this.textBox_MinGPA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_WithMinGPA = new System.Windows.Forms.ListBox();
            this.btn_ViewGradeStatistics = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.btn_GroupByGPA = new System.Windows.Forms.Button();
            this.listBox_GroupByGPA = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartmanCollegeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.gradePointAverageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
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
            // gradePointAverageDataGridViewTextBoxColumn
            // 
            this.gradePointAverageDataGridViewTextBoxColumn.DataPropertyName = "GradePointAverage";
            this.gradePointAverageDataGridViewTextBoxColumn.HeaderText = "GradePointAverage";
            this.gradePointAverageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradePointAverageDataGridViewTextBoxColumn.Name = "gradePointAverageDataGridViewTextBoxColumn";
            this.gradePointAverageDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "tblStudents";
            this.tblStudentsBindingSource.DataSource = this.cartmanCollegeDataSet;
            // 
            // cartmanCollegeDataSet
            // 
            this.cartmanCollegeDataSet.DataSetName = "CartmanCollegeDataSet";
            this.cartmanCollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentsTableAdapter
            // 
            this.tblStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_HighGPA
            // 
            this.btn_HighGPA.Location = new System.Drawing.Point(34, 343);
            this.btn_HighGPA.Name = "btn_HighGPA";
            this.btn_HighGPA.Size = new System.Drawing.Size(267, 40);
            this.btn_HighGPA.TabIndex = 1;
            this.btn_HighGPA.Text = "Show Student with High GPA";
            this.btn_HighGPA.UseVisualStyleBackColor = true;
            this.btn_HighGPA.Click += new System.EventHandler(this.btn_HighGPA_Click);
            // 
            // listBox_WithHighGPA
            // 
            this.listBox_WithHighGPA.FormattingEnabled = true;
            this.listBox_WithHighGPA.ItemHeight = 16;
            this.listBox_WithHighGPA.Location = new System.Drawing.Point(34, 396);
            this.listBox_WithHighGPA.Name = "listBox_WithHighGPA";
            this.listBox_WithHighGPA.Size = new System.Drawing.Size(267, 196);
            this.listBox_WithHighGPA.TabIndex = 2;
            // 
            // btn_ShowRecords
            // 
            this.btn_ShowRecords.Location = new System.Drawing.Point(671, 342);
            this.btn_ShowRecords.Name = "btn_ShowRecords";
            this.btn_ShowRecords.Size = new System.Drawing.Size(122, 31);
            this.btn_ShowRecords.TabIndex = 3;
            this.btn_ShowRecords.Text = "Show Records";
            this.btn_ShowRecords.UseVisualStyleBackColor = true;
            this.btn_ShowRecords.Click += new System.EventHandler(this.btn_ShowRecords_Click);
            // 
            // textBox_MinGPA
            // 
            this.textBox_MinGPA.Location = new System.Drawing.Point(486, 346);
            this.textBox_MinGPA.Name = "textBox_MinGPA";
            this.textBox_MinGPA.Size = new System.Drawing.Size(161, 22);
            this.textBox_MinGPA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Minimum GPA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox_WithMinGPA
            // 
            this.listBox_WithMinGPA.FormattingEnabled = true;
            this.listBox_WithMinGPA.ItemHeight = 16;
            this.listBox_WithMinGPA.Location = new System.Drawing.Point(349, 412);
            this.listBox_WithMinGPA.Name = "listBox_WithMinGPA";
            this.listBox_WithMinGPA.Size = new System.Drawing.Size(444, 180);
            this.listBox_WithMinGPA.TabIndex = 6;
            // 
            // btn_ViewGradeStatistics
            // 
            this.btn_ViewGradeStatistics.Location = new System.Drawing.Point(621, 30);
            this.btn_ViewGradeStatistics.Name = "btn_ViewGradeStatistics";
            this.btn_ViewGradeStatistics.Size = new System.Drawing.Size(324, 31);
            this.btn_ViewGradeStatistics.TabIndex = 7;
            this.btn_ViewGradeStatistics.Text = "View Grade Statistics";
            this.btn_ViewGradeStatistics.UseVisualStyleBackColor = true;
            this.btn_ViewGradeStatistics.Click += new System.EventHandler(this.btn_ViewGradeStatistics_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(635, 81);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(46, 17);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "label2";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(635, 127);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(46, 17);
            this.labelMin.TabIndex = 9;
            this.labelMin.Text = "label3";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(635, 170);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(46, 17);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "label4";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(635, 215);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(46, 17);
            this.labelAverage.TabIndex = 11;
            this.labelAverage.Text = "label5";
            // 
            // btn_GroupByGPA
            // 
            this.btn_GroupByGPA.Location = new System.Drawing.Point(950, 30);
            this.btn_GroupByGPA.Name = "btn_GroupByGPA";
            this.btn_GroupByGPA.Size = new System.Drawing.Size(324, 31);
            this.btn_GroupByGPA.TabIndex = 12;
            this.btn_GroupByGPA.Text = "Group Records of GPA";
            this.btn_GroupByGPA.UseVisualStyleBackColor = true;
            this.btn_GroupByGPA.Click += new System.EventHandler(this.btn_GroupByGPA_Click);
            // 
            // listBox_GroupByGPA
            // 
            this.listBox_GroupByGPA.FormattingEnabled = true;
            this.listBox_GroupByGPA.ItemHeight = 16;
            this.listBox_GroupByGPA.Location = new System.Drawing.Point(950, 67);
            this.listBox_GroupByGPA.Name = "listBox_GroupByGPA";
            this.listBox_GroupByGPA.Size = new System.Drawing.Size(324, 356);
            this.listBox_GroupByGPA.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 656);
            this.Controls.Add(this.listBox_GroupByGPA);
            this.Controls.Add(this.btn_GroupByGPA);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btn_ViewGradeStatistics);
            this.Controls.Add(this.listBox_WithMinGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MinGPA);
            this.Controls.Add(this.btn_ShowRecords);
            this.Controls.Add(this.listBox_WithHighGPA);
            this.Controls.Add(this.btn_HighGPA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartmanCollegeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CartmanCollegeDataSet cartmanCollegeDataSet;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private CartmanCollegeDataSetTableAdapters.tblStudentsTableAdapter tblStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradePointAverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_HighGPA;
        private System.Windows.Forms.ListBox listBox_WithHighGPA;
        private System.Windows.Forms.Button btn_ShowRecords;
        private System.Windows.Forms.TextBox textBox_MinGPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_WithMinGPA;
        private System.Windows.Forms.Button btn_ViewGradeStatistics;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Button btn_GroupByGPA;
        private System.Windows.Forms.ListBox listBox_GroupByGPA;
    }
}