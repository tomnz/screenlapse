namespace Screenlapse
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblInterval = new System.Windows.Forms.Label();
            this.grpFinishCriteria = new System.Windows.Forms.GroupBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.optWhenStopped = new System.Windows.Forms.RadioButton();
            this.optNumScreenshots = new System.Windows.Forms.RadioButton();
            this.optTime = new System.Windows.Forms.RadioButton();
            this.txtNumScreenshots = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.folder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpFinishCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(135, 164);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(79, 27);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(12, 9);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(56, 13);
            this.lblInterval.TabIndex = 2;
            this.lblInterval.Text = "Interval (s)";
            // 
            // grpFinishCriteria
            // 
            this.grpFinishCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFinishCriteria.Controls.Add(this.dateTimePicker1);
            this.grpFinishCriteria.Controls.Add(this.txtNumScreenshots);
            this.grpFinishCriteria.Controls.Add(this.optTime);
            this.grpFinishCriteria.Controls.Add(this.optNumScreenshots);
            this.grpFinishCriteria.Controls.Add(this.optWhenStopped);
            this.grpFinishCriteria.Location = new System.Drawing.Point(12, 32);
            this.grpFinishCriteria.Name = "grpFinishCriteria";
            this.grpFinishCriteria.Size = new System.Drawing.Size(202, 92);
            this.grpFinishCriteria.TabIndex = 3;
            this.grpFinishCriteria.TabStop = false;
            this.grpFinishCriteria.Text = "Finish Criteria";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(74, 6);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(76, 20);
            this.txtInterval.TabIndex = 4;
            // 
            // optWhenStopped
            // 
            this.optWhenStopped.AutoSize = true;
            this.optWhenStopped.Checked = true;
            this.optWhenStopped.Location = new System.Drawing.Point(15, 19);
            this.optWhenStopped.Name = "optWhenStopped";
            this.optWhenStopped.Size = new System.Drawing.Size(95, 17);
            this.optWhenStopped.TabIndex = 0;
            this.optWhenStopped.TabStop = true;
            this.optWhenStopped.Text = "When stopped";
            this.optWhenStopped.UseVisualStyleBackColor = true;
            // 
            // optNumScreenshots
            // 
            this.optNumScreenshots.AutoSize = true;
            this.optNumScreenshots.Location = new System.Drawing.Point(15, 42);
            this.optNumScreenshots.Name = "optNumScreenshots";
            this.optNumScreenshots.Size = new System.Drawing.Size(94, 17);
            this.optNumScreenshots.TabIndex = 1;
            this.optNumScreenshots.Text = "# Screenshots";
            this.optNumScreenshots.UseVisualStyleBackColor = true;
            // 
            // optTime
            // 
            this.optTime.AutoSize = true;
            this.optTime.Location = new System.Drawing.Point(15, 65);
            this.optTime.Name = "optTime";
            this.optTime.Size = new System.Drawing.Size(48, 17);
            this.optTime.TabIndex = 2;
            this.optTime.Text = "Time";
            this.optTime.UseVisualStyleBackColor = true;
            // 
            // txtNumScreenshots
            // 
            this.txtNumScreenshots.Location = new System.Drawing.Point(115, 41);
            this.txtNumScreenshots.Name = "txtNumScreenshots";
            this.txtNumScreenshots.Size = new System.Drawing.Size(75, 20);
            this.txtNumScreenshots.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(12, 137);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(36, 13);
            this.lblFolder.TabIndex = 5;
            this.lblFolder.Text = "Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(54, 134);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(129, 20);
            this.txtFolder.TabIndex = 6;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(189, 132);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(25, 23);
            this.btnChooseFolder.TabIndex = 7;
            this.btnChooseFolder.Text = "...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 203);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.grpFinishCriteria);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.btnStartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Screenlapse";
            this.grpFinishCriteria.ResumeLayout(false);
            this.grpFinishCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.GroupBox grpFinishCriteria;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNumScreenshots;
        private System.Windows.Forms.RadioButton optTime;
        private System.Windows.Forms.RadioButton optNumScreenshots;
        private System.Windows.Forms.RadioButton optWhenStopped;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.FolderBrowserDialog folder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Timer timer;
    }
}

