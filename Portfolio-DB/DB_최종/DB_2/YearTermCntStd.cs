using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DB_2
{
    public partial class YearTermCntStd : UserControl
    {
        public YearTermCntStd()
        {
            InitializeComponent();
        }

        private void YearTermCntStd_Load(object sender, EventArgs e)
        {
            comboBoxYear.Items.Clear();
            oracleConnection1.Open();
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                comboBoxYear.Items.Add(rdr["CRS_YEAR"].ToString());
            }
            oracleConnection1.Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            pRO1_COURSESTableAdapter.FillByYearTerm(dataSet11.PRO1_COURSES, Convert.ToDecimal(comboBoxYear.SelectedItem),
                Convert.ToDecimal(comboBoxTerm.SelectedItem));
        }

        private void dataGridViewCrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCrs.Rows.Count == 0) ;
            else
            {
                string mySQL = "SELECT CRS_NUM, CRS_YEAR, CRS_TERM, CRS_NAME, COUNT(EN_STD_NUM) AS CNT_STD " +
                    "FROM PRO1_COURSES LEFT OUTER JOIN PRO1_ENROLLS ON CRS_YEAR = EN_CRS_YEAR AND CRS_TERM = EN_CRS_TERM AND CRS_NUM = EN_CRS_NUM " +
                    "GROUP BY CRS_NUM, CRS_YEAR, CRS_TERM, CRS_NAME";
                for(int i=0;i<4;i++)
                    chartCntStd.Series[i].Points.Clear();
                oracleConnection1.Open();
                oracleCommand2.CommandText = mySQL +
                    " HAVING CRS_NUM IN '" + dataGridViewCrs.CurrentRow.Cells[0].Value.ToString() + "' " +
                    "AND CRS_YEAR = " + dataGridViewCrs.CurrentRow.Cells[1].Value.ToString() +
                    " AND CRS_TERM = " + dataGridViewCrs.CurrentRow.Cells[2].Value.ToString();
                OracleDataReader rdr1 = oracleCommand2.ExecuteReader();
                rdr1.Read();
                chartCntStd.Series[0].Points.AddXY(rdr1["CRS_NAME"], rdr1["CNT_STD"]);
                rdr1.Close();
                    oracleCommand3.CommandText = "SELECT CRS_YEAR, CRS_TERM, ROUND(AVG(CNT_STD),0) AS AVG_STD " +
                        "FROM (" + mySQL + ") GROUP BY CRS_YEAR, CRS_TERM " +
                        "HAVING CRS_YEAR = " + dataGridViewCrs.CurrentRow.Cells[1].Value.ToString() +
                        " AND CRS_TERM = " + dataGridViewCrs.CurrentRow.Cells[2].Value.ToString(); ;
                    OracleDataReader rdr2 = oracleCommand3.ExecuteReader();
                    rdr2.Read();
                    chartCntStd.Series[1].Points.AddXY("평균 학생 수", rdr2["AVG_STD"]);
                    rdr2.Close();
                    oracleCommand4.CommandText = "SELECT CRS_YEAR, CRS_TERM, MAX(CNT_STD) AS MAX_STD " +
                        "FROM (" + mySQL + ") GROUP BY CRS_YEAR, CRS_TERM " +
                        "HAVING CRS_YEAR = " + dataGridViewCrs.CurrentRow.Cells[1].Value.ToString() +
                        " AND CRS_TERM = " + dataGridViewCrs.CurrentRow.Cells[2].Value.ToString(); ;
                    OracleDataReader rdr3 = oracleCommand4.ExecuteReader();
                    rdr3.Read();
                    chartCntStd.Series[2].Points.AddXY("최고 학생 수", rdr3["MAX_STD"]);
                    rdr3.Close();
                    oracleCommand5.CommandText = "SELECT CRS_YEAR, CRS_TERM, MIN(CNT_STD) AS MIN_STD " +
                        "FROM (" + mySQL + ") GROUP BY CRS_YEAR, CRS_TERM " +
                        "HAVING CRS_YEAR = " + dataGridViewCrs.CurrentRow.Cells[1].Value.ToString() +
                        " AND CRS_TERM = " + dataGridViewCrs.CurrentRow.Cells[2].Value.ToString(); ;
                    OracleDataReader rdr4 = oracleCommand5.ExecuteReader();
                    rdr4.Read();
                    chartCntStd.Series[3].Points.AddXY("최저 학생 수", rdr4["MIN_STD"]);
                    rdr4.Close();
                oracleConnection1.Close();
            }
        }
    }
}
