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
    public partial class ResultEn : Form
    {
        public ResultEn()
        {
            InitializeComponent();
        }

        private void ResultEn_Load(object sender, EventArgs e)
        {
            this.pRO1_ENROLLSTableAdapter.Fill(this.dataSet1.PRO1_ENROLLS);

        }
    }
}
