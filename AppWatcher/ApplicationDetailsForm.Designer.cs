
namespace AppWatcher
{
    partial class ApplicationDetailsForm
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
            this.pnlButtonBar = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbcApplicationDetails = new System.Windows.Forms.TabControl();
            this.tbpExecutable = new System.Windows.Forms.TabPage();
            this.tbpAdvanced = new System.Windows.Forms.TabPage();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.btnBrowseWorkingDirectory = new System.Windows.Forms.Button();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.lblWorkingDirectory = new System.Windows.Forms.Label();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.lblArguments = new System.Windows.Forms.Label();
            this.btnBrowseExecutableFileName = new System.Windows.Forms.Button();
            this.txtExecutableFileName = new System.Windows.Forms.TextBox();
            this.lblExecutableFileName = new System.Windows.Forms.Label();
            this.lblUseShellExecute = new System.Windows.Forms.Label();
            this.chkUseShellExecute = new System.Windows.Forms.CheckBox();
            this.lblWindowStyle = new System.Windows.Forms.Label();
            this.cboWindowStyle = new System.Windows.Forms.ComboBox();
            this.pnlButtonBar.SuspendLayout();
            this.tbcApplicationDetails.SuspendLayout();
            this.tbpExecutable.SuspendLayout();
            this.tbpAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonBar
            // 
            this.pnlButtonBar.Controls.Add(this.btnTest);
            this.pnlButtonBar.Controls.Add(this.btnCancel);
            this.pnlButtonBar.Controls.Add(this.btnOK);
            this.pnlButtonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonBar.Location = new System.Drawing.Point(3, 283);
            this.pnlButtonBar.Name = "pnlButtonBar";
            this.pnlButtonBar.Size = new System.Drawing.Size(475, 36);
            this.pnlButtonBar.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(3, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "&Test...";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(397, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(316, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbcApplicationDetails
            // 
            this.tbcApplicationDetails.Controls.Add(this.tbpExecutable);
            this.tbcApplicationDetails.Controls.Add(this.tbpAdvanced);
            this.tbcApplicationDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcApplicationDetails.Location = new System.Drawing.Point(3, 3);
            this.tbcApplicationDetails.Name = "tbcApplicationDetails";
            this.tbcApplicationDetails.SelectedIndex = 0;
            this.tbcApplicationDetails.Size = new System.Drawing.Size(475, 247);
            this.tbcApplicationDetails.TabIndex = 2;
            // 
            // tbpExecutable
            // 
            this.tbpExecutable.Controls.Add(this.txtDisplayName);
            this.tbpExecutable.Controls.Add(this.lblDisplayName);
            this.tbpExecutable.Controls.Add(this.btnBrowseWorkingDirectory);
            this.tbpExecutable.Controls.Add(this.txtWorkingDirectory);
            this.tbpExecutable.Controls.Add(this.lblWorkingDirectory);
            this.tbpExecutable.Controls.Add(this.txtArguments);
            this.tbpExecutable.Controls.Add(this.lblArguments);
            this.tbpExecutable.Controls.Add(this.btnBrowseExecutableFileName);
            this.tbpExecutable.Controls.Add(this.txtExecutableFileName);
            this.tbpExecutable.Controls.Add(this.lblExecutableFileName);
            this.tbpExecutable.Location = new System.Drawing.Point(4, 24);
            this.tbpExecutable.Name = "tbpExecutable";
            this.tbpExecutable.Padding = new System.Windows.Forms.Padding(3);
            this.tbpExecutable.Size = new System.Drawing.Size(467, 219);
            this.tbpExecutable.TabIndex = 0;
            this.tbpExecutable.Text = "Executable";
            this.tbpExecutable.UseVisualStyleBackColor = true;
            // 
            // tbpAdvanced
            // 
            this.tbpAdvanced.Controls.Add(this.cboWindowStyle);
            this.tbpAdvanced.Controls.Add(this.lblWindowStyle);
            this.tbpAdvanced.Controls.Add(this.chkUseShellExecute);
            this.tbpAdvanced.Controls.Add(this.lblUseShellExecute);
            this.tbpAdvanced.Location = new System.Drawing.Point(4, 24);
            this.tbpAdvanced.Name = "tbpAdvanced";
            this.tbpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdvanced.Size = new System.Drawing.Size(467, 219);
            this.tbpAdvanced.TabIndex = 1;
            this.tbpAdvanced.Text = "Advanced";
            this.tbpAdvanced.UseVisualStyleBackColor = true;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(97, 175);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(332, 23);
            this.txtDisplayName.TabIndex = 19;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(8, 178);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(86, 15);
            this.lblDisplayName.TabIndex = 18;
            this.lblDisplayName.Text = "Displ&ay Name :";
            // 
            // btnBrowseWorkingDirectory
            // 
            this.btnBrowseWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseWorkingDirectory.Location = new System.Drawing.Point(435, 133);
            this.btnBrowseWorkingDirectory.Name = "btnBrowseWorkingDirectory";
            this.btnBrowseWorkingDirectory.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseWorkingDirectory.TabIndex = 17;
            this.btnBrowseWorkingDirectory.Text = "...";
            this.btnBrowseWorkingDirectory.UseVisualStyleBackColor = true;
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingDirectory.Location = new System.Drawing.Point(97, 133);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(332, 23);
            this.txtWorkingDirectory.TabIndex = 16;
            // 
            // lblWorkingDirectory
            // 
            this.lblWorkingDirectory.Location = new System.Drawing.Point(8, 121);
            this.lblWorkingDirectory.Name = "lblWorkingDirectory";
            this.lblWorkingDirectory.Size = new System.Drawing.Size(83, 35);
            this.lblWorkingDirectory.TabIndex = 15;
            this.lblWorkingDirectory.Text = "Working &Directory :";
            // 
            // txtArguments
            // 
            this.txtArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArguments.Location = new System.Drawing.Point(97, 59);
            this.txtArguments.Multiline = true;
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(332, 55);
            this.txtArguments.TabIndex = 14;
            // 
            // lblArguments
            // 
            this.lblArguments.AutoSize = true;
            this.lblArguments.Location = new System.Drawing.Point(8, 62);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(72, 15);
            this.lblArguments.TabIndex = 13;
            this.lblArguments.Text = "&Arguments :";
            // 
            // btnBrowseExecutableFileName
            // 
            this.btnBrowseExecutableFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseExecutableFileName.Location = new System.Drawing.Point(435, 13);
            this.btnBrowseExecutableFileName.Name = "btnBrowseExecutableFileName";
            this.btnBrowseExecutableFileName.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseExecutableFileName.TabIndex = 12;
            this.btnBrowseExecutableFileName.Text = "...";
            this.btnBrowseExecutableFileName.UseVisualStyleBackColor = true;
            // 
            // txtExecutableFileName
            // 
            this.txtExecutableFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExecutableFileName.Location = new System.Drawing.Point(97, 14);
            this.txtExecutableFileName.Name = "txtExecutableFileName";
            this.txtExecutableFileName.Size = new System.Drawing.Size(332, 23);
            this.txtExecutableFileName.TabIndex = 11;
            // 
            // lblExecutableFileName
            // 
            this.lblExecutableFileName.AutoSize = true;
            this.lblExecutableFileName.Location = new System.Drawing.Point(8, 17);
            this.lblExecutableFileName.Name = "lblExecutableFileName";
            this.lblExecutableFileName.Size = new System.Drawing.Size(66, 15);
            this.lblExecutableFileName.TabIndex = 10;
            this.lblExecutableFileName.Text = "&File Name :";
            // 
            // lblUseShellExecute
            // 
            this.lblUseShellExecute.AutoSize = true;
            this.lblUseShellExecute.Location = new System.Drawing.Point(8, 17);
            this.lblUseShellExecute.Name = "lblUseShellExecute";
            this.lblUseShellExecute.Size = new System.Drawing.Size(104, 15);
            this.lblUseShellExecute.TabIndex = 11;
            this.lblUseShellExecute.Text = "Use &Shell Execute :";
            // 
            // chkUseShellExecute
            // 
            this.chkUseShellExecute.AutoSize = true;
            this.chkUseShellExecute.Location = new System.Drawing.Point(118, 18);
            this.chkUseShellExecute.Name = "chkUseShellExecute";
            this.chkUseShellExecute.Size = new System.Drawing.Size(15, 14);
            this.chkUseShellExecute.TabIndex = 12;
            this.chkUseShellExecute.UseVisualStyleBackColor = true;
            // 
            // lblWindowStyle
            // 
            this.lblWindowStyle.AutoSize = true;
            this.lblWindowStyle.Location = new System.Drawing.Point(8, 48);
            this.lblWindowStyle.Name = "lblWindowStyle";
            this.lblWindowStyle.Size = new System.Drawing.Size(85, 15);
            this.lblWindowStyle.TabIndex = 13;
            this.lblWindowStyle.Text = "Window St&yle :";
            // 
            // cboWindowStyle
            // 
            this.cboWindowStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWindowStyle.FormattingEnabled = true;
            this.cboWindowStyle.Location = new System.Drawing.Point(118, 45);
            this.cboWindowStyle.Name = "cboWindowStyle";
            this.cboWindowStyle.Size = new System.Drawing.Size(149, 23);
            this.cboWindowStyle.TabIndex = 14;
            // 
            // ApplicationDetailsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(481, 322);
            this.Controls.Add(this.tbcApplicationDetails);
            this.Controls.Add(this.pnlButtonBar);
            this.Name = "ApplicationDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "ApplicationDetailsForm";
            this.Load += new System.EventHandler(this.ApplicationDetailsForm_Load);
            this.pnlButtonBar.ResumeLayout(false);
            this.tbcApplicationDetails.ResumeLayout(false);
            this.tbpExecutable.ResumeLayout(false);
            this.tbpExecutable.PerformLayout();
            this.tbpAdvanced.ResumeLayout(false);
            this.tbpAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TabControl tbcApplicationDetails;
        private System.Windows.Forms.TabPage tbpExecutable;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Button btnBrowseWorkingDirectory;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Label lblWorkingDirectory;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label lblArguments;
        private System.Windows.Forms.Button btnBrowseExecutableFileName;
        private System.Windows.Forms.TextBox txtExecutableFileName;
        private System.Windows.Forms.Label lblExecutableFileName;
        private System.Windows.Forms.TabPage tbpAdvanced;
        private System.Windows.Forms.CheckBox chkUseShellExecute;
        private System.Windows.Forms.Label lblUseShellExecute;
        private System.Windows.Forms.ComboBox cboWindowStyle;
        private System.Windows.Forms.Label lblWindowStyle;
    }
}