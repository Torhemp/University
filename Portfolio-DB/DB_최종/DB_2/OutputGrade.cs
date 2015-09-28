using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DB_2
{
    public partial class OutputGrade : Form
    {
        private string stdNum;
        public OutputGrade(string num)
        {
            InitializeComponent();
            stdNum = num;
        }

        private void OutputGrade_Load(object sender, EventArgs e)
        {
            int cnt = 0, sum = 0;
            double score = 0;
            this.pRO1_STUDENTSTableAdapter.Fill(dataSet11.PRO1_STUDENTS);
            DataTable dTable = dataSet11.PRO1_STUDENTS;
            foreach (DataRow row in dTable.Rows)
            {
                if (row.ItemArray[0].ToString() == stdNum)
                    break;
                cnt++;
            }
            if (cnt >= dTable.Rows.Count)
            {
                MessageBox.Show("존재하지 않는 학번입니다.");
                this.Close();
            }
            else
            {
                DataTable eTable = pRO1_ENROLLSTableAdapter.GetDataByStdDesY(
                    Convert.ToDecimal(stdNum));
                for (int i = 0; i < eTable.Rows.Count; i++)
                {
                    dataGridViewEnroll.Rows.Add();
                    dataGridViewEnroll.Rows[i].Cells[0].Value = eTable.Rows[i].ItemArray[0];
                    dataGridViewEnroll.Rows[i].Cells[1].Value = eTable.Rows[i].ItemArray[1];
                    dataGridViewEnroll.Rows[i].Cells[2].Value = eTable.Rows[i].ItemArray[2];
                    dataGridViewEnroll.Rows[i].Cells[3].Value = eTable.Rows[i].ItemArray[3];
                    dataGridViewEnroll.Rows[i].Cells[4].Value = eTable.Rows[i].ItemArray[10];
                    dataGridViewEnroll.Rows[i].Cells[5].Value = eTable.Rows[i].ItemArray[4];
                    dataGridViewEnroll.Rows[i].Cells[6].Value = eTable.Rows[i].ItemArray[9];
                }

                labelOutputStdNum.Text = dTable.Rows[cnt].ItemArray[0].ToString();
                labelStdName.Text = dTable.Rows[cnt].ItemArray[12].ToString();
                labelStdDept.Text = dTable.Rows[cnt].ItemArray[10].ToString();
                labelStdYear.Text = dTable.Rows[cnt].ItemArray[2].ToString();

                for (int i = 0; i < dataGridViewEnroll.Rows.Count; i++)
                {
                    switch (dataGridViewEnroll.Rows[i].Cells[5].Value.ToString())
                    {
                        case "A":
                            sum += 4;
                            break;
                        case "B":
                            sum += 3;
                            break;
                        case "C":
                            sum += 2;
                            break;
                        case "D":
                            sum += 1;
                            break;
                        case "F":
                            sum += 0;
                            break;
                    }
                }
                score = Convert.ToDouble(sum) / Convert.ToDouble(dataGridViewEnroll.Rows.Count);

                labelStdScore.Text = score.ToString("#.0");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"성적증명서.txt", false))
                {
                    file.WriteLine("성적증명서");
                    file.WriteLine(labelStdNum.Text + " " + labelOutputStdNum.Text);
                    file.WriteLine(labelName.Text + " " + labelStdName.Text);
                    file.WriteLine(labelDept.Text + " " + labelStdDept.Text);
                    file.WriteLine(labelYear.Text + " " + labelStdYear.Text);
                    file.WriteLine(labelScore.Text + " " + labelStdScore.Text);
                    file.WriteLine("과목번호  과목년도  과목학기 과목성적       과목이름");
                    for (int i = 0; i < dataGridViewEnroll.Rows.Count; i++)
                    {
                        file.Write(dataGridViewEnroll.Rows[i].Cells[1].Value);
                        file.Write("    ");
                        file.Write(dataGridViewEnroll.Rows[i].Cells[2].Value);
                        file.Write("       ");
                        file.Write(dataGridViewEnroll.Rows[i].Cells[3].Value);
                        file.Write("        ");
                        file.Write(dataGridViewEnroll.Rows[i].Cells[5].Value);
                        file.Write("    ");
                        file.Write(string.Format("{0,11}", dataGridViewEnroll.Rows[i].Cells[4].Value));
                        file.WriteLine("");
                    }
                }
                MessageBox.Show("파일 저장 성공!");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
