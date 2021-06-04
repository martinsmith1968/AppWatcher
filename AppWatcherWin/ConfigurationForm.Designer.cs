
namespace AppWatcherWin
{
    partial class ConfigurationForm
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
            this.tbcContainer = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudWakeUpSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblWakeUpSeconds = new System.Windows.Forms.Label();
            this.lblWakeUpSecondsValueDescription = new System.Windows.Forms.Label();
            this.tbcContainer.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWakeUpSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcContainer
            // 
            this.tbcContainer.Controls.Add(this.tabSettings);
            this.tbcContainer.Controls.Add(this.tabApplications);
            this.tbcContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcContainer.Location = new System.Drawing.Point(3, 3);
            this.tbcContainer.Name = "tbcContainer";
            this.tbcContainer.SelectedIndex = 0;
            this.tbcContainer.Size = new System.Drawing.Size(578, 200);
            this.tbcContainer.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblWakeUpSecondsValueDescription);
            this.tabSettings.Controls.Add(this.nudWakeUpSeconds);
            this.tabSettings.Controls.Add(this.lblWakeUpSeconds);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(570, 172);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabApplications
            // 
            this.tabApplications.Location = new System.Drawing.Point(4, 24);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(570, 172);
            this.tabApplications.TabIndex = 1;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 36);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(419, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(500, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nudWakeUpSeconds
            // 
            this.nudWakeUpSeconds.Location = new System.Drawing.Point(151, 15);
            this.nudWakeUpSeconds.Name = "nudWakeUpSeconds";
            this.nudWakeUpSeconds.Size = new System.Drawing.Size(120, 23);
            this.nudWakeUpSeconds.TabIndex = 3;
            this.nudWakeUpSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWakeUpSeconds
            // 
            this.lblWakeUpSeconds.AutoSize = true;
            this.lblWakeUpSeconds.Location = new System.Drawing.Point(6, 17);
            this.lblWakeUpSeconds.Name = "lblWakeUpSeconds";
            this.lblWakeUpSeconds.Size = new System.Drawing.Size(139, 15);
            this.lblWakeUpSeconds.TabIndex = 2;
            this.lblWakeUpSeconds.Text = "Interval between checks :";
            // 
            // lblWakeUpSecondsValueDescription
            // 
            this.lblWakeUpSecondsValueDescription.AutoSize = true;
            this.lblWakeUpSecondsValueDescription.Location = new System.Drawing.Point(278, 17);
            this.lblWakeUpSecondsValueDescription.Name = "lblWakeUpSecondsValueDescription";
            this.lblWakeUpSecondsValueDescription.Size = new System.Drawing.Size(50, 15);
            this.lblWakeUpSecondsValueDescription.TabIndex = 4;
            this.lblWakeUpSecondsValueDescription.Text = "seconds";
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcContainer);
            this.Name = "ConfigurationForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.tbcContainer.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWakeUpSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcContainer;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblWakeUpSecondsValueDescription;
        private System.Windows.Forms.NumericUpDown nudWakeUpSeconds;
        private System.Windows.Forms.Label lblWakeUpSeconds;
    }
}