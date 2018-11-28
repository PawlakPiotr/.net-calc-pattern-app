using Calc.Model.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Model.Data
{
    public class Result: ICoreResult
    {
        public string res;
        
        public Result(Operation op)
        {
            res = GetResult(op.result);
        }

        public string GetResult<T>(T value)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(value.ToString(), "");
            return v.ToString();
        }
    }
}
