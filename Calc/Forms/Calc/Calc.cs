using Calc.Forms.History;
using Calc.Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calc
{
    public partial class CalcForm : Form
    {
        public static List<KeyValuePair<string, DateTime>> history;
        public Operation operation, val;
        public List<string> math;

        public CalcForm()
        {
            InitializeComponent();
            history = new List<KeyValuePair<string, DateTime>>();
            math = new List<string>();
            val = new Operation("", history);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ShowValue(1, Operation_txtBox);
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            operation = new Operation(Operation_txtBox.Text, history);
            string x = val.GetResult(Operation_txtBox.Text);
            Operation_txtBox.Text = x;
            CalcResult_txtBox.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Operation_txtBox.Clear();
            CalcResult_txtBox.Clear();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ShowValue(5, Operation_txtBox);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowValue(4, Operation_txtBox);    
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ShowValue(2, Operation_txtBox);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShowValue(3, Operation_txtBox);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ShowValue(9, Operation_txtBox);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ShowValue(8, Operation_txtBox);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ShowValue(7, Operation_txtBox);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ShowValue(6, Operation_txtBox);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ShowValue(0, Operation_txtBox);
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            ShowValue("+", Operation_txtBox);
            math.Add("+");
        }

        void ShowValue<T>(T val, TextBox textBox)
        {
            textBox.AppendText(val.ToString());
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ShowValue("-", Operation_txtBox);
            math.Add("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ShowValue("*", Operation_txtBox);
            math.Add("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            ShowValue("/", Operation_txtBox);
            math.Add("/");
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            ShowValue(".", Operation_txtBox);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var dialog = new History();
            dialog.historyGrid.DataSource = operation.GetHistory();
            dialog.ShowDialog();
        }

        private void CalcResult_txtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Operation_txtBox_TextChanged(object sender, EventArgs e)
        {
            val.GetCalcState(
                    val, 
                    Operation_txtBox, 
                    CalcResult_txtBox
                );
        }
    }
}
