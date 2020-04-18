namespace SalmanAloufi_IE322
{
    partial class frmpicture
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
            this.BtnLoadPic = new System.Windows.Forms.Button();
            this.PicTry = new System.Windows.Forms.PictureBox();
            this.BtnBack6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadPic
            // 
            this.BtnLoadPic.Location = new System.Drawing.Point(12, 12);
            this.BtnLoadPic.Name = "BtnLoadPic";
            this.BtnLoadPic.Size = new System.Drawing.Size(89, 23);
            this.BtnLoadPic.TabIndex = 0;
            this.BtnLoadPic.Text = "Load Image";
            this.BtnLoadPic.UseVisualStyleBackColor = true;
            this.BtnLoadPic.Click += new System.EventHandler(this.BtnLoadPic_Click);
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(12, 41);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(606, 471);
            this.PicTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry.TabIndex = 1;
            this.PicTry.TabStop = false;
            // 
            // BtnBack6
            // 
            this.BtnBack6.Location = new System.Drawing.Point(840, 518);
            this.BtnBack6.Name = "BtnBack6";
            this.BtnBack6.Size = new System.Drawing.Size(75, 23);
            this.BtnBack6.TabIndex = 2;
            this.BtnBack6.Text = "Back";
            this.BtnBack6.UseVisualStyleBackColor = true;
            // 
            // frmpicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 582);
            this.Controls.Add(this.BtnBack6);
            this.Controls.Add(this.PicTry);
            this.Controls.Add(this.BtnLoadPic);
            this.Name = "frmpicture";
            this.Text = "frmpicture";
            this.Load += new System.EventHandler(this.frmpicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadPic;
        private System.Windows.Forms.PictureBox PicTry;
        private System.Windows.Forms.Button BtnBack6;
    }
}