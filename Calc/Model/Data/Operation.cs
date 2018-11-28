using Calc.Model.Core;
using Calc.Model.Pattern;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.Model.Data
{
    public class Operation : ICoreResult, ICoreHistory
    {
        List<KeyValuePair<string, DateTime>> hist;
        public string result;
        public char[] mathArray = new char[4]{ '+', '-', '*', '/'};

        public Operation(string val, List<KeyValuePair<string, DateTime>> history)
        {
            this.hist = history;
            result = GetResult(val);
            AddToHistory(result);
        }
        public void GetCalcState(Operation val, TextBox op, TextBox res)
        {
            CalcState cst = new CalcState(val);
            cst.GetCalcState(val, op, res);
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


        public bool NumberNext(Operation val, TextBox op, TextBox res)
        {
            throw new NotImplementedException();
        }

        public bool SymbolNext(Operation val, TextBox op, TextBox res)
        {
            throw new NotImplementedException();
        }
    }
}
