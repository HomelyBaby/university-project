using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMA.PanelControl
{
    class SlidePanel
    {
        Panel span;
        Button button;
        bool hidden;
        string hText;
        string sText;
        int size;
        Timer t;

        public SlidePanel(ref Panel p, ref Button b, string hText, string sText)
        {

            this.span = p;
            this.button = b;
            hidden = true;
            this.hText = hText;
            this.sText = sText;

            size = p.Height;
            b.Click += new EventHandler(button_clicked);

            t = new Timer();
            t.Interval = 1;
            t.Tick += new EventHandler(t_tick);
        }


        void ChangeSize(int val)
        {
            span.Height += val;
            if (span.Height >= size || span.Height <= 0)
            {
                t.Stop();
                hidden = !hidden;
            }

        }
        private void t_tick(object sender, EventArgs e)
        {
            if (hidden) ChangeSize(+1950);
            else ChangeSize(-1950);
        }
        private void button_clicked(object sender, EventArgs e)
        {
            if (hidden) button.Text = sText;
            else button.Text = hText;
            t.Start();
        }
    }
}
