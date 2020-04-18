namespace SalmanAloufi_IE322
{
    partial class frmMain
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblPW = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnCheckbox = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnGrpApp = new System.Windows.Forms.Button();
            this.BtnPicBox2 = new System.Windows.Forms.Button();
            this.BtnSelfie = new System.Windows.Forms.Button();
            this.BtnPicBox = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnRndmCom = new System.Windows.Forms.Button();
            this.BtnRndm = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnPrgrs = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnJoh = new System.Windows.Forms.Button();
            this.BtnABC = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnManCell = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.BtnClasses = new System.Windows.Forms.Button();
            this.BtnMethods = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Crimson;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnExit.Location = new System.Drawing.Point(779, 362);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(326, 76);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(108, 27);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(147, 24);
            this.TxtUser.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.LblPW);
            this.groupBox1.Controls.Add(this.LblUser);
            this.groupBox1.Controls.Add(this.TxtPW);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login to IE322";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Lime;
            this.BtnLogin.Location = new System.Drawing.Point(108, 129);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(147, 47);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblPW
            // 
            this.LblPW.AutoSize = true;
            this.LblPW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblPW.Location = new System.Drawing.Point(6, 77);
            this.LblPW.Name = "LblPW";
            this.LblPW.Size = new System.Drawing.Size(66, 17);
            this.LblPW.TabIndex = 4;
            this.LblPW.Text = "Password";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblUser.Location = new System.Drawing.Point(6, 30);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(74, 17);
            this.LblUser.TabIndex = 3;
            this.LblUser.Text = "User Name";
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(108, 70);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.PasswordChar = '*';
            this.TxtPW.Size = new System.Drawing.Size(147, 24);
            this.TxtPW.TabIndex = 2;
            this.TxtPW.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAbout.Location = new System.Drawing.Point(457, 362);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(316, 76);
            this.BtnAbout.TabIndex = 3;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.BtnArray);
            this.groupBox2.Controls.Add(this.BtnCombo);
            this.groupBox2.Controls.Add(this.BtnCheckbox);
            this.groupBox2.Controls.Add(this.BtnRadio);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(143, 65);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(134, 29);
            this.BtnArray.TabIndex = 6;
            this.BtnArray.Text = "Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnCombo.Location = new System.Drawing.Point(6, 65);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(131, 29);
            this.BtnCombo.TabIndex = 5;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnCheckbox
            // 
            this.BtnCheckbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnCheckbox.Location = new System.Drawing.Point(143, 27);
            this.BtnCheckbox.Name = "BtnCheckbox";
            this.BtnCheckbox.Size = new System.Drawing.Size(136, 32);
            this.BtnCheckbox.TabIndex = 5;
            this.BtnCheckbox.Text = "CheckBox";
            this.BtnCheckbox.UseVisualStyleBackColor = false;
            this.BtnCheckbox.Click += new System.EventHandler(this.BtnCheckbox_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRadio.Location = new System.Drawing.Point(6, 27);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(131, 32);
            this.BtnRadio.TabIndex = 0;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.BtnGrpApp);
            this.groupBox3.Controls.Add(this.BtnPicBox2);
            this.groupBox3.Controls.Add(this.BtnSelfie);
            this.groupBox3.Controls.Add(this.BtnPicBox);
            this.groupBox3.Location = new System.Drawing.Point(279, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 93);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            // 
            // BtnGrpApp
            // 
            this.BtnGrpApp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnGrpApp.Location = new System.Drawing.Point(143, 58);
            this.BtnGrpApp.Name = "BtnGrpApp";
            this.BtnGrpApp.Size = new System.Drawing.Size(136, 26);
            this.BtnGrpApp.TabIndex = 6;
            this.BtnGrpApp.Text = "Groupe App";
            this.BtnGrpApp.UseVisualStyleBackColor = false;
            // 
            // BtnPicBox2
            // 
            this.BtnPicBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnPicBox2.Location = new System.Drawing.Point(6, 58);
            this.BtnPicBox2.Name = "BtnPicBox2";
            this.BtnPicBox2.Size = new System.Drawing.Size(131, 26);
            this.BtnPicBox2.TabIndex = 6;
            this.BtnPicBox2.Text = "PictureBox2";
            this.BtnPicBox2.UseVisualStyleBackColor = false;
            this.BtnPicBox2.Click += new System.EventHandler(this.BtnPicBox2_Click);
            // 
            // BtnSelfie
            // 
            this.BtnSelfie.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnSelfie.Location = new System.Drawing.Point(143, 23);
            this.BtnSelfie.Name = "BtnSelfie";
            this.BtnSelfie.Size = new System.Drawing.Size(136, 29);
            this.BtnSelfie.TabIndex = 6;
            this.BtnSelfie.Text = "SelfieApp";
            this.BtnSelfie.UseVisualStyleBackColor = false;
            // 
            // BtnPicBox
            // 
            this.BtnPicBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnPicBox.Location = new System.Drawing.Point(6, 23);
            this.BtnPicBox.Name = "BtnPicBox";
            this.BtnPicBox.Size = new System.Drawing.Size(131, 29);
            this.BtnPicBox.TabIndex = 6;
            this.BtnPicBox.Text = "PictureBox";
            this.BtnPicBox.UseVisualStyleBackColor = false;
            this.BtnPicBox.Click += new System.EventHandler(this.BtnPicBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.BtnRndmCom);
            this.groupBox4.Controls.Add(this.BtnRndm);
            this.groupBox4.Controls.Add(this.BtnTimer);
            this.groupBox4.Controls.Add(this.BtnPrgrs);
            this.groupBox4.Location = new System.Drawing.Point(570, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // BtnRndmCom
            // 
            this.BtnRndmCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRndmCom.Location = new System.Drawing.Point(149, 65);
            this.BtnRndmCom.Name = "BtnRndmCom";
            this.BtnRndmCom.Size = new System.Drawing.Size(130, 29);
            this.BtnRndmCom.TabIndex = 10;
            this.BtnRndmCom.Text = "RandomCom";
            this.BtnRndmCom.UseVisualStyleBackColor = false;
            this.BtnRndmCom.Click += new System.EventHandler(this.BtnRndmCom_Click);
            // 
            // BtnRndm
            // 
            this.BtnRndm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRndm.Location = new System.Drawing.Point(6, 65);
            this.BtnRndm.Name = "BtnRndm";
            this.BtnRndm.Size = new System.Drawing.Size(137, 29);
            this.BtnRndm.TabIndex = 9;
            this.BtnRndm.Text = "Random";
            this.BtnRndm.UseVisualStyleBackColor = false;
            this.BtnRndm.Click += new System.EventHandler(this.BtnRndm_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnTimer.Location = new System.Drawing.Point(149, 27);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(130, 32);
            this.BtnTimer.TabIndex = 8;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = false;
            // 
            // BtnPrgrs
            // 
            this.BtnPrgrs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnPrgrs.Location = new System.Drawing.Point(3, 27);
            this.BtnPrgrs.Name = "BtnPrgrs";
            this.BtnPrgrs.Size = new System.Drawing.Size(140, 32);
            this.BtnPrgrs.TabIndex = 8;
            this.BtnPrgrs.Text = "Progress";
            this.BtnPrgrs.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.BtnTalk);
            this.groupBox5.Controls.Add(this.BtnDraw);
            this.groupBox5.Location = new System.Drawing.Point(573, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 93);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw and Talk";
            // 
            // BtnTalk
            // 
            this.BtnTalk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnTalk.Location = new System.Drawing.Point(146, 23);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(130, 61);
            this.BtnTalk.TabIndex = 10;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnDraw.Location = new System.Drawing.Point(6, 23);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(134, 61);
            this.BtnDraw.TabIndex = 9;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox6.Controls.Add(this.BtnJoh);
            this.groupBox6.Controls.Add(this.BtnABC);
            this.groupBox6.Controls.Add(this.BtnRoboticCell);
            this.groupBox6.Controls.Add(this.BtnManCell);
            this.groupBox6.Location = new System.Drawing.Point(861, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(244, 319);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Exam Apps";
            // 
            // BtnJoh
            // 
            this.BtnJoh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnJoh.Location = new System.Drawing.Point(6, 248);
            this.BtnJoh.Name = "BtnJoh";
            this.BtnJoh.Size = new System.Drawing.Size(232, 65);
            this.BtnJoh.TabIndex = 10;
            this.BtnJoh.Text = "Johari";
            this.BtnJoh.UseVisualStyleBackColor = false;
            // 
            // BtnABC
            // 
            this.BtnABC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnABC.Location = new System.Drawing.Point(6, 182);
            this.BtnABC.Name = "BtnABC";
            this.BtnABC.Size = new System.Drawing.Size(232, 60);
            this.BtnABC.TabIndex = 9;
            this.BtnABC.Text = "ABC Analysis";
            this.BtnABC.UseVisualStyleBackColor = false;
            this.BtnABC.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRoboticCell.Location = new System.Drawing.Point(6, 107);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(232, 69);
            this.BtnRoboticCell.TabIndex = 8;
            this.BtnRoboticCell.Text = "Robotic Cell";
            this.BtnRoboticCell.UseVisualStyleBackColor = false;
            // 
            // BtnManCell
            // 
            this.BtnManCell.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnManCell.Location = new System.Drawing.Point(6, 27);
            this.BtnManCell.Name = "BtnManCell";
            this.BtnManCell.Size = new System.Drawing.Size(232, 72);
            this.BtnManCell.TabIndex = 8;
            this.BtnManCell.Text = "Manufacturing Cell";
            this.BtnManCell.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox7.Controls.Add(this.BtnArduino);
            this.groupBox7.Location = new System.Drawing.Point(279, 217);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(576, 114);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Micro Controller";
            // 
            // BtnArduino
            // 
            this.BtnArduino.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnArduino.Location = new System.Drawing.Point(35, 34);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(504, 58);
            this.BtnArduino.TabIndex = 0;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = false;
            this.BtnArduino.Click += new System.EventHandler(this.BtnArduino_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox8.Controls.Add(this.BtnMethods);
            this.groupBox8.Controls.Add(this.BtnClasses);
            this.groupBox8.Location = new System.Drawing.Point(12, 217);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(261, 114);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Objects orianted";
            // 
            // BtnClasses
            // 
            this.BtnClasses.Location = new System.Drawing.Point(3, 20);
            this.BtnClasses.Name = "BtnClasses";
            this.BtnClasses.Size = new System.Drawing.Size(252, 38);
            this.BtnClasses.TabIndex = 0;
            this.BtnClasses.Text = "Classes";
            this.BtnClasses.UseVisualStyleBackColor = true;
            this.BtnClasses.Click += new System.EventHandler(this.BtnClasses_Click);
            // 
            // BtnMethods
            // 
            this.BtnMethods.Location = new System.Drawing.Point(3, 64);
            this.BtnMethods.Name = "BtnMethods";
            this.BtnMethods.Size = new System.Drawing.Size(252, 44);
            this.BtnMethods.TabIndex = 1;
            this.BtnMethods.Text = "Methods";
            this.BtnMethods.UseVisualStyleBackColor = true;
            this.BtnMethods.Click += new System.EventHandler(this.BtnMethods_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Name = "frmMain";
            this.Text = "IE322_S20_KAU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblPW;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnCheckbox;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnGrpApp;
        private System.Windows.Forms.Button BtnPicBox2;
        private System.Windows.Forms.Button BtnSelfie;
        private System.Windows.Forms.Button BtnPicBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnRndmCom;
        private System.Windows.Forms.Button BtnRndm;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnPrgrs;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnJoh;
        private System.Windows.Forms.Button BtnABC;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnManCell;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button BtnMethods;
        private System.Windows.Forms.Button BtnClasses;
    }
}

