namespace DB_2
{
    partial class CrsSign
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
            this.labelSign = new System.Windows.Forms.Label();
            this.dataGridViewCrs = new System.Windows.Forms.DataGridView();
            this.pRO1COURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DB_2.DataSet1();
            this.dataGridViewEnroll = new System.Windows.Forms.DataGridView();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pRO1_COURSESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSESTableAdapter();
            this.pRO1ENROLLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1_ENROLLSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_ENROLLSTableAdapter();
            this.cRSPRFNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSDEPTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSSCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSCONTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNSTDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("휴먼편지체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSign.Location = new System.Drawing.Point(3, 5);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(143, 43);
            this.labelSign.TabIndex = 3;
            this.labelSign.Text = "수강신청";
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
            this.dataGridViewCrs.Location = new System.Drawing.Point(4, 53);
            this.dataGridViewCrs.Name = "dataGridViewCrs";
            this.dataGridViewCrs.ReadOnly = true;
            this.dataGridViewCrs.RowTemplate.Height = 23;
            this.dataGridViewCrs.Size = new System.Drawing.Size(778, 248);
            this.dataGridViewCrs.TabIndex = 2;
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
            // dataGridViewEnroll
            // 
            this.dataGridViewEnroll.AllowUserToAddRows = false;
            this.dataGridViewEnroll.AllowUserToDeleteRows = false;
            this.dataGridViewEnroll.AutoGenerateColumns = false;
            this.dataGridViewEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNSTDNUMDataGridViewTextBoxColumn,
            this.eNCRSNUMDataGridViewTextBoxColumn,
            this.eNCRSYEARDataGridViewTextBoxColumn,
            this.eNCRSTERMDataGridViewTextBoxColumn});
            this.dataGridViewEnroll.DataSource = this.pRO1ENROLLSBindingSource;
            this.dataGridViewEnroll.Location = new System.Drawing.Point(4, 307);
            this.dataGridViewEnroll.Name = "dataGridViewEnroll";
            this.dataGridViewEnroll.ReadOnly = true;
            this.dataGridViewEnroll.RowTemplate.Height = 23;
            this.dataGridViewEnroll.Size = new System.Drawing.Size(778, 228);
            this.dataGridViewEnroll.TabIndex = 4;
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDel.Location = new System.Drawing.Point(702, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 42);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "삭제";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAdd.Location = new System.Drawing.Point(621, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 42);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "신청";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pRO1_COURSESTableAdapter
            // 
            this.pRO1_COURSESTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1ENROLLSBindingSource
            // 
            this.pRO1ENROLLSBindingSource.DataMember = "PRO1_ENROLLS";
            this.pRO1ENROLLSBindingSource.DataSource = this.dataSet11;
            // 
            // pRO1_ENROLLSTableAdapter
            // 
            this.pRO1_ENROLLSTableAdapter.ClearBeforeFill = true;
            // 
            // cRSPRFNUMDataGridViewTextBoxColumn
            // 
            this.cRSPRFNUMDataGridViewTextBoxColumn.DataPropertyName = "CRS_PRF_NUM";
            this.cRSPRFNUMDataGridViewTextBoxColumn.HeaderText = "담당교수";
            this.cRSPRFNUMDataGridViewTextBoxColumn.Name = "cRSPRFNUMDataGridViewTextBoxColumn";
            this.cRSPRFNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSDEPTNAMEDataGridViewTextBoxColumn
            // 
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRS_DEPT_NAME";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.HeaderText = "개설학과";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.Name = "cRSDEPTNAMEDataGridViewTextBoxColumn";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSTYPEDataGridViewTextBoxColumn
            // 
            this.cRSTYPEDataGridViewTextBoxColumn.DataPropertyName = "CRS_TYPE";
            this.cRSTYPEDataGridViewTextBoxColumn.HeaderText = "과목유형";
            this.cRSTYPEDataGridViewTextBoxColumn.Name = "cRSTYPEDataGridViewTextBoxColumn";
            this.cRSTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSSCOREDataGridViewTextBoxColumn
            // 
            this.cRSSCOREDataGridViewTextBoxColumn.DataPropertyName = "CRS_SCORE";
            this.cRSSCOREDataGridViewTextBoxColumn.HeaderText = "과목학점";
            this.cRSSCOREDataGridViewTextBoxColumn.Name = "cRSSCOREDataGridViewTextBoxColumn";
            this.cRSSCOREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSCONTEXTDataGridViewTextBoxColumn
            // 
            this.cRSCONTEXTDataGridViewTextBoxColumn.DataPropertyName = "CRS_CONTEXT";
            this.cRSCONTEXTDataGridViewTextBoxColumn.HeaderText = "과목설명";
            this.cRSCONTEXTDataGridViewTextBoxColumn.Name = "cRSCONTEXTDataGridViewTextBoxColumn";
            this.cRSCONTEXTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSNAMEDataGridViewTextBoxColumn
            // 
            this.cRSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRS_NAME";
            this.cRSNAMEDataGridViewTextBoxColumn.HeaderText = "과목이름";
            this.cRSNAMEDataGridViewTextBoxColumn.Name = "cRSNAMEDataGridViewTextBoxColumn";
            this.cRSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSTERMDataGridViewTextBoxColumn
            // 
            this.cRSTERMDataGridViewTextBoxColumn.DataPropertyName = "CRS_TERM";
            this.cRSTERMDataGridViewTextBoxColumn.HeaderText = "과목학기";
            this.cRSTERMDataGridViewTextBoxColumn.Name = "cRSTERMDataGridViewTextBoxColumn";
            this.cRSTERMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSYEARDataGridViewTextBoxColumn
            // 
            this.cRSYEARDataGridViewTextBoxColumn.DataPropertyName = "CRS_YEAR";
            this.cRSYEARDataGridViewTextBoxColumn.HeaderText = "과목년도";
            this.cRSYEARDataGridViewTextBoxColumn.Name = "cRSYEARDataGridViewTextBoxColumn";
            this.cRSYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRSNUMDataGridViewTextBoxColumn
            // 
            this.cRSNUMDataGridViewTextBoxColumn.DataPropertyName = "CRS_NUM";
            this.cRSNUMDataGridViewTextBoxColumn.HeaderText = "과목번호";
            this.cRSNUMDataGridViewTextBoxColumn.Name = "cRSNUMDataGridViewTextBoxColumn";
            this.cRSNUMDataGridViewTextBoxColumn.ReadOnly = true;
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
            // CrsSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewEnroll);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.dataGridViewCrs);
            this.MaximumSize = new System.Drawing.Size(784, 538);
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "CrsSign";
            this.Size = new System.Drawing.Size(784, 538);
            this.Load += new System.EventHandler(this.crsSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.DataGridView dataGridViewCrs;
        private System.Windows.Forms.DataGridView dataGridViewEnroll;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource pRO1COURSESBindingSource;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.PRO1_COURSESTableAdapter pRO1_COURSESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSCONTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSSCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSDEPTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSPRFNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRO1ENROLLSBindingSource;
        private DataSet1TableAdapters.PRO1_ENROLLSTableAdapter pRO1_ENROLLSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNSTDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSTERMDataGridViewTextBoxColumn;
    }
}
