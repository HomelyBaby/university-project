using System;
using System.Drawing;
using System.Windows.Forms;
using FORMA.Properties;

namespace FORMA
{
    public partial class Form1 : Form
    {
        //метод для переміщення панелі SidePanel
        public void SidePnl(Button btn)
        {
            SidePanel.Height = btn.Height;//висота елемента
            SidePanel.Top = btn.Top;//верхня границя
        }
        public Form1()
        {
            InitializeComponent();
            //задаємо початковий стан елементів головної панелі
            SidePnl(btnHome);//викликаємо методу SidePnl для btnHome
            panelHomeUS.BringToFront();//помістити панель на передній план
            pBoxArrow.Image = Resources.ExpandArrow;//зміна зображення елемента PictureBox
        }
        //кнопки для регулювання розміру застосунку/закриття
        //кнопка закриття програми
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
        //кнопки для збільшення на весь екран/ повернення початкових розмірів застосунку
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnResturar.Visible = true;
        }
        private void btnResturar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnResturar.Visible = false;
            btnMaximizar.Visible = true;
            
        }
        //кнопка, що згортає застосунок
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //кнопки меню
        //Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePnl(btnHome);//викликаємо метод SidePnl для btnHome
            panelHomeUS.BringToFront();//помістити панель panelHomeUS на передній план
        }
        //Courses
        private void btnCourses_Click(object sender, EventArgs e)
        {
            timer1.Start();//запускаємо таймер
            SidePanel.Location = new Point(6, 177);//змінюємо розташування панелі SidePanel

        }
        //Programs
        private void btnPrograms_Click(object sender, EventArgs e)
        {
            SidePnl(btnPrograms);//викликаємо метод SidePnl для btnPrograms
            panelPrograms.BringToFront();//помістити панель panelPrograms на передній план
        }
        //Compiler
        private void btnCompiler_Click(object sender, EventArgs e)
        {
            SidePnl(btnCompiler);//викликаємо метод SidePnl для btnCompiler
            panelCompiler.BringToFront();//помістити панель panelCompiler на передній план
        }
        //кнопки панелі, яку відкриває кнопка btnCourses
        private void btnCplusplus_Click(object sender, EventArgs e)
        {
            panelCPlusPlus.BringToFront();//помістити панель panelCPlusPlus на передній план
        }
        private void btnCsharp_Click(object sender, EventArgs e)
        {
            panelCsharp.BringToFront();//помістити панель panelCsharp на передній план
        }
        private void btnJava_Click(object sender, EventArgs e)
        {
            panelJava.BringToFront();//помістити панель panelJava на передній план
        }
        private void btnPython_Click(object sender, EventArgs e)
        {
            panelPython.BringToFront();//помістити панель panelPython на передній план
        }
     
        //кнопка, приховує та показує меню
        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            if(pnlLeft.Height>= 594 && pnlLeft.Width>= 196)
            {
                pnlLeft.Height = 594;//задаємо висоту панелі
                pnlLeft.Width = 95;//задаємо ширину панелі
                //зміження тексту кнопок вліво
                btnCplusplus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnCsharp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnJava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnPython.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            }
            else
            {
                //зміщення тексту кнопок вліво посередину 
                pnlLeft.Height = 594;
                pnlLeft.Width = 196;
                btnCplusplus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnCsharp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnJava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnPython.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            }

        }
        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)//якщо панель згорнуто
            {
                pBoxArrow.Image = Resources.CollapseArrow;//змінити зображення PictureBox
                flowLayoutPanelCourses.Height += 10;//змінюємо висоту елемента управління
                //збільшення розмірів панелі до встановленого максимуму
                if (flowLayoutPanelCourses.Size == flowLayoutPanelCourses.MaximumSize)
                {
                    timer1.Stop(); timer1.Stop();//зупиняємо таймер
                    isCollapsed = false;//присвоюємо значення змінній
                }
            }
            //в іншому випадку
            else
            {
                pBoxArrow.Image = Resources.ExpandArrow;//змінити зображення PictureBox
                flowLayoutPanelCourses.Height -= 10;//змінюємо висоту елемента управління
                //зменшення розмірів панелі до встановленого мінімуму
                if (flowLayoutPanelCourses.Size == flowLayoutPanelCourses.MinimumSize)
                {
                    timer1.Stop();//зупиняємо таймер
                    isCollapsed = true;//присвоюємо значення змінній
                }
            }
        }
    }
}
