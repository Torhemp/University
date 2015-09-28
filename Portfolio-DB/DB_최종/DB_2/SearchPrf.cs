using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace DB_2
{
    public partial class SearchPrf : UserControl
    {
        public SearchPrf()
        {
            InitializeComponent();
        }

        private void SearchPrf_Load(object sender, EventArgs e)
        {
            pRO1_DEPTSTableAdapter.Fill(dataSet11.PRO1_DEPTS);
        }

        private void dataGridViewDept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pRO1_PROFESSORSTableAdapter.Fill(dataSet11.PRO1_PROFESSORS);
            labelDeptPrf.Text = "";
            labelEmailPrf.Text = "";
            labelPhonePrf.Text = "";
            labelNamePrf.Text = "";
            labelYearPrf.Text = "";
            labelGenderPrf.Text = "";
            pictureBoxPrf.Visible = false;
        }

        private void dataGridViewPrf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBoxPrf.Visible = true;
            int cnt=0;
            DataTable dTable = dataSet11.PRO1_PROFESSORS;
            foreach(DataRow row in dTable.Rows){
                if(row.ItemArray[0].ToString()==dataGridViewPrf.CurrentRow.Cells[0].Value.ToString())
                    break;
                cnt++;
            }
            try
            {
                labelNamePrf.Text = dTable.Rows[cnt].ItemArray[1].ToString();
                labelYearPrf.Text = dTable.Rows[cnt].ItemArray[2].ToString() + "년";
                if (dTable.Rows[cnt].ItemArray[4].ToString() == "M")
                    labelGenderPrf.Text = "남성";
                else
                    labelGenderPrf.Text = "여성";
                labelDeptPrf.Text = dTable.Rows[cnt].ItemArray[8].ToString();
                labelEmailPrf.Text = dTable.Rows[cnt].ItemArray[5].ToString();
                labelPhonePrf.Text = dTable.Rows[cnt].ItemArray[3].ToString();
                pRO1_COURSESTableAdapter.FillByOrderYear(dataSet11.PRO1_COURSES);
            }
            catch (IndexOutOfRangeException ex)
            {
            }
        }
    }
}
