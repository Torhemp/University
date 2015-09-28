namespace DB_2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.과목개설ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.성적입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수강신청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.교수검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.학생성적ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.학생검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.분석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.과목별분석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.과목별성적분포ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기간별학생수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.시간표ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem,
            this.입력ToolStripMenuItem,
            this.검색ToolStripMenuItem,
            this.분석ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem1,
            this.로그아웃ToolStripMenuItem});
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.로그인ToolStripMenuItem.Text = "계정";
            // 
            // 로그인ToolStripMenuItem1
            // 
            this.로그인ToolStripMenuItem1.Name = "로그인ToolStripMenuItem1";
            this.로그인ToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+N";
            this.로그인ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.로그인ToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.로그인ToolStripMenuItem1.Text = "로그인";
            this.로그인ToolStripMenuItem1.Click += new System.EventHandler(this.로그인ToolStripMenuItem1_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // 입력ToolStripMenuItem
            // 
            this.입력ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.과목개설ToolStripMenuItem,
            this.성적입력ToolStripMenuItem,
            this.수강신청ToolStripMenuItem,
            this.시간표ToolStripMenuItem});
            this.입력ToolStripMenuItem.Name = "입력ToolStripMenuItem";
            this.입력ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.입력ToolStripMenuItem.Text = "입력 및 수정";
            // 
            // 과목개설ToolStripMenuItem
            // 
            this.과목개설ToolStripMenuItem.Name = "과목개설ToolStripMenuItem";
            this.과목개설ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.과목개설ToolStripMenuItem.Text = "과목개설";
            this.과목개설ToolStripMenuItem.Click += new System.EventHandler(this.과목개설ToolStripMenuItem_Click);
            // 
            // 성적입력ToolStripMenuItem
            // 
            this.성적입력ToolStripMenuItem.Name = "성적입력ToolStripMenuItem";
            this.성적입력ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.성적입력ToolStripMenuItem.Text = "성적입력";
            this.성적입력ToolStripMenuItem.Click += new System.EventHandler(this.성적입력ToolStripMenuItem_Click);
            // 
            // 수강신청ToolStripMenuItem
            // 
            this.수강신청ToolStripMenuItem.Name = "수강신청ToolStripMenuItem";
            this.수강신청ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.수강신청ToolStripMenuItem.Text = "수강신청";
            this.수강신청ToolStripMenuItem.Click += new System.EventHandler(this.수강신청ToolStripMenuItem_Click);
            // 
            // 검색ToolStripMenuItem
            // 
            this.검색ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.교수검색ToolStripMenuItem,
            this.학생성적ToolStripMenuItem,
            this.학생검색ToolStripMenuItem});
            this.검색ToolStripMenuItem.Name = "검색ToolStripMenuItem";
            this.검색ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.검색ToolStripMenuItem.Text = "검색";
            // 
            // 교수검색ToolStripMenuItem
            // 
            this.교수검색ToolStripMenuItem.Name = "교수검색ToolStripMenuItem";
            this.교수검색ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.교수검색ToolStripMenuItem.Text = "교수검색";
            this.교수검색ToolStripMenuItem.Click += new System.EventHandler(this.교수검색ToolStripMenuItem_Click);
            // 
            // 학생성적ToolStripMenuItem
            // 
            this.학생성적ToolStripMenuItem.Name = "학생성적ToolStripMenuItem";
            this.학생성적ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.학생성적ToolStripMenuItem.Text = "학생세부성적";
            this.학생성적ToolStripMenuItem.Click += new System.EventHandler(this.학생성적ToolStripMenuItem_Click);
            // 
            // 학생검색ToolStripMenuItem
            // 
            this.학생검색ToolStripMenuItem.Name = "학생검색ToolStripMenuItem";
            this.학생검색ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.학생검색ToolStripMenuItem.Text = "학생검색";
            this.학생검색ToolStripMenuItem.Click += new System.EventHandler(this.학생검색ToolStripMenuItem_Click);
            // 
            // 분석ToolStripMenuItem
            // 
            this.분석ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.과목별분석ToolStripMenuItem,
            this.과목별성적분포ToolStripMenuItem,
            this.기간별학생수ToolStripMenuItem});
            this.분석ToolStripMenuItem.Name = "분석ToolStripMenuItem";
            this.분석ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.분석ToolStripMenuItem.Text = "분석";
            // 
            // 과목별분석ToolStripMenuItem
            // 
            this.과목별분석ToolStripMenuItem.Name = "과목별분석ToolStripMenuItem";
            this.과목별분석ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.과목별분석ToolStripMenuItem.Text = "과목별 학생 수";
            this.과목별분석ToolStripMenuItem.Click += new System.EventHandler(this.과목별분석ToolStripMenuItem_Click);
            // 
            // 과목별성적분포ToolStripMenuItem
            // 
            this.과목별성적분포ToolStripMenuItem.Name = "과목별성적분포ToolStripMenuItem";
            this.과목별성적분포ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.과목별성적분포ToolStripMenuItem.Text = "과목별 성적분포";
            this.과목별성적분포ToolStripMenuItem.Click += new System.EventHandler(this.과목별성적분포ToolStripMenuItem_Click);
            // 
            // 기간별학생수ToolStripMenuItem
            // 
            this.기간별학생수ToolStripMenuItem.Name = "기간별학생수ToolStripMenuItem";
            this.기간별학생수ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.기간별학생수ToolStripMenuItem.Text = "기간별 학생 수";
            this.기간별학생수ToolStripMenuItem.Click += new System.EventHandler(this.기간별학생수ToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 538);
            this.MainPanel.TabIndex = 1;
            // 
            // 시간표ToolStripMenuItem
            // 
            this.시간표ToolStripMenuItem.Name = "시간표ToolStripMenuItem";
            this.시간표ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.시간표ToolStripMenuItem.Text = "시간표";
            this.시간표ToolStripMenuItem.Click += new System.EventHandler(this.시간표ToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 과목개설ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 성적입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수강신청ToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem 교수검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 학생성적ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 분석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 과목별분석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 과목별성적분포ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기간별학생수ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 학생검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간표ToolStripMenuItem;
    }
}

