namespace DB_2
{
    partial class CreateCT
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
            this.buttonAllDel = new System.Windows.Forms.Button();
            this.buttonAddByFile = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCT = new System.Windows.Forms.Label();
            this.dataGridViewMakeCT = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new DB_2.DataSet1();
            this.pRO1COURSETIMESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO1_COURSETIMESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSETIMESTableAdapter();
            this.cTNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTSEQNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTLOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMakeCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSETIMESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAllDel
            // 
            this.buttonAllDel.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAllDel.Location = new System.Drawing.Point(535, 5);
            this.buttonAllDel.Name = "buttonAllDel";
            this.buttonAllDel.Size = new System.Drawing.Size(84, 42);
            this.buttonAllDel.TabIndex = 13;
            this.buttonAllDel.Text = "전체삭제";
            this.buttonAllDel.UseVisualStyleBackColor = true;
            this.buttonAllDel.Click += new System.EventHandler(this.buttonAllDel_Click);
            // 
            // buttonAddByFile
            // 
            this.buttonAddByFile.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAddByFile.Location = new System.Drawing.Point(280, 5);
            this.buttonAddByFile.Name = "buttonAddByFile";
            this.buttonAddByFile.Size = new System.Drawing.Size(168, 42);
            this.buttonAddByFile.TabIndex = 12;
            this.buttonAddByFile.Text = "파일에서 추가하기";
            this.buttonAddByFile.UseVisualStyleBackColor = true;
            this.buttonAddByFile.Click += new System.EventHandler(this.buttonAddByFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSave.Location = new System.Drawing.Point(706, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 42);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "저장";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDel.Location = new System.Drawing.Point(625, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 42);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "삭제";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAdd.Location = new System.Drawing.Point(454, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 42);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCT
            // 
            this.labelCT.AutoSize = true;
            this.labelCT.Font = new System.Drawing.Font("휴먼편지체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCT.Location = new System.Drawing.Point(3, 5);
            this.labelCT.Name = "labelCT";
            this.labelCT.Size = new System.Drawing.Size(193, 43);
            this.labelCT.TabIndex = 8;
            this.labelCT.Text = "과목시간등록";
            // 
            // dataGridViewMakeCT
            // 
            this.dataGridViewMakeCT.AllowUserToAddRows = false;
            this.dataGridViewMakeCT.AllowUserToDeleteRows = false;
            this.dataGridViewMakeCT.AutoGenerateColumns = false;
            this.dataGridViewMakeCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMakeCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTNUMDataGridViewTextBoxColumn,
            this.cTYEARDataGridViewTextBoxColumn,
            this.cTTERMDataGridViewTextBoxColumn,
            this.cTSEQNUMDataGridViewTextBoxColumn,
            this.cTSTARTTIMEDataGridViewTextBoxColumn,
            this.cTENDTIMEDataGridViewTextBoxColumn,
            this.cTLOCDataGridViewTextBoxColumn,
            this.cTDAYDataGridViewTextBoxColumn});
            this.dataGridViewMakeCT.DataSource = this.pRO1COURSETIMESBindingSource;
            this.dataGridViewMakeCT.Location = new System.Drawing.Point(4, 53);
            this.dataGridViewMakeCT.Name = "dataGridViewMakeCT";
            this.dataGridViewMakeCT.RowTemplate.Height = 23;
            this.dataGridViewMakeCT.Size = new System.Drawing.Size(778, 480);
            this.dataGridViewMakeCT.TabIndex = 7;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRO1COURSETIMESBindingSource
            // 
            this.pRO1COURSETIMESBindingSource.DataMember = "PRO1_COURSETIMES";
            this.pRO1COURSETIMESBindingSource.DataSource = this.dataSet11;
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
            // 
            // cTYEARDataGridViewTextBoxColumn
            // 
            this.cTYEARDataGridViewTextBoxColumn.DataPropertyName = "CT_YEAR";
            this.cTYEARDataGridViewTextBoxColumn.HeaderText = "과목년도";
            this.cTYEARDataGridViewTextBoxColumn.Name = "cTYEARDataGridViewTextBoxColumn";
            // 
            // cTTERMDataGridViewTextBoxColumn
            // 
            this.cTTERMDataGridViewTextBoxColumn.DataPropertyName = "CT_TERM";
            this.cTTERMDataGridViewTextBoxColumn.HeaderText = "과목학기";
            this.cTTERMDataGridViewTextBoxColumn.Name = "cTTERMDataGridViewTextBoxColumn";
            // 
            // cTSEQNUMDataGridViewTextBoxColumn
            // 
            this.cTSEQNUMDataGridViewTextBoxColumn.DataPropertyName = "CT_SEQ_NUM";
            this.cTSEQNUMDataGridViewTextBoxColumn.HeaderText = "시간표번호";
            this.cTSEQNUMDataGridViewTextBoxColumn.Name = "cTSEQNUMDataGridViewTextBoxColumn";
            // 
            // cTSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.cTSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "CT_STARTTIME";
            this.cTSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "시작시간";
            this.cTSTARTTIMEDataGridViewTextBoxColumn.Name = "cTSTARTTIMEDataGridViewTextBoxColumn";
            // 
            // cTENDTIMEDataGridViewTextBoxColumn
            // 
            this.cTENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "CT_ENDTIME";
            this.cTENDTIMEDataGridViewTextBoxColumn.HeaderText = "종료시간";
            this.cTENDTIMEDataGridViewTextBoxColumn.Name = "cTENDTIMEDataGridViewTextBoxColumn";
            // 
            // cTLOCDataGridViewTextBoxColumn
            // 
            this.cTLOCDataGridViewTextBoxColumn.DataPropertyName = "CT_LOC";
            this.cTLOCDataGridViewTextBoxColumn.HeaderText = "강의실위치";
            this.cTLOCDataGridViewTextBoxColumn.Name = "cTLOCDataGridViewTextBoxColumn";
            // 
            // cTDAYDataGridViewTextBoxColumn
            // 
            this.cTDAYDataGridViewTextBoxColumn.DataPropertyName = "CT_DAY";
            this.cTDAYDataGridViewTextBoxColumn.HeaderText = "강의요일";
            this.cTDAYDataGridViewTextBoxColumn.Name = "cTDAYDataGridViewTextBoxColumn";
            // 
            // CreateCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAllDel);
            this.Controls.Add(this.buttonAddByFile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCT);
            this.Controls.Add(this.dataGridViewMakeCT);
            this.MaximumSize = new System.Drawing.Size(784, 538);
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "CreateCT";
            this.Size = new System.Drawing.Size(784, 538);
            this.Load += new System.EventHandler(this.CreateCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMakeCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSETIMESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAllDel;
        private System.Windows.Forms.Button buttonAddByFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCT;
        private System.Windows.Forms.DataGridView dataGridViewMakeCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTSEQNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTLOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRO1COURSETIMESBindingSource;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.PRO1_COURSETIMESTableAdapter pRO1_COURSETIMESTableAdapter;
    }
}
