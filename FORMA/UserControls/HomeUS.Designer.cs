namespace FORMA.UserControls
{
    partial class HomeUS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUS));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReadMore = new System.Windows.Forms.Button();
            this.lbTop10 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelText = new System.Windows.Forms.FlowLayoutPanel();
            this.readMore11 = new FORMA.PanelControl.ReadMore1();
            this.flowLayoutPanelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnReadMore
            // 
            this.btnReadMore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadMore.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReadMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.ForeColor = System.Drawing.Color.White;
            this.btnReadMore.Location = new System.Drawing.Point(362, 104);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(249, 47);
            this.btnReadMore.TabIndex = 0;
            this.btnReadMore.Text = "Read More";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // lbTop10
            // 
            this.lbTop10.BackColor = System.Drawing.Color.Transparent;
            this.lbTop10.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTop10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTop10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTop10.ForeColor = System.Drawing.Color.White;
            this.lbTop10.Location = new System.Drawing.Point(0, 0);
            this.lbTop10.Name = "lbTop10";
            this.lbTop10.Size = new System.Drawing.Size(969, 88);
            this.lbTop10.TabIndex = 1;
            this.lbTop10.Text = "ТОП 10 МОВ ПРОГРАМУВАННЯ У 2019";
            this.lbTop10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(3, 3);
            this.richTextBox.MaximumSize = new System.Drawing.Size(968, 330);
            this.richTextBox.MinimumSize = new System.Drawing.Size(968, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(968, 0);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // flowLayoutPanelText
            // 
            this.flowLayoutPanelText.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelText.Controls.Add(this.richTextBox);
            this.flowLayoutPanelText.Location = new System.Drawing.Point(-2, 189);
            this.flowLayoutPanelText.MinimumSize = new System.Drawing.Size(966, 0);
            this.flowLayoutPanelText.Name = "flowLayoutPanelText";
            this.flowLayoutPanelText.Size = new System.Drawing.Size(971, 333);
            this.flowLayoutPanelText.TabIndex = 3;
            // 
            // readMore11
            // 
            this.readMore11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readMore11.Location = new System.Drawing.Point(0, 0);
            this.readMore11.Margin = new System.Windows.Forms.Padding(4);
            this.readMore11.Name = "readMore11";
            this.readMore11.Size = new System.Drawing.Size(951, 2000);
            this.readMore11.TabIndex = 0;
            // 
            // HomeUS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.flowLayoutPanelText);
            this.Controls.Add(this.lbTop10);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeUS";
            this.Size = new System.Drawing.Size(969, 522);
            this.flowLayoutPanelText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PanelControl.ReadMore1 readMore11;
        private System.Windows.Forms.Label lbTop10;
        private System.Windows.Forms.Button btnReadMore;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelText;
    }
}
