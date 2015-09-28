namespace DB_2
{
    partial class CrsCt
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
            this.dataSet11 = new DB_2.DataSet1();
            this.dataGridViewCrs = new System.Windows.Forms.DataGridView();
            this.dataGridViewCT = new System.Windows.Forms.DataGridView();
            this.pRO1COURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1_COURSESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSESTableAdapter();
            this.pRO1PROFESSORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1_PROFESSORSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_PROFESSORSTableAdapter();
            this.cRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSCONTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSSCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSDEPTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSPRFNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sYSC0068521BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1_COURSETIMESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSETIMESTableAdapter();
            this.cTNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTSEQNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTLOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1PROFESSORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068521BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewCrs
            // 
            this.dataGridViewCrs.AllowUserToAddRows = false;
            this.dataGridViewCrs.AllowUserToDeleteRows = false;
            this.dataGridViewCrs.AutoGenerateColumns = false;
            this.dataGridViewCrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRSNUMDataGridViewTextBoxColumn,
            this.cRSYEARDataGridViewTextBoxColumn,
            this.cRSTERMDataGridViewTextBoxColumn,
            this.cRSNAMEDataGridViewTextBoxColumn,
            this.cRSCONTEXTDataGridViewTextBoxColumn,
            this.cRSSCOREDataGridViewTextBoxColumn,
            this.cRSTYPEDataGridViewTextBoxColumn,
            this.cRSDEPTNAMEDataGridViewTextBoxColumn,
            this.cRSPRFNUMDataGridViewTextBoxColumn});
            this.dataGridViewCrs.DataSource = this.pRO1COURSESBindingSource;
            this.dataGridViewCrs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCrs.Name = "dataGridViewCrs";
            this.dataGridViewCrs.ReadOnly = true;
            this.dataGridViewCrs.RowTemplate.Height = 23;
            this.dataGridViewCrs.Size = new System.Drawing.Size(662, 189);
            this.dataGridViewCrs.TabIndex = 0;
            this.dataGridViewCrs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCrs_CellClick);
            // 
            // dataGridViewCT
            // 
            this.dataGridViewCT.AllowUserToAddRows = false;
            this.dataGridViewCT.AllowUserToDeleteRows = false;
            this.dataGridViewCT.AutoGenerateColumns = false;
            this.dataGridViewCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTNUMDataGridViewTextBoxColumn,
            this.cTYEARDataGridViewTextBoxColumn,
            this.cTTERMDataGridViewTextBoxColumn,
            this.cTSEQNUMDataGridViewTextBoxColumn,
            this.cTSTARTTIMEDataGridViewTextBoxColumn,
            this.cTENDTIMEDataGridViewTextBoxColumn,
            this.cTLOCDataGridViewTextBoxColumn,
            this.cTDAYDataGridViewTextBoxColumn});
            this.dataGridViewCT.DataSource = this.sYSC0068521BindingSource;
            this.dataGridViewCT.Location = new System.Drawing.Point(12, 207);
            this.dataGridViewCT.Name = "dataGridViewCT";
            this.dataGridViewCT.ReadOnly = true;
            this.dataGridViewCT.RowTemplate.Height = 23;
            this.dataGridViewCT.Size = new System.Drawing.Size(662, 111);
            this.dataGridViewCT.TabIndex = 1;
            // 
            // pRO1COURSESBindingSource
            // 
            this.pRO1COURSESBindingSource.DataMember = "PRO1_COURSES";
            this.pRO1COURSESBindingSource.DataSource = this.dataSet11;
            // 
            // pRO1_COURSESTableAdapter
            // 
            this.pRO1_COURSESTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1PROFESSORSBindingSource
            // 
            this.pRO1PROFESSORSBindingSource.DataMember = "PRO1_PROFESSORS";
            this.pRO1PROFESSORSBindingSource.DataSource = this.dataSet11;
            // 
            // pRO1_PROFESSORSTableAdapter
            // 
            this.pRO1_PROFESSORSTableAdapter.ClearBeforeFill = true;
            // 
            // cRSNUMDataGridViewTextBoxColumn
            // 
            this.cRSNUMDataGridViewTextBoxColumn.DataPropertyName = "CRS_NUM";
            this.cRSNUMDataGridViewTextBoxColumn.HeaderText = "과목번호";
            this.cRSNUMDataGridViewTextBoxColumn.Name = "cRSNUMDataGridViewTextBoxColumn";
            this.cRSNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSYEARDataGridViewTextBoxColumn
            // 
            this.cRSYEARDataGridViewTextBoxColumn.DataPropertyName = "CRS_YEAR";
            this.cRSYEARDataGridViewTextBoxColumn.HeaderText = "과목년도";
            this.cRSYEARDataGridViewTextBoxColumn.Name = "cRSYEARDataGridViewTextBoxColumn";
            this.cRSYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSTERMDataGridViewTextBoxColumn
            // 
            this.cRSTERMDataGridViewTextBoxColumn.DataPropertyName = "CRS_TERM";
            this.cRSTERMDataGridViewTextBoxColumn.HeaderText = "과목학기";
            this.cRSTERMDataGridViewTextBoxColumn.Name = "cRSTERMDataGridViewTextBoxColumn";
            this.cRSTERMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSNAMEDataGridViewTextBoxColumn
            // 
            this.cRSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRS_NAME";
            this.cRSNAMEDataGridViewTextBoxColumn.HeaderText = "과목이름";
            this.cRSNAMEDataGridViewTextBoxColumn.Name = "cRSNAMEDataGridViewTextBoxColumn";
            this.cRSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSCONTEXTDataGridViewTextBoxColumn
            // 
            this.cRSCONTEXTDataGridViewTextBoxColumn.DataPropertyName = "CRS_CONTEXT";
            this.cRSCONTEXTDataGridViewTextBoxColumn.HeaderText = "과목설명";
            this.cRSCONTEXTDataGridViewTextBoxColumn.Name = "cRSCONTEXTDataGridViewTextBoxColumn";
            this.cRSCONTEXTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSSCOREDataGridViewTextBoxColumn
            // 
            this.cRSSCOREDataGridViewTextBoxColumn.DataPropertyName = "CRS_SCORE";
            this.cRSSCOREDataGridViewTextBoxColumn.HeaderText = "과목학점";
            this.cRSSCOREDataGridViewTextBoxColumn.Name = "cRSSCOREDataGridViewTextBoxColumn";
            this.cRSSCOREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSTYPEDataGridViewTextBoxColumn
            // 
            this.cRSTYPEDataGridViewTextBoxColumn.DataPropertyName = "CRS_TYPE";
            this.cRSTYPEDataGridViewTextBoxColumn.HeaderText = "과목유형";
            this.cRSTYPEDataGridViewTextBoxColumn.Name = "cRSTYPEDataGridViewTextBoxColumn";
            this.cRSTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSDEPTNAMEDataGridViewTextBoxColumn
            // 
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRS_DEPT_NAME";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.HeaderText = "담당학과";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.Name = "cRSDEPTNAMEDataGridViewTextBoxColumn";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSPRFNUMDataGridViewTextBoxColumn
            // 
            this.cRSPRFNUMDataGridViewTextBoxColumn.DataPropertyName = "CRS_PRF_NUM";
            this.cRSPRFNUMDataGridViewTextBoxColumn.DataSource = this.pRO1PROFESSORSBindingSource;
            this.cRSPRFNUMDataGridViewTextBoxColumn.DisplayMember = "PRF_NAME";
            this.cRSPRFNUMDataGridViewTextBoxColumn.HeaderText = "담당교수";
            this.cRSPRFNUMDataGridViewTextBoxColumn.Name = "cRSPRFNUMDataGridViewTextBoxColumn";
            this.cRSPRFNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRSPRFNUMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cRSPRFNUMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cRSPRFNUMDataGridViewTextBoxColumn.ValueMember = "PRF_NUM";
            // 
            // sYSC0068521BindingSource
            // 
            this.sYSC0068521BindingSource.DataMember = "SYS_C0068521";
            this.sYSC0068521BindingSource.DataSource = this.pRO1COURSESBindingSource;
            // 
            // pRO1_COURSETIMESTableAdapter
            // 
            this.pRO1_COURSETIMESTableAdapter.ClearBeforeFill = true;
            // 
            // cTNUMDataGridViewTextBoxColumn
            // 
            this.cTNUMDataGridViewTextBoxColumn.DataPropertyName = "CT_NUM";
            this.cTNUMDataGridViewTextBoxColumn.HeaderText = "과목번호";
            this.cTNUMDataGridViewTextBoxColumn.Name = "cTNUMDataGridViewTextBoxColumn";
            this.cTNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTYEARDataGridViewTextBoxColumn
            // 
            this.cTYEARDataGridViewTextBoxColumn.DataPropertyName = "CT_YEAR";
            this.cTYEARDataGridViewTextBoxColumn.HeaderText = "과목년도";
            this.cTYEARDataGridViewTextBoxColumn.Name = "cTYEARDataGridViewTextBoxColumn";
            this.cTYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTTERMDataGridViewTextBoxColumn
            // 
            this.cTTERMDataGridViewTextBoxColumn.DataPropertyName = "CT_TERM";
            this.cTTERMDataGridViewTextBoxColumn.HeaderText = "과목학기";
            this.cTTERMDataGridViewTextBoxColumn.Name = "cTTERMDataGridViewTextBoxColumn";
            this.cTTERMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTSEQNUMDataGridViewTextBoxColumn
            // 
            this.cTSEQNUMDataGridViewTextBoxColumn.DataPropertyName = "CT_SEQ_NUM";
            this.cTSEQNUMDataGridViewTextBoxColumn.HeaderText = "시간표번호";
            this.cTSEQNUMDataGridViewTextBoxColumn.Name = "cTSEQNUMDataGridViewTextBoxColumn";
            this.cTSEQNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.cTSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "CT_STARTTIME";
            this.cTSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "시작시간";
            this.cTSTARTTIMEDataGridViewTextBoxColumn.Name = "cTSTARTTIMEDataGridViewTextBoxColumn";
            this.cTSTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTENDTIMEDataGridViewTextBoxColumn
            // 
            this.cTENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "CT_ENDTIME";
            this.cTENDTIMEDataGridViewTextBoxColumn.HeaderText = "종료시간";
            this.cTENDTIMEDataGridViewTextBoxColumn.Name = "cTENDTIMEDataGridViewTextBoxColumn";
            this.cTENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTLOCDataGridViewTextBoxColumn
            // 
            this.cTLOCDataGridViewTextBoxColumn.DataPropertyName = "CT_LOC";
            this.cTLOCDataGridViewTextBoxColumn.HeaderText = "강의위치";
            this.cTLOCDataGridViewTextBoxColumn.Name = "cTLOCDataGridViewTextBoxColumn";
            this.cTLOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTDAYDataGridViewTextBoxColumn
            // 
            this.cTDAYDataGridViewTextBoxColumn.DataPropertyName = "CT_DAY";
            this.cTDAYDataGridViewTextBoxColumn.HeaderText = "강의요일";
            this.cTDAYDataGridViewTextBoxColumn.Name = "cTDAYDataGridViewTextBoxColumn";
            this.cTDAYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CrsCt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 330);
            this.Controls.Add(this.dataGridViewCT);
            this.Controls.Add(this.dataGridViewCrs);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(702, 368);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(702, 368);
            this.Name = "CrsCt";
            this.Text = "CrsCt";
            this.Load += new System.EventHandler(this.CrsCt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1PROFESSORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068521BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridViewCrs;
        private System.Windows.Forms.DataGridView dataGridViewCT;
        private System.Windows.Forms.BindingSource pRO1COURSESBindingSource;
        private DataSet1TableAdapters.PRO1_COURSESTableAdapter pRO1_COURSESTableAdapter;
        private System.Windows.Forms.BindingSource pRO1PROFESSORSBindingSource;
        private DataSet1TableAdapters.PRO1_PROFESSORSTableAdapter pRO1_PROFESSORSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSCONTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSSCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSDEPTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRSPRFNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sYSC0068521BindingSource;
        private DataSet1TableAdapters.PRO1_COURSETIMESTableAdapter pRO1_COURSETIMESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTSEQNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTLOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTDAYDataGridViewTextBoxColumn;
    }
}