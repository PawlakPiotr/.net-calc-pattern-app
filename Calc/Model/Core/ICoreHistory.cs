using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Model.Core
{
    interface ICoreHistory
    {
        void AddToHistory<T>(T value);
        List<KeyValuePair<string, DateTime>> GetHistory();
        void ClearHistory(List<KeyValuePair<string, DateTime>> history);
    }
}
