namespace DB_2
{
    partial class CreateCrs
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
            this.dataGridViewMakeCrs = new System.Windows.Forms.DataGridView();
            this.cRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSCONTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSSCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cRSDEPTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRO1DEPTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DB_2.DataSet1();
            this.cRSPRFNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRO1PROFESSORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1COURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCrs = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pRO1_COURSESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSESTableAdapter();
            this.pRO1_DEPTSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_DEPTSTableAdapter();
            this.pRO1_PROFESSORSTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_PROFESSORSTableAdapter();
            this.buttonAddByFile = new System.Windows.Forms.Button();
            this.buttonAllDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMakeCrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1DEPTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1PROFESSORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMakeCrs
            // 
            this.dataGridViewMakeCrs.AllowUserToAddRows = false;
            this.dataGridViewMakeCrs.AllowUserToDeleteRows = false;
            this.dataGridViewMakeCrs.AutoGenerateColumns = false;
            this.dataGridViewMakeCrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMakeCrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRSNUMDataGridViewTextBoxColumn,
            this.cRSYEARDataGridViewTextBoxColumn,
            this.cRSTERMDataGridViewTextBoxColumn,
            this.cRSNAMEDataGridViewTextBoxColumn,
            this.cRSCONTEXTDataGridViewTextBoxColumn,
            this.cRSSCOREDataGridViewTextBoxColumn,
            this.cRSTYPEDataGridViewTextBoxColumn,
            this.cRSDEPTNAMEDataGridViewTextBoxColumn,
            this.cRSPRFNUMDataGridViewTextBoxColumn});
            this.dataGridViewMakeCrs.DataSource = this.pRO1COURSESBindingSource;
            this.dataGridViewMakeCrs.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewMakeCrs.Name = "dataGridViewMakeCrs";
            this.dataGridViewMakeCrs.RowTemplate.Height = 23;
            this.dataGridViewMakeCrs.Size = new System.Drawing.Size(778, 480);
            this.dataGridViewMakeCrs.TabIndex = 0;
            // 
            // cRSNUMDataGridViewTextBoxColumn
            // 
            this.cRSNUMDataGridViewTextBoxColumn.DataPropertyName = "CRS_NUM";
            this.cRSNUMDataGridViewTextBoxColumn.HeaderText = "과목번호";
            this.cRSNUMDataGridViewTextBoxColumn.Name = "cRSNUMDataGridViewTextBoxColumn";
            // 
            // cRSYEARDataGridViewTextBoxColumn
            // 
            this.cRSYEARDataGridViewTextBoxColumn.DataPropertyName = "CRS_YEAR";
            this.cRSYEARDataGridViewTextBoxColumn.HeaderText = "과목개설년도";
            this.cRSYEARDataGridViewTextBoxColumn.Name = "cRSYEARDataGridViewTextBoxColumn";
            // 
            // cRSTERMDataGridViewTextBoxColumn
            // 
            this.cRSTERMDataGridViewTextBoxColumn.DataPropertyName = "CRS_TERM";
            this.cRSTERMDataGridViewTextBoxColumn.HeaderText = "과목개설학기";
            this.cRSTERMDataGridViewTextBoxColumn.Name = "cRSTERMDataGridViewTextBoxColumn";
            this.cRSTERMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cRSNAMEDataGridViewTextBoxColumn
            // 
            this.cRSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRS_NAME";
            this.cRSNAMEDataGridViewTextBoxColumn.HeaderText = "과목이름";
            this.cRSNAMEDataGridViewTextBoxColumn.Name = "cRSNAMEDataGridViewTextBoxColumn";
            // 
            // cRSCONTEXTDataGridViewTextBoxColumn
            // 
            this.cRSCONTEXTDataGridViewTextBoxColumn.DataPropertyName = "CRS_CONTEXT";
            this.cRSCONTEXTDataGridViewTextBoxColumn.HeaderText = "과목설명";
            this.cRSCONTEXTDataGridViewTextBoxColumn.Name = "cRSCONTEXTDataGridViewTextBoxColumn";
            // 
            // cRSSCOREDataGridViewTextBoxColumn
            // 
            this.cRSSCOREDataGridViewTextBoxColumn.DataPropertyName = "CRS_SCORE";
            this.cRSSCOREDataGridViewTextBoxColumn.HeaderText = "과목학점";
            this.cRSSCOREDataGridViewTextBoxColumn.Name = "cRSSCOREDataGridViewTextBoxColumn";
            this.cRSSCOREDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cRSTYPEDataGridViewTextBoxColumn
            // 
            this.cRSTYPEDataGridViewTextBoxColumn.DataPropertyName = "CRS_TYPE";
            this.cRSTYPEDataGridViewTextBoxColumn.HeaderText = "과목유형";
            this.cRSTYPEDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "전공선택",
            "전공기초",
            "전공필수"});
            this.cRSTYPEDataGridViewTextBoxColumn.Name = "cRSTYPEDataGridViewTextBoxColumn";
            this.cRSTYPEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cRSTYPEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cRSDEPTNAMEDataGridViewTextBoxColumn
            // 
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRS_DEPT_NAME";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.DataSource = this.pRO1DEPTSBindingSource;
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.DisplayMember = "DEPT_NAME";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.HeaderText = "과목담당학과";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.Name = "cRSDEPTNAMEDataGridViewTextBoxColumn";
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cRSDEPTNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // cRSPRFNUMDataGridViewTextBoxColumn
            // 
            this.cRSPRFNUMDataGridViewTextBoxColumn.DataPropertyName = "CRS_PRF_NUM";
            this.cRSPRFNUMDataGridViewTextBoxColumn.DataSource = this.pRO1PROFESSORSBindingSource;
            this.cRSPRFNUMDataGridViewTextBoxColumn.DisplayMember = "PRF_NAME";
            this.cRSPRFNUMDataGridViewTextBoxColumn.HeaderText = "과목담당교수";
            this.cRSPRFNUMDataGridViewTextBoxColumn.Name = "cRSPRFNUMDataGridViewTextBoxColumn";
            this.cRSPRFNUMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cRSPRFNUMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cRSPRFNUMDataGridViewTextBoxColumn.ValueMember = "PRF_NUM";
            // 
            // pRO1PROFESSORSBindingSource
            // 
            this.pRO1PROFESSORSBindingSource.DataMember = "PRO1_PROFESSORS";
            this.pRO1PROFESSORSBindingSource.DataSource = this.dataSet11;
            // 
            // pRO1COURSESBindingSource
            // 
            this.pRO1COURSESBindingSource.DataMember = "PRO1_COURSES";
            this.pRO1COURSESBindingSource.DataSource = this.dataSet11;
            // 
            // labelCrs
            // 
            this.labelCrs.AutoSize = true;
            this.labelCrs.Font = new System.Drawing.Font("휴먼편지체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCrs.Location = new System.Drawing.Point(2, 7);
            this.labelCrs.Name = "labelCrs";
            this.labelCrs.Size = new System.Drawing.Size(143, 43);
            this.labelCrs.TabIndex = 1;
            this.labelCrs.Text = "과목개설";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAdd.Location = new System.Drawing.Point(453, 7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 42);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDel.Location = new System.Drawing.Point(624, 7);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 42);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "삭제";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSave.Location = new System.Drawing.Point(705, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 42);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "저장";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pRO1_COURSESTableAdapter
            // 
            this.pRO1_COURSESTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_DEPTSTableAdapter
            // 
            this.pRO1_DEPTSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO1_PROFESSORSTableAdapter
            // 
            this.pRO1_PROFESSORSTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddByFile
            // 
            this.buttonAddByFile.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAddByFile.Location = new System.Drawing.Point(279, 7);
            this.buttonAddByFile.Name = "buttonAddByFile";
            this.buttonAddByFile.Size = new System.Drawing.Size(168, 42);
            this.buttonAddByFile.TabIndex = 5;
            this.buttonAddByFile.Text = "파일에서 추가하기";
            this.buttonAddByFile.UseVisualStyleBackColor = true;
            this.buttonAddByFile.Click += new System.EventHandler(this.buttonAddByFile_Click);
            // 
            // buttonAllDel
            // 
            this.buttonAllDel.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAllDel.Location = new System.Drawing.Point(534, 7);
            this.buttonAllDel.Name = "buttonAllDel";
            this.buttonAllDel.Size = new System.Drawing.Size(84, 42);
            this.buttonAllDel.TabIndex = 6;
            this.buttonAllDel.Text = "전체삭제";
            this.buttonAllDel.UseVisualStyleBackColor = true;
            this.buttonAllDel.Click += new System.EventHandler(this.buttonAllDel_Click);
            // 
            // CreateCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAllDel);
            this.Controls.Add(this.buttonAddByFile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCrs);
            this.Controls.Add(this.dataGridViewMakeCrs);
            this.MaximumSize = new System.Drawing.Size(784, 538);
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "CreateCrs";
            this.Size = new System.Drawing.Size(784, 538);
            this.Load += new System.EventHandler(this.CreateCrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMakeCrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1DEPTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1PROFESSORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMakeCrs;
        private System.Windows.Forms.Label labelCrs;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSave;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource pRO1COURSESBindingSource;
        private DataSet1TableAdapters.PRO1_COURSESTableAdapter pRO1_COURSESTableAdapter;
        private System.Windows.Forms.BindingSource pRO1DEPTSBindingSource;
        private DataSet1TableAdapters.PRO1_DEPTSTableAdapter pRO1_DEPTSTableAdapter;
        private System.Windows.Forms.BindingSource pRO1PROFESSORSBindingSource;
        private DataSet1TableAdapters.PRO1_PROFESSORSTableAdapter pRO1_PROFESSORSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSCONTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSSCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRSTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRSDEPTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRSPRFNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAddByFile;
        private System.Windows.Forms.Button buttonAllDel;
    }
}
