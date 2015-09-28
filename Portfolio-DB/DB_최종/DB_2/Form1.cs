using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_2
{
    public partial class Form1 : Form
    {
        Login login = new Login();
        CreateCrs createCrs = new CreateCrs();
        InputGrade inputGrade;
        CrsSign crsSign;

        public Form1()
        {
            InitializeComponent();
            Load_Main();
        }

        private void 로그인ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (login.userFlag == 0)
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(login);
            }
            else
                MessageBox.Show("이미 로그인되어 있습니다.");
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.userFlag == 0)
                MessageBox.Show("아직 로그인하지 않았습니다!");
            else
            {
                login.userFlag = 0;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(login);
            }
        }

        public void Load_Main(){
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Main());
        }

        private void 과목개설ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (login.userFlag)
            {
                case 0:
                    MessageBox.Show("아직 로그인하지 않았습니다.");
                    break;
                case 1:
                    MessageBox.Show("학생은 접근할 수 없는 정보입니다.");
                    break;
                case 2:
                    MessageBox.Show("교수가 접근할 수 없는 정보입니다.");
                    break;
                case 3:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(createCrs);
                    break;
                default:
                    break;
            }
        }

        private void 성적입력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputGrade = new InputGrade(login.Id);
            switch (login.userFlag)
            {
                case 0:
                    MessageBox.Show("아직 로그인하지 않았습니다.");
                    break;
                case 1:
                    MessageBox.Show("학생은 접근할 수 없는 정보입니다.");
                    break;
                case 2:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(inputGrade);
                    break;
                case 3:
                    MessageBox.Show("관리자가 접근할 수 없는 정보입니다.");
                    break;
                default:
                    break;
            }
        }

        private void 수강신청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crsSign = new CrsSign(login.Id, login.dept);
            switch (login.userFlag)
            {
                case 0:
                    MessageBox.Show("아직 로그인하지 않았습니다.");
                    break;
                case 1:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(crsSign);
                    break;
                case 2:
                    MessageBox.Show("교수는 접근할 수 없는 정보입니다.");
                    break;
                case 3:
                    MessageBox.Show("관리자가 접근할 수 없는 정보입니다.");
                    break;
                default:
                    break;
            }
        }

        private void 교수검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.userFlag == 0)
                MessageBox.Show("먼저 로그인부터 해주세요.");
            else
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(new SearchPrf());
            }
        }

        private void 학생성적ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (login.userFlag)
            {
                case 0:
                    MessageBox.Show("로그인이 되어있지 않습니다.");
                    break;
                case 1:
                    MessageBox.Show("학생은 본인 정보만 확인할 수 있습니다.");
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(new SearchStdGrade(login.userFlag, login.Id));
                    break;
                case 2:
                case 3:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(new SearchStdGrade(login.userFlag, login.Id));
                    break;
            }
        }

        private void 과목별분석ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.userFlag == 0)
                MessageBox.Show("먼저 로그인부터 해주세요.");
            else
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(new CntStd());
            }
        }

        private void 과목별성적분포ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.userFlag == 0)
                MessageBox.Show("먼저 로그인부터 해주세요.");
            else
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(new CrsGrade());
            }
        }

        private void 기간별학생수ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.userFlag == 0)
                MessageBox.Show("먼저 로그인부터 해주세요.");
            else
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(new YearTermCntStd());
            }
        }

        private void 학생검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.userFlag == 0)
                MessageBox.Show("먼저 로그인부터 해주세요.");
            else
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(new SearchStd());
            }
        }

        private void 시간표ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            switch (login.userFlag)
            {
                case 0:
                    MessageBox.Show("아직 로그인하지 않았습니다.");
                    break;
                case 1:
                    MessageBox.Show("학생은 접근할 수 없는 정보입니다.");
                    break;
                case 2:
                    MessageBox.Show("교수가 접근할 수 없는 정보입니다.");
                    break;
                case 3:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(new CreateCT());
                    break;
                default:
                    break;
            }
        }
    }
}
