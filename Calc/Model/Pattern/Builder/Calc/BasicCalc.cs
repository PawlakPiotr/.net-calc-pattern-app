using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.Model.Pattern.Builder.Calc
{
    class BasicCalc : Builder
    {
        Size size;

        public BasicCalc(Form form)
        {
            size = SetSize(354, 498);
            form.Size = size;
        }

        public override void Build()
        {
            var Build = CalcForm.ActiveForm;
            Build.Activate();
        }

        public override bool GetFormState(Form fr)
        {
            if (fr.Size.Width == 354)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override Size GetSize()
        {
            return size;
        }

        public override Size SetSize(int x, int y)
        {
            return new Size(x, y);
        }

        public override Button CreateButton(string txt, Point location, Size size) => null;
        public override void AddButtonListener(Button btn) { }
        public override void AddButtonToControls(Form form, Button btn) { }
    }
}
