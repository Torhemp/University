using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_2
{
    public partial class InputGrade : UserControl
    {
        private string prf;
        private int prfnum;
        private bool selEventFlag = false;
        public InputGrade(string prfNum)
        {
            InitializeComponent();
            prf = prfNum;
            pRO1_PROFESSORSTableAdapter.Fill(dataSet11.PRO1_PROFESSORS);
        }

        private void InputGrade_Load(object sender, EventArgs e)
        {
            if (prf == "admin")
                MessageBox.Show("관리자 권한으로 접속합니다. 계정과 연동된 자료를 불러오지 않습니다.");
            else
                prfnum = Convert.ToInt32(prf);
            pRO1_COURSESTableAdapter.FillByPrf(dataSet11.PRO1_COURSES, prfnum);
        }

        private void dataGridViewPfsCrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pRO1_ENROLLSTableAdapter.FillBySelectedCrs(dataSet11.PRO1_ENROLLS,
                dataGridViewPfsCrs.CurrentRow.Cells[0].Value.ToString(),
                Convert.ToDecimal(dataGridViewPfsCrs.CurrentRow.Cells[1].Value),
                Convert.ToDecimal(dataGridViewPfsCrs.CurrentRow.Cells[2].Value));
            pRO1_ASSIGNMENTSTableAdapter.FillByCrs(dataSet11.PRO1_ASSIGNMENTS,
                dataGridViewPfsCrs.CurrentRow.Cells[0].Value.ToString(),
                Convert.ToDecimal(dataGridViewPfsCrs.CurrentRow.Cells[1].Value),
                Convert.ToDecimal(dataGridViewPfsCrs.CurrentRow.Cells[2].Value));
            selEventFlag = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //저장 여부 한번 물어봐 주고 저장한다면
            if (MessageBox.Show("입력한 데이터가 저장됩니다. 계속하시겠습니까?", "Save?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //저장하여 변경점이 있다면 저장 후 결과 출력
                try
                {
                    pRO1ENROLLSBindingSource.EndEdit();
                    int retval = pRO1_ENROLLSTableAdapter.Update(dataSet11.PRO1_ENROLLS);
                    if (retval > 0)
                    {
                        if (MessageBox.Show(retval.ToString() + "개 업데이트 성공!\r결과를 확인하시겠습니까?",
                            "결과 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Form frm = new ResultEn();
                            frm.ShowDialog();
                        }
                    }
                    //변경점 없다면 저장하지 않는 메세지 출력
                    else
                    {
                        MessageBox.Show("변경된 데이터가 없습니다.");
                    }
                }
                //그 외의 문제 발생 시 내용 출력
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonLoadByFile_Click(object sender, EventArgs e)
        {
            //xls파일 불러와서 테이블에 저장
            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.xls;Extended Properties='Excel 8.0;HDR=No'";
            DataTable dTable = new DataTable();

            //SQL문을 통한 OleDb로 자료 읽기
            try
            {
                OleDbConnection oleDbCon = new OleDbConnection(strConnection);
                oleDbCon.Open();
                string strSQL = "SELECT * FROM [Grade$]";
                OleDbCommand dbCommand = new OleDbCommand(strSQL, oleDbCon);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dbCommand);

                dataAdapter.Fill(dTable);
                dTable.Dispose();
                dataAdapter.Dispose();
                dbCommand.Dispose();
                oleDbCon.Close();
                oleDbCon.Dispose();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //데이터그리드뷰에 데이터 입력
            for (int i = 0; i < dataGridViewInputGrade.Rows.Count; i++)
            {
                bool dataExistFlag=false;
                int cnt=0;
                foreach(DataRow row in dTable.Rows)
                {
                    if (dataGridViewInputGrade.Rows[i].Cells[0].Value.ToString() == row.ItemArray[0].ToString())
                    {
                        dataExistFlag = true;
                        break;
                    }
                    cnt++;
                }
                if(dataExistFlag)
                {
                    dataGridViewInputGrade.Rows[i].Cells[4].Value=dTable.Rows[cnt].ItemArray[1];
                    dataGridViewInputGrade.Rows[i].Cells[5].Value=dTable.Rows[cnt].ItemArray[2];
                    dataGridViewInputGrade.Rows[i].Cells[6].Value=dTable.Rows[cnt].ItemArray[3];
                    dataGridViewInputGrade.Rows[i].Cells[7].Value=dTable.Rows[cnt].ItemArray[4];
                }
                else{
                    MessageBox.Show("잘못된 정보가 있습니다. 파일을 확인해주세요.");
                    break;
                }
            }
        }

        private void buttonSaveAssignment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("입력한 데이터가 저장됩니다. 계속하시겠습니까?", "Save?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //저장하여 변경점이 있다면 저장 후 결과 출력
                try
                {
                    pRO1ASSIGNMENTSBindingSource.EndEdit();
                    int retval = pRO1_ASSIGNMENTSTableAdapter.Update(dataSet11.PRO1_ASSIGNMENTS);
                    if (retval > 0)
                    {
                        MessageBox.Show(retval.ToString() + "개 업데이트 성공!");
                    }
                    //변경점 없다면 저장하지 않는 메세지 출력
                    else
                    {
                        MessageBox.Show("변경된 데이터가 없습니다.");
                    }
                }
                //그 외의 문제 발생 시 내용 출력
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int maxSeqNum=0;
            int preRowCnt = dataGridViewAssignment.Rows.Count;
            for (int i = 0; i < preRowCnt; i++)
            {
                if (maxSeqNum < Convert.ToInt32(dataGridViewAssignment.Rows[i].Cells[0].Value))
                    maxSeqNum = Convert.ToInt32(dataGridViewAssignment.Rows[i].Cells[0].Value);
            }
            for (int i = 0; i < dataGridViewInputGrade.Rows.Count; i++)
            {
                pRO1ASSIGNMENTSBindingSource.AddNew();
                dataGridViewAssignment.Rows[preRowCnt+i].Cells[0].Value = Convert.ToDecimal(maxSeqNum+1);
                dataGridViewAssignment.Rows[preRowCnt + i].Cells[1].Value = dataGridViewInputGrade.Rows[i].Cells[0].Value;
                dataGridViewAssignment.Rows[preRowCnt + i].Cells[2].Value = dataGridViewPfsCrs.CurrentRow.Cells[0].Value;
                dataGridViewAssignment.Rows[preRowCnt + i].Cells[3].Value = dataGridViewPfsCrs.CurrentRow.Cells[1].Value;
                dataGridViewAssignment.Rows[preRowCnt + i].Cells[4].Value = dataGridViewPfsCrs.CurrentRow.Cells[2].Value;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int maxSeqNum = 0;
            int preRowCnt = dataGridViewAssignment.Rows.Count;
            for (int i = 0; i < preRowCnt; i++)
            {
                if (maxSeqNum < Convert.ToInt32(dataGridViewAssignment.Rows[i].Cells[0].Value))
                    maxSeqNum = Convert.ToInt32(dataGridViewAssignment.Rows[i].Cells[0].Value);
            }
            for(int i=preRowCnt-1; i>=0;i--){
                if (dataGridViewAssignment.Rows[i].Cells[0].Value.ToString() == maxSeqNum.ToString())
                    pRO1ASSIGNMENTSBindingSource.RemoveAt(i);
            }
        }
    }
}
