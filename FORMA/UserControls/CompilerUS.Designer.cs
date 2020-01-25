namespace FORMA.UserControls
{
    partial class CompilerUS
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompilerUS));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnPython = new System.Windows.Forms.Button();
            this.btnJava = new System.Windows.Forms.Button();
            this.btnCsharp = new System.Windows.Forms.Button();
            this.btnCplusplus = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(969, 522);
            this.webBrowser.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnPython);
            this.pnlTop.Controls.Add(this.btnJava);
            this.pnlTop.Controls.Add(this.btnCsharp);
            this.pnlTop.Controls.Add(this.btnCplusplus);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(969, 49);
            this.pnlTop.TabIndex = 1;
            // 
            // btnPython
            // 
            this.btnPython.BackColor = System.Drawing.Color.Teal;
            this.btnPython.FlatAppearance.BorderSize = 0;
            this.btnPython.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPython.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPython.ForeColor = System.Drawing.Color.White;
            this.btnPython.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPython.Location = new System.Drawing.Point(726, 0);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(243, 49);
            this.btnPython.TabIndex = 3;
            this.btnPython.Text = "Python";
            this.btnPython.UseVisualStyleBackColor = false;
            this.btnPython.Click += new System.EventHandler(this.btnPython_Click);
            // 
            // btnJava
            // 
            this.btnJava.BackColor = System.Drawing.Color.Teal;
            this.btnJava.FlatAppearance.BorderSize = 0;
            this.btnJava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJava.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnJava.ForeColor = System.Drawing.Color.White;
            this.btnJava.Location = new System.Drawing.Point(484, 0);
            this.btnJava.Name = "btnJava";
            this.btnJava.Size = new System.Drawing.Size(242, 49);
            this.btnJava.TabIndex = 2;
            this.btnJava.Text = "Java";
            this.btnJava.UseVisualStyleBackColor = false;
            this.btnJava.Click += new System.EventHandler(this.btnJava_Click);
            // 
            // btnCsharp
            // 
            this.btnCsharp.BackColor = System.Drawing.Color.Teal;
            this.btnCsharp.FlatAppearance.BorderSize = 0;
            this.btnCsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsharp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCsharp.ForeColor = System.Drawing.Color.White;
            this.btnCsharp.Location = new System.Drawing.Point(242, 0);
            this.btnCsharp.Name = "btnCsharp";
            this.btnCsharp.Size = new System.Drawing.Size(242, 49);
            this.btnCsharp.TabIndex = 1;
            this.btnCsharp.Text = "C#";
            this.btnCsharp.UseVisualStyleBackColor = false;
            this.btnCsharp.Click += new System.EventHandler(this.btnCsharp_Click);
            // 
            // btnCplusplus
            // 
            this.btnCplusplus.BackColor = System.Drawing.Color.Teal;
            this.btnCplusplus.FlatAppearance.BorderSize = 0;
            this.btnCplusplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCplusplus.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCplusplus.ForeColor = System.Drawing.Color.White;
            this.btnCplusplus.Location = new System.Drawing.Point(0, 0);
            this.btnCplusplus.Name = "btnCplusplus";
            this.btnCplusplus.Size = new System.Drawing.Size(242, 49);
            this.btnCplusplus.TabIndex = 0;
            this.btnCplusplus.Text = "C++";
            this.btnCplusplus.UseVisualStyleBackColor = false;
            this.btnCplusplus.Click += new System.EventHandler(this.btnCplusplus_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(0, 49);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(969, 475);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(32, 102);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(424, 34);
            this.label.TabIndex = 3;
            this.label.Text = "Select a language to compile";
            // 
            // CompilerUS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.webBrowser);
            this.Name = "CompilerUS";
            this.Size = new System.Drawing.Size(969, 522);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnPython;
        private System.Windows.Forms.Button btnJava;
        private System.Windows.Forms.Button btnCsharp;
        private System.Windows.Forms.Button btnCplusplus;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
    }
}
