using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.Model.Pattern.Builder
{
    public abstract class Builder
    {
        Form CalcForm;
        List<Button> btnList;
        Size size;
        Button btn;

        // buttons abstract methods
        public abstract Button CreateButton();
        public abstract void AddButtonToControls(Button btn);

        // size abstract methods
        public abstract Size SetSize(int x, int y);
        public abstract Size GetSize();
    }
}
