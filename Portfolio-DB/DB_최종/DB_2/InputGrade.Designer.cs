namespace DB_2
{
    partial class InputGrade
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelInputGrade = new System.Windows.Forms.Label();
            this.dataGridViewInputGrade = new System.Windows.Forms.DataGridView();
            this.buttonLoadByFile = new System.Windows.Forms.Button();
            this.dataGridViewPfsCrs = new System.Windows.Forms.DataGridView();
            this.dataGridViewAssignment = new System.Windows.Forms.DataGridView();
            this.buttonSaveAssignment = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.aSNNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSNSTDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRO1ENROLLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DB_2.DataSet1();
            this.aSNCRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRO1COURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSNCRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aSNCRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aSNSCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRO1ASSIGNMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSSCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSPRFNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRO1PROFESSORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1STUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1_ENROLLSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_ENROLLSTableAdapter();
            this.pRO1_STUDENTSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_STUDENTSTableAdapter();
            this.pRO1_COURSESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSESTableAdapter();
            this.pRO1_PROFESSORSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_PROFESSORSTableAdapter();
            this.pRO1_ASSIGNMENTSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_ASSIGNMENTSTableAdapter();
            this.eNSTDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eNMIDTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNFINTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNATTENDANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EN_ASSIGNMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EN_DECISION = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPfsCrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ASSIGNMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1PROFESSORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1STUDENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSave.Location = new System.Drawing.Point(609, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 42);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "성적저장";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelInputGrade
            // 
            this.labelInputGrade.AutoSize = true;
            this.labelInputGrade.Font = new System.Drawing.Font("휴먼편지체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelInputGrade.Location = new System.Drawing.Point(3, 5);
            this.labelInputGrade.Name = "labelInputGrade";
            this.labelInputGrade.Size = new System.Drawing.Size(151, 43);
            this.labelInputGrade.TabIndex = 8;
            this.labelInputGrade.Text = "성적입력";
            // 
            // dataGridViewInputGrade
            // 
            this.dataGridViewInputGrade.AllowUserToAddRows = false;
            this.dataGridViewInputGrade.AllowUserToDeleteRows = false;
            this.dataGridViewInputGrade.AutoGenerateColumns = false;
            this.dataGridViewInputGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNSTDNUMDataGridViewTextBoxColumn,
            this.eNCRSNUMDataGridViewTextBoxColumn,
            this.eNCRSYEARDataGridViewTextBoxColumn,
            this.eNCRSTERMDataGridViewTextBoxColumn,
            this.eNGRADEDataGridViewTextBoxColumn,
            this.eNMIDTERMDataGridViewTextBoxColumn,
            this.eNFINTERMDataGridViewTextBoxColumn,
            this.eNATTENDANCEDataGridViewTextBoxColumn,
            this.EN_ASSIGNMENT,
            this.EN_DECISION});
            this.dataGridViewInputGrade.DataSource = this.pRO1ENROLLSBindingSource;
            this.dataGridViewInputGrade.Location = new System.Drawing.Point(4, 261);
            this.dataGridViewInputGrade.Name = "dataGridViewInputGrade";
            this.dataGridViewInputGrade.RowTemplate.Height = 23;
            this.dataGridViewInputGrade.Size = new System.Drawing.Size(778, 272);
            this.dataGridViewInputGrade.TabIndex = 7;
            // 
            // buttonLoadByFile
            // 
            this.buttonLoadByFile.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonLoadByFile.Location = new System.Drawing.Point(277, 5);
            this.buttonLoadByFile.Name = "buttonLoadByFile";
            this.buttonLoadByFile.Size = new System.Drawing.Size(168, 42);
            this.buttonLoadByFile.TabIndex = 13;
            this.buttonLoadByFile.Text = "파일에서 불러오기";
            this.buttonLoadByFile.UseVisualStyleBackColor = true;
            this.buttonLoadByFile.Click += new System.EventHandler(this.buttonLoadByFile_Click);
            // 
            // dataGridViewPfsCrs
            // 
            this.dataGridViewPfsCrs.AllowUserToAddRows = false;
            this.dataGridViewPfsCrs.AllowUserToDeleteRows = false;
            this.dataGridViewPfsCrs.AutoGenerateColumns = false;
            this.dataGridViewPfsCrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPfsCrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRSNUMDataGridViewTextBoxColumn,
            this.cRSYEARDataGridViewTextBoxColumn,
            this.cRSTERMDataGridViewTextBoxColumn,
            this.cRSNAMEDataGridViewTextBoxColumn,
            this.cRSSCOREDataGridViewTextBoxColumn,
            this.cRSTYPEDataGridViewTextBoxColumn,
            this.cRSPRFNUMDataGridViewTextBoxColumn});
            this.dataGridViewPfsCrs.DataSource = this.pRO1COURSESBindingSource;
            this.dataGridViewPfsCrs.Location = new System.Drawing.Point(4, 53);
            this.dataGridViewPfsCrs.Name = "dataGridViewPfsCrs";
            this.dataGridViewPfsCrs.ReadOnly = true;
            this.dataGridViewPfsCrs.RowTemplate.Height = 23;
            this.dataGridViewPfsCrs.Size = new System.Drawing.Size(343, 202);
            this.dataGridViewPfsCrs.TabIndex = 14;
            this.dataGridViewPfsCrs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPfsCrs_CellClick);
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
            this.aSNCRSNUMDataGridViewTextBoxColumn,
            this.aSNCRSYEARDataGridViewTextBoxColumn,
            this.aSNCRSTERMDataGridViewTextBoxColumn,
            this.aSNSCOREDataGridViewTextBoxColumn});
            this.dataGridViewAssignment.DataSource = this.pRO1ASSIGNMENTSBindingSource;
            this.dataGridViewAssignment.Location = new System.Drawing.Point(353, 53);
            this.dataGridViewAssignment.Name = "dataGridViewAssignment";
            this.dataGridViewAssignment.RowTemplate.Height = 23;
            this.dataGridViewAssignment.Size = new System.Drawing.Size(428, 202);
            this.dataGridViewAssignment.TabIndex = 15;
            // 
            // buttonSaveAssignment
            // 
            this.buttonSaveAssignment.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSaveAssignment.Location = new System.Drawing.Point(696, 5);
            this.buttonSaveAssignment.Name = "buttonSaveAssignment";
            this.buttonSaveAssignment.Size = new System.Drawing.Size(85, 42);
            this.buttonSaveAssignment.TabIndex = 16;
            this.buttonSaveAssignment.Text = "과제저장";
            this.buttonSaveAssignment.UseVisualStyleBackColor = true;
            this.buttonSaveAssignment.Click += new System.EventHandler(this.buttonSaveAssignment_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDel.Location = new System.Drawing.Point(530, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 42);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "삭제";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAdd.Location = new System.Drawing.Point(450, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 42);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // aSNNUMDataGridViewTextBoxColumn
            // 
            this.aSNNUMDataGridViewTextBoxColumn.DataPropertyName = "ASN_NUM";
            this.aSNNUMDataGridViewTextBoxColumn.HeaderText = "과제번호";
            this.aSNNUMDataGridViewTextBoxColumn.Name = "aSNNUMDataGridViewTextBoxColumn";
            this.aSNNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSNNUMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // aSNSTDNUMDataGridViewTextBoxColumn
            // 
            this.aSNSTDNUMDataGridViewTextBoxColumn.DataPropertyName = "ASN_STD_NUM";
            this.aSNSTDNUMDataGridViewTextBoxColumn.DataSource = this.pRO1ENROLLSBindingSource;
            this.aSNSTDNUMDataGridViewTextBoxColumn.DisplayMember = "EN_STD_NUM";
            this.aSNSTDNUMDataGridViewTextBoxColumn.HeaderText = "학생번호";
            this.aSNSTDNUMDataGridViewTextBoxColumn.Name = "aSNSTDNUMDataGridViewTextBoxColumn";
            this.aSNSTDNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSNSTDNUMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aSNSTDNUMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aSNSTDNUMDataGridViewTextBoxColumn.ValueMember = "EN_STD_NUM";
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
            // aSNCRSNUMDataGridViewTextBoxColumn
            // 
            this.aSNCRSNUMDataGridViewTextBoxColumn.DataPropertyName = "ASN_CRS_NUM";
            this.aSNCRSNUMDataGridViewTextBoxColumn.DataSource = this.pRO1COURSESBindingSource;
            this.aSNCRSNUMDataGridViewTextBoxColumn.DisplayMember = "CRS_NUM";
            this.aSNCRSNUMDataGridViewTextBoxColumn.HeaderText = "과목번호";
            this.aSNCRSNUMDataGridViewTextBoxColumn.Name = "aSNCRSNUMDataGridViewTextBoxColumn";
            this.aSNCRSNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSNCRSNUMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aSNCRSNUMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aSNCRSNUMDataGridViewTextBoxColumn.ValueMember = "CRS_NUM";
            // 
            // pRO1COURSESBindingSource
            // 
            this.pRO1COURSESBindingSource.DataMember = "PRO1_COURSES";
            this.pRO1COURSESBindingSource.DataSource = this.dataSet11;
            // 
            // aSNCRSYEARDataGridViewTextBoxColumn
            // 
            this.aSNCRSYEARDataGridViewTextBoxColumn.DataPropertyName = "ASN_CRS_YEAR";
            this.aSNCRSYEARDataGridViewTextBoxColumn.DataSource = this.pRO1COURSESBindingSource;
            this.aSNCRSYEARDataGridViewTextBoxColumn.DisplayMember = "CRS_YEAR";
            this.aSNCRSYEARDataGridViewTextBoxColumn.HeaderText = "과목년도";
            this.aSNCRSYEARDataGridViewTextBoxColumn.Name = "aSNCRSYEARDataGridViewTextBoxColumn";
            this.aSNCRSYEARDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSNCRSYEARDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aSNCRSYEARDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aSNCRSYEARDataGridViewTextBoxColumn.ValueMember = "CRS_YEAR";
            // 
            // aSNCRSTERMDataGridViewTextBoxColumn
            // 
            this.aSNCRSTERMDataGridViewTextBoxColumn.DataPropertyName = "ASN_CRS_TERM";
            this.aSNCRSTERMDataGridViewTextBoxColumn.DataSource = this.pRO1COURSESBindingSource;
            this.aSNCRSTERMDataGridViewTextBoxColumn.DisplayMember = "CRS_TERM";
            this.aSNCRSTERMDataGridViewTextBoxColumn.HeaderText = "과목학기";
            this.aSNCRSTERMDataGridViewTextBoxColumn.Name = "aSNCRSTERMDataGridViewTextBoxColumn";
            this.aSNCRSTERMDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSNCRSTERMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aSNCRSTERMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aSNCRSTERMDataGridViewTextBoxColumn.ValueMember = "CRS_TERM";
            // 
            // aSNSCOREDataGridViewTextBoxColumn
            // 
            this.aSNSCOREDataGridViewTextBoxColumn.DataPropertyName = "ASN_SCORE";
            this.aSNSCOREDataGridViewTextBoxColumn.HeaderText = "과제점수";
            this.aSNSCOREDataGridViewTextBoxColumn.Name = "aSNSCOREDataGridViewTextBoxColumn";
            // 
            // pRO1ASSIGNMENTSBindingSource
            // 
            this.pRO1ASSIGNMENTSBindingSource.DataMember = "PRO1_ASSIGNMENTS";
            this.pRO1ASSIGNMENTSBindingSource.DataSource = this.dataSet11;
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
            // pRO1PROFESSORSBindingSource
            // 
            this.pRO1PROFESSORSBindingSource.DataMember = "PRO1_PROFESSORS";
            this.pRO1PROFESSORSBindingSource.DataSource = this.dataSet11;
            // 
            // pRO1STUDENTSBindingSource
            // 
            this.pRO1STUDENTSBindingSource.DataMember = "PRO1_STUDENTS";
            this.pRO1STUDENTSBindingSource.DataSource = this.dataSet11;
            // 
            // pRO1_ENROLLSTableAdapter
            // 
            this.pRO1_ENROLLSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_STUDENTSTableAdapter
            // 
            this.pRO1_STUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_COURSESTableAdapter
            // 
            this.pRO1_COURSESTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_PROFESSORSTableAdapter
            // 
            this.pRO1_PROFESSORSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_ASSIGNMENTSTableAdapter
            // 
            this.pRO1_ASSIGNMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // eNSTDNUMDataGridViewTextBoxColumn
            // 
            this.eNSTDNUMDataGridViewTextBoxColumn.DataPropertyName = "EN_STD_NUM";
            this.eNSTDNUMDataGridViewTextBoxColumn.HeaderText = "학생번호";
            this.eNSTDNUMDataGridViewTextBoxColumn.Name = "eNSTDNUMDataGridViewTextBoxColumn";
            this.eNSTDNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNSTDNUMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // eNCRSNUMDataGridViewTextBoxColumn
            // 
            this.eNCRSNUMDataGridViewTextBoxColumn.DataPropertyName = "EN_CRS_NUM";
            this.eNCRSNUMDataGridViewTextBoxColumn.HeaderText = "과목번호";
            this.eNCRSNUMDataGridViewTextBoxColumn.Name = "eNCRSNUMDataGridViewTextBoxColumn";
            this.eNCRSNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNCRSNUMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // eNCRSYEARDataGridViewTextBoxColumn
            // 
            this.eNCRSYEARDataGridViewTextBoxColumn.DataPropertyName = "EN_CRS_YEAR";
            this.eNCRSYEARDataGridViewTextBoxColumn.HeaderText = "과목년도";
            this.eNCRSYEARDataGridViewTextBoxColumn.Name = "eNCRSYEARDataGridViewTextBoxColumn";
            this.eNCRSYEARDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNCRSYEARDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // eNCRSTERMDataGridViewTextBoxColumn
            // 
            this.eNCRSTERMDataGridViewTextBoxColumn.DataPropertyName = "EN_CRS_TERM";
            this.eNCRSTERMDataGridViewTextBoxColumn.HeaderText = "과목학기";
            this.eNCRSTERMDataGridViewTextBoxColumn.Name = "eNCRSTERMDataGridViewTextBoxColumn";
            this.eNCRSTERMDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNCRSTERMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // eNGRADEDataGridViewTextBoxColumn
            // 
            this.eNGRADEDataGridViewTextBoxColumn.DataPropertyName = "EN_GRADE";
            this.eNGRADEDataGridViewTextBoxColumn.HeaderText = "최종성적";
            this.eNGRADEDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.eNGRADEDataGridViewTextBoxColumn.Name = "eNGRADEDataGridViewTextBoxColumn";
            this.eNGRADEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eNGRADEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eNMIDTERMDataGridViewTextBoxColumn
            // 
            this.eNMIDTERMDataGridViewTextBoxColumn.DataPropertyName = "EN_MID_TERM";
            this.eNMIDTERMDataGridViewTextBoxColumn.HeaderText = "중간고사성적";
            this.eNMIDTERMDataGridViewTextBoxColumn.Name = "eNMIDTERMDataGridViewTextBoxColumn";
            // 
            // eNFINTERMDataGridViewTextBoxColumn
            // 
            this.eNFINTERMDataGridViewTextBoxColumn.DataPropertyName = "EN_FIN_TERM";
            this.eNFINTERMDataGridViewTextBoxColumn.HeaderText = "기말고사성적";
            this.eNFINTERMDataGridViewTextBoxColumn.Name = "eNFINTERMDataGridViewTextBoxColumn";
            // 
            // eNATTENDANCEDataGridViewTextBoxColumn
            // 
            this.eNATTENDANCEDataGridViewTextBoxColumn.DataPropertyName = "EN_ATTENDANCE";
            this.eNATTENDANCEDataGridViewTextBoxColumn.HeaderText = "출석";
            this.eNATTENDANCEDataGridViewTextBoxColumn.Name = "eNATTENDANCEDataGridViewTextBoxColumn";
            // 
            // EN_ASSIGNMENT
            // 
            this.EN_ASSIGNMENT.DataPropertyName = "EN_ASSIGNMENT";
            this.EN_ASSIGNMENT.HeaderText = "과제점수";
            this.EN_ASSIGNMENT.Name = "EN_ASSIGNMENT";
            // 
            // EN_DECISION
            // 
            this.EN_DECISION.DataPropertyName = "EN_DECISION";
            this.EN_DECISION.FalseValue = "N";
            this.EN_DECISION.HeaderText = "성적확정";
            this.EN_DECISION.Name = "EN_DECISION";
            this.EN_DECISION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EN_DECISION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EN_DECISION.TrueValue = "Y";
            // 
            // InputGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSaveAssignment);
            this.Controls.Add(this.dataGridViewAssignment);
            this.Controls.Add(this.dataGridViewPfsCrs);
            this.Controls.Add(this.buttonLoadByFile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelInputGrade);
            this.Controls.Add(this.dataGridViewInputGrade);
            this.MaximumSize = new System.Drawing.Size(784, 538);
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "InputGrade";
            this.Size = new System.Drawing.Size(784, 538);
            this.Load += new System.EventHandler(this.InputGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPfsCrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ENROLLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1ASSIGNMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1PROFESSORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1STUDENTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelInputGrade;
        private System.Windows.Forms.DataGridView dataGridViewInputGrade;
        private System.Windows.Forms.Button buttonLoadByFile;
        private System.Windows.Forms.BindingSource pRO1STUDENTSBindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource pRO1COURSESBindingSource;
        private System.Windows.Forms.BindingSource pRO1ENROLLSBindingSource;
        private DataSet1TableAdapters.PRO1_ENROLLSTableAdapter pRO1_ENROLLSTableAdapter;
        private DataSet1TableAdapters.PRO1_STUDENTSTableAdapter pRO1_STUDENTSTableAdapter;
        private DataSet1TableAdapters.PRO1_COURSESTableAdapter pRO1_COURSESTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewPfsCrs;
        private System.Windows.Forms.BindingSource pRO1PROFESSORSBindingSource;
        private DataSet1TableAdapters.PRO1_PROFESSORSTableAdapter pRO1_PROFESSORSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSSCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRSPRFNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewAssignment;
        private System.Windows.Forms.BindingSource pRO1ASSIGNMENTSBindingSource;
        private DataSet1TableAdapters.PRO1_ASSIGNMENTSTableAdapter pRO1_ASSIGNMENTSTableAdapter;
        private System.Windows.Forms.Button buttonSaveAssignment;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSNNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aSNSTDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aSNCRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aSNCRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aSNCRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSNSCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNSTDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eNGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNMIDTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNFINTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNATTENDANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EN_ASSIGNMENT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EN_DECISION;
    }
}
