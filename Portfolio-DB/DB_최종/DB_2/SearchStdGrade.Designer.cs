namespace DB_2
{
    partial class SearchStdGrade
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelSearchStd = new System.Windows.Forms.Label();
            this.dataGridViewEnroll = new System.Windows.Forms.DataGridView();
            this.pRO1COURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DB_2.DataSet1();
            this.pRO1ENROLLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewAssignment = new System.Windows.Forms.DataGridView();
            this.aSNNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSNSTDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASN_STD_NUM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRO1STUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSNCRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASN_CRS_NUM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aSNCRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSNCRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSNSCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYSC0068571BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pRO1_ENROLLSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_ENROLLSTableAdapter();
            this.pRO1_ASSIGNMENTSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_ASSIGNMENTSTableAdapter();
            this.pRO1_COURSESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSESTableAdapter();
            this.pRO1_STUDENTSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_STUDENTSTableAdapter();
            this.labelStdNum = new System.Windows.Forms.Label();
            this.textBoxStd = new System.Windows.Forms.TextBox();
            this.buttonOutputGrade = new System.Windows.Forms.Button();
            this.eNSTDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EN_CRS_NUM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eNCRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNMIDTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNFINTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNATTENDANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EN_ASSIGNMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1STUDENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068571BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchStd
            // 
            this.labelSearchStd.AutoSize = true;
            this.labelSearchStd.Font = new System.Drawing.Font("휴먼편지체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSearchStd.Location = new System.Drawing.Point(3, 4);
            this.labelSearchStd.Name = "labelSearchStd";
            this.labelSearchStd.Size = new System.Drawing.Size(151, 43);
            this.labelSearchStd.TabIndex = 6;
            this.labelSearchStd.Text = "학생성적";
            // 
            // dataGridViewEnroll
            // 
            this.dataGridViewEnroll.AllowUserToAddRows = false;
            this.dataGridViewEnroll.AllowUserToDeleteRows = false;
            this.dataGridViewEnroll.AutoGenerateColumns = false;
            this.dataGridViewEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNSTDNUMDataGridViewTextBoxColumn,
            this.eNCRSNUMDataGridViewTextBoxColumn,
            this.EN_CRS_NUM,
            this.eNCRSYEARDataGridViewTextBoxColumn,
            this.eNCRSTERMDataGridViewTextBoxColumn,
            this.eNGRADEDataGridViewTextBoxColumn,
            this.eNMIDTERMDataGridViewTextBoxColumn,
            this.eNFINTERMDataGridViewTextBoxColumn,
            this.eNATTENDANCEDataGridViewTextBoxColumn,
            this.EN_ASSIGNMENT,
            this.Column1});
            this.dataGridViewEnroll.DataSource = this.pRO1ENROLLSBindingSource;
            this.dataGridViewEnroll.Location = new System.Drawing.Point(4, 52);
            this.dataGridViewEnroll.Name = "dataGridViewEnroll";
            this.dataGridViewEnroll.ReadOnly = true;
            this.dataGridViewEnroll.RowTemplate.Height = 23;
            this.dataGridViewEnroll.Size = new System.Drawing.Size(778, 248);
            this.dataGridViewEnroll.TabIndex = 5;
            this.dataGridViewEnroll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCrs_CellClick);
            // 
            // pRO1COURSESBindingSource
            // 
            this.pRO1COURSESBindingSource.DataMember = "PRO1_COURSES";
            this.pRO1COURSESBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRO1ENROLLSBindingSource
            // 
            this.pRO1ENROLLSBindingSource.DataMember = "PRO1_ENROLLS";
            this.pRO1ENROLLSBindingSource.DataSource = this.dataSet11;
            // 
            // dataGridViewAssignment
            // 
            this.dataGridViewAssignment.AllowUserToAddRows = false;
            this.dataGridViewAssignment.AllowUserToDeleteRows = false;
            this.dataGridViewAssignment.AutoGenerateColumns = false;
            this.dataGridViewAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aSNNUMDataGridViewTextBoxColumn,
            this.aSNSTDNUMDataGridViewTextBoxColumn,
            this.ASN_STD_NUM,
            this.aSNCRSNUMDataGridViewTextBoxColumn,
            this.ASN_CRS_NUM,
            this.aSNCRSYEARDataGridViewTextBoxColumn,
            this.aSNCRSTERMDataGridViewTextBoxColumn,
            this.aSNSCOREDataGridViewTextBoxColumn});
            this.dataGridViewAssignment.DataSource = this.sYSC0068571BindingSource;
            this.dataGridViewAssignment.Location = new System.Drawing.Point(4, 306);
            this.dataGridViewAssignment.Name = "dataGridViewAssignment";
            this.dataGridViewAssignment.ReadOnly = true;
            this.dataGridViewAssignment.RowTemplate.Height = 23;
            this.dataGridViewAssignment.Size = new System.Drawing.Size(778, 229);
            this.dataGridViewAssignment.TabIndex = 7;
            // 
            // aSNNUMDataGridViewTextBoxColumn
            // 
            this.aSNNUMDataGridViewTextBoxColumn.DataPropertyName = "ASN_NUM";
            this.aSNNUMDataGridViewTextBoxColumn.HeaderText = "과제번호";
            this.aSNNUMDataGridViewTextBoxColumn.Name = "aSNNUMDataGridViewTextBoxColumn";
            this.aSNNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSNNUMDataGridViewTextBoxColumn.Width = 78;
            // 
            // aSNSTDNUMDataGridViewTextBoxColumn
            // 
            this.aSNSTDNUMDataGridViewTextBoxColumn.DataPropertyName = "ASN_STD_NUM";
            this.aSNSTDNUMDataGridViewTextBoxColumn.HeaderText = "학생번호";
            this.aSNSTDNUMDataGridViewTextBoxColumn.Name = "aSNSTDNUMDataGridViewTextBoxColumn";
            this.aSNSTDNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ASN_STD_NUM
            // 
            this.ASN_STD_NUM.DataPropertyName = "ASN_STD_NUM";
            this.ASN_STD_NUM.DataSource = this.pRO1STUDENTSBindingSource;
            this.ASN_STD_NUM.DisplayMember = "STD_NAME";
            this.ASN_STD_NUM.HeaderText = "학생이름";
            this.ASN_STD_NUM.Name = "ASN_STD_NUM";
            this.ASN_STD_NUM.ReadOnly = true;
            this.ASN_STD_NUM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ASN_STD_NUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ASN_STD_NUM.ValueMember = "STD_NUM";
            // 
            // pRO1STUDENTSBindingSource
            // 
            this.pRO1STUDENTSBindingSource.DataMember = "PRO1_STUDENTS";
            this.pRO1STUDENTSBindingSource.DataSource = this.dataSet11;
            // 
            // aSNCRSNUMDataGridViewTextBoxColumn
            // 
            this.aSNCRSNUMDataGridViewTextBoxColumn.DataPropertyName = "ASN_CRS_NUM";
            this.aSNCRSNUMDataGridViewTextBoxColumn.HeaderText = "과제과목번호";
            this.aSNCRSNUMDataGridViewTextBoxColumn.Name = "aSNCRSNUMDataGridViewTextBoxColumn";
            this.aSNCRSNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ASN_CRS_NUM
            // 
            this.ASN_CRS_NUM.DataPropertyName = "ASN_CRS_NUM";
            this.ASN_CRS_NUM.DataSource = this.pRO1COURSESBindingSource;
            this.ASN_CRS_NUM.DisplayMember = "CRS_NAME";
            this.ASN_CRS_NUM.HeaderText = "과제과목이름";
            this.ASN_CRS_NUM.Name = "ASN_CRS_NUM";
            this.ASN_CRS_NUM.ReadOnly = true;
            this.ASN_CRS_NUM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ASN_CRS_NUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ASN_CRS_NUM.ValueMember = "CRS_NUM";
            // 
            // aSNCRSYEARDataGridViewTextBoxColumn
            // 
            this.aSNCRSYEARDataGridViewTextBoxColumn.DataPropertyName = "ASN_CRS_YEAR";
            this.aSNCRSYEARDataGridViewTextBoxColumn.HeaderText = "과제과목년도";
            this.aSNCRSYEARDataGridViewTextBoxColumn.Name = "aSNCRSYEARDataGridViewTextBoxColumn";
            this.aSNCRSYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aSNCRSTERMDataGridViewTextBoxColumn
            // 
            this.aSNCRSTERMDataGridViewTextBoxColumn.DataPropertyName = "ASN_CRS_TERM";
            this.aSNCRSTERMDataGridViewTextBoxColumn.HeaderText = "과제과목학기";
            this.aSNCRSTERMDataGridViewTextBoxColumn.Name = "aSNCRSTERMDataGridViewTextBoxColumn";
            this.aSNCRSTERMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aSNSCOREDataGridViewTextBoxColumn
            // 
            this.aSNSCOREDataGridViewTextBoxColumn.DataPropertyName = "ASN_SCORE";
            this.aSNSCOREDataGridViewTextBoxColumn.HeaderText = "과제점수";
            this.aSNSCOREDataGridViewTextBoxColumn.Name = "aSNSCOREDataGridViewTextBoxColumn";
            this.aSNSCOREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sYSC0068571BindingSource
            // 
            this.sYSC0068571BindingSource.DataMember = "SYS_C0068571";
            this.sYSC0068571BindingSource.DataSource = this.pRO1ENROLLSBindingSource;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearch.Location = new System.Drawing.Point(693, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 31);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pRO1_ENROLLSTableAdapter
            // 
            this.pRO1_ENROLLSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_ASSIGNMENTSTableAdapter
            // 
            this.pRO1_ASSIGNMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_COURSESTableAdapter
            // 
            this.pRO1_COURSESTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_STUDENTSTableAdapter
            // 
            this.pRO1_STUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // labelStdNum
            // 
            this.labelStdNum.AutoSize = true;
            this.labelStdNum.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStdNum.Location = new System.Drawing.Point(509, 14);
            this.labelStdNum.Name = "labelStdNum";
            this.labelStdNum.Size = new System.Drawing.Size(56, 22);
            this.labelStdNum.TabIndex = 9;
            this.labelStdNum.Text = "학번 :";
            // 
            // textBoxStd
            // 
            this.textBoxStd.Location = new System.Drawing.Point(572, 15);
            this.textBoxStd.Name = "textBoxStd";
            this.textBoxStd.Size = new System.Drawing.Size(100, 21);
            this.textBoxStd.TabIndex = 10;
            // 
            // buttonOutputGrade
            // 
            this.buttonOutputGrade.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonOutputGrade.Location = new System.Drawing.Point(344, 10);
            this.buttonOutputGrade.Name = "buttonOutputGrade";
            this.buttonOutputGrade.Size = new System.Drawing.Size(159, 31);
            this.buttonOutputGrade.TabIndex = 11;
            this.buttonOutputGrade.Text = "성적증명서 가져오기";
            this.buttonOutputGrade.UseVisualStyleBackColor = true;
            this.buttonOutputGrade.Click += new System.EventHandler(this.buttonOutputGrade_Click);
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
            // EN_CRS_NUM
            // 
            this.EN_CRS_NUM.DataPropertyName = "EN_CRS_NUM";
            this.EN_CRS_NUM.DataSource = this.pRO1COURSESBindingSource;
            this.EN_CRS_NUM.DisplayMember = "CRS_NAME";
            this.EN_CRS_NUM.HeaderText = "과목이름";
            this.EN_CRS_NUM.Name = "EN_CRS_NUM";
            this.EN_CRS_NUM.ReadOnly = true;
            this.EN_CRS_NUM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EN_CRS_NUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EN_CRS_NUM.ValueMember = "CRS_NUM";
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
            // EN_ASSIGNMENT
            // 
            this.EN_ASSIGNMENT.DataPropertyName = "EN_ASSIGNMENT";
            this.EN_ASSIGNMENT.HeaderText = "과제점수";
            this.EN_ASSIGNMENT.Name = "EN_ASSIGNMENT";
            this.EN_ASSIGNMENT.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EN_DECISION";
            this.Column1.HeaderText = "성적확정";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // SearchStdGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOutputGrade);
            this.Controls.Add(this.textBoxStd);
            this.Controls.Add(this.labelStdNum);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewAssignment);
            this.Controls.Add(this.labelSearchStd);
            this.Controls.Add(this.dataGridViewEnroll);
            this.MaximumSize = new System.Drawing.Size(784, 538);
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "SearchStdGrade";
            this.Size = new System.Drawing.Size(784, 538);
            this.Load += new System.EventHandler(this.SearchStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1STUDENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068571BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchStd;
        private System.Windows.Forms.DataGridView dataGridViewEnroll;
        private System.Windows.Forms.BindingSource pRO1COURSESBindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource pRO1ENROLLSBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewAssignment;
        private System.Windows.Forms.BindingSource sYSC0068571BindingSource;
        private DataSet1TableAdapters.PRO1_ENROLLSTableAdapter pRO1_ENROLLSTableAdapter;
        private DataSet1TableAdapters.PRO1_ASSIGNMENTSTableAdapter pRO1_ASSIGNMENTSTableAdapter;
        private DataSet1TableAdapters.PRO1_COURSESTableAdapter pRO1_COURSESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSNNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSNSTDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ASN_STD_NUM;
        private System.Windows.Forms.BindingSource pRO1STUDENTSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSNCRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ASN_CRS_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSNCRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSNCRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSNSCOREDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.PRO1_STUDENTSTableAdapter pRO1_STUDENTSTableAdapter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelStdNum;
        private System.Windows.Forms.TextBox textBoxStd;
        private System.Windows.Forms.Button buttonOutputGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNSTDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn EN_CRS_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNMIDTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNFINTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNATTENDANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EN_ASSIGNMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
