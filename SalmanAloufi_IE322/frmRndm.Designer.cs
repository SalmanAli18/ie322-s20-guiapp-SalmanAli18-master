namespace SalmanAloufi_IE322
{
    partial class frmRndm
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
            this.BtnGnrtRndmClr = new System.Windows.Forms.Button();
            this.BtnRndmNmbr = new System.Windows.Forms.Button();
            this.BtnBack4 = new System.Windows.Forms.Button();
            this.LblRGB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGnrtRndmClr
            // 
            this.BtnGnrtRndmClr.Location = new System.Drawing.Point(177, 33);
            this.BtnGnrtRndmClr.Name = "BtnGnrtRndmClr";
            this.BtnGnrtRndmClr.Size = new System.Drawing.Size(365, 57);
            this.BtnGnrtRndmClr.TabIndex = 0;
            this.BtnGnrtRndmClr.Text = "Generate Random Color";
            this.BtnGnrtRndmClr.UseVisualStyleBackColor = true;
            this.BtnGnrtRndmClr.Click += new System.EventHandler(this.BtnGnrtRndmClr_Click);
            // 
            // BtnRndmNmbr
            // 
            this.BtnRndmNmbr.Location = new System.Drawing.Point(91, 280);
            this.BtnRndmNmbr.Name = "BtnRndmNmbr";
            this.BtnRndmNmbr.Size = new System.Drawing.Size(130, 38);
            this.BtnRndmNmbr.TabIndex = 1;
            this.BtnRndmNmbr.Text = "Random Number";
            this.BtnRndmNmbr.UseVisualStyleBackColor = true;
            this.BtnRndmNmbr.Click += new System.EventHandler(this.BtnRndmNmbr_Click);
            // 
            // BtnBack4
            // 
            this.BtnBack4.Location = new System.Drawing.Point(560, 280);
            this.BtnBack4.Name = "BtnBack4";
            this.BtnBack4.Size = new System.Drawing.Size(87, 38);
            this.BtnBack4.TabIndex = 2;
            this.BtnBack4.Text = "Back";
            this.BtnBack4.UseVisualStyleBackColor = true;
            this.BtnBack4.Click += new System.EventHandler(this.BtnBack4_Click);
            // 
            // LblRGB
            // 
            this.LblRGB.AutoSize = true;
            this.LblRGB.Location = new System.Drawing.Point(330, 168);
            this.LblRGB.Name = "LblRGB";
            this.LblRGB.Size = new System.Drawing.Size(39, 17);
            this.LblRGB.TabIndex = 3;
            this.LblRGB.Text = "r-g-b";
            // 
            // frmRndm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRGB);
            this.Controls.Add(this.BtnBack4);
            this.Controls.Add(this.BtnRndmNmbr);
            this.Controls.Add(this.BtnGnrtRndmClr);
            this.Name = "frmRndm";
            this.Text = "frmRndm";
            this.Load += new System.EventHandler(this.frmRndm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGnrtRndmClr;
        private System.Windows.Forms.Button BtnRndmNmbr;
        private System.Windows.Forms.Button BtnBack4;
        private System.Windows.Forms.Label LblRGB;
    }
}