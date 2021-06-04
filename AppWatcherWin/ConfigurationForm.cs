using System;
using System.Windows.Forms;

namespace AppWatcherWin
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private bool ValidateData()
        {
            return true;
        }

        private void LoadData()
        {
            nudWakeUpSeconds.Value = Convert.ToInt32(Program.AppSettings.WakeUpTimeout.TotalSeconds);
            // TODO:
        }

        private void SaveData()
        {
            Program.AppSettings.WakeUpTimeout = TimeSpan.FromSeconds(Convert.ToDouble(nudWakeUpSeconds.Value));
            // TODO:

            Program.AppSettings.Save();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            tbcContainer.Dock = DockStyle.Fill;
            tbcContainer.SelectedIndex = 0;

            LoadData();
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
                MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
