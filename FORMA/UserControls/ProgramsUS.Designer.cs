namespace FORMA.UserControls
{
    partial class ProgramsUS
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Об’єму та площі бічної поверхні кубу.");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("a i b за заданою формулою.");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Опору електричного кола.");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Площі трикутника. ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Обчислення", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Періоду коливання маятника довжиною L за формулою.");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Написати програму для визначення катету та радіусу вписаного кола.");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Знаходження", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Вивести на екран в зворотному порядку цифри.");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Інверсування", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeViewLineStructure = new System.Windows.Forms.TreeView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnOne = new System.Windows.Forms.Panel();
            this.pnlSecond = new System.Windows.Forms.Panel();
            this.treeViewIfAndElse = new System.Windows.Forms.TreeView();
            this.pnlTopic = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTopics = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLineStructure = new System.Windows.Forms.Button();
            this.btnIfAndElse = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnArrays = new System.Windows.Forms.Button();
            this.btnFunctions = new System.Windows.Forms.Button();
            this.btnPointers = new System.Windows.Forms.Button();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnHideShow = new System.Windows.Forms.Button();
            this.showCode1 = new FORMA.UserControls.ShowCode();
            this.pnlMain.SuspendLayout();
            this.pnOne.SuspendLayout();
            this.pnlSecond.SuspendLayout();
            this.pnlTopic.SuspendLayout();
            this.flowLayoutPanelTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewLineStructure
            // 
            this.treeViewLineStructure.BackColor = System.Drawing.Color.Teal;
            this.treeViewLineStructure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewLineStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLineStructure.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewLineStructure.ForeColor = System.Drawing.Color.White;
            this.treeViewLineStructure.FullRowSelect = true;
            this.treeViewLineStructure.Location = new System.Drawing.Point(0, 0);
            this.treeViewLineStructure.Name = "treeViewLineStructure";
            treeNode1.BackColor = System.Drawing.Color.MediumTurquoise;
            treeNode1.Name = "1";
            treeNode1.Text = "Об’єму та площі бічної поверхні кубу.";
            treeNode1.ToolTipText = "Значення довжини ребра кубу вводиться з клавіатури. ";
            treeNode2.BackColor = System.Drawing.Color.MediumTurquoise;
            treeNode2.Name = "3";
            treeNode2.Text = "a i b за заданою формулою.";
            treeNode2.ToolTipText = "Значення  x,y,z вводяться з клавіатури. Для облегшення обчислення великого арифме" +
    "тичного виразу розділимо його на частини (формула)";
            treeNode3.BackColor = System.Drawing.Color.MediumTurquoise;
            treeNode3.Name = "2";
            treeNode3.Text = "Опору електричного кола.";
            treeNode3.ToolTipText = "Електричне коло складається з трьох паралельно з’єднаних опорів R1, R2, R3. Значе" +
    "ння опорів R1, R2, R3 вводяться з клавіатури. ";
            treeNode4.BackColor = System.Drawing.Color.MediumTurquoise;
            treeNode4.Name = "4";
            treeNode4.Text = "Площі трикутника. ";
            treeNode4.ToolTipText = "Дана сторона рівностороннього трикутника a. Знайти площу цього трикутника. (форму" +
    "ла)";
            treeNode5.BackColor = System.Drawing.Color.Teal;
            treeNode5.Checked = true;
            treeNode5.Name = "Заголовок";
            treeNode5.Text = "Обчислення";
            treeNode6.BackColor = System.Drawing.Color.MediumTurquoise;
            treeNode6.Name = "5";
            treeNode6.Text = "Періоду коливання маятника довжиною L за формулою.";
            treeNode6.ToolTipText = "Періоду коливання маятника довжиною L. (формула)";
            treeNode7.BackColor = System.Drawing.Color.MediumTurquoise;
            treeNode7.Name = "6";
            treeNode7.Text = "Написати програму для визначення катету та радіусу вписаного кола.";
            treeNode7.ToolTipText = "Написати програму для визначення катету та радіусу вписаного кола. (формула)";
            treeNode8.BackColor = System.Drawing.Color.Teal;
            treeNode8.Name = "Заголовок2";
            treeNode8.Text = "Знаходження";
            treeNode9.BackColor = System.Drawing.Color.MediumTurquoise;
            treeNode9.Name = "7";
            treeNode9.Text = "Вивести на екран в зворотному порядку цифри.";
            treeNode9.ToolTipText = "Дано чотиризначний число (наприклад 5678).";
            treeNode10.BackColor = System.Drawing.Color.Teal;
            treeNode10.Name = "Заголовок3";
            treeNode10.Text = "Інверсування";
            this.treeViewLineStructure.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode10});
            this.treeViewLineStructure.PathSeparator = "";
            this.treeViewLineStructure.ShowLines = false;
            this.treeViewLineStructure.ShowNodeToolTips = true;
            this.treeViewLineStructure.Size = new System.Drawing.Size(775, 493);
            this.treeViewLineStructure.TabIndex = 0;
            this.treeViewLineStructure.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLineStructure_AfterSelect);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnOne);
            this.pnlMain.Controls.Add(this.pnlTopic);
            this.pnlMain.Controls.Add(this.showCode1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(969, 493);
            this.pnlMain.TabIndex = 2;
            // 
            // pnOne
            // 
            this.pnOne.Controls.Add(this.pnlSecond);
            this.pnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOne.Location = new System.Drawing.Point(194, 0);
            this.pnOne.Name = "pnOne";
            this.pnOne.Size = new System.Drawing.Size(775, 493);
            this.pnOne.TabIndex = 3;
            // 
            // pnlSecond
            // 
            this.pnlSecond.Controls.Add(this.treeViewLineStructure);
            this.pnlSecond.Controls.Add(this.treeViewIfAndElse);
            this.pnlSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSecond.Location = new System.Drawing.Point(0, 0);
            this.pnlSecond.Name = "pnlSecond";
            this.pnlSecond.Size = new System.Drawing.Size(775, 493);
            this.pnlSecond.TabIndex = 2;
            // 
            // treeViewIfAndElse
            // 
            this.treeViewIfAndElse.BackColor = System.Drawing.Color.Teal;
            this.treeViewIfAndElse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewIfAndElse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewIfAndElse.Location = new System.Drawing.Point(0, 0);
            this.treeViewIfAndElse.Name = "treeViewIfAndElse";
            this.treeViewIfAndElse.Size = new System.Drawing.Size(775, 493);
            this.treeViewIfAndElse.TabIndex = 1;
            // 
            // pnlTopic
            // 
            this.pnlTopic.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTopic.Controls.Add(this.flowLayoutPanelTopics);
            this.pnlTopic.Controls.Add(this.btnHideShow);
            this.pnlTopic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopic.Location = new System.Drawing.Point(0, 0);
            this.pnlTopic.Name = "pnlTopic";
            this.pnlTopic.Size = new System.Drawing.Size(194, 493);
            this.pnlTopic.TabIndex = 2;
            // 
            // flowLayoutPanelTopics
            // 
            this.flowLayoutPanelTopics.AutoScroll = true;
            this.flowLayoutPanelTopics.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelTopics.Controls.Add(this.btnLineStructure);
            this.flowLayoutPanelTopics.Controls.Add(this.btnIfAndElse);
            this.flowLayoutPanelTopics.Controls.Add(this.btnFor);
            this.flowLayoutPanelTopics.Controls.Add(this.btnArrays);
            this.flowLayoutPanelTopics.Controls.Add(this.btnFunctions);
            this.flowLayoutPanelTopics.Controls.Add(this.btnPointers);
            this.flowLayoutPanelTopics.Controls.Add(this.btnClasses);
            this.flowLayoutPanelTopics.Location = new System.Drawing.Point(16, 0);
            this.flowLayoutPanelTopics.Name = "flowLayoutPanelTopics";
            this.flowLayoutPanelTopics.Size = new System.Drawing.Size(201, 493);
            this.flowLayoutPanelTopics.TabIndex = 1;
            // 
            // btnLineStructure
            // 
            this.btnLineStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLineStructure.FlatAppearance.BorderSize = 0;
            this.btnLineStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineStructure.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLineStructure.ForeColor = System.Drawing.Color.White;
            this.btnLineStructure.Location = new System.Drawing.Point(3, 3);
            this.btnLineStructure.Name = "btnLineStructure";
            this.btnLineStructure.Size = new System.Drawing.Size(171, 60);
            this.btnLineStructure.TabIndex = 4;
            this.btnLineStructure.Text = "Програми лінійної структури";
            this.btnLineStructure.UseVisualStyleBackColor = true;
            this.btnLineStructure.Click += new System.EventHandler(this.btnLineStructure_Click);
            // 
            // btnIfAndElse
            // 
            this.btnIfAndElse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIfAndElse.FlatAppearance.BorderSize = 0;
            this.btnIfAndElse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIfAndElse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIfAndElse.ForeColor = System.Drawing.Color.White;
            this.btnIfAndElse.Location = new System.Drawing.Point(3, 69);
            this.btnIfAndElse.Name = "btnIfAndElse";
            this.btnIfAndElse.Size = new System.Drawing.Size(171, 82);
            this.btnIfAndElse.TabIndex = 5;
            this.btnIfAndElse.Text = "Програми структури розгалуження";
            this.btnIfAndElse.UseVisualStyleBackColor = true;
            this.btnIfAndElse.Click += new System.EventHandler(this.btnIfAndElse_Click);
            // 
            // btnFor
            // 
            this.btnFor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFor.FlatAppearance.BorderSize = 0;
            this.btnFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFor.ForeColor = System.Drawing.Color.White;
            this.btnFor.Location = new System.Drawing.Point(3, 157);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(171, 74);
            this.btnFor.TabIndex = 8;
            this.btnFor.Text = "Програми циклічної структури";
            this.btnFor.UseVisualStyleBackColor = true;
            // 
            // btnArrays
            // 
            this.btnArrays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrays.FlatAppearance.BorderSize = 0;
            this.btnArrays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrays.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArrays.ForeColor = System.Drawing.Color.White;
            this.btnArrays.Location = new System.Drawing.Point(3, 237);
            this.btnArrays.Name = "btnArrays";
            this.btnArrays.Size = new System.Drawing.Size(171, 37);
            this.btnArrays.TabIndex = 9;
            this.btnArrays.Text = "Масиви";
            this.btnArrays.UseVisualStyleBackColor = true;
            // 
            // btnFunctions
            // 
            this.btnFunctions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunctions.FlatAppearance.BorderSize = 0;
            this.btnFunctions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunctions.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFunctions.ForeColor = System.Drawing.Color.White;
            this.btnFunctions.Location = new System.Drawing.Point(3, 280);
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.Size = new System.Drawing.Size(171, 37);
            this.btnFunctions.TabIndex = 10;
            this.btnFunctions.Text = "Функції";
            this.btnFunctions.UseVisualStyleBackColor = true;
            // 
            // btnPointers
            // 
            this.btnPointers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPointers.FlatAppearance.BorderSize = 0;
            this.btnPointers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointers.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPointers.ForeColor = System.Drawing.Color.White;
            this.btnPointers.Location = new System.Drawing.Point(3, 323);
            this.btnPointers.Name = "btnPointers";
            this.btnPointers.Size = new System.Drawing.Size(171, 37);
            this.btnPointers.TabIndex = 11;
            this.btnPointers.Text = "Покажчики";
            this.btnPointers.UseVisualStyleBackColor = true;
            // 
            // btnClasses
            // 
            this.btnClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClasses.FlatAppearance.BorderSize = 0;
            this.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasses.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClasses.ForeColor = System.Drawing.Color.White;
            this.btnClasses.Location = new System.Drawing.Point(3, 366);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(171, 37);
            this.btnClasses.TabIndex = 12;
            this.btnClasses.Text = "Класи";
            this.btnClasses.UseVisualStyleBackColor = true;
            // 
            // btnHideShow
            // 
            this.btnHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHideShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHideShow.FlatAppearance.BorderSize = 0;
            this.btnHideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideShow.Image = global::FORMA.Properties.Resources.back;
            this.btnHideShow.Location = new System.Drawing.Point(0, 0);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(17, 493);
            this.btnHideShow.TabIndex = 1;
            this.btnHideShow.UseVisualStyleBackColor = true;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
            // 
            // showCode1
            // 
            this.showCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showCode1.Location = new System.Drawing.Point(0, 0);
            this.showCode1.Name = "showCode1";
            this.showCode1.Size = new System.Drawing.Size(969, 493);
            this.showCode1.TabIndex = 1;
            // 
            // ProgramsUS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlMain);
            this.Name = "ProgramsUS";
            this.Size = new System.Drawing.Size(969, 493);
            this.Load += new System.EventHandler(this.ProgramsUS_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnOne.ResumeLayout(false);
            this.pnlSecond.ResumeLayout(false);
            this.pnlTopic.ResumeLayout(false);
            this.flowLayoutPanelTopics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewLineStructure;
        private System.Windows.Forms.Panel pnlMain;
        private ShowCode showCode1;
        private System.Windows.Forms.Panel pnOne;
        private System.Windows.Forms.Panel pnlTopic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopics;
        private System.Windows.Forms.Button btnLineStructure;
        private System.Windows.Forms.Button btnIfAndElse;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnArrays;
        private System.Windows.Forms.Button btnFunctions;
        private System.Windows.Forms.Button btnPointers;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Panel pnlSecond;
        private System.Windows.Forms.Button btnHideShow;
        private System.Windows.Forms.TreeView treeViewIfAndElse;
    }
}
