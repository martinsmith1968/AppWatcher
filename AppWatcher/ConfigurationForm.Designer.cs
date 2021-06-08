
namespace AppWatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.tbcContainer = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblWakeUpSecondsValueDescription = new System.Windows.Forms.Label();
            this.nudWakeUpSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblWakeUpSeconds = new System.Windows.Forms.Label();
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.lvwApplications = new System.Windows.Forms.ListView();
            this.colApplicationsDisplayName = new System.Windows.Forms.ColumnHeader();
            this.colApplicationsExecutable = new System.Windows.Forms.ColumnHeader();
            this.colApplicationsArguments = new System.Windows.Forms.ColumnHeader();
            this.tlsApplications = new System.Windows.Forms.ToolStrip();
            this.tsbApplicationsAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbApplicationsEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbApplicationsMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbApplicationsMoveDown = new System.Windows.Forms.ToolStripButton();
            this.pnlButtonBar = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbcContainer.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWakeUpSeconds)).BeginInit();
            this.tabApplications.SuspendLayout();
            this.tlsApplications.SuspendLayout();
            this.pnlButtonBar.SuspendLayout();
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
            // lblWakeUpSecondsValueDescription
            // 
            this.lblWakeUpSecondsValueDescription.AutoSize = true;
            this.lblWakeUpSecondsValueDescription.Location = new System.Drawing.Point(254, 17);
            this.lblWakeUpSecondsValueDescription.Name = "lblWakeUpSecondsValueDescription";
            this.lblWakeUpSecondsValueDescription.Size = new System.Drawing.Size(50, 15);
            this.lblWakeUpSecondsValueDescription.TabIndex = 4;
            this.lblWakeUpSecondsValueDescription.Text = "seconds";
            // 
            // nudWakeUpSeconds
            // 
            this.nudWakeUpSeconds.Location = new System.Drawing.Point(151, 15);
            this.nudWakeUpSeconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudWakeUpSeconds.Name = "nudWakeUpSeconds";
            this.nudWakeUpSeconds.Size = new System.Drawing.Size(97, 23);
            this.nudWakeUpSeconds.TabIndex = 3;
            this.nudWakeUpSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWakeUpSeconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            // tabApplications
            // 
            this.tabApplications.Controls.Add(this.lvwApplications);
            this.tabApplications.Controls.Add(this.tlsApplications);
            this.tabApplications.Location = new System.Drawing.Point(4, 24);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(570, 172);
            this.tabApplications.TabIndex = 1;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // lvwApplications
            // 
            this.lvwApplications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colApplicationsDisplayName,
            this.colApplicationsExecutable,
            this.colApplicationsArguments});
            this.lvwApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwApplications.FullRowSelect = true;
            this.lvwApplications.HideSelection = false;
            this.lvwApplications.Location = new System.Drawing.Point(3, 3);
            this.lvwApplications.MultiSelect = false;
            this.lvwApplications.Name = "lvwApplications";
            this.lvwApplications.Size = new System.Drawing.Size(532, 83);
            this.lvwApplications.TabIndex = 2;
            this.lvwApplications.UseCompatibleStateImageBehavior = false;
            this.lvwApplications.View = System.Windows.Forms.View.Details;
            this.lvwApplications.DoubleClick += new System.EventHandler(this.lvwApplications_DoubleClick);
            // 
            // colApplicationsDisplayName
            // 
            this.colApplicationsDisplayName.Text = "Display Name";
            this.colApplicationsDisplayName.Width = 150;
            // 
            // colApplicationsExecutable
            // 
            this.colApplicationsExecutable.Text = "Executable";
            this.colApplicationsExecutable.Width = 150;
            // 
            // colApplicationsArguments
            // 
            this.colApplicationsArguments.Text = "Arguments";
            this.colApplicationsArguments.Width = 90;
            // 
            // tlsApplications
            // 
            this.tlsApplications.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbApplicationsAdd,
            this.toolStripSeparator1,
            this.tsbApplicationsEdit,
            this.toolStripSeparator2,
            this.tsbApplicationsMoveUp,
            this.tsbApplicationsMoveDown});
            this.tlsApplications.Location = new System.Drawing.Point(535, 3);
            this.tlsApplications.Name = "tlsApplications";
            this.tlsApplications.Size = new System.Drawing.Size(32, 166);
            this.tlsApplications.TabIndex = 1;
            this.tlsApplications.Text = "toolStrip1";
            // 
            // tsbApplicationsAdd
            // 
            this.tsbApplicationsAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbApplicationsAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplicationsAdd.Image")));
            this.tsbApplicationsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplicationsAdd.Name = "tsbApplicationsAdd";
            this.tsbApplicationsAdd.Size = new System.Drawing.Size(29, 20);
            this.tsbApplicationsAdd.Text = "Add...";
            this.tsbApplicationsAdd.Click += new System.EventHandler(this.tsbApplicationsAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(29, 6);
            // 
            // tsbApplicationsEdit
            // 
            this.tsbApplicationsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbApplicationsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplicationsEdit.Image")));
            this.tsbApplicationsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplicationsEdit.Name = "tsbApplicationsEdit";
            this.tsbApplicationsEdit.Size = new System.Drawing.Size(29, 20);
            this.tsbApplicationsEdit.Text = "&Edit...";
            this.tsbApplicationsEdit.Click += new System.EventHandler(this.tsbApplicationsEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(29, 6);
            // 
            // tsbApplicationsMoveUp
            // 
            this.tsbApplicationsMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbApplicationsMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplicationsMoveUp.Image")));
            this.tsbApplicationsMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplicationsMoveUp.Name = "tsbApplicationsMoveUp";
            this.tsbApplicationsMoveUp.Size = new System.Drawing.Size(29, 20);
            this.tsbApplicationsMoveUp.Text = "Move &Up";
            // 
            // tsbApplicationsMoveDown
            // 
            this.tsbApplicationsMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbApplicationsMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplicationsMoveDown.Image")));
            this.tsbApplicationsMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplicationsMoveDown.Name = "tsbApplicationsMoveDown";
            this.tsbApplicationsMoveDown.Size = new System.Drawing.Size(29, 20);
            this.tsbApplicationsMoveDown.Text = "Move &Down";
            // 
            // pnlButtonBar
            // 
            this.pnlButtonBar.Controls.Add(this.btnCancel);
            this.pnlButtonBar.Controls.Add(this.btnOK);
            this.pnlButtonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonBar.Location = new System.Drawing.Point(3, 251);
            this.pnlButtonBar.Name = "pnlButtonBar";
            this.pnlButtonBar.Size = new System.Drawing.Size(578, 36);
            this.pnlButtonBar.TabIndex = 1;
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
            // ConfigurationForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 290);
            this.Controls.Add(this.tbcContainer);
            this.Controls.Add(this.pnlButtonBar);
            this.Name = "ConfigurationForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.Text = "ConfigurationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigurationForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.tbcContainer.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWakeUpSeconds)).EndInit();
            this.tabApplications.ResumeLayout(false);
            this.tabApplications.PerformLayout();
            this.tlsApplications.ResumeLayout(false);
            this.tlsApplications.PerformLayout();
            this.pnlButtonBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcContainer;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.Panel pnlButtonBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblWakeUpSecondsValueDescription;
        private System.Windows.Forms.NumericUpDown nudWakeUpSeconds;
        private System.Windows.Forms.Label lblWakeUpSeconds;
        private System.Windows.Forms.ListView lvwApplications;
        private System.Windows.Forms.ColumnHeader colApplicationsDisplayName;
        private System.Windows.Forms.ColumnHeader colApplicationsExecutable;
        private System.Windows.Forms.ColumnHeader colApplicationsArguments;
        private System.Windows.Forms.ToolStrip tlsApplications;
        private System.Windows.Forms.ToolStripButton tsbApplicationsAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbApplicationsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbApplicationsMoveUp;
        private System.Windows.Forms.ToolStripButton tsbApplicationsMoveDown;
    }
}