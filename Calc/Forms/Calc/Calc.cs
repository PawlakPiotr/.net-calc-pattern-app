using Calc.Forms.History;
using Calc.Model.Data;
using Calc.Model.Pattern;
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
        CalcState cs;
        Form mainFormHandler;

        public CalcForm()
        {
            InitializeComponent();

            history = new List<KeyValuePair<string, DateTime>>();
            val = new Operation("", history);
            cs = new CalcState(val, val.result);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ShowValue(1, Operation_txtBox);
            cs.PreviousValue.Add("1");
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            mainFormHandler = Application.OpenForms[0];
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            operation = new Operation(Operation_txtBox.Text, history);
            Result CalcResult = new Result(operation);
            //string x = val.GetResult(Operation_txtBox.Text);
            Operation_txtBox.Text = CalcResult.res;
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
            cs.PreviousValue.Add("5");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowValue(4, Operation_txtBox);
            cs.PreviousValue.Add("4");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ShowValue(2, Operation_txtBox);
            cs.PreviousValue.Add("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShowValue(3, Operation_txtBox);
            cs.PreviousValue.Add("3");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ShowValue(9, Operation_txtBox);
            cs.PreviousValue.Add("9");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ShowValue(8, Operation_txtBox);
            cs.PreviousValue.Add("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ShowValue(7, Operation_txtBox);
            cs.PreviousValue.Add("7");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ShowValue(6, Operation_txtBox);
            cs.PreviousValue.Add("6");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ShowValue(0, Operation_txtBox);
            cs.PreviousValue.Add("0");
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            ShowValue("+", Operation_txtBox);
            cs.PreviousValue.Add("+");
        }

        void ShowValue<T>(T val, TextBox textBox)
        {
            textBox.AppendText(val.ToString());
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ShowValue("-", Operation_txtBox);
            cs.PreviousValue.Add("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ShowValue("*", Operation_txtBox);
            cs.PreviousValue.Add("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            ShowValue("/", Operation_txtBox);
            cs.PreviousValue.Add("/");
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

        private void btnExt_Click(object sender, EventArgs e)
        {
            // abstarct builder -> buttons_list, buttons, size, addButton(), setButton(), set/get_Size()
            // getFormState() -> return 'extend' or 'basic'
            // delete form builder -> delete all buttons 
            if(btnExt.Text == "EXTEND")
            {
                mainFormHandler.Size = new Size(600, 498);
                Button newButton = new Button();
                newButton.Location = new Point(345,12);
                newButton.Size = new Size(89,32);
                this.Controls.Add(newButton);
                btnExt.Text = "BASIC";
            } else
            {
                btnExt.Text = "EXTEND";
                mainFormHandler.Size = new Size(354, 498);
            }
        }


        private void Operation_txtBox_TextChanged(object sender, EventArgs e)
        {
            cs.GetCalcState(
                    val, 
                    Operation_txtBox, 
                    CalcResult_txtBox
                );
            cs.PreviousValue.Add(val.result);
        }
    }
}
