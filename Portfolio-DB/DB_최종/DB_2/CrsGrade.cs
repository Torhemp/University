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
    public partial class CrsGrade : UserControl
    {
        public CrsGrade()
        {
            InitializeComponent();
        }

        private void CrsGrade_Load(object sender, EventArgs e)
        {
            pRO1_COURSESTableAdapter.Fill(dataSet11.PRO1_COURSES);
        }

        private void dataGridViewCrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cnt=0;
            for (int i = 0; i < 5; i++)
            {
                chartCrsGrade.Series[i].Points.Clear();
            }
            dataGridViewCrsGrade.Rows.Clear();
            oracleConnection1.Open();
            oracleCommand1.CommandText = "SELECT EN_CRS_NUM, EN_CRS_YEAR, EN_CRS_TERM, COUNT(DECODE(EN_GRADE, 'A', 1)) AS A, " +
                "COUNT(DECODE(EN_GRADE, 'B', 1)) AS B, COUNT(DECODE(EN_GRADE, 'C', 1)) AS C, " +
                "COUNT(DECODE(EN_GRADE, 'D', 1)) AS D, COUNT(DECODE(EN_GRADE, 'F', 1)) AS F " +
                "FROM PRO1_ENROLLS GROUP BY EN_CRS_NUM, EN_CRS_YEAR, EN_CRS_TERM " +
                "HAVING EN_CRS_NUM = '" + dataGridViewCrs.CurrentRow.Cells[0].Value.ToString() + "'";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                dataGridViewCrsGrade.Rows.Add();
                dataGridViewCrsGrade.Rows[cnt].Cells[0].Value = rdr["EN_CRS_YEAR"];
                dataGridViewCrsGrade.Rows[cnt].Cells[1].Value = rdr["A"];
                dataGridViewCrsGrade.Rows[cnt].Cells[2].Value = rdr["B"];
                dataGridViewCrsGrade.Rows[cnt].Cells[3].Value = rdr["C"];
                dataGridViewCrsGrade.Rows[cnt].Cells[4].Value = rdr["D"];
                dataGridViewCrsGrade.Rows[cnt].Cells[5].Value = rdr["F"];
                chartCrsGrade.Series[0].Points.AddXY(rdr["EN_CRS_YEAR"], rdr["A"]);
                chartCrsGrade.Series[1].Points.AddXY(rdr["EN_CRS_YEAR"], rdr["B"]);
                chartCrsGrade.Series[2].Points.AddXY(rdr["EN_CRS_YEAR"], rdr["C"]);
                chartCrsGrade.Series[3].Points.AddXY(rdr["EN_CRS_YEAR"], rdr["D"]);
                chartCrsGrade.Series[4].Points.AddXY(rdr["EN_CRS_YEAR"], rdr["F"]);
                cnt++;
            }
            rdr.Close();
            oracleConnection1.Close();
        }
    }
}
