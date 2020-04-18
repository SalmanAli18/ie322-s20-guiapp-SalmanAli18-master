namespace SalmanAloufi_IE322
{
    partial class frmCombo
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
            this.BtnMthd1 = new System.Windows.Forms.Button();
            this.BtnMthd2 = new System.Windows.Forms.Button();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.BtnRemoveByI = new System.Windows.Forms.Button();
            this.BtnRemoveByN = new System.Windows.Forms.Button();
            this.BtnRemoveLI = new System.Windows.Forms.Button();
            this.BtnRemove2LI = new System.Windows.Forms.Button();
            this.BtnBack3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMthd1
            // 
            this.BtnMthd1.Location = new System.Drawing.Point(64, 12);
            this.BtnMthd1.Name = "BtnMthd1";
            this.BtnMthd1.Size = new System.Drawing.Size(128, 59);
            this.BtnMthd1.TabIndex = 0;
            this.BtnMthd1.Text = "Show Selected Method1";
            this.BtnMthd1.UseVisualStyleBackColor = true;
            this.BtnMthd1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMthd2
            // 
            this.BtnMthd2.Location = new System.Drawing.Point(209, 12);
            this.BtnMthd2.Name = "BtnMthd2";
            this.BtnMthd2.Size = new System.Drawing.Size(127, 59);
            this.BtnMthd2.TabIndex = 1;
            this.BtnMthd2.Text = "Show Selected Method2";
            this.BtnMthd2.UseVisualStyleBackColor = true;
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(105, 122);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(199, 24);
            this.cmbDays.TabIndex = 2;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // BtnRemoveByI
            // 
            this.BtnRemoveByI.Location = new System.Drawing.Point(64, 250);
            this.BtnRemoveByI.Name = "BtnRemoveByI";
            this.BtnRemoveByI.Size = new System.Drawing.Size(87, 49);
            this.BtnRemoveByI.TabIndex = 3;
            this.BtnRemoveByI.Text = "Remove By index";
            this.BtnRemoveByI.UseVisualStyleBackColor = true;
            this.BtnRemoveByI.Click += new System.EventHandler(this.BtnRemoveByI_Click);
            // 
            // BtnRemoveByN
            // 
            this.BtnRemoveByN.Location = new System.Drawing.Point(209, 250);
            this.BtnRemoveByN.Name = "BtnRemoveByN";
            this.BtnRemoveByN.Size = new System.Drawing.Size(95, 49);
            this.BtnRemoveByN.TabIndex = 4;
            this.BtnRemoveByN.Text = "Remove By Name";
            this.BtnRemoveByN.UseVisualStyleBackColor = true;
            this.BtnRemoveByN.Click += new System.EventHandler(this.BtnRemoveByN_Click);
            // 
            // BtnRemoveLI
            // 
            this.BtnRemoveLI.Location = new System.Drawing.Point(601, 42);
            this.BtnRemoveLI.Name = "BtnRemoveLI";
            this.BtnRemoveLI.Size = new System.Drawing.Size(107, 57);
            this.BtnRemoveLI.TabIndex = 5;
            this.BtnRemoveLI.Text = "Remove last item";
            this.BtnRemoveLI.UseVisualStyleBackColor = true;
            this.BtnRemoveLI.Click += new System.EventHandler(this.BtnRemoveLI_Click);
            // 
            // BtnRemove2LI
            // 
            this.BtnRemove2LI.Location = new System.Drawing.Point(601, 105);
            this.BtnRemove2LI.Name = "BtnRemove2LI";
            this.BtnRemove2LI.Size = new System.Drawing.Size(107, 56);
            this.BtnRemove2LI.TabIndex = 6;
            this.BtnRemove2LI.Text = "Remove 2nd last item";
            this.BtnRemove2LI.UseVisualStyleBackColor = true;
            // 
            // BtnBack3
            // 
            this.BtnBack3.Location = new System.Drawing.Point(645, 367);
            this.BtnBack3.Name = "BtnBack3";
            this.BtnBack3.Size = new System.Drawing.Size(106, 45);
            this.BtnBack3.TabIndex = 7;
            this.BtnBack3.Text = "Back";
            this.BtnBack3.UseVisualStyleBackColor = true;
            this.BtnBack3.Click += new System.EventHandler(this.BtnBack3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days";
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack3);
            this.Controls.Add(this.BtnRemove2LI);
            this.Controls.Add(this.BtnRemoveLI);
            this.Controls.Add(this.BtnRemoveByN);
            this.Controls.Add(this.BtnRemoveByI);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.BtnMthd2);
            this.Controls.Add(this.BtnMthd1);
            this.Name = "frmCombo";
            this.Text = "frmCombo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMthd1;
        private System.Windows.Forms.Button BtnMthd2;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Button BtnRemoveByI;
        private System.Windows.Forms.Button BtnRemoveByN;
        private System.Windows.Forms.Button BtnRemoveLI;
        private System.Windows.Forms.Button BtnRemove2LI;
        private System.Windows.Forms.Button BtnBack3;
        private System.Windows.Forms.Label label1;
    }
}