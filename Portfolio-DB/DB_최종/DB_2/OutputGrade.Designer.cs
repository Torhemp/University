namespace DB_2
{
    partial class OutputGrade
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
            this.dataGridViewEnroll = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRO1ENROLLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DB_2.DataSet1();
            this.pRO1_ENROLLSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_ENROLLSTableAdapter();
            this.labelStdNum = new System.Windows.Forms.Label();
            this.labelOutputStdNum = new System.Windows.Forms.Label();
            this.labelStdName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStdYear = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelStdDept = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelStdScore = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pRO1_STUDENTSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_STUDENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnroll
            // 
            this.dataGridViewEnroll.AllowUserToAddRows = false;
            this.dataGridViewEnroll.AllowUserToDeleteRows = false;
            this.dataGridViewEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewEnroll.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewEnroll.Name = "dataGridViewEnroll";
            this.dataGridViewEnroll.ReadOnly = true;
            this.dataGridViewEnroll.RowTemplate.Height = 23;
            this.dataGridViewEnroll.Size = new System.Drawing.Size(662, 248);
            this.dataGridViewEnroll.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "학생번호";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "과목번호";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "과목년도";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "과목학기";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "과목이름";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "과목성적";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "성적확정";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // pRO1ENROLLSBindingSource
            // 
            this.pRO1ENROLLSBindingSource.DataMember = "PRO1_ENROLLS";
            this.pRO1ENROLLSBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRO1_ENROLLSTableAdapter
            // 
            this.pRO1_ENROLLSTableAdapter.ClearBeforeFill = true;
            // 
            // labelStdNum
            // 
            this.labelStdNum.AutoSize = true;
            this.labelStdNum.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStdNum.Location = new System.Drawing.Point(8, 9);
            this.labelStdNum.Name = "labelStdNum";
            this.labelStdNum.Size = new System.Drawing.Size(56, 22);
            this.labelStdNum.TabIndex = 10;
            this.labelStdNum.Text = "학번 :";
            // 
            // labelOutputStdNum
            // 
            this.labelOutputStdNum.AutoSize = true;
            this.labelOutputStdNum.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOutputStdNum.Location = new System.Drawing.Point(64, 9);
            this.labelOutputStdNum.Name = "labelOutputStdNum";
            this.labelOutputStdNum.Size = new System.Drawing.Size(0, 22);
            this.labelOutputStdNum.TabIndex = 11;
            // 
            // labelStdName
            // 
            this.labelStdName.AutoSize = true;
            this.labelStdName.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStdName.Location = new System.Drawing.Point(270, 9);
            this.labelStdName.Name = "labelStdName";
            this.labelStdName.Size = new System.Drawing.Size(0, 22);
            this.labelStdName.TabIndex = 13;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.Location = new System.Drawing.Point(218, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 22);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "이름 :";
            // 
            // labelStdYear
            // 
            this.labelStdYear.AutoSize = true;
            this.labelStdYear.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStdYear.Location = new System.Drawing.Point(99, 41);
            this.labelStdYear.Name = "labelStdYear";
            this.labelStdYear.Size = new System.Drawing.Size(0, 22);
            this.labelStdYear.TabIndex = 15;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelYear.Location = new System.Drawing.Point(8, 41);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(86, 22);
            this.labelYear.TabIndex = 14;
            this.labelYear.Text = "입학년도 :";
            // 
            // labelStdDept
            // 
            this.labelStdDept.AutoSize = true;
            this.labelStdDept.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStdDept.Location = new System.Drawing.Point(270, 41);
            this.labelStdDept.Name = "labelStdDept";
            this.labelStdDept.Size = new System.Drawing.Size(0, 22);
            this.labelStdDept.TabIndex = 17;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDept.Location = new System.Drawing.Point(218, 41);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(52, 22);
            this.labelDept.TabIndex = 16;
            this.labelDept.Text = "전공 :";
            // 
            // labelStdScore
            // 
            this.labelStdScore.AutoSize = true;
            this.labelStdScore.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStdScore.Location = new System.Drawing.Point(452, 9);
            this.labelStdScore.Name = "labelStdScore";
            this.labelStdScore.Size = new System.Drawing.Size(0, 22);
            this.labelStdScore.TabIndex = 19;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelScore.Location = new System.Drawing.Point(400, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(52, 22);
            this.labelScore.TabIndex = 18;
            this.labelScore.Text = "총점 :";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSave.Location = new System.Drawing.Point(599, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 54);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "저장";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pRO1_STUDENTSTableAdapter
            // 
            this.pRO1_STUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // OutputGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 330);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelStdScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelStdDept);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.labelStdYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelStdName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelOutputStdNum);
            this.Controls.Add(this.labelStdNum);
            this.Controls.Add(this.dataGridViewEnroll);
            this.Name = "OutputGrade";
            this.Text = "OutputGrade";
            this.Load += new System.EventHandler(this.OutputGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnroll;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource pRO1ENROLLSBindingSource;
        private DataSet1TableAdapters.PRO1_ENROLLSTableAdapter pRO1_ENROLLSTableAdapter;
        private System.Windows.Forms.Label labelStdNum;
        private System.Windows.Forms.Label labelOutputStdNum;
        private System.Windows.Forms.Label labelStdName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStdYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelStdDept;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelStdScore;
        private System.Windows.Forms.Label labelScore;
        private DataSet1TableAdapters.PRO1_STUDENTSTableAdapter pRO1_STUDENTSTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}