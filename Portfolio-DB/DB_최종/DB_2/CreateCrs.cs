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
using Oracle.DataAccess.Client;

namespace DB_2
{
    public partial class CreateCrs : UserControl
    {
        public CreateCrs()
        {
            InitializeComponent();
            //그리드뷰 내에서 콤보박스 불러오기 위한 초석
            pRO1_DEPTSTableAdapter.Fill(dataSet11.PRO1_DEPTS);
            pRO1_PROFESSORSTableAdapter.Fill(dataSet11.PRO1_PROFESSORS);
        }

        //추가 버튼 누르면 새로운 행 넣기
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                pRO1COURSESBindingSource.AddNew();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //삭제 버튼 누르면 현재 활성화 된 행 삭제
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                pRO1COURSESBindingSource.RemoveCurrent();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //저장 버튼 누를 시, 데이터베이스로 실제 반영됨
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //저장 여부 한번 물어봐 주고 저장한다면
            if (MessageBox.Show("입력한 데이터가 저장됩니다. 계속하시겠습니까?", "Save?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //저장하여 변경점이 있다면 저장 후 결과 출력
                try
                {
                    pRO1COURSESBindingSource.EndEdit();
                    int retval = pRO1_COURSESTableAdapter.Update(dataSet11.PRO1_COURSES);
                    if (retval > 0)
                    {
                        if (MessageBox.Show(retval.ToString() + "개 업데이트 성공!\r결과를 확인하시겠습니까?",
                            "결과 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Form frm = new ResultCrs();
                            frm.ShowDialog();
                        }
                    }
                    //변경점 없다면 저장하지 않는 메세지 출력
                    else
                    {
                        MessageBox.Show("변경된 데이터가 없습니다.");
                    }
                }
                catch (OracleException ex)
                {
                    if(ex.Message.Substring(4, 5).ToString()=="00001")
                        MessageBox.Show("기존 데이터와 중복된 항목이 있습니다.");
                    else
                        MessageBox.Show(ex.Message);
                }
                //그 외의 문제 발생 시 내용 출력
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //파일에서 불러오기
        private void buttonAddByFile_Click(object sender, EventArgs e)
        {
            //xls파일 불러와서 테이블에 저장
            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.xls;Extended Properties='Excel 8.0;HDR=No'";
            DataTable dTable = new DataTable();
            int rCnt=0;

            //SQL문을 통한 OleDb로 자료 읽기
            try
            {
                OleDbConnection oleDbCon = new OleDbConnection(strConnection);
                oleDbCon.Open();
                string strSQL = "SELECT * FROM [Course$]";
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
            try
            {
                foreach (DataRow row in dTable.Rows)
                {
                    int cnt = 0;
                    pRO1COURSESBindingSource.AddNew();
                    foreach (DataColumn col in dTable.Columns)
                    {
                        dataGridViewMakeCrs.Rows[rCnt].Cells[cnt].Value = dTable.Rows[rCnt].ItemArray[cnt];
                        cnt++;
                    }
                    rCnt++;
                }
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show("완성되지 않은 행이 있습니다. 삭제 후 다시 시도해주세요.");
            }
        }

        private void buttonAllDel_Click(object sender, EventArgs e)
        {
            for (int i = dataGridViewMakeCrs.RowCount-1; i >= 0; i--)
                dataGridViewMakeCrs.Rows.RemoveAt(i);
        }

        private void CreateCrs_Load(object sender, EventArgs e)
        {
            MessageBox.Show("파일 불러오기 사용 시 Crs.xls파일에 데이터만 순서대로 입력해주세요!");
        }
    }
}