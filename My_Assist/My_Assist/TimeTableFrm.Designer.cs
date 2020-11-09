namespace My_Assist
{
    partial class TimeTableFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTableFrm));
            this.gbNewTask = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtTskNo = new System.Windows.Forms.TextBox();
            this.lblTskNo = new System.Windows.Forms.Label();
            this.txtNtask = new System.Windows.Forms.TextBox();
            this.lblNTask = new System.Windows.Forms.Label();
            this.dtpEtime = new System.Windows.Forms.DateTimePicker();
            this.lblEtime = new System.Windows.Forms.Label();
            this.dtpStime = new System.Windows.Forms.DateTimePicker();
            this.lblStime = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.gbNewTask.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewTask
            // 
            this.gbNewTask.BackColor = System.Drawing.Color.Blue;
            this.gbNewTask.Controls.Add(this.btnBack);
            this.gbNewTask.Controls.Add(this.btnSave);
            this.gbNewTask.Controls.Add(this.btnEdit);
            this.gbNewTask.Controls.Add(this.btnDelete);
            this.gbNewTask.Controls.Add(this.btnNew);
            this.gbNewTask.Controls.Add(this.txtTskNo);
            this.gbNewTask.Controls.Add(this.lblTskNo);
            this.gbNewTask.Controls.Add(this.txtNtask);
            this.gbNewTask.Controls.Add(this.lblNTask);
            this.gbNewTask.Controls.Add(this.dtpEtime);
            this.gbNewTask.Controls.Add(this.lblEtime);
            this.gbNewTask.Controls.Add(this.dtpStime);
            this.gbNewTask.Controls.Add(this.lblStime);
            this.gbNewTask.Location = new System.Drawing.Point(13, 16);
            this.gbNewTask.Name = "gbNewTask";
            this.gbNewTask.Size = new System.Drawing.Size(669, 238);
            this.gbNewTask.TabIndex = 24;
            this.gbNewTask.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(23, 189);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "&Refresh";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(290, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(423, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 40);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(546, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(158, 189);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 40);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "&NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtTskNo
            // 
            this.txtTskNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTskNo.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTskNo.Location = new System.Drawing.Point(255, 20);
            this.txtTskNo.Name = "txtTskNo";
            this.txtTskNo.Size = new System.Drawing.Size(161, 36);
            this.txtTskNo.TabIndex = 1;
            // 
            // lblTskNo
            // 
            this.lblTskNo.AutoSize = true;
            this.lblTskNo.BackColor = System.Drawing.Color.Blue;
            this.lblTskNo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTskNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTskNo.Location = new System.Drawing.Point(23, 20);
            this.lblTskNo.Name = "lblTskNo";
            this.lblTskNo.Size = new System.Drawing.Size(210, 32);
            this.lblTskNo.TabIndex = 18;
            this.lblTskNo.Text = "Task Number    :";
            // 
            // txtNtask
            // 
            this.txtNtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNtask.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNtask.ForeColor = System.Drawing.Color.Black;
            this.txtNtask.Location = new System.Drawing.Point(255, 147);
            this.txtNtask.Name = "txtNtask";
            this.txtNtask.Size = new System.Drawing.Size(391, 36);
            this.txtNtask.TabIndex = 4;
            // 
            // lblNTask
            // 
            this.lblNTask.AutoSize = true;
            this.lblNTask.BackColor = System.Drawing.Color.Blue;
            this.lblNTask.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTask.ForeColor = System.Drawing.Color.Yellow;
            this.lblNTask.Location = new System.Drawing.Point(23, 147);
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
            this.dtpEtime.Location = new System.Drawing.Point(255, 102);
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
            this.lblEtime.Location = new System.Drawing.Point(23, 104);
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
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.Color.Blue;
            this.gbData.Controls.Add(this.dGView);
            this.gbData.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(13, 260);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(669, 229);
            this.gbData.TabIndex = 10;
            this.gbData.TabStop = false;
            // 
            // dGView
            // 
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGView.Location = new System.Drawing.Point(3, 26);
            this.dGView.Name = "dGView";
            this.dGView.Size = new System.Drawing.Size(663, 200);
            this.dGView.TabIndex = 0;
            // 
            // TimeTableFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(694, 501);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbNewTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(710, 540);
            this.MinimumSize = new System.Drawing.Size(710, 540);
            this.Name = "TimeTableFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Table Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimeTableFrm_FormClosed);
            this.Load += new System.EventHandler(this.TimeTableFrm_Load);
            this.gbNewTask.ResumeLayout(false);
            this.gbNewTask.PerformLayout();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
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
        private System.Windows.Forms.TextBox txtTskNo;
        private System.Windows.Forms.Label lblTskNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.Button btnBack;
    }
}