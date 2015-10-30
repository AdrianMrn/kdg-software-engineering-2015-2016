namespace lemonade
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.lblIncome = new System.Windows.Forms.Label();
      this.lblDay = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.upgradePnl = new System.Windows.Forms.FlowLayoutPanel();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(14, 120);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(428, 475);
      this.panel1.TabIndex = 0;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // panel2
      // 
      this.panel2.Location = new System.Drawing.Point(14, 15);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(428, 98);
      this.panel2.TabIndex = 1;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.lblIncome);
      this.panel3.Controls.Add(this.lblDay);
      this.panel3.Controls.Add(this.progressBar1);
      this.panel3.Location = new System.Drawing.Point(464, 15);
      this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(343, 175);
      this.panel3.TabIndex = 2;
      // 
      // lblIncome
      // 
      this.lblIncome.AutoSize = true;
      this.lblIncome.Location = new System.Drawing.Point(19, 141);
      this.lblIncome.Name = "lblIncome";
      this.lblIncome.Size = new System.Drawing.Size(51, 20);
      this.lblIncome.TabIndex = 4;
      this.lblIncome.Text = "label1";
      // 
      // lblDay
      // 
      this.lblDay.AutoSize = true;
      this.lblDay.BackColor = System.Drawing.Color.Transparent;
      this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDay.Location = new System.Drawing.Point(15, 22);
      this.lblDay.Name = "lblDay";
      this.lblDay.Size = new System.Drawing.Size(135, 46);
      this.lblDay.TabIndex = 3;
      this.lblDay.Text = "Day: 1";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(22, 89);
      this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.progressBar1.Maximum = 600;
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(308, 49);
      this.progressBar1.TabIndex = 2;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // upgradePnl
      // 
      this.upgradePnl.Location = new System.Drawing.Point(464, 198);
      this.upgradePnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.upgradePnl.Name = "upgradePnl";
      this.upgradePnl.Size = new System.Drawing.Size(343, 365);
      this.upgradePnl.TabIndex = 3;
      this.upgradePnl.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
      // 
      // MainGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1040, 578);
      this.Controls.Add(this.upgradePnl);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainGame";
      this.Text = "Lemonade Market";
      this.Load += new System.EventHandler(this.MainGame_Load);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.FlowLayoutPanel upgradePnl;


    }
}

