using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using AppWatcher.Configuration;

// ReSharper disable InconsistentNaming

namespace AppWatcher
{
    public partial class ApplicationDetailsForm : Form
    {
        public const int TabPageIndex_Executable = 0;
        public const int TabPageIndex_Advanced = 1;

        public int StartTabPageIndex { get; set; } = TabPageIndex_Executable;

        public static ApplicationDetails? Create()
        {
            using var frm = new ApplicationDetailsForm();
            frm.LoadToForm(null);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var applicationDetails = new ApplicationDetails();
                frm.SaveToObject(applicationDetails);
                return applicationDetails;
            }

            return null;
        }

        public static bool Edit(ApplicationDetails applicationDetails)
        {
            using var frm = new ApplicationDetailsForm();
            frm.LoadToForm(applicationDetails);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                frm.SaveToObject(applicationDetails);
                return true;
            }

            return false;
        }

        private void LoadToForm(ApplicationDetails? applicationDetails)
        {
            // Executable
            txtExecutableFileName.Text = applicationDetails?.FileName;
            txtArguments.Text = applicationDetails?.Arguments;
            txtWorkingDirectory.Text = applicationDetails?.WorkingDirectory;
            txtDisplayName.Text = applicationDetails?.DisplayName;

            // Advanced
            chkUseShellExecute.Enabled = applicationDetails?.UseShellExecute ?? false;
            cboWindowStyle.SelectedIndex = Math.Max(0, cboWindowStyle.Items.IndexOf(applicationDetails?.WindowStyle.ToString() ?? string.Empty));

            if (applicationDetails != null)
                SetDisplayNameAsSpecific();
        }

        private void SaveToObject(ApplicationDetails applicationDetails)
        {
            applicationDetails.FileName = txtExecutableFileName.Text;
            applicationDetails.Arguments = txtArguments.Text;
            applicationDetails.WorkingDirectory = txtWorkingDirectory.Text;
            applicationDetails.DisplayName = txtDisplayName.Text;
        }

        private void SetupControls()
        {
            cboWindowStyle.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(ProcessWindowStyle)))
            {
                var text = value?.ToString() ?? string.Empty;

                cboWindowStyle.Items.Add(text);
            }
        }

        private bool ValidateData()
        {
            // TODO:
            return true;
        }

        private void SetSuggestedDisplayName(object source, string displayName)
        {
            if (txtDisplayName.Tag != txtDisplayName)
            {
                txtDisplayName.Text = Path.GetFileNameWithoutExtension(displayName);
            }
        }

        private void SetDisplayNameAsSpecific()
        {
            txtDisplayName.Tag = txtDisplayName;
        }

        public ApplicationDetailsForm()
        {
            InitializeComponent();

            SetupControls();
        }

        private void ApplicationDetailsForm_Load(object sender, EventArgs e)
        {
            tbcApplicationDetails.Dock = DockStyle.Fill;
            tbcApplicationDetails.SelectedIndex = StartTabPageIndex;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            DialogResult = DialogResult.OK;
        }

        private void txtExecutableFileName_TextChanged(object sender, EventArgs e)
        {
            SetSuggestedDisplayName(txtExecutableFileName, Path.GetFileNameWithoutExtension(txtExecutableFileName.Text));
        }

        private void txtDisplayName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetDisplayNameAsSpecific();
        }
    }
}
