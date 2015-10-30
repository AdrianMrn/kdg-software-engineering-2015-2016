namespace YahtzeeTeerling
{
    partial class TeerlingView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.teerlingLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // teerlingLabel
      // 
      this.teerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.teerlingLabel.Location = new System.Drawing.Point(36, 18);
      this.teerlingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.teerlingLabel.Name = "teerlingLabel";
      this.teerlingLabel.Size = new System.Drawing.Size(73, 95);
      this.teerlingLabel.TabIndex = 0;
      this.teerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.teerlingLabel.Click += new System.EventHandler(this.teerlingLabel_Click);
      // 
      // TeerlingView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.teerlingLabel);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "TeerlingView";
      this.Size = new System.Drawing.Size(161, 165);
      this.Load += new System.EventHandler(this.TeerlingView_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label teerlingLabel;
    }
}
