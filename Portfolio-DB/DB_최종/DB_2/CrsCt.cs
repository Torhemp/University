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
    public partial class CrsCt : Form
    {
        public CrsCt()
        {
            InitializeComponent();
        }

        private void CrsCt_Load(object sender, EventArgs e)
        {
            this.pRO1_PROFESSORSTableAdapter.Fill(this.dataSet11.PRO1_PROFESSORS);
            this.pRO1_COURSESTableAdapter.Fill(this.dataSet11.PRO1_COURSES);
        }

        private void dataGridViewCrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.pRO1_COURSETIMESTableAdapter.FillByCrs(dataSet11.PRO1_COURSETIMES,
                    dataGridViewCrs.CurrentRow.Cells[0].Value.ToString(),
                    Convert.ToDecimal(dataGridViewCrs.CurrentRow.Cells[1].Value),
                    Convert.ToDecimal(dataGridViewCrs.CurrentRow.Cells[2].Value));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
