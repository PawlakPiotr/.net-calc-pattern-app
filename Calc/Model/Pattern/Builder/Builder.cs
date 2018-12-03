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
        public static Size size;
        Button btn;
       
        // buttons abstract methods
        public abstract Button CreateButton(string txt, Point location, Size size);
        public abstract void AddButtonListener(Button btn);
        public abstract void AddButtonToControls(Form form, Button btn);

        // size abstract methods
        public abstract Size SetSize(int x, int y);
        public abstract Size GetSize();

        public abstract bool GetFormState(Form fr);

        public abstract void Build();
        
    }
}
