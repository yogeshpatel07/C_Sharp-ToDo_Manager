namespace My_Assist
{
    partial class EditTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTask));
            this.gbNewTask = new System.Windows.Forms.GroupBox();
            this.gbTimeTable = new System.Windows.Forms.GroupBox();
            this.btnEditTT = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtNtask = new System.Windows.Forms.TextBox();
            this.lblNTask = new System.Windows.Forms.Label();
            this.dtpEtime = new System.Windows.Forms.DateTimePicker();
            this.lblEtime = new System.Windows.Forms.Label();
            this.dtpStime = new System.Windows.Forms.DateTimePicker();
            this.lblStime = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbEditTask = new System.Windows.Forms.GroupBox();
            this.txtYouDo = new System.Windows.Forms.TextBox();
            this.lblYouDo = new System.Windows.Forms.Label();
            this.gbTaskStat = new System.Windows.Forms.GroupBox();
            this.rbNotDone = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.lblTskStat = new System.Windows.Forms.Label();
            this.txtTskNo = new System.Windows.Forms.TextBox();
            this.lblTskNo = new System.Windows.Forms.Label();
            this.gbNewTask.SuspendLayout();
            this.gbTimeTable.SuspendLayout();
            this.gbEditTask.SuspendLayout();
            this.gbTaskStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewTask
            // 
            this.gbNewTask.BackColor = System.Drawing.Color.Blue;
            this.gbNewTask.Controls.Add(this.gbTimeTable);
            this.gbNewTask.Controls.Add(this.txtNtask);
            this.gbNewTask.Controls.Add(this.lblNTask);
            this.gbNewTask.Controls.Add(this.dtpEtime);
            this.gbNewTask.Controls.Add(this.lblEtime);
            this.gbNewTask.Controls.Add(this.dtpStime);
            this.gbNewTask.Controls.Add(this.lblStime);
            this.gbNewTask.Controls.Add(this.dtpDate);
            this.gbNewTask.Controls.Add(this.lblDate);
            this.gbNewTask.Location = new System.Drawing.Point(13, 15);
            this.gbNewTask.Name = "gbNewTask";
            this.gbNewTask.Size = new System.Drawing.Size(669, 213);
            this.gbNewTask.TabIndex = 23;
            this.gbNewTask.TabStop = false;
            // 
            // gbTimeTable
            // 
            this.gbTimeTable.Controls.Add(this.btnEditTT);
            this.gbTimeTable.Controls.Add(this.btnImport);
            this.gbTimeTable.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimeTable.ForeColor = System.Drawing.Color.Yellow;
            this.gbTimeTable.Location = new System.Drawing.Point(422, 15);
            this.gbTimeTable.Name = "gbTimeTable";
            this.gbTimeTable.Size = new System.Drawing.Size(241, 141);
            this.gbTimeTable.TabIndex = 18;
            this.gbTimeTable.TabStop = false;
            this.gbTimeTable.Text = "Time Table";
            // 
            // btnEditTT
            // 
            this.btnEditTT.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTT.ForeColor = System.Drawing.Color.Black;
            this.btnEditTT.Location = new System.Drawing.Point(6, 95);
            this.btnEditTT.Name = "btnEditTT";
            this.btnEditTT.Size = new System.Drawing.Size(229, 40);
            this.btnEditTT.TabIndex = 6;
            this.btnEditTT.Text = "Edit &Time Table";
            this.btnEditTT.UseVisualStyleBackColor = true;
            this.btnEditTT.Click += new System.EventHandler(this.btnEditTT_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(6, 41);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(229, 40);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "&Import from Time Table";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtNtask
            // 
            this.txtNtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNtask.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNtask.ForeColor = System.Drawing.Color.Black;
            this.txtNtask.Location = new System.Drawing.Point(255, 162);
            this.txtNtask.Name = "txtNtask";
            this.txtNtask.Size = new System.Drawing.Size(391, 36);
            this.txtNtask.TabIndex = 7;
            // 
            // lblNTask
            // 
            this.lblNTask.AutoSize = true;
            this.lblNTask.BackColor = System.Drawing.Color.Blue;
            this.lblNTask.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTask.ForeColor = System.Drawing.Color.Yellow;
            this.lblNTask.Location = new System.Drawing.Point(23, 162);
            this.lblNTask.Name = "lblNTask";
            this.lblNTask.Size = new System.Drawing.Size(212, 32);
            this.lblNTask.TabIndex = 16;
            this.lblNTask.Text = "Enter the Task  :";
            // 
            // dtpEtime
            // 
            this.dtpEtime.CustomFormat = "";
            this.dtpEtime.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Bold);
            this.dtpEtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEtime.Location = new System.Drawing.Point(255, 109);
            this.dtpEtime.Name = "dtpEtime";
            this.dtpEtime.Size = new System.Drawing.Size(161, 34);
            this.dtpEtime.TabIndex = 3;
            this.dtpEtime.Value = new System.DateTime(2020, 6, 16, 0, 0, 0, 0);
            // 
            // lblEtime
            // 
            this.lblEtime.AutoSize = true;
            this.lblEtime.BackColor = System.Drawing.Color.Blue;
            this.lblEtime.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtime.ForeColor = System.Drawing.Color.Yellow;
            this.lblEtime.Location = new System.Drawing.Point(23, 111);
            this.lblEtime.Name = "lblEtime";
            this.lblEtime.Size = new System.Drawing.Size(211, 32);
            this.lblEtime.TabIndex = 14;
            this.lblEtime.Text = "End time             :";
            // 
            // dtpStime
            // 
            this.dtpStime.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Bold);
            this.dtpStime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStime.Location = new System.Drawing.Point(255, 62);
            this.dtpStime.Name = "dtpStime";
            this.dtpStime.Size = new System.Drawing.Size(161, 34);
            this.dtpStime.TabIndex = 2;
            this.dtpStime.Value = new System.DateTime(2020, 6, 16, 0, 0, 0, 0);
            // 
            // lblStime
            // 
            this.lblStime.AutoSize = true;
            this.lblStime.BackColor = System.Drawing.Color.Blue;
            this.lblStime.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStime.ForeColor = System.Drawing.Color.Yellow;
            this.lblStime.Location = new System.Drawing.Point(23, 64);
            this.lblStime.Name = "lblStime";
            this.lblStime.Size = new System.Drawing.Size(211, 32);
            this.lblStime.TabIndex = 12;
            this.lblStime.Text = "Start time           :";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(255, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(161, 34);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2020, 10, 6, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Blue;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblDate.Location = new System.Drawing.Point(23, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(208, 32);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Select the date :";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(294, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(427, 446);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 40);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(550, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 40);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(162, 446);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 40);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 446);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbEditTask
            // 
            this.gbEditTask.BackColor = System.Drawing.Color.Blue;
            this.gbEditTask.Controls.Add(this.txtYouDo);
            this.gbEditTask.Controls.Add(this.lblYouDo);
            this.gbEditTask.Controls.Add(this.gbTaskStat);
            this.gbEditTask.Controls.Add(this.lblTskStat);
            this.gbEditTask.Controls.Add(this.txtTskNo);
            this.gbEditTask.Controls.Add(this.lblTskNo);
            this.gbEditTask.Location = new System.Drawing.Point(13, 234);
            this.gbEditTask.Name = "gbEditTask";
            this.gbEditTask.Size = new System.Drawing.Size(669, 190);
            this.gbEditTask.TabIndex = 17;
            this.gbEditTask.TabStop = false;
            this.gbEditTask.Visible = false;
            // 
            // txtYouDo
            // 
            this.txtYouDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtYouDo.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYouDo.ForeColor = System.Drawing.Color.Black;
            this.txtYouDo.Location = new System.Drawing.Point(316, 129);
            this.txtYouDo.Name = "txtYouDo";
            this.txtYouDo.Size = new System.Drawing.Size(324, 36);
            this.txtYouDo.TabIndex = 11;
            // 
            // lblYouDo
            // 
            this.lblYouDo.AutoSize = true;
            this.lblYouDo.BackColor = System.Drawing.Color.Blue;
            this.lblYouDo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouDo.ForeColor = System.Drawing.Color.Yellow;
            this.lblYouDo.Location = new System.Drawing.Point(17, 131);
            this.lblYouDo.Name = "lblYouDo";
            this.lblYouDo.Size = new System.Drawing.Size(281, 32);
            this.lblYouDo.TabIndex = 14;
            this.lblYouDo.Text = "What do you have do :";
            // 
            // gbTaskStat
            // 
            this.gbTaskStat.BackColor = System.Drawing.Color.Blue;
            this.gbTaskStat.Controls.Add(this.rbNotDone);
            this.gbTaskStat.Controls.Add(this.rbDone);
            this.gbTaskStat.ForeColor = System.Drawing.Color.Yellow;
            this.gbTaskStat.Location = new System.Drawing.Point(249, 71);
            this.gbTaskStat.Name = "gbTaskStat";
            this.gbTaskStat.Size = new System.Drawing.Size(219, 43);
            this.gbTaskStat.TabIndex = 13;
            this.gbTaskStat.TabStop = false;
            // 
            // rbNotDone
            // 
            this.rbNotDone.AutoSize = true;
            this.rbNotDone.BackColor = System.Drawing.Color.Blue;
            this.rbNotDone.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotDone.ForeColor = System.Drawing.Color.Yellow;
            this.rbNotDone.Location = new System.Drawing.Point(93, 8);
            this.rbNotDone.Name = "rbNotDone";
            this.rbNotDone.Size = new System.Drawing.Size(120, 29);
            this.rbNotDone.TabIndex = 10;
            this.rbNotDone.Text = "Not Done";
            this.rbNotDone.UseVisualStyleBackColor = false;
            // 
            // rbDone
            // 
            this.rbDone.AutoSize = true;
            this.rbDone.Checked = true;
            this.rbDone.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDone.Location = new System.Drawing.Point(6, 8);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(81, 29);
            this.rbDone.TabIndex = 9;
            this.rbDone.TabStop = true;
            this.rbDone.Text = "Done";
            this.rbDone.UseVisualStyleBackColor = true;
            // 
            // lblTskStat
            // 
            this.lblTskStat.AutoSize = true;
            this.lblTskStat.BackColor = System.Drawing.Color.Blue;
            this.lblTskStat.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTskStat.ForeColor = System.Drawing.Color.Yellow;
            this.lblTskStat.Location = new System.Drawing.Point(17, 75);
            this.lblTskStat.Name = "lblTskStat";
            this.lblTskStat.Size = new System.Drawing.Size(210, 32);
            this.lblTskStat.TabIndex = 12;
            this.lblTskStat.Text = "Task Status        :";
            // 
            // txtTskNo
            // 
            this.txtTskNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTskNo.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTskNo.ForeColor = System.Drawing.Color.Black;
            this.txtTskNo.Location = new System.Drawing.Point(249, 29);
            this.txtTskNo.Name = "txtTskNo";
            this.txtTskNo.Size = new System.Drawing.Size(391, 36);
            this.txtTskNo.TabIndex = 8;
            // 
            // lblTskNo
            // 
            this.lblTskNo.AutoSize = true;
            this.lblTskNo.BackColor = System.Drawing.Color.Blue;
            this.lblTskNo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTskNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTskNo.Location = new System.Drawing.Point(17, 29);
            this.lblTskNo.Name = "lblTskNo";
            this.lblTskNo.Size = new System.Drawing.Size(210, 32);
            this.lblTskNo.TabIndex = 10;
            this.lblTskNo.Text = "Task Number    :";
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(694, 501);
            this.Controls.Add(this.gbNewTask);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbEditTask);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 540);
            this.MinimumSize = new System.Drawing.Size(710, 540);
            this.Name = "EditTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditTask_FormClosed);
            this.Load += new System.EventHandler(this.EditTask_Load);
            this.gbNewTask.ResumeLayout(false);
            this.gbNewTask.PerformLayout();
            this.gbTimeTable.ResumeLayout(false);
            this.gbEditTask.ResumeLayout(false);
            this.gbEditTask.PerformLayout();
            this.gbTaskStat.ResumeLayout(false);
            this.gbTaskStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewTask;
        private System.Windows.Forms.TextBox txtNtask;
        private System.Windows.Forms.Label lblNTask;
        private System.Windows.Forms.DateTimePicker dtpEtime;
        private System.Windows.Forms.Label lblEtime;
        private System.Windows.Forms.DateTimePicker dtpStime;
        private System.Windows.Forms.Label lblStime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbEditTask;
        private System.Windows.Forms.TextBox txtYouDo;
        private System.Windows.Forms.Label lblYouDo;
        private System.Windows.Forms.GroupBox gbTaskStat;
        private System.Windows.Forms.RadioButton rbNotDone;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.Label lblTskStat;
        private System.Windows.Forms.TextBox txtTskNo;
        private System.Windows.Forms.Label lblTskNo;
        private System.Windows.Forms.GroupBox gbTimeTable;
        private System.Windows.Forms.Button btnEditTT;
        private System.Windows.Forms.Button btnImport;
    }
}