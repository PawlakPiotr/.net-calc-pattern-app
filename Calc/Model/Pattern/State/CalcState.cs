using Calc.Model.Core;
using Calc.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.Model.Pattern
{
    public class CalcState : ICoreState
    {
        Operation oprt;
        public List<string> PreviousValue;

        public CalcState(Operation op, string action)
        {
            PreviousValue = new List<string>();
            this.oprt = op;
            PreviousValue.Add(action);
        }

        public void GetCalcState(Operation val, TextBox op, TextBox res)
        {
            onChange(val, op, res);
        }

        public bool NumberNext(Operation val, TextBox op)
        {
            if (op.Text.Last() == oprt.mathArray[0] && op.Text.Last() == oprt.mathArray[1]
                && op.Text.Last() == oprt.mathArray[2] && op.Text.Last() == oprt.mathArray[3])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void onChange(Operation val, TextBox op, TextBox res)
        {
            if (op.Text.Length >= 3 && SymbolNext(val, op))
            {
                string x = val.GetResult(op.Text);
                res.Text = x;
            } else
            {
                res.Text = "wait";
            }
        }

        public bool SymbolNext(Operation val, TextBox op)
        {
            if(op.Text.Last() != oprt.mathArray[0] && op.Text.Last() != oprt.mathArray[1]
                && op.Text.Last() != oprt.mathArray[2] && op.Text.Last() != oprt.mathArray[3])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
