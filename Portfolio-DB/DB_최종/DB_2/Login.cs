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
    public partial class Login : UserControl
    {
        public int userFlag = 0;
        public string Id;
        public string Pw;
        public string dept;
    
        public Login()
        {
            InitializeComponent();
        }

        //로그인 버튼 누르면
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form1 frm = this.ParentForm as Form1;
            //ID, PW 받아옴
            Id = textBoxId.Text;
            Pw = textBoxPw.Text;
            
            //입력 안되면 경고창
            if (Id.Length == 0 || Pw.Length == 0)
            {
                MessageBox.Show("ID 또는 패스워드가 입력되지 않았습니다.");
                userFlag = 0;
            }

            //어드민으로 접속 시 어드민 플래그 온
            else if (Id == "admin" && Pw == "qwer")
            {
                MessageBox.Show(Id + "님 환영합니다!");
                userFlag = 3;
                textBoxId.Text = "";
                textBoxPw.Text = "";
                frm.Load_Main();
            }
            
            //학생, 교수의 경우
            else
            {
                //학생, 교수 데이터 불러오기
                oracleConnection1.Open();
                oracleDataAdapter1.Fill(dataSet11, "PRO1_STUDENTS");
                oracleConnection1.Close();
                oracleConnection2.Open();
                oracleDataAdapter2.Fill(dataSet11, "PRO1_PROFESSORS");
                oracleConnection2.Close();
                DataTable sTable = dataSet11.Tables["PRO1_STUDENTS"];
                DataTable pTable = dataSet11.Tables["PRO1_PROFESSORS"];

                //학생 먼저 찾아보기
                foreach (DataRow sDataRow in sTable.Rows)
                {
                    //일치하면 접속 허가 및 학생 플래그 온
                    if (Id == sDataRow["STD_NUM"].ToString() && Pw == sDataRow["STD_PASSWORD"].ToString())
                    {
                        MessageBox.Show(sDataRow["STD_NAME"].ToString() + "님 환영합니다!");
                        dept = sDataRow["STD_DEPT_NAME"].ToString();
                        userFlag = 1;
                        break;
                    }
                }

                
                //교수 찾아보기
                foreach (DataRow pDataRow in pTable.Rows)
                {
                    if (Id == pDataRow["PRF_NUM"].ToString() && Pw == pDataRow["PRF_PASSWORD"].ToString())
                    {
                        MessageBox.Show(pDataRow["PRF_NAME"] + "님 환영합니다!");
                        dept = pDataRow["PRF_DEPT_NAME"].ToString();
                        userFlag = 2;
                        break;
                    }
                }

                //아무도 없으면
                if (userFlag == 0)
                {
                    MessageBox.Show("Id 또는 비밀번호가 잘못되었습니다.");
                    userFlag = 0;
                }
                else
                {
                    textBoxId.Text = "";
                    textBoxPw.Text = "";
                    Pw = textBoxPw.Text;
                    frm.Load_Main();
                }
            }
        }

        //엔터키 입력으로 로그인 버튼 기능 수행
        private void textBoxPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                buttonLogin.PerformClick();
        }
    }
}
