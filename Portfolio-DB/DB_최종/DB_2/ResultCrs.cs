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
    public partial class ResultCrs : Form
    {
        public ResultCrs()
        {
            InitializeComponent();
        }

        private void ResultCrs_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.PRO1_COURSES' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRO1_COURSESTableAdapter.Fill(this.dataSet11.PRO1_COURSES);

        }
    }
}
