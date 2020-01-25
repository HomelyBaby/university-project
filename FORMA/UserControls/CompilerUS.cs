using System;
using System.Windows.Forms;

namespace FORMA.UserControls
{
    public partial class CompilerUS : UserControl
    {
        public CompilerUS()
        {
            InitializeComponent();
            //елементом управління відображаються його діалогові вікна
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void btnCplusplus_Click(object sender, EventArgs e)
        {
            pictureBox.Hide();//приховати pictureBox
            label.Hide();//пиховати label
            //перехід за адресою в мережі інтернет
            webBrowser.Navigate("https://www.tutorialspoint.com/compile_cpp11_online.php");
        }
        private void btnCsharp_Click(object sender, EventArgs e)
        {
            pictureBox.Hide();
            label.Hide();
            webBrowser.Navigate("https://www.tutorialspoint.com/compile_csharp_online.php");
        }
        private void btnJava_Click(object sender, EventArgs e)
        {
            pictureBox.Hide();
            label.Hide();
            webBrowser.Navigate("https://www.tutorialspoint.com/compile_java_online.php");
        }
        private void btnPython_Click(object sender, EventArgs e)
        {
            pictureBox.Hide();
            label.Hide();
            webBrowser.Navigate("https://www.tutorialspoint.com/execute_python_online.php");
        }
    }
}
