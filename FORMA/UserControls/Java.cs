﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMA.UserControls
{
    public partial class Java : UserControl
    {
        public Java()
        {
            InitializeComponent();
        }

        private void treeViewJava_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name != "Глава1" && e.Node.Name != "Глава2" && e.Node.Name != "Глава3")//якщо не глава
            {
                //загружаємо текст файлу
                richTBoxInfo.LoadFile(@"C:\Users\Owner\Desktop\Курсова\txt\Java\" + e.Node.Name + ".rtf", RichTextBoxStreamType.RichText);
            }
        }
    }
}
