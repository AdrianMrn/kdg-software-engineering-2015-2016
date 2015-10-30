namespace YahtzeeTeerling
{
    partial class Yahtzee
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
      this.button1 = new System.Windows.Forms.Button();
      this.resetBtn = new System.Windows.Forms.Button();
      this.lblScore = new System.Windows.Forms.Label();
      this.lblHuidigeWorp = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(13, 138);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(112, 35);
      this.button1.TabIndex = 0;
      this.button1.Text = "Werp";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // resetBtn
      // 
      this.resetBtn.Location = new System.Drawing.Point(134, 138);
      this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.resetBtn.Name = "resetBtn";
      this.resetBtn.Size = new System.Drawing.Size(112, 35);
      this.resetBtn.TabIndex = 1;
      this.resetBtn.Text = "Reset";
      this.resetBtn.UseVisualStyleBackColor = true;
      this.resetBtn.Click += new System.EventHandler(this.button2_Click);
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.Location = new System.Drawing.Point(253, 145);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(68, 20);
      this.lblScore.TabIndex = 2;
      this.lblScore.Text = "Score: 0";
      // 
      // lblHuidigeWorp
      // 
      this.lblHuidigeWorp.AutoSize = true;
      this.lblHuidigeWorp.Location = new System.Drawing.Point(394, 145);
      this.lblHuidigeWorp.Name = "lblHuidigeWorp";
      this.lblHuidigeWorp.Size = new System.Drawing.Size(118, 20);
      this.lblHuidigeWorp.TabIndex = 3;
      this.lblHuidigeWorp.Text = "Huidige worp: 0";
      // 
      // Yahtzee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(864, 216);
      this.Controls.Add(this.lblHuidigeWorp);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.resetBtn);
      this.Controls.Add(this.button1);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Yahtzee";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Yahtzee_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHuidigeWorp;
    }
}

