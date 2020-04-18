namespace SalmanAloufi_IE322
{
    partial class frmCheckBox
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack2 = new System.Windows.Forms.Button();
            this.CheckCoffee = new System.Windows.Forms.CheckBox();
            this.CheckDonut = new System.Windows.Forms.CheckBox();
            this.CheckBrownie = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(304, 59);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(103, 35);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack2
            // 
            this.BtnBack2.Location = new System.Drawing.Point(586, 353);
            this.BtnBack2.Name = "BtnBack2";
            this.BtnBack2.Size = new System.Drawing.Size(102, 30);
            this.BtnBack2.TabIndex = 1;
            this.BtnBack2.Text = "Back";
            this.BtnBack2.UseVisualStyleBackColor = true;
            this.BtnBack2.Click += new System.EventHandler(this.BtnBack2_Click);
            // 
            // CheckCoffee
            // 
            this.CheckCoffee.AutoSize = true;
            this.CheckCoffee.Location = new System.Drawing.Point(6, 23);
            this.CheckCoffee.Name = "CheckCoffee";
            this.CheckCoffee.Size = new System.Drawing.Size(69, 21);
            this.CheckCoffee.TabIndex = 2;
            this.CheckCoffee.Text = "Coffee";
            this.CheckCoffee.UseVisualStyleBackColor = true;
            // 
            // CheckDonut
            // 
            this.CheckDonut.AutoSize = true;
            this.CheckDonut.Location = new System.Drawing.Point(6, 50);
            this.CheckDonut.Name = "CheckDonut";
            this.CheckDonut.Size = new System.Drawing.Size(69, 21);
            this.CheckDonut.TabIndex = 3;
            this.CheckDonut.Text = "Donut";
            this.CheckDonut.UseVisualStyleBackColor = true;
            // 
            // CheckBrownie
            // 
            this.CheckBrownie.AutoSize = true;
            this.CheckBrownie.Location = new System.Drawing.Point(6, 77);
            this.CheckBrownie.Name = "CheckBrownie";
            this.CheckBrownie.Size = new System.Drawing.Size(78, 21);
            this.CheckBrownie.TabIndex = 4;
            this.CheckBrownie.Text = "Brownie";
            this.CheckBrownie.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckCoffee);
            this.groupBox1.Controls.Add(this.CheckBrownie);
            this.groupBox1.Controls.Add(this.CheckDonut);
            this.groupBox1.Location = new System.Drawing.Point(236, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack2);
            this.Controls.Add(this.BtnShow);
            this.Name = "frmCheckBox";
            this.Text = "frmCheckBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack2;
        private System.Windows.Forms.CheckBox CheckCoffee;
        private System.Windows.Forms.CheckBox CheckDonut;
        private System.Windows.Forms.CheckBox CheckBrownie;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}