using System;
using System.Windows.Forms;
using AppWatcherWin.Configuration;

// ReSharper disable InconsistentNaming

namespace AppWatcherWin
{
    public partial class ConfigurationForm : Form
    {
        public const int TabPageIndex_Settings = 0;
        public const int TabPageIndex_Applications = 1;

        public int StartTabPageIndex { get; set; } = TabPageIndex_Settings;

        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigureUIState()
        {
            var isItemSelected = lvwApplications.SelectedItems.Count > 0;
            var selectedItemIndex = isItemSelected ? lvwApplications.SelectedIndices[0] : -1;
            var itemCount = lvwApplications.Items.Count;

            tsbApplicationsEdit.Enabled = isItemSelected;
            tsbApplicationsMoveUp.Enabled = isItemSelected && selectedItemIndex > 0;
            tsbApplicationsMoveDown.Enabled = isItemSelected && selectedItemIndex < itemCount;
        }

        private bool ValidateData()
        {
            // TODO:
            return true;
        }

        private void LoadData()
        {
            nudWakeUpSeconds.Value = Convert.ToInt32(ApplicationContext.AppSettings.WakeUpTimeout.TotalSeconds);
            foreach (var applicationDetail in ApplicationContext.AppSettings.Applications)
            {
                AddToListView(applicationDetail);
            }
        }

        private void AddToListView(ApplicationDetails applicationDetail)
        {
            var listItem = lvwApplications.Items.Add(new ListViewItem());

            ReplaceListView(listItem.Index, applicationDetail);
        }

        private void ReplaceListView(int itemIndex, ApplicationDetails applicationDetail)
        {
            var listItem = lvwApplications.Items[itemIndex];

            listItem.Tag = applicationDetail;
            listItem.Text = applicationDetail.DisplayName;

            listItem.SubItems.Clear();

            listItem.SubItems.Add(applicationDetail.FileName);
            listItem.SubItems.Add(applicationDetail.Arguments);
            listItem.SubItems.Add(applicationDetail.WorkingDirectory);
        }

        private void SaveData()
        {
            ApplicationContext.AppSettings.WakeUpTimeout = TimeSpan.FromSeconds(Convert.ToDouble(nudWakeUpSeconds.Value));

            ApplicationContext.AppSettings.Applications.Clear();
            foreach (ListViewItem? listItem in lvwApplications.Items)
            {
                if (listItem?.Tag is ApplicationDetails applicationDetail)
                    ApplicationContext.AppSettings.Applications.Add(applicationDetail);
            }

            ApplicationContext.AppSettings.Save();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            Icon = System.Drawing.Icon.FromHandle(Resources.ConfigurationImage.GetHicon());

            tbcContainer.Dock = DockStyle.Fill;
            tbcContainer.SelectedIndex = StartTabPageIndex;

            lvwApplications.Dock = DockStyle.Fill;

            nudWakeUpSeconds.Maximum = Convert.ToDecimal(TimeSpan.FromHours(24).TotalSeconds);

            LoadData();

            Application.Idle += ApplicationOnIdle;
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Idle -= ApplicationOnIdle;
        }

        private void ApplicationOnIdle(object? sender, EventArgs e)
        {
            ConfigureUIState();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult = DialogResult.OK;
        }

        private void lvwApplications_DoubleClick(object sender, EventArgs e)
        {
            if (lvwApplications.SelectedItems.Count > 0)
            {
                tsbApplicationsEdit.PerformClick();
            }
        }

        private void tsbApplicationsAdd_Click(object sender, EventArgs e)
        {
            var applicationDetails = ApplicationDetailsForm.Create();
            if (applicationDetails != null)
            {
                AddToListView(applicationDetails);
            }
        }

        private void tsbApplicationsEdit_Click(object sender, EventArgs e)
        {
            var selectedItemIndex = lvwApplications.SelectedItems.Count > 0
                 ? lvwApplications.SelectedIndices[0]
                 : -1;

            if (selectedItemIndex >= 0 && lvwApplications.Items[selectedItemIndex].Tag is ApplicationDetails applicationDetails && ApplicationDetailsForm.Edit(applicationDetails))
            {
                ReplaceListView(selectedItemIndex, applicationDetails);
            }
        }
    }
}
