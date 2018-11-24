using Calc.Model.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.Model.Data
{
    public class Operation : ICoreState, ICoreResult, ICoreHistory
    {
        List<KeyValuePair<string, DateTime>> hist;
        string result;
        char[] mathArray = new char[4]{ '+', '-', '*', '/'};

        public Operation(string val, List<KeyValuePair<string, DateTime>> history)
        {
            this.hist = history;
            result = GetResult(val);
            AddToHistory(result);
        }

        // [ICoreState] 
        public void onChange(Operation val, TextBox op, TextBox res)
        {
            if (op.Text.Length >= 3 
                && op.Text.Last() != mathArray[0] && op.Text.Last() != mathArray[1]
                && op.Text.Last() != mathArray[2] && op.Text.Last() != mathArray[3])
            {
                string x = val.GetResult(op.Text);
                res.Text = x;
            }
        }
        // [ICoreResult]
        public string GetResult<T>(T value)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(value.ToString(), "");
            return v.ToString();
        }

        // [ICoreHistory]
        public void AddToHistory<T>(T value)
        {
            KeyValuePair<string, DateTime> obj = 
                new KeyValuePair<string, DateTime>(value.ToString(), DateTime.Now);
            hist.Add(obj);
        }

        public void ClearHistory(List<KeyValuePair<string, DateTime>> history) => history.Clear();

        public List<KeyValuePair<string, DateTime>> GetHistory() => hist;
    }
}
