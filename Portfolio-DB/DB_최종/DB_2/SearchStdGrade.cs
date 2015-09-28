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
    public partial class SearchStdGrade : UserControl
    {
        private int userFlag;
        private string stdNum;
        public SearchStdGrade(int uF, string Id)
        {
            InitializeComponent();
            userFlag = uF;
            stdNum = Id;
        }

        private void SearchStd_Load(object sender, EventArgs e)
        {
            if (userFlag == 1)
            {
                pRO1_COURSESTableAdapter.Fill(dataSet11.PRO1_COURSES);
                pRO1_ENROLLSTableAdapter.FillByStd(dataSet11.PRO1_ENROLLS, Convert.ToDecimal(stdNum));
            }
        }

        private void dataGridViewCrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEnroll.Rows.Count == 0) ;
            else
            {
                pRO1_STUDENTSTableAdapter.Fill(dataSet11.PRO1_STUDENTS);
                pRO1_ASSIGNMENTSTableAdapter.FillByStdCrs(dataSet11.PRO1_ASSIGNMENTS,
                    Convert.ToDecimal(dataGridViewEnroll.CurrentRow.Cells[0].Value),
                    dataGridViewEnroll.CurrentRow.Cells[1].Value.ToString(),
                    Convert.ToDecimal(dataGridViewEnroll.CurrentRow.Cells[3].Value),
                    Convert.ToDecimal(dataGridViewEnroll.CurrentRow.Cells[4].Value));
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (userFlag == 1)
            {
                MessageBox.Show("학생은 다른 학생의 성적을 검색할 수 없습니다.");
            }
            else if (textBoxStd.Text == "")
            {
                MessageBox.Show("학번을 입력해주세요");
            }
            else
            {
                pRO1_COURSESTableAdapter.Fill(dataSet11.PRO1_COURSES);
                pRO1_ENROLLSTableAdapter.FillByStd(dataSet11.PRO1_ENROLLS, Convert.ToDecimal(textBoxStd.Text));
                if (dataGridViewEnroll.Rows.Count == 0)
                    MessageBox.Show("검색된 결과 값이 없습니다.");
            }
        }

        private void buttonOutputGrade_Click(object sender, EventArgs e)
        {
            if (userFlag == 1)
            {
                new OutputGrade(stdNum).ShowDialog();
            }
            else if (userFlag == 3)
            {
                if (textBoxStd.Text == "")
                    MessageBox.Show("학번을 입력해주세요");
                else
                    new OutputGrade(textBoxStd.Text).ShowDialog();
            }
            else
                MessageBox.Show("성적증명을 할 수 없는 계정입니다.");
        }
    }
}
