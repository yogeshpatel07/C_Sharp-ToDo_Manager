namespace My_Assist
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.GbLogin = new System.Windows.Forms.GroupBox();
            this.btnNewAc = new System.Windows.Forms.Button();
            this.lblNewAc = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPWord = new System.Windows.Forms.TextBox();
            this.TxtUName = new System.Windows.Forms.TextBox();
            this.LblPWord = new System.Windows.Forms.Label();
            this.LblUName = new System.Windows.Forms.Label();
            this.GbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbLogin
            // 
            this.GbLogin.BackColor = System.Drawing.Color.Blue;
            this.GbLogin.Controls.Add(this.btnNewAc);
            this.GbLogin.Controls.Add(this.lblNewAc);
            this.GbLogin.Controls.Add(this.BtnExit);
            this.GbLogin.Controls.Add(this.BtnLogin);
            this.GbLogin.Controls.Add(this.TxtPWord);
            this.GbLogin.Controls.Add(this.TxtUName);
            this.GbLogin.Controls.Add(this.LblPWord);
            this.GbLogin.Controls.Add(this.LblUName);
            this.GbLogin.Location = new System.Drawing.Point(53, 84);
            this.GbLogin.Name = "GbLogin";
            this.GbLogin.Size = new System.Drawing.Size(582, 328);
            this.GbLogin.TabIndex = 3;
            this.GbLogin.TabStop = false;
            // 
            // btnNewAc
            // 
            this.btnNewAc.BackColor = System.Drawing.Color.White;
            this.btnNewAc.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAc.ForeColor = System.Drawing.Color.Black;
            this.btnNewAc.Location = new System.Drawing.Point(363, 254);
            this.btnNewAc.Name = "btnNewAc";
            this.btnNewAc.Size = new System.Drawing.Size(158, 47);
            this.btnNewAc.TabIndex = 5;
            this.btnNewAc.Text = "&NEW AC.";
            this.btnNewAc.UseVisualStyleBackColor = false;
            this.btnNewAc.Click += new System.EventHandler(this.btnNewAc_Click);
            // 
            // lblNewAc
            // 
            this.lblNewAc.AutoSize = true;
            this.lblNewAc.BackColor = System.Drawing.Color.Blue;
            this.lblNewAc.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAc.ForeColor = System.Drawing.Color.Yellow;
            this.lblNewAc.Location = new System.Drawing.Point(16, 260);
            this.lblNewAc.Name = "lblNewAc";
            this.lblNewAc.Size = new System.Drawing.Size(334, 37);
            this.lblNewAc.TabIndex = 15;
            this.lblNewAc.Text = "Create New Account  :";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(330, 171);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(161, 49);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "&CLEAR";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.Location = new System.Drawing.Point(118, 171);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(161, 49);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "&LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPWord
            // 
            this.TxtPWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtPWord.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPWord.Location = new System.Drawing.Point(330, 95);
            this.TxtPWord.MaxLength = 10;
            this.TxtPWord.Name = "TxtPWord";
            this.TxtPWord.PasswordChar = '*';
            this.TxtPWord.Size = new System.Drawing.Size(228, 39);
            this.TxtPWord.TabIndex = 2;
            // 
            // TxtUName
            // 
            this.TxtUName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtUName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUName.Location = new System.Drawing.Point(330, 37);
            this.TxtUName.MaxLength = 10;
            this.TxtUName.Name = "TxtUName";
            this.TxtUName.Size = new System.Drawing.Size(228, 39);
            this.TxtUName.TabIndex = 1;
            // 
            // LblPWord
            // 
            this.LblPWord.AutoSize = true;
            this.LblPWord.BackColor = System.Drawing.Color.Blue;
            this.LblPWord.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPWord.ForeColor = System.Drawing.Color.Yellow;
            this.LblPWord.Location = new System.Drawing.Point(27, 95);
            this.LblPWord.Name = "LblPWord";
            this.LblPWord.Size = new System.Drawing.Size(285, 37);
            this.LblPWord.TabIndex = 13;
            this.LblPWord.Text = "Enter Password   : ";
            // 
            // LblUName
            // 
            this.LblUName.AutoSize = true;
            this.LblUName.BackColor = System.Drawing.Color.Blue;
            this.LblUName.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUName.ForeColor = System.Drawing.Color.Yellow;
            this.LblUName.Location = new System.Drawing.Point(27, 37);
            this.LblUName.Name = "LblUName";
            this.LblUName.Size = new System.Drawing.Size(288, 37);
            this.LblUName.TabIndex = 12;
            this.LblUName.Text = "Enter User Name : ";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(694, 501);
            this.Controls.Add(this.GbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 540);
            this.MinimumSize = new System.Drawing.Size(710, 540);
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFrm_FormClosing);
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.GbLogin.ResumeLayout(false);
            this.GbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbLogin;
        private System.Windows.Forms.Button btnNewAc;
        private System.Windows.Forms.Label lblNewAc;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPWord;
        private System.Windows.Forms.TextBox TxtUName;
        private System.Windows.Forms.Label LblPWord;
        private System.Windows.Forms.Label LblUName;
    }
}

