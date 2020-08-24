namespace Contour.AutoCAD.Plugin.Controls
{
    partial class MainPalette
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbContours = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "0>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbContours
            // 
            this.lbContours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbContours.FormattingEnabled = true;
            this.lbContours.Location = new System.Drawing.Point(3, 33);
            this.lbContours.Name = "lbContours";
            this.lbContours.Size = new System.Drawing.Size(317, 589);
            this.lbContours.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "+>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbContours);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainPalette";
            this.Size = new System.Drawing.Size(323, 634);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbContours;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
