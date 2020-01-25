namespace FORMA
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanelCourses = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.pBoxArrow = new System.Windows.Forms.PictureBox();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnCplusplus = new System.Windows.Forms.Button();
            this.btnCsharp = new System.Windows.Forms.Button();
            this.btnJava = new System.Windows.Forms.Button();
            this.btnPython = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnCompiler = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnResturar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelHomeUS = new FORMA.UserControls.HomeUS();
            this.panelCompiler = new FORMA.UserControls.CompilerUS();
            this.panelPrograms = new FORMA.UserControls.ProgramsUS();
            this.panelCPlusPlus = new FORMA.UserControls.C__();
            this.panelCsharp = new FORMA.UserControls.Csharp();
            this.panelJava = new FORMA.UserControls.Java();
            this.panelPython = new FORMA.UserControls.Python();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.flowLayoutPanelCourses.SuspendLayout();
            this.panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrow)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Controls.Add(this.flowLayoutPanelMenu);
            this.pnlLeft.Controls.Add(this.SidePanel);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(196, 594);
            this.pnlLeft.TabIndex = 0;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanelMenu.Controls.Add(this.btnMenu);
            this.flowLayoutPanelMenu.Controls.Add(this.btnHome);
            this.flowLayoutPanelMenu.Controls.Add(this.flowLayoutPanelCourses);
            this.flowLayoutPanelMenu.Controls.Add(this.btnPrograms);
            this.flowLayoutPanelMenu.Controls.Add(this.btnCompiler);
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(29, 0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(167, 594);
            this.flowLayoutPanelMenu.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(167, 69);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 78);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(167, 93);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // flowLayoutPanelCourses
            // 
            this.flowLayoutPanelCourses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanelCourses.Controls.Add(this.panelCourses);
            this.flowLayoutPanelCourses.Controls.Add(this.btnCplusplus);
            this.flowLayoutPanelCourses.Controls.Add(this.btnCsharp);
            this.flowLayoutPanelCourses.Controls.Add(this.btnJava);
            this.flowLayoutPanelCourses.Controls.Add(this.btnPython);
            this.flowLayoutPanelCourses.Location = new System.Drawing.Point(3, 177);
            this.flowLayoutPanelCourses.MaximumSize = new System.Drawing.Size(165, 238);
            this.flowLayoutPanelCourses.MinimumSize = new System.Drawing.Size(165, 90);
            this.flowLayoutPanelCourses.Name = "flowLayoutPanelCourses";
            this.flowLayoutPanelCourses.Size = new System.Drawing.Size(165, 90);
            this.flowLayoutPanelCourses.TabIndex = 2;
            // 
            // panelCourses
            // 
            this.panelCourses.BackColor = System.Drawing.Color.Black;
            this.panelCourses.Controls.Add(this.pBoxArrow);
            this.panelCourses.Controls.Add(this.btnCourses);
            this.panelCourses.Location = new System.Drawing.Point(3, 3);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(161, 93);
            this.panelCourses.TabIndex = 3;
            // 
            // pBoxArrow
            // 
            this.pBoxArrow.BackColor = System.Drawing.Color.Black;
            this.pBoxArrow.Location = new System.Drawing.Point(74, 61);
            this.pBoxArrow.Name = "pBoxArrow";
            this.pBoxArrow.Size = new System.Drawing.Size(32, 32);
            this.pBoxArrow.TabIndex = 1;
            this.pBoxArrow.TabStop = false;
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.Black;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCourses.ForeColor = System.Drawing.Color.Transparent;
            this.btnCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnCourses.Image")));
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(0, -3);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(161, 93);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnCplusplus
            // 
            this.btnCplusplus.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCplusplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCplusplus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCplusplus.Location = new System.Drawing.Point(3, 102);
            this.btnCplusplus.Name = "btnCplusplus";
            this.btnCplusplus.Size = new System.Drawing.Size(161, 28);
            this.btnCplusplus.TabIndex = 3;
            this.btnCplusplus.Text = "C++";
            this.btnCplusplus.UseVisualStyleBackColor = false;
            this.btnCplusplus.Click += new System.EventHandler(this.btnCplusplus_Click);
            // 
            // btnCsharp
            // 
            this.btnCsharp.BackColor = System.Drawing.Color.Purple;
            this.btnCsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsharp.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCsharp.Location = new System.Drawing.Point(3, 136);
            this.btnCsharp.Name = "btnCsharp";
            this.btnCsharp.Size = new System.Drawing.Size(161, 28);
            this.btnCsharp.TabIndex = 4;
            this.btnCsharp.Text = "C#";
            this.btnCsharp.UseVisualStyleBackColor = false;
            this.btnCsharp.Click += new System.EventHandler(this.btnCsharp_Click);
            // 
            // btnJava
            // 
            this.btnJava.BackColor = System.Drawing.Color.ForestGreen;
            this.btnJava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJava.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnJava.Location = new System.Drawing.Point(3, 170);
            this.btnJava.Name = "btnJava";
            this.btnJava.Size = new System.Drawing.Size(161, 28);
            this.btnJava.TabIndex = 5;
            this.btnJava.Text = "Java";
            this.btnJava.UseVisualStyleBackColor = false;
            this.btnJava.Click += new System.EventHandler(this.btnJava_Click);
            // 
            // btnPython
            // 
            this.btnPython.BackColor = System.Drawing.Color.Gold;
            this.btnPython.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPython.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPython.Location = new System.Drawing.Point(3, 204);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(161, 28);
            this.btnPython.TabIndex = 6;
            this.btnPython.Text = "Python";
            this.btnPython.UseVisualStyleBackColor = false;
            this.btnPython.Click += new System.EventHandler(this.btnPython_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrograms.FlatAppearance.BorderSize = 0;
            this.btnPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrograms.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrograms.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrograms.Image = ((System.Drawing.Image)(resources.GetObject("btnPrograms.Image")));
            this.btnPrograms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrograms.Location = new System.Drawing.Point(3, 273);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(167, 93);
            this.btnPrograms.TabIndex = 3;
            this.btnPrograms.Text = "Programs";
            this.btnPrograms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrograms.UseVisualStyleBackColor = true;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // btnCompiler
            // 
            this.btnCompiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompiler.FlatAppearance.BorderSize = 0;
            this.btnCompiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompiler.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCompiler.ForeColor = System.Drawing.Color.Transparent;
            this.btnCompiler.Image = ((System.Drawing.Image)(resources.GetObject("btnCompiler.Image")));
            this.btnCompiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompiler.Location = new System.Drawing.Point(3, 372);
            this.btnCompiler.Name = "btnCompiler";
            this.btnCompiler.Size = new System.Drawing.Size(167, 93);
            this.btnCompiler.TabIndex = 4;
            this.btnCompiler.Text = "Compiler";
            this.btnCompiler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompiler.UseVisualStyleBackColor = true;
            this.btnCompiler.Click += new System.EventHandler(this.btnCompiler_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SidePanel.FlatAppearance.BorderSize = 0;
            this.SidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidePanel.Location = new System.Drawing.Point(3, 80);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(20, 93);
            this.SidePanel.TabIndex = 2;
            this.SidePanel.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTop.Controls.Add(this.btnResturar);
            this.pnlTop.Controls.Add(this.btnMinimizar);
            this.pnlTop.Controls.Add(this.btnMaximizar);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblMain);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(196, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(969, 72);
            this.pnlTop.TabIndex = 1;
            // 
            // btnResturar
            // 
            this.btnResturar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResturar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResturar.BackgroundImage")));
            this.btnResturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResturar.FlatAppearance.BorderSize = 0;
            this.btnResturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResturar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResturar.ForeColor = System.Drawing.Color.White;
            this.btnResturar.Location = new System.Drawing.Point(896, 8);
            this.btnResturar.Name = "btnResturar";
            this.btnResturar.Size = new System.Drawing.Size(32, 32);
            this.btnResturar.TabIndex = 4;
            this.btnResturar.UseVisualStyleBackColor = true;
            this.btnResturar.Visible = false;
            this.btnResturar.Click += new System.EventHandler(this.btnResturar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(858, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(896, 8);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 32);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(934, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMain
            // 
            this.lblMain.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(3, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(538, 52);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Programming Handbook";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panelHomeUS);
            this.pnlMain.Controls.Add(this.panelCompiler);
            this.pnlMain.Controls.Add(this.panelPrograms);
            this.pnlMain.Controls.Add(this.panelCPlusPlus);
            this.pnlMain.Controls.Add(this.panelCsharp);
            this.pnlMain.Controls.Add(this.panelJava);
            this.pnlMain.Controls.Add(this.panelPython);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(196, 72);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(969, 522);
            this.pnlMain.TabIndex = 2;
            // 
            // panelHomeUS
            // 
            this.panelHomeUS.AutoScroll = true;
            this.panelHomeUS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHomeUS.BackgroundImage")));
            this.panelHomeUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHomeUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHomeUS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelHomeUS.Location = new System.Drawing.Point(0, 0);
            this.panelHomeUS.Margin = new System.Windows.Forms.Padding(4);
            this.panelHomeUS.Name = "panelHomeUS";
            this.panelHomeUS.Size = new System.Drawing.Size(969, 522);
            this.panelHomeUS.TabIndex = 0;
            // 
            // panelCompiler
            // 
            this.panelCompiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCompiler.Location = new System.Drawing.Point(0, 0);
            this.panelCompiler.Name = "panelCompiler";
            this.panelCompiler.Size = new System.Drawing.Size(969, 522);
            this.panelCompiler.TabIndex = 3;
            // 
            // panelPrograms
            // 
            this.panelPrograms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrograms.Location = new System.Drawing.Point(0, 0);
            this.panelPrograms.Name = "panelPrograms";
            this.panelPrograms.Size = new System.Drawing.Size(969, 522);
            this.panelPrograms.TabIndex = 2;
            // 
            // panelCPlusPlus
            // 
            this.panelCPlusPlus.BackColor = System.Drawing.Color.White;
            this.panelCPlusPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCPlusPlus.BackgroundImage")));
            this.panelCPlusPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCPlusPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCPlusPlus.Location = new System.Drawing.Point(0, 0);
            this.panelCPlusPlus.Margin = new System.Windows.Forms.Padding(4);
            this.panelCPlusPlus.Name = "panelCPlusPlus";
            this.panelCPlusPlus.Size = new System.Drawing.Size(969, 522);
            this.panelCPlusPlus.TabIndex = 1;
            // 
            // panelCsharp
            // 
            this.panelCsharp.BackColor = System.Drawing.Color.White;
            this.panelCsharp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCsharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCsharp.Location = new System.Drawing.Point(0, 0);
            this.panelCsharp.Name = "panelCsharp";
            this.panelCsharp.Size = new System.Drawing.Size(969, 522);
            this.panelCsharp.TabIndex = 4;
            // 
            // panelJava
            // 
            this.panelJava.BackColor = System.Drawing.Color.White;
            this.panelJava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelJava.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJava.Location = new System.Drawing.Point(0, 0);
            this.panelJava.Name = "panelJava";
            this.panelJava.Size = new System.Drawing.Size(969, 522);
            this.panelJava.TabIndex = 5;
            // 
            // panelPython
            // 
            this.panelPython.BackColor = System.Drawing.Color.White;
            this.panelPython.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPython.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPython.Location = new System.Drawing.Point(0, 0);
            this.panelPython.Name = "panelPython";
            this.panelPython.Size = new System.Drawing.Size(969, 522);
            this.panelPython.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1165, 594);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLeft.ResumeLayout(false);
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.flowLayoutPanelCourses.ResumeLayout(false);
            this.panelCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrow)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button SidePanel;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel pnlMain;
        private UserControls.HomeUS panelHomeUS;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnResturar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnCompiler;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCourses;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCplusplus;
        private System.Windows.Forms.Button btnCsharp;
        private System.Windows.Forms.Button btnJava;
        private System.Windows.Forms.Button btnPython;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel panelCourses;
        private System.Windows.Forms.PictureBox pBoxArrow;
        private UserControls.C__ panelCPlusPlus;
        private UserControls.ProgramsUS panelPrograms;
        private UserControls.CompilerUS panelCompiler;
        private UserControls.Csharp panelCsharp;
        private UserControls.Java panelJava;
        private UserControls.Python panelPython;
    }
}

