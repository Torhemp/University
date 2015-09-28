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
    public partial class CntStd : UserControl
    {
        private bool avgFlag = false;
        public CntStd()
        {
            InitializeComponent();
        }

        private void dataGridViewCrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cnt = 0;
            oracleConnection1.Open();
            chartCntStd.Series[0].Points.Clear();
            dataGridViewResult.Rows.Clear();
            string mySQL = "SELECT CRS_NUM, CRS_YEAR, CRS_TERM, COUNT(EN_STD_NUM) AS CNT_STD "
                + "FROM PRO1_COURSES LEFT OUTER JOIN PRO1_ENROLLS ON CRS_YEAR = EN_CRS_YEAR AND CRS_TERM = EN_CRS_TERM AND CRS_NUM = EN_CRS_NUM "
                + "GROUP BY CRS_NUM, CRS_YEAR, CRS_TERM";
            oracleCommand1.CommandText = mySQL + " HAVING CRS_NUM IN " + "'" + dataGridViewCrs.CurrentRow.Cells[0].Value.ToString() + "'";
            OracleDataReader rdr1 = oracleCommand1.ExecuteReader();
            while (rdr1.Read())
            {
                dataGridViewResult.Rows.Add();
                dataGridViewResult.Rows[cnt].Cells[0].Value = rdr1["CRS_YEAR"];
                dataGridViewResult.Rows[cnt].Cells[1].Value = rdr1["CRS_TERM"];
                dataGridViewResult.Rows[cnt].Cells[2].Value = rdr1["CNT_STD"];
                chartCntStd.Series[0].Points.AddXY(rdr1["CRS_YEAR"], rdr1["CNT_STD"]);
                cnt++;
            }
            if (!avgFlag)
            {
                oracleCommand2.CommandText = "SELECT CRS_YEAR, CRS_TERM, ROUND(AVG(CNT_STD),0) AS AVG_STD " +
                    "FROM (" + mySQL + ") GROUP BY CRS_YEAR, CRS_TERM";
                OracleDataReader rdr2 = oracleCommand2.ExecuteReader();
                while (rdr2.Read())
                {
                    chartCntStd.Series[1].Points.AddXY(rdr2["CRS_YEAR"], Convert.ToInt32(rdr2["AVG_STD"]));
                }
                avgFlag = true;
                rdr2.Close();
            }
            rdr1.Close();
            oracleConnection1.Close();
        }

        private void CntStd_Load(object sender, EventArgs e)
        {
            pRO1_COURSESTableAdapter.Fill(dataSet11.PRO1_COURSES);
        }
    }
}
