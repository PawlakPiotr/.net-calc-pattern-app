using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc.Model.Pattern.Builder;

namespace Calc.Model.Pattern.Builder.Calc
{
    public class ExtendedCalc : Builder
    {
        Size size;
        Form form;

        public ExtendedCalc(Form form)
        {
            this.form = form;
            size = SetSize(600, 498);
            form.Size = size;
        }

        public override void AddButtonListener(Button btn)
        {
            btn.Click += delegate
            {
               // TODO => add listeners
            };
        }

        public override void Build()
        {
            var width = 12;
            for (int i=0; i< 9; i++)
            {
                AddButtonToControls(
                    form, CreateButton("SQRT" + i, new Point(354, width), new Size(180, 32))
                    );
                width += 50;
            }
        }

        public override void AddButtonToControls(Form form, Button btn)
        {
            form.Controls.Add(btn);
        }

        public override Button CreateButton(string txt, Point location, Size size)
        {
            Button btn = new Button();
            btn.Text = txt;
            btn.Location = location;
            btn.Size = size;

            return btn;
        }

        public override bool GetFormState(Form fr)
        {
            if (fr.Size.Width == 600)
            {
                return true;
            }
            else
            {
                return false;
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

    }
}
