namespace DB_2
{
    partial class SearchPrf
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
            this.dataGridViewCrs = new System.Windows.Forms.DataGridView();
            this.cRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSCONTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSSCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSDEPTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSPRFNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sYSC0068500BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1DEPTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DB_2.DataSet1();
            this.sYSC0068505BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSearchPrf = new System.Windows.Forms.Label();
            this.dataGridViewDept = new System.Windows.Forms.DataGridView();
            this.dEPTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPrf = new System.Windows.Forms.DataGridView();
            this.pRFNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRO1_DEPTSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_DEPTSTableAdapter();
            this.pRO1_PROFESSORSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_PROFESSORSTableAdapter();
            this.pictureBoxPrf = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelNamePrf = new System.Windows.Forms.Label();
            this.labelYearPrf = new System.Windows.Forms.Label();
            this.labelGenderPrf = new System.Windows.Forms.Label();
            this.labelDeptPrf = new System.Windows.Forms.Label();
            this.labelEmailPrf = new System.Windows.Forms.Label();
            this.labelPhonePrf = new System.Windows.Forms.Label();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.pRO1_COURSESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068500BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1DEPTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068505BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrf)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewCrs.DataSource = this.sYSC0068505BindingSource;
            this.dataGridViewCrs.Location = new System.Drawing.Point(4, 209);
            this.dataGridViewCrs.Name = "dataGridViewCrs";
            this.dataGridViewCrs.ReadOnly = true;
            this.dataGridViewCrs.RowTemplate.Height = 23;
            this.dataGridViewCrs.Size = new System.Drawing.Size(778, 325);
            this.dataGridViewCrs.TabIndex = 7;
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
            this.cRSCONTEXTDataGridViewTextBoxColumn.HeaderText = "과목정보";
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
            this.cRSPRFNUMDataGridViewTextBoxColumn.DataSource = this.sYSC0068500BindingSource;
            this.cRSPRFNUMDataGridViewTextBoxColumn.DisplayMember = "PRF_NAME";
            this.cRSPRFNUMDataGridViewTextBoxColumn.HeaderText = "담당교수";
            this.cRSPRFNUMDataGridViewTextBoxColumn.Name = "cRSPRFNUMDataGridViewTextBoxColumn";
            this.cRSPRFNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRSPRFNUMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cRSPRFNUMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cRSPRFNUMDataGridViewTextBoxColumn.ValueMember = "PRF_NUM";
            // 
            // sYSC0068500BindingSource
            // 
            this.sYSC0068500BindingSource.DataMember = "SYS_C0068500";
            this.sYSC0068500BindingSource.DataSource = this.pRO1DEPTSBindingSource;
            // 
            // pRO1DEPTSBindingSource
            // 
            this.pRO1DEPTSBindingSource.DataMember = "PRO1_DEPTS";
            this.pRO1DEPTSBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sYSC0068505BindingSource
            // 
            this.sYSC0068505BindingSource.DataMember = "SYS_C0068505";
            this.sYSC0068505BindingSource.DataSource = this.sYSC0068500BindingSource;
            // 
            // labelSearchPrf
            // 
            this.labelSearchPrf.AutoSize = true;
            this.labelSearchPrf.Font = new System.Drawing.Font("휴먼편지체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSearchPrf.Location = new System.Drawing.Point(3, 4);
            this.labelSearchPrf.Name = "labelSearchPrf";
            this.labelSearchPrf.Size = new System.Drawing.Size(135, 43);
            this.labelSearchPrf.TabIndex = 6;
            this.labelSearchPrf.Text = "교수검색";
            // 
            // dataGridViewDept
            // 
            this.dataGridViewDept.AllowUserToAddRows = false;
            this.dataGridViewDept.AllowUserToDeleteRows = false;
            this.dataGridViewDept.AutoGenerateColumns = false;
            this.dataGridViewDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dEPTNAMEDataGridViewTextBoxColumn});
            this.dataGridViewDept.DataSource = this.pRO1DEPTSBindingSource;
            this.dataGridViewDept.Location = new System.Drawing.Point(4, 52);
            this.dataGridViewDept.Name = "dataGridViewDept";
            this.dataGridViewDept.ReadOnly = true;
            this.dataGridViewDept.RowTemplate.Height = 23;
            this.dataGridViewDept.Size = new System.Drawing.Size(158, 151);
            this.dataGridViewDept.TabIndex = 5;
            this.dataGridViewDept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDept_CellClick);
            // 
            // dEPTNAMEDataGridViewTextBoxColumn
            // 
            this.dEPTNAMEDataGridViewTextBoxColumn.DataPropertyName = "DEPT_NAME";
            this.dEPTNAMEDataGridViewTextBoxColumn.HeaderText = "학과명";
            this.dEPTNAMEDataGridViewTextBoxColumn.Name = "dEPTNAMEDataGridViewTextBoxColumn";
            this.dEPTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewPrf
            // 
            this.dataGridViewPrf.AllowUserToAddRows = false;
            this.dataGridViewPrf.AllowUserToDeleteRows = false;
            this.dataGridViewPrf.AutoGenerateColumns = false;
            this.dataGridViewPrf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRFNUMDataGridViewTextBoxColumn,
            this.pRFNAMEDataGridViewTextBoxColumn});
            this.dataGridViewPrf.DataSource = this.sYSC0068500BindingSource;
            this.dataGridViewPrf.Location = new System.Drawing.Point(168, 52);
            this.dataGridViewPrf.Name = "dataGridViewPrf";
            this.dataGridViewPrf.ReadOnly = true;
            this.dataGridViewPrf.RowTemplate.Height = 23;
            this.dataGridViewPrf.Size = new System.Drawing.Size(245, 151);
            this.dataGridViewPrf.TabIndex = 8;
            this.dataGridViewPrf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrf_CellClick);
            // 
            // pRFNUMDataGridViewTextBoxColumn
            // 
            this.pRFNUMDataGridViewTextBoxColumn.DataPropertyName = "PRF_NUM";
            this.pRFNUMDataGridViewTextBoxColumn.HeaderText = "교수인사번호";
            this.pRFNUMDataGridViewTextBoxColumn.Name = "pRFNUMDataGridViewTextBoxColumn";
            this.pRFNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRFNAMEDataGridViewTextBoxColumn
            // 
            this.pRFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRF_NAME";
            this.pRFNAMEDataGridViewTextBoxColumn.HeaderText = "교수성함";
            this.pRFNAMEDataGridViewTextBoxColumn.Name = "pRFNAMEDataGridViewTextBoxColumn";
            this.pRFNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRO1_DEPTSTableAdapter
            // 
            this.pRO1_DEPTSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_PROFESSORSTableAdapter
            // 
            this.pRO1_PROFESSORSTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBoxPrf
            // 
            this.pictureBoxPrf.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.sYSC0068500BindingSource, "PRF_IMAGE", true));
            this.pictureBoxPrf.Location = new System.Drawing.Point(419, 52);
            this.pictureBoxPrf.MaximumSize = new System.Drawing.Size(119, 151);
            this.pictureBoxPrf.MinimumSize = new System.Drawing.Size(119, 151);
            this.pictureBoxPrf.Name = "pictureBoxPrf";
            this.pictureBoxPrf.Size = new System.Drawing.Size(119, 151);
            this.pictureBoxPrf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrf.TabIndex = 9;
            this.pictureBoxPrf.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.Location = new System.Drawing.Point(540, 54);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 16);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "성명 :";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelYear.Location = new System.Drawing.Point(540, 80);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(82, 16);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "임용년도 :";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGender.Location = new System.Drawing.Point(540, 106);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(50, 16);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "성별 :";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDept.Location = new System.Drawing.Point(540, 132);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(50, 16);
            this.labelDept.TabIndex = 13;
            this.labelDept.Text = "학과 :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEmail.Location = new System.Drawing.Point(540, 158);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 16);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email :";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPhone.Location = new System.Drawing.Point(540, 184);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(66, 16);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "연락처 :";
            // 
            // labelNamePrf
            // 
            this.labelNamePrf.AutoSize = true;
            this.labelNamePrf.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNamePrf.Location = new System.Drawing.Point(595, 54);
            this.labelNamePrf.Name = "labelNamePrf";
            this.labelNamePrf.Size = new System.Drawing.Size(0, 16);
            this.labelNamePrf.TabIndex = 16;
            // 
            // labelYearPrf
            // 
            this.labelYearPrf.AutoSize = true;
            this.labelYearPrf.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelYearPrf.Location = new System.Drawing.Point(627, 80);
            this.labelYearPrf.Name = "labelYearPrf";
            this.labelYearPrf.Size = new System.Drawing.Size(0, 16);
            this.labelYearPrf.TabIndex = 17;
            // 
            // labelGenderPrf
            // 
            this.labelGenderPrf.AutoSize = true;
            this.labelGenderPrf.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGenderPrf.Location = new System.Drawing.Point(590, 106);
            this.labelGenderPrf.Name = "labelGenderPrf";
            this.labelGenderPrf.Size = new System.Drawing.Size(0, 16);
            this.labelGenderPrf.TabIndex = 18;
            // 
            // labelDeptPrf
            // 
            this.labelDeptPrf.AutoSize = true;
            this.labelDeptPrf.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDeptPrf.Location = new System.Drawing.Point(590, 132);
            this.labelDeptPrf.Name = "labelDeptPrf";
            this.labelDeptPrf.Size = new System.Drawing.Size(0, 16);
            this.labelDeptPrf.TabIndex = 19;
            // 
            // labelEmailPrf
            // 
            this.labelEmailPrf.AutoSize = true;
            this.labelEmailPrf.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEmailPrf.Location = new System.Drawing.Point(596, 158);
            this.labelEmailPrf.Name = "labelEmailPrf";
            this.labelEmailPrf.Size = new System.Drawing.Size(0, 16);
            this.labelEmailPrf.TabIndex = 20;
            // 
            // labelPhonePrf
            // 
            this.labelPhonePrf.AutoSize = true;
            this.labelPhonePrf.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPhonePrf.Location = new System.Drawing.Point(606, 184);
            this.labelPhonePrf.Name = "labelPhonePrf";
            this.labelPhonePrf.Size = new System.Drawing.Size(0, 16);
            this.labelPhonePrf.TabIndex = 21;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORAORA;USER ID=S5049986; PASSWORD=s5049986";
            // 
            // pRO1_COURSESTableAdapter
            // 
            this.pRO1_COURSESTableAdapter.ClearBeforeFill = true;
            // 
            // SearchPrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPhonePrf);
            this.Controls.Add(this.labelEmailPrf);
            this.Controls.Add(this.labelDeptPrf);
            this.Controls.Add(this.labelGenderPrf);
            this.Controls.Add(this.labelYearPrf);
            this.Controls.Add(this.labelNamePrf);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxPrf);
            this.Controls.Add(this.dataGridViewPrf);
            this.Controls.Add(this.dataGridViewCrs);
            this.Controls.Add(this.labelSearchPrf);
            this.Controls.Add(this.dataGridViewDept);
            this.MaximumSize = new System.Drawing.Size(784, 538);
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "SearchPrf";
            this.Size = new System.Drawing.Size(784, 538);
            this.Load += new System.EventHandler(this.SearchPrf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068500BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1DEPTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068505BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCrs;
        private System.Windows.Forms.Label labelSearchPrf;
        private System.Windows.Forms.DataGridView dataGridViewDept;
        private System.Windows.Forms.BindingSource pRO1DEPTSBindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridViewPrf;
        private DataSet1TableAdapters.PRO1_DEPTSTableAdapter pRO1_DEPTSTableAdapter;
        private System.Windows.Forms.BindingSource sYSC0068500BindingSource;
        private DataSet1TableAdapters.PRO1_PROFESSORSTableAdapter pRO1_PROFESSORSTableAdapter;
        private System.Windows.Forms.PictureBox pictureBoxPrf;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelNamePrf;
        private System.Windows.Forms.Label labelYearPrf;
        private System.Windows.Forms.Label labelGenderPrf;
        private System.Windows.Forms.Label labelDeptPrf;
        private System.Windows.Forms.Label labelEmailPrf;
        private System.Windows.Forms.Label labelPhonePrf;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private System.Windows.Forms.BindingSource sYSC0068505BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFNAMEDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.PRO1_COURSESTableAdapter pRO1_COURSESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSCONTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSSCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSDEPTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRSPRFNUMDataGridViewTextBoxColumn;
    }
}
