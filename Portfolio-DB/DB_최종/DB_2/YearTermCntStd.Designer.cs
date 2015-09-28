namespace DB_2
{
    partial class YearTermCntStd
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewCrs = new System.Windows.Forms.DataGridView();
            this.cRSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSDEPTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSPRFNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRO1COURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DB_2.DataSet1();
            this.label = new System.Windows.Forms.Label();
            this.chartCntStd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCrsYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.pRO1_COURSESTableAdapter = new DB_2.DataSet1TableAdapters.PRO1_COURSESTableAdapter();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand3 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand4 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand5 = new Oracle.DataAccess.Client.OracleCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntStd)).BeginInit();
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
            this.cRSDEPTNAMEDataGridViewTextBoxColumn,
            this.cRSPRFNUMDataGridViewTextBoxColumn});
            this.dataGridViewCrs.DataSource = this.pRO1COURSESBindingSource;
            this.dataGridViewCrs.Location = new System.Drawing.Point(3, 49);
            this.dataGridViewCrs.Name = "dataGridViewCrs";
            this.dataGridViewCrs.ReadOnly = true;
            this.dataGridViewCrs.RowTemplate.Height = 23;
            this.dataGridViewCrs.Size = new System.Drawing.Size(544, 137);
            this.dataGridViewCrs.TabIndex = 10;
            this.dataGridViewCrs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCrs_CellClick);
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
            this.cRSPRFNUMDataGridViewTextBoxColumn.HeaderText = "담당교수";
            this.cRSPRFNUMDataGridViewTextBoxColumn.Name = "cRSPRFNUMDataGridViewTextBoxColumn";
            this.cRSPRFNUMDataGridViewTextBoxColumn.ReadOnly = true;
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("휴먼편지체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(3, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(249, 43);
            this.label.TabIndex = 8;
            this.label.Text = "기간별 학생분포";
            // 
            // chartCntStd
            // 
            this.chartCntStd.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartCntStd.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCntStd.Legends.Add(legend1);
            this.chartCntStd.Location = new System.Drawing.Point(3, 191);
            this.chartCntStd.Name = "chartCntStd";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "과목 학생수";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.LegendText = "평균 학생수";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.LegendText = "최고 학생수";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.LegendText = "최저 학생수";
            series4.Name = "Series4";
            this.chartCntStd.Series.Add(series1);
            this.chartCntStd.Series.Add(series2);
            this.chartCntStd.Series.Add(series3);
            this.chartCntStd.Series.Add(series4);
            this.chartCntStd.Size = new System.Drawing.Size(770, 344);
            this.chartCntStd.TabIndex = 11;
            this.chartCntStd.Text = "chart1";
            // 
            // labelCrsYear
            // 
            this.labelCrsYear.AutoSize = true;
            this.labelCrsYear.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCrsYear.Location = new System.Drawing.Point(566, 49);
            this.labelCrsYear.Name = "labelCrsYear";
            this.labelCrsYear.Size = new System.Drawing.Size(52, 22);
            this.labelCrsYear.TabIndex = 12;
            this.labelCrsYear.Text = "년도 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(566, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "학기 :";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(624, 49);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(129, 20);
            this.comboBoxYear.TabIndex = 14;
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxTerm.Location = new System.Drawing.Point(624, 95);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(51, 20);
            this.comboBoxTerm.TabIndex = 15;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonLoad.Location = new System.Drawing.Point(570, 143);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(105, 42);
            this.buttonLoad.TabIndex = 16;
            this.buttonLoad.Text = "과목 출력";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORAORA;USER ID=S5049986; PASSWORD=s5049986";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.CommandText = "SELECT DISTINCT CRS_YEAR FROM PRO1_COURSES";
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // pRO1_COURSESTableAdapter
            // 
            this.pRO1_COURSESTableAdapter.ClearBeforeFill = true;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            this.oracleCommand2.Transaction = null;
            // 
            // oracleCommand3
            // 
            this.oracleCommand3.Connection = this.oracleConnection1;
            this.oracleCommand3.Transaction = null;
            // 
            // oracleCommand4
            // 
            this.oracleCommand4.Connection = this.oracleConnection1;
            this.oracleCommand4.Transaction = null;
            // 
            // oracleCommand5
            // 
            this.oracleCommand5.Connection = this.oracleConnection1;
            this.oracleCommand5.Transaction = null;
            // 
            // YearTermCntStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.comboBoxTerm);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCrsYear);
            this.Controls.Add(this.chartCntStd);
            this.Controls.Add(this.dataGridViewCrs);
            this.Controls.Add(this.label);
            this.MaximumSize = new System.Drawing.Size(784, 538);
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "YearTermCntStd";
            this.Size = new System.Drawing.Size(784, 538);
            this.Load += new System.EventHandler(this.YearTermCntStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRO1COURSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCntStd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCrs;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.BindingSource pRO1COURSESBindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCntStd;
        private DataSet1TableAdapters.PRO1_COURSESTableAdapter pRO1_COURSESTableAdapter;
        private System.Windows.Forms.Label labelCrsYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.Button buttonLoad;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSDEPTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSPRFNUMDataGridViewTextBoxColumn;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand3;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand4;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand5;
    }
}
