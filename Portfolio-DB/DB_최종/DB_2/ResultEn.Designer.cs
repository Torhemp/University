namespace DB_2
{
    partial class ResultEn
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
            this.dataSet1 = new DB_2.DataSet1();
            this.pRO1ENROLLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1_ENROLLSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_ENROLLSTableAdapter();
            this.eNSTDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNMIDTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNFINTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNATTENDANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNSTDNUMDataGridViewTextBoxColumn,
            this.eNCRSNUMDataGridViewTextBoxColumn,
            this.eNCRSYEARDataGridViewTextBoxColumn,
            this.eNCRSTERMDataGridViewTextBoxColumn,
            this.eNGRADEDataGridViewTextBoxColumn,
            this.eNMIDTERMDataGridViewTextBoxColumn,
            this.eNFINTERMDataGridViewTextBoxColumn,
            this.eNATTENDANCEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRO1ENROLLSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(945, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRO1ENROLLSBindingSource
            // 
            this.pRO1ENROLLSBindingSource.DataMember = "PRO1_ENROLLS";
            this.pRO1ENROLLSBindingSource.DataSource = this.dataSet1;
            // 
            // pRO1_ENROLLSTableAdapter
            // 
            this.pRO1_ENROLLSTableAdapter.ClearBeforeFill = true;
            // 
            // eNSTDNUMDataGridViewTextBoxColumn
            // 
            this.eNSTDNUMDataGridViewTextBoxColumn.DataPropertyName = "EN_STD_NUM";
            this.eNSTDNUMDataGridViewTextBoxColumn.HeaderText = "학생번호";
            this.eNSTDNUMDataGridViewTextBoxColumn.Name = "eNSTDNUMDataGridViewTextBoxColumn";
            this.eNSTDNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNCRSNUMDataGridViewTextBoxColumn
            // 
            this.eNCRSNUMDataGridViewTextBoxColumn.DataPropertyName = "EN_CRS_NUM";
            this.eNCRSNUMDataGridViewTextBoxColumn.HeaderText = "과목번호";
            this.eNCRSNUMDataGridViewTextBoxColumn.Name = "eNCRSNUMDataGridViewTextBoxColumn";
            this.eNCRSNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNCRSYEARDataGridViewTextBoxColumn
            // 
            this.eNCRSYEARDataGridViewTextBoxColumn.DataPropertyName = "EN_CRS_YEAR";
            this.eNCRSYEARDataGridViewTextBoxColumn.HeaderText = "과목년도";
            this.eNCRSYEARDataGridViewTextBoxColumn.Name = "eNCRSYEARDataGridViewTextBoxColumn";
            this.eNCRSYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNCRSTERMDataGridViewTextBoxColumn
            // 
            this.eNCRSTERMDataGridViewTextBoxColumn.DataPropertyName = "EN_CRS_TERM";
            this.eNCRSTERMDataGridViewTextBoxColumn.HeaderText = "과목학기";
            this.eNCRSTERMDataGridViewTextBoxColumn.Name = "eNCRSTERMDataGridViewTextBoxColumn";
            this.eNCRSTERMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNGRADEDataGridViewTextBoxColumn
            // 
            this.eNGRADEDataGridViewTextBoxColumn.DataPropertyName = "EN_GRADE";
            this.eNGRADEDataGridViewTextBoxColumn.HeaderText = "최종성적";
            this.eNGRADEDataGridViewTextBoxColumn.Name = "eNGRADEDataGridViewTextBoxColumn";
            this.eNGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNMIDTERMDataGridViewTextBoxColumn
            // 
            this.eNMIDTERMDataGridViewTextBoxColumn.DataPropertyName = "EN_MID_TERM";
            this.eNMIDTERMDataGridViewTextBoxColumn.HeaderText = "중간고사성적";
            this.eNMIDTERMDataGridViewTextBoxColumn.Name = "eNMIDTERMDataGridViewTextBoxColumn";
            this.eNMIDTERMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNFINTERMDataGridViewTextBoxColumn
            // 
            this.eNFINTERMDataGridViewTextBoxColumn.DataPropertyName = "EN_FIN_TERM";
            this.eNFINTERMDataGridViewTextBoxColumn.HeaderText = "기말고사성적";
            this.eNFINTERMDataGridViewTextBoxColumn.Name = "eNFINTERMDataGridViewTextBoxColumn";
            this.eNFINTERMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNATTENDANCEDataGridViewTextBoxColumn
            // 
            this.eNATTENDANCEDataGridViewTextBoxColumn.DataPropertyName = "EN_ATTENDANCE";
            this.eNATTENDANCEDataGridViewTextBoxColumn.HeaderText = "출석";
            this.eNATTENDANCEDataGridViewTextBoxColumn.Name = "eNATTENDANCEDataGridViewTextBoxColumn";
            this.eNATTENDANCEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ResultEn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 354);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(987, 392);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(987, 392);
            this.Name = "ResultEn";
            this.Text = "ResultEn";
            this.Load += new System.EventHandler(this.ResultEn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pRO1ENROLLSBindingSource;
        private DataSet1TableAdapters.PRO1_ENROLLSTableAdapter pRO1_ENROLLSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNSTDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNMIDTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNFINTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNATTENDANCEDataGridViewTextBoxColumn;
    }
}