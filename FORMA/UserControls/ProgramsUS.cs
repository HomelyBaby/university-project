using System;
using System.Windows.Forms;
using FORMA.Properties;

namespace FORMA.UserControls
{
    public partial class ProgramsUS : UserControl
    { 
        public ProgramsUS()
        {
            InitializeComponent();
            pnlMain.BringToFront();//помістити панель на передній план
        }

        private void ProgramsUS_Load(object sender, EventArgs e)
        {
            showCode1.ButtonClicked += (o, args) =>
            {
                showCode1.SendToBack();
            };
        }
        //приховання і показ панелі для вибору тем
        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (pnlTopic.Height >= 484 && pnlTopic.Width >= 194)//якщо розмір панелі >=заданих параметрів
            {
                btnHideShow.Image = Resources.forward;//зміна зображення елемента 
                pnlTopic.Height = 484;//задаємо висоту панелі
                pnlTopic.Width = 17;//задаємо ширину панелі

            }
            else
            {
                btnHideShow.Image = Resources.back;//зміна зображення елемента 
                pnlTopic.Height = 484;//задаємо висоту панелі
                pnlTopic.Width = 194;//задаємо ширину панелі

            }
        }
        //treeView із задачами для теми "Програми лінійної структури" 
        private void treeViewLineStructure_AfterSelect(object sender, TreeViewEventArgs e)
        {
            showCode1.BringToFront();//помістити панель на передній план
            ShowCode sc = new ShowCode();//створюємо об'єкт
            string textBoxText, textCplusplus, textCsharp,  textJava,  textPython;//поля
            //передаємо текст в метод SetText в ShowCode
            textBoxText = (@"C:\Users\Owner\Desktop\Курсова\txt\Problems\Програми лінійної структури\task\" + e.Node.Name + ".rtf");
            textCplusplus = (@"C:\Users\Owner\Desktop\Курсова\txt\Problems\Програми лінійної структури\C++\" + e.Node.Name + ".rtf");
            textCsharp = (@"C:\Users\Owner\Desktop\Курсова\txt\Problems\Програми лінійної структури\Csharp\" + e.Node.Name + ".rtf");
            textJava = (@"C:\Users\Owner\Desktop\Курсова\txt\Problems\Програми лінійної структури\Java\" + e.Node.Name + ".rtf");
            textPython = (@"C:\Users\Owner\Desktop\Курсова\txt\Problems\Програми лінійної структури\Python\" + e.Node.Name + ".rtf");
            showCode1.SetText(textBoxText, textCplusplus,textCsharp,textJava,textPython);
        }
        //кнопка, яка відкриває treeView із задачами для теми "Програми лінійної структури" 
        private void btnLineStructure_Click(object sender, EventArgs e)
        {
               treeViewLineStructure.BringToFront();//помістити панель на передній план
        } 
        private void btnIfAndElse_Click(object sender, EventArgs e)
        {
            showCode1.SendToBack();
            treeViewIfAndElse.BringToFront();

        }
        
      
    }
}
