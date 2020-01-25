using System;
using System.Windows.Forms;

namespace FORMA.UserControls
{
    public partial class ShowCode : UserControl
    {
        public ShowCode()
        {
            InitializeComponent();

        }
        //приймаємо дані string з ProgramsUS
        public void SetText(string textTask, string textCplusplus, string textCsharp, string textJava, string textPython)
        {
          //завантаження файлів
          richTextBoxText.LoadFile(textTask, RichTextBoxStreamType.RichText);
          richTextBoxCplusplus.LoadFile(textCplusplus, RichTextBoxStreamType.RichText);
          richTextBoxCsharp.LoadFile(textCsharp, RichTextBoxStreamType.RichText);
          richTextBoxJava.LoadFile(textJava, RichTextBoxStreamType.RichText);
          richTextBoxPython.LoadFile(textPython, RichTextBoxStreamType.RichText);
        }

        public event EventHandler ButtonClicked;//подія кнопки
        private void btnBack_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, new EventArgs());
        }
    }
}
