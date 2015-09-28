using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_2
{
    public partial class SearchStd : UserControl
    {
        public SearchStd()
        {
            InitializeComponent();
        }

        private void SearchStd_Load(object sender, EventArgs e)
        {
            pictureBoxStd.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text == "")
                pRO1_STUDENTSTableAdapter.Fill(dataSet11.PRO1_STUDENTS);
            else
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "학번":
                        pRO1_STUDENTSTableAdapter.FillByStdNum(dataSet11.PRO1_STUDENTS, Convert.ToDecimal(textBoxValue.Text));
                        break;
                    case "이름":
                        pRO1_STUDENTSTableAdapter.FillByStdName(dataSet11.PRO1_STUDENTS, textBoxValue.Text);
                        break;
                    case "입학년도":
                        pRO1_STUDENTSTableAdapter.FillByStdYear(dataSet11.PRO1_STUDENTS, Convert.ToDecimal(textBoxValue.Text));
                        break;
                    case "성별":
                        pRO1_STUDENTSTableAdapter.FillByStdGender(dataSet11.PRO1_STUDENTS, textBoxValue.Text);
                        break;
                    case "학과":
                        pRO1_STUDENTSTableAdapter.FillByDept(dataSet11.PRO1_STUDENTS, textBoxValue.Text);
                        break;
                    default:
                        pRO1_STUDENTSTableAdapter.Fill(dataSet11.PRO1_STUDENTS);
                        break;
                }
            }
            if (dataGridViewStd.Rows.Count == 0)
                MessageBox.Show("검색결과가 존재하지 않습니다.");
        }

        private void dataGridViewStd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStd.Rows.Count==0);
            else
            {
                dataGridViewEnroll.Rows.Clear();
                int cnt = 0;
                DataTable dTable = pRO1_COURSESTableAdapter.GetDataByStdJoinEnroll(
                    Convert.ToDecimal(dataGridViewStd.CurrentRow.Cells[0].Value));
                DataTable sTable = dataSet11.PRO1_STUDENTS;
                foreach (DataRow row in dTable.Rows)
                {
                    dataGridViewEnroll.Rows.Add();
                    dataGridViewEnroll.Rows[cnt].Cells[0].Value = dTable.Rows[cnt].ItemArray[9];
                    dataGridViewEnroll.Rows[cnt].Cells[1].Value = dTable.Rows[cnt].ItemArray[0];
                    dataGridViewEnroll.Rows[cnt].Cells[2].Value = dTable.Rows[cnt].ItemArray[1];
                    dataGridViewEnroll.Rows[cnt].Cells[3].Value = dTable.Rows[cnt].ItemArray[2];
                    dataGridViewEnroll.Rows[cnt].Cells[4].Value = dTable.Rows[cnt].ItemArray[3];
                    cnt++;
                }
                cnt = 0;
                foreach (DataRow row in dTable.Rows)
                {
                    if (row.ItemArray[0].ToString() == dataGridViewStd.CurrentRow.Cells[0].Value.ToString())
                        break;
                    cnt++;
                }
                labelNameStd.Text = sTable.Rows[cnt].ItemArray[12].ToString();
                labelYearStd.Text = sTable.Rows[cnt].ItemArray[2].ToString() + "년";
                if (sTable.Rows[cnt].ItemArray[5].ToString() == "M")
                    labelGenderStd.Text = "남성";
                else
                    labelGenderStd.Text = "여성";
                labelDeptStd.Text = sTable.Rows[cnt].ItemArray[10].ToString();
                labelEmailStd.Text = sTable.Rows[cnt].ItemArray[6].ToString();
                labelPhoneStd.Text = sTable.Rows[cnt].ItemArray[4].ToString();
                labelLocStd.Text = sTable.Rows[cnt].ItemArray[1].ToString();
                pictureBoxStd.Visible = true;
            }
        }

        private void dataGridViewEnroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEnroll.Rows.Count == 0) ;
            else
            {
                dataGridViewEnrollStd.Rows.Clear();
                int cnt = 0;
                DataTable dTable = pRO1_ENROLLSTableAdapter.GetDataByCrsJoinStd(
                    dataGridViewEnroll.CurrentRow.Cells[1].Value.ToString(),
                    Convert.ToDecimal(dataGridViewEnroll.CurrentRow.Cells[2].Value),
                    Convert.ToDecimal(dataGridViewEnroll.CurrentRow.Cells[3].Value));
                foreach (DataRow row in dTable.Rows)
                {
                    dataGridViewEnrollStd.Rows.Add();
                    dataGridViewEnrollStd.Rows[cnt].Cells[0].Value = dTable.Rows[cnt].ItemArray[0];
                    dataGridViewEnrollStd.Rows[cnt].Cells[1].Value = dTable.Rows[cnt].ItemArray[8];
                    dataGridViewEnrollStd.Rows[cnt].Cells[2].Value = dTable.Rows[cnt].ItemArray[1];
                    dataGridViewEnrollStd.Rows[cnt].Cells[3].Value = dTable.Rows[cnt].ItemArray[2];
                    dataGridViewEnrollStd.Rows[cnt].Cells[4].Value = dTable.Rows[cnt].ItemArray[3];
                    cnt++;
                }
            }
        }
    }
}
