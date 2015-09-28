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
    public partial class CrsSign : UserControl
    {
        private string stdnum, dept;
        public CrsSign(string stdNum, string deptName)
        {
            InitializeComponent();
            stdnum = stdNum;
            dept = deptName;
        }

        private void crsSign_Load(object sender, EventArgs e)
        {
            int year = 2015;
            int term = 1;
            pRO1_COURSESTableAdapter.FillByYearTerm(dataSet11.PRO1_COURSES, year, term);
            pRO1_ENROLLSTableAdapter.FillByStdYearTerm(dataSet11.PRO1_ENROLLS, Convert.ToDecimal(stdnum), year, term);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int retval;
            if (dataGridViewEnroll.Rows.Count < 3)
            {
                try
                {
                    pRO1ENROLLSBindingSource.AddNew();
                    dataGridViewEnroll.CurrentRow.Cells[0].Value = Convert.ToDecimal(stdnum);
                    dataGridViewEnroll.CurrentRow.Cells[1].Value = dataGridViewCrs.CurrentRow.Cells[0].Value;
                    dataGridViewEnroll.CurrentRow.Cells[2].Value = 2015;
                    dataGridViewEnroll.CurrentRow.Cells[3].Value = 1;
                    if (dept != dataGridViewCrs.CurrentRow.Cells[7].Value.ToString())
                        throw new UserException();
                    pRO1ENROLLSBindingSource.EndEdit();
                    retval = pRO1_ENROLLSTableAdapter.Update(dataSet11.PRO1_ENROLLS);
                    if (retval > 0)
                    {
                        MessageBox.Show("신청 성공!");
                    }
                }
                catch (UserException ex)
                {
                    MessageBox.Show("타전공 과목은 신청 할 수 없습니다.");
                    pRO1ENROLLSBindingSource.RemoveCurrent();
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show("동일 과목은 신청 할 수 없습니다.");
                    pRO1ENROLLSBindingSource.RemoveCurrent();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    pRO1ENROLLSBindingSource.RemoveCurrent();
                }
            }
            else
            {
                MessageBox.Show("과목 개수를 초과하였습니다.");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int retval;
            try
            {
                pRO1ENROLLSBindingSource.RemoveCurrent();
                pRO1ENROLLSBindingSource.EndEdit();
                retval = pRO1_ENROLLSTableAdapter.Update(dataSet11.PRO1_ENROLLS);
                if (retval > 0)
                {
                    MessageBox.Show("삭제 성공!");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
