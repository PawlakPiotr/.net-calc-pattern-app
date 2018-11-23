using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc.Forms;

namespace Calc.Forms.History
{
    public partial class History : Form
    {
        List<KeyValuePair<string, DateTime>> history;

        public History()
        {
            InitializeComponent();
            history = CalcForm.history;
        }

        private void History_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clrHistory_Click(object sender, EventArgs e)
        {
            history.Clear();
            historyGrid.DataSource = null;
        }
    }
}
