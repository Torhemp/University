namespace DB_2
{
    partial class SearchStd
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
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewEnroll = new System.Windows.Forms.DataGridView();
            this.labelSearchStd = new System.Windows.Forms.Label();
            this.dataGridViewStd = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewEnrollStd = new System.Windows.Forms.DataGridView();
            this.sYSC0068543BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxStd = new System.Windows.Forms.PictureBox();
            this.labelPhoneStd = new System.Windows.Forms.Label();
            this.labelEmailStd = new System.Windows.Forms.Label();
            this.labelDeptStd = new System.Windows.Forms.Label();
            this.labelGenderStd = new System.Windows.Forms.Label();
            this.labelYearStd = new System.Windows.Forms.Label();
            this.labelNameStd = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLocStd = new System.Windows.Forms.Label();
            this.labelLoc = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRO1STUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DB_2.DataSet1();
            this.pRO1COURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDLOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRO1_COURSESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSESTableAdapter();
            this.pRO1_ENROLLSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_ENROLLSTableAdapter();
            this.pRO1_STUDENTSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_STUDENTSTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnrollStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068543BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1STUDENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(572, 15);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 21);
            this.textBoxValue.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(531, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "값 :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearch.Location = new System.Drawing.Point(693, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 31);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewEnroll
            // 
            this.dataGridViewEnroll.AllowUserToAddRows = false;
            this.dataGridViewEnroll.AllowUserToDeleteRows = false;
            this.dataGridViewEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewEnroll.Location = new System.Drawing.Point(4, 227);
            this.dataGridViewEnroll.Name = "dataGridViewEnroll";
            this.dataGridViewEnroll.ReadOnly = true;
            this.dataGridViewEnroll.RowTemplate.Height = 23;
            this.dataGridViewEnroll.Size = new System.Drawing.Size(344, 308);
            this.dataGridViewEnroll.TabIndex = 13;
            this.dataGridViewEnroll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnroll_CellClick);
            // 
            // labelSearchStd
            // 
            this.labelSearchStd.AutoSize = true;
            this.labelSearchStd.Font = new System.Drawing.Font("휴먼편지체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSearchStd.Location = new System.Drawing.Point(3, 4);
            this.labelSearchStd.Name = "labelSearchStd";
            this.labelSearchStd.Size = new System.Drawing.Size(151, 43);
            this.labelSearchStd.TabIndex = 12;
            this.labelSearchStd.Text = "학생검색";
            // 
            // dataGridViewStd
            // 
            this.dataGridViewStd.AllowUserToAddRows = false;
            this.dataGridViewStd.AllowUserToDeleteRows = false;
            this.dataGridViewStd.AutoGenerateColumns = false;
            this.dataGridViewStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTDNUMDataGridViewTextBoxColumn,
            this.sTDNAMEDataGridViewTextBoxColumn,
            this.sTDLOCDataGridViewTextBoxColumn,
            this.sTDYEARDataGridViewTextBoxColumn,
            this.sTDGENDERDataGridViewTextBoxColumn});
            this.dataGridViewStd.DataSource = this.pRO1STUDENTSBindingSource;
            this.dataGridViewStd.Location = new System.Drawing.Point(4, 52);
            this.dataGridViewStd.Name = "dataGridViewStd";
            this.dataGridViewStd.ReadOnly = true;
            this.dataGridViewStd.RowTemplate.Height = 23;
            this.dataGridViewStd.Size = new System.Drawing.Size(344, 169);
            this.dataGridViewStd.TabIndex = 11;
            this.dataGridViewStd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStd_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(316, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "검색 항목";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "학번",
            "이름",
            "입학년도",
            "성별",
            "학과"});
            this.comboBox1.Location = new System.Drawing.Point(402, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 18;
            // 
            // dataGridViewEnrollStd
            // 
            this.dataGridViewEnrollStd.AllowUserToAddRows = false;
            this.dataGridViewEnrollStd.AllowUserToDeleteRows = false;
            this.dataGridViewEnrollStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnrollStd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewEnrollStd.Location = new System.Drawing.Point(354, 227);
            this.dataGridViewEnrollStd.Name = "dataGridViewEnrollStd";
            this.dataGridViewEnrollStd.ReadOnly = true;
            this.dataGridViewEnrollStd.RowTemplate.Height = 23;
            this.dataGridViewEnrollStd.Size = new System.Drawing.Size(427, 308);
            this.dataGridViewEnrollStd.TabIndex = 19;
            // 
            // sYSC0068543BindingSource
            // 
            this.sYSC0068543BindingSource.DataMember = "SYS_C0068543";
            this.sYSC0068543BindingSource.DataSource = this.pRO1COURSESBindingSource;
            // 
            // pictureBoxStd
            // 
            this.pictureBoxStd.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pRO1STUDENTSBindingSource, "STD_IMAGE", true));
            this.pictureBoxStd.Location = new System.Drawing.Point(354, 52);
            this.pictureBoxStd.Name = "pictureBoxStd";
            this.pictureBoxStd.Size = new System.Drawing.Size(151, 169);
            this.pictureBoxStd.TabIndex = 20;
            this.pictureBoxStd.TabStop = false;
            // 
            // labelPhoneStd
            // 
            this.labelPhoneStd.AutoSize = true;
            this.labelPhoneStd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPhoneStd.Location = new System.Drawing.Point(577, 181);
            this.labelPhoneStd.Name = "labelPhoneStd";
            this.labelPhoneStd.Size = new System.Drawing.Size(0, 16);
            this.labelPhoneStd.TabIndex = 33;
            // 
            // labelEmailStd
            // 
            this.labelEmailStd.AutoSize = true;
            this.labelEmailStd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEmailStd.Location = new System.Drawing.Point(567, 155);
            this.labelEmailStd.Name = "labelEmailStd";
            this.labelEmailStd.Size = new System.Drawing.Size(0, 16);
            this.labelEmailStd.TabIndex = 32;
            // 
            // labelDeptStd
            // 
            this.labelDeptStd.AutoSize = true;
            this.labelDeptStd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDeptStd.Location = new System.Drawing.Point(561, 130);
            this.labelDeptStd.Name = "labelDeptStd";
            this.labelDeptStd.Size = new System.Drawing.Size(0, 16);
            this.labelDeptStd.TabIndex = 31;
            // 
            // labelGenderStd
            // 
            this.labelGenderStd.AutoSize = true;
            this.labelGenderStd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGenderStd.Location = new System.Drawing.Point(561, 104);
            this.labelGenderStd.Name = "labelGenderStd";
            this.labelGenderStd.Size = new System.Drawing.Size(0, 16);
            this.labelGenderStd.TabIndex = 30;
            // 
            // labelYearStd
            // 
            this.labelYearStd.AutoSize = true;
            this.labelYearStd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelYearStd.Location = new System.Drawing.Point(598, 78);
            this.labelYearStd.Name = "labelYearStd";
            this.labelYearStd.Size = new System.Drawing.Size(0, 16);
            this.labelYearStd.TabIndex = 29;
            // 
            // labelNameStd
            // 
            this.labelNameStd.AutoSize = true;
            this.labelNameStd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNameStd.Location = new System.Drawing.Point(566, 52);
            this.labelNameStd.Name = "labelNameStd";
            this.labelNameStd.Size = new System.Drawing.Size(0, 16);
            this.labelNameStd.TabIndex = 28;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPhone.Location = new System.Drawing.Point(511, 181);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(66, 16);
            this.labelPhone.TabIndex = 27;
            this.labelPhone.Text = "연락처 :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEmail.Location = new System.Drawing.Point(511, 155);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 16);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Email :";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDept.Location = new System.Drawing.Point(511, 130);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(50, 16);
            this.labelDept.TabIndex = 25;
            this.labelDept.Text = "학과 :";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGender.Location = new System.Drawing.Point(511, 104);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(50, 16);
            this.labelGender.TabIndex = 24;
            this.labelGender.Text = "성별 :";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelYear.Location = new System.Drawing.Point(511, 78);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(82, 16);
            this.labelYear.TabIndex = 23;
            this.labelYear.Text = "입학년도 :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.Location = new System.Drawing.Point(511, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 16);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "성명 :";
            // 
            // labelLocStd
            // 
            this.labelLocStd.AutoSize = true;
            this.labelLocStd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLocStd.Location = new System.Drawing.Point(561, 205);
            this.labelLocStd.Name = "labelLocStd";
            this.labelLocStd.Size = new System.Drawing.Size(0, 16);
            this.labelLocStd.TabIndex = 35;
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLoc.Location = new System.Drawing.Point(511, 205);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(50, 16);
            this.labelLoc.TabIndex = 34;
            this.labelLoc.Text = "주소 :";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "학생번호";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "과목번호";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "과목년도";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "과목학기";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "과목이름";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // pRO1STUDENTSBindingSource
            // 
            this.pRO1STUDENTSBindingSource.DataMember = "PRO1_STUDENTS";
            this.pRO1STUDENTSBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRO1COURSESBindingSource
            // 
            this.pRO1COURSESBindingSource.DataMember = "PRO1_COURSES";
            this.pRO1COURSESBindingSource.DataSource = this.dataSet11;
            // 
            // sTDNUMDataGridViewTextBoxColumn
            // 
            this.sTDNUMDataGridViewTextBoxColumn.DataPropertyName = "STD_NUM";
            this.sTDNUMDataGridViewTextBoxColumn.HeaderText = "학생번호";
            this.sTDNUMDataGridViewTextBoxColumn.Name = "sTDNUMDataGridViewTextBoxColumn";
            this.sTDNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTDNAMEDataGridViewTextBoxColumn
            // 
            this.sTDNAMEDataGridViewTextBoxColumn.DataPropertyName = "STD_NAME";
            this.sTDNAMEDataGridViewTextBoxColumn.HeaderText = "학생이름";
            this.sTDNAMEDataGridViewTextBoxColumn.Name = "sTDNAMEDataGridViewTextBoxColumn";
            this.sTDNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTDLOCDataGridViewTextBoxColumn
            // 
            this.sTDLOCDataGridViewTextBoxColumn.DataPropertyName = "STD_LOC";
            this.sTDLOCDataGridViewTextBoxColumn.HeaderText = "주소";
            this.sTDLOCDataGridViewTextBoxColumn.Name = "sTDLOCDataGridViewTextBoxColumn";
            this.sTDLOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTDYEARDataGridViewTextBoxColumn
            // 
            this.sTDYEARDataGridViewTextBoxColumn.DataPropertyName = "STD_YEAR";
            this.sTDYEARDataGridViewTextBoxColumn.HeaderText = "입학년도";
            this.sTDYEARDataGridViewTextBoxColumn.Name = "sTDYEARDataGridViewTextBoxColumn";
            this.sTDYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTDGENDERDataGridViewTextBoxColumn
            // 
            this.sTDGENDERDataGridViewTextBoxColumn.DataPropertyName = "STD_GENDER";
            this.sTDGENDERDataGridViewTextBoxColumn.HeaderText = "성별";
            this.sTDGENDERDataGridViewTextBoxColumn.Name = "sTDGENDERDataGridViewTextBoxColumn";
            this.sTDGENDERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRO1_COURSESTableAdapter
            // 
            this.pRO1_COURSESTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_ENROLLSTableAdapter
            // 
            this.pRO1_ENROLLSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_STUDENTSTableAdapter
            // 
            this.pRO1_STUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "학생번호";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "학생이름";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "과목번호";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "과목년도";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "과목학기";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // SearchStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLocStd);
            this.Controls.Add(this.labelLoc);
            this.Controls.Add(this.labelPhoneStd);
            this.Controls.Add(this.labelEmailStd);
            this.Controls.Add(this.labelDeptStd);
            this.Controls.Add(this.labelGenderStd);
            this.Controls.Add(this.labelYearStd);
            this.Controls.Add(this.labelNameStd);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxStd);
            this.Controls.Add(this.dataGridViewEnrollStd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewEnroll);
            this.Controls.Add(this.labelSearchStd);
            this.Controls.Add(this.dataGridViewStd);
            this.MaximumSize = new System.Drawing.Size(784, 538);
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "SearchStd";
            this.Size = new System.Drawing.Size(784, 538);
            this.Load += new System.EventHandler(this.SearchStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnrollStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSC0068543BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1STUDENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewEnroll;
        private System.Windows.Forms.Label labelSearchStd;
        private System.Windows.Forms.DataGridView dataGridViewStd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridViewEnrollStd;
        private System.Windows.Forms.PictureBox pictureBoxStd;
        private System.Windows.Forms.Label labelPhoneStd;
        private System.Windows.Forms.Label labelEmailStd;
        private System.Windows.Forms.Label labelDeptStd;
        private System.Windows.Forms.Label labelGenderStd;
        private System.Windows.Forms.Label labelYearStd;
        private System.Windows.Forms.Label labelNameStd;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLocStd;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.BindingSource pRO1COURSESBindingSource;
        private System.Windows.Forms.BindingSource sYSC0068543BindingSource;
        private DataSet1TableAdapters.PRO1_COURSESTableAdapter pRO1_COURSESTableAdapter;
        private DataSet1TableAdapters.PRO1_ENROLLSTableAdapter pRO1_ENROLLSTableAdapter;
        private System.Windows.Forms.BindingSource pRO1STUDENTSBindingSource;
        private DataSet1TableAdapters.PRO1_STUDENTSTableAdapter pRO1_STUDENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDLOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
