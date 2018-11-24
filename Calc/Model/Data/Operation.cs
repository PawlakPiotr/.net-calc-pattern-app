using Calc.Model.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Model.Data
{
    public class Operation : ICoreHistory
    {
        List<KeyValuePair<string, DateTime>> hist;
        string result;

        public Operation(string val, List<KeyValuePair<string, DateTime>> history)
        {
            this.hist = history;
            result = GetResult(val);
            AddToHistory(result);
        }

        public string GetResult(string value)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(value, "");
            return v.ToString();
        }

        // [begin] HISTORY INTERFACE
        public void AddToHistory<T>(T value)
        {
            KeyValuePair<string, DateTime> obj = 
                new KeyValuePair<string, DateTime>(value.ToString(), DateTime.Now);
            hist.Add(obj);
        }

        public void ClearHistory(List<KeyValuePair<string, DateTime>> history) => history.Clear();

        public List<KeyValuePair<string, DateTime>> GetHistory() => hist;
        // [end] HISTORY INTERFACE
    }
}
