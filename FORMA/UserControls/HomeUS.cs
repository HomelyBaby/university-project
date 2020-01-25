using System;
using System.Windows.Forms;

namespace FORMA.UserControls
{
    public partial class HomeUS : UserControl
    {
     
            public HomeUS()
            {
                InitializeComponent();
                //завантажуємо файл
                richTextBox.LoadFile(@"C:\Users\Owner\Desktop\Курсова\txt\Home\ТопМови.rtf", RichTextBoxStreamType.RichText);
            }
            //кнопка, приховує та показує статтю
            private void btnReadMore_Click(object sender, EventArgs e)
            {
                timer1.Start();//запускаємо таймер
            }
            private bool isCollapsed;
            
            private void timer1_Tick_1(object sender, EventArgs e)
            {
                if (isCollapsed)//якщо панель згорнуто
            {

                    richTextBox.Height += 10;//змінюємо висоту елемента управління
                //збільшення розмірів панелі до встановленого максимуму
                if (richTextBox.Size == richTextBox.MaximumSize)
                    {
                        timer1.Stop();//зупиняємо таймер
                        isCollapsed = false;//присвоюємо значення змінній
                }
                    btnReadMore.Text = "Hide";//змінюємо текст кнопки
                }
                else
                //в іншому випадку
                {
                    richTextBox.Height -= 10;//змінюємо висоту елемента управління
                //зменшення розмірів панелі до встановленого мінімуму
                    if (richTextBox.Size == richTextBox.MinimumSize)
                    {
                        timer1.Stop();
                        isCollapsed = true;//присвоюємо значення змінній
                    }
                    btnReadMore.Text = "Read More";//змінюємо текст кнопки
                }
            }
    }
}
