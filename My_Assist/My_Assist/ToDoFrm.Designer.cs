namespace My_Assist
{
    partial class ToDoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoFrm));
            this.btnShow = new System.Windows.Forms.Button();
            this.lblAllData = new System.Windows.Forms.Label();
            this.gbShowData = new System.Windows.Forms.GroupBox();
            this.rbNDoneS = new System.Windows.Forms.RadioButton();
            this.rbDoneS = new System.Windows.Forms.RadioButton();
            this.rbAllS = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.gbTaskType = new System.Windows.Forms.GroupBox();
            this.rbNotDone = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.BtnUser = new System.Windows.Forms.Button();
            this.gbShowData.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.gbTaskType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(528, 58);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(152, 37);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "&Show Data";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblAllData
            // 
            this.lblAllData.AutoSize = true;
            this.lblAllData.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllData.Location = new System.Drawing.Point(13, 58);
            this.lblAllData.Name = "lblAllData";
            this.lblAllData.Size = new System.Drawing.Size(209, 32);
            this.lblAllData.TabIndex = 15;
            this.lblAllData.Text = "Show all data    :";
            // 
            // gbShowData
            // 
            this.gbShowData.Controls.Add(this.rbNDoneS);
            this.gbShowData.Controls.Add(this.rbDoneS);
            this.gbShowData.Controls.Add(this.rbAllS);
            this.gbShowData.Location = new System.Drawing.Point(229, 52);
            this.gbShowData.Name = "gbShowData";
            this.gbShowData.Size = new System.Drawing.Size(293, 43);
            this.gbShowData.TabIndex = 14;
            this.gbShowData.TabStop = false;
            // 
            // rbNDoneS
            // 
            this.rbNDoneS.AutoSize = true;
            this.rbNDoneS.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNDoneS.Location = new System.Drawing.Point(171, 10);
            this.rbNDoneS.Name = "rbNDoneS";
            this.rbNDoneS.Size = new System.Drawing.Size(120, 29);
            this.rbNDoneS.TabIndex = 7;
            this.rbNDoneS.Text = "Not Done";
            this.rbNDoneS.UseVisualStyleBackColor = true;
            // 
            // rbDoneS
            // 
            this.rbDoneS.AutoSize = true;
            this.rbDoneS.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDoneS.Location = new System.Drawing.Point(84, 10);
            this.rbDoneS.Name = "rbDoneS";
            this.rbDoneS.Size = new System.Drawing.Size(81, 29);
            this.rbDoneS.TabIndex = 6;
            this.rbDoneS.Text = "Done";
            this.rbDoneS.UseVisualStyleBackColor = true;
            // 
            // rbAllS
            // 
            this.rbAllS.AutoSize = true;
            this.rbAllS.Checked = true;
            this.rbAllS.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllS.Location = new System.Drawing.Point(6, 10);
            this.rbAllS.Name = "rbAllS";
            this.rbAllS.Size = new System.Drawing.Size(56, 29);
            this.rbAllS.TabIndex = 5;
            this.rbAllS.TabStop = true;
            this.rbAllS.Text = "All";
            this.rbAllS.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(16, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 55);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "&Task Manager";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.dGView);
            this.gbData.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.ForeColor = System.Drawing.Color.Black;
            this.gbData.Location = new System.Drawing.Point(13, 107);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(669, 326);
            this.gbData.TabIndex = 12;
            this.gbData.TabStop = false;
            // 
            // dGView
            // 
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGView.Location = new System.Drawing.Point(3, 26);
            this.dGView.Name = "dGView";
            this.dGView.Size = new System.Drawing.Size(663, 297);
            this.dGView.TabIndex = 0;
            // 
            // gbTaskType
            // 
            this.gbTaskType.Controls.Add(this.rbNotDone);
            this.gbTaskType.Controls.Add(this.rbDone);
            this.gbTaskType.Controls.Add(this.rbAll);
            this.gbTaskType.Location = new System.Drawing.Point(389, 7);
            this.gbTaskType.Name = "gbTaskType";
            this.gbTaskType.Size = new System.Drawing.Size(293, 43);
            this.gbTaskType.TabIndex = 11;
            this.gbTaskType.TabStop = false;
            // 
            // rbNotDone
            // 
            this.rbNotDone.AutoSize = true;
            this.rbNotDone.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotDone.Location = new System.Drawing.Point(171, 10);
            this.rbNotDone.Name = "rbNotDone";
            this.rbNotDone.Size = new System.Drawing.Size(120, 29);
            this.rbNotDone.TabIndex = 4;
            this.rbNotDone.Text = "Not Done";
            this.rbNotDone.UseVisualStyleBackColor = true;
            this.rbNotDone.CheckedChanged += new System.EventHandler(this.rbNotDone_CheckedChanged);
            // 
            // rbDone
            // 
            this.rbDone.AutoSize = true;
            this.rbDone.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDone.Location = new System.Drawing.Point(84, 10);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(81, 29);
            this.rbDone.TabIndex = 3;
            this.rbDone.Text = "Done";
            this.rbDone.UseVisualStyleBackColor = true;
            this.rbDone.CheckedChanged += new System.EventHandler(this.rbDone_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(6, 10);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 29);
            this.rbAll.TabIndex = 2;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(229, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(153, 34);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2020, 10, 6, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(208, 32);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Select the date :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(440, 439);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 21);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "User :";
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.White;
            this.BtnUser.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.ForeColor = System.Drawing.Color.Black;
            this.BtnUser.Location = new System.Drawing.Point(222, 439);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(172, 55);
            this.BtnUser.TabIndex = 11;
            this.BtnUser.Text = "&User Manager";
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // ToDoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(694, 501);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblAllData);
            this.Controls.Add(this.gbShowData);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbTaskType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 540);
            this.MinimumSize = new System.Drawing.Size(710, 540);
            this.Name = "ToDoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDoFrm_FormClosed);
            this.Load += new System.EventHandler(this.ToDoFrm_Load);
            this.gbShowData.ResumeLayout(false);
            this.gbShowData.PerformLayout();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.gbTaskType.ResumeLayout(false);
            this.gbTaskType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblAllData;
        private System.Windows.Forms.GroupBox gbShowData;
        private System.Windows.Forms.RadioButton rbNDoneS;
        private System.Windows.Forms.RadioButton rbDoneS;
        private System.Windows.Forms.RadioButton rbAllS;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.GroupBox gbTaskType;
        private System.Windows.Forms.RadioButton rbNotDone;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button BtnUser;
    }
}