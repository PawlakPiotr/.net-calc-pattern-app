using Calc.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.Model.Core
{
    interface ICoreState
    {
        void onChange(Operation val, TextBox op, TextBox res);
        bool NumberNext(Operation val, TextBox op);
        bool SymbolNext(Operation val, TextBox op);
    }
}
