using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Model.Core
{
    interface ICoreResult
    {
        string GetResult<T>(T value);
    }
}
