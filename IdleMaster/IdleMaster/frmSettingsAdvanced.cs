using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdleMaster.Properties;

namespace IdleMaster
{
    public partial class frmSettingsAdvanced : Form
    {
        public frmSettingsAdvanced()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtSessionID.PasswordChar = '\0';
            txtsteamMachineAuth.PasswordChar = '\0';
            txtsteamLoginSecure.PasswordChar = '\0';

            txtSessionID.Enabled = true;
            txtsteamMachineAuth.Enabled = true;
            txtsteamLoginSecure.Enabled = true;

            btnView.Visible = false;
        }

        private void frmSettingsAdvanced_Load(object sender, EventArgs e)
        {
            // Localize Form
            btnUpdate.Text = localization.strings.update;
            this.Text = localization.strings.auth_data;
            ttHelp.SetToolTip(btnView, localization.strings.cookie_warning);


            if (!string.IsNullOrWhiteSpace(Settings.Default.sessionid))
            {
                txtSessionID.Text = Settings.Default.sessionid;
                txtSessionID.Enabled = false;
            }
            else
            {
                txtSessionID.PasswordChar = '\0';
            }

            if (!string.IsNullOrWhiteSpace(Settings.Default.steamLogin))
            {
                txtsteamMachineAuth.Text = Settings.Default.steamLogin;
                txtsteamMachineAuth.Enabled = false;
            }
            else
            {
                txtsteamMachineAuth.PasswordChar = '\0';
            }

            if (!string.IsNullOrWhiteSpace(Settings.Default.steamLoginSecure))
            {
                txtsteamLoginSecure.Text = Settings.Default.steamLoginSecure;
                txtsteamLoginSecure.Enabled = false;
            }
            else
            {
                txtsteamLoginSecure.PasswordChar = '\0';
            }

            if (txtSessionID.Enabled && txtsteamMachineAuth.Enabled && txtsteamLoginSecure.Enabled)
            {
                btnView.Visible = false;
            }

            btnUpdate.Enabled = false;
        }

        private void txtSessionID_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtSteamLogin_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtSteamParental_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private async Task CheckAndSave()
        {
            try
            {
                Settings.Default.sessionid = txtSessionID.Text.Trim();
                Settings.Default.steamMachineAuth = txtsteamMachineAuth.Text.Trim();
                Settings.Default.steamLoginSecure = txtsteamLoginSecure.Text.Trim();
                Settings.Default.myProfileURL = SteamProfile.GetSteamUrl();

                if (await CookieClient.IsLogined())
                {
                    Settings.Default.Save();
                    Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "frmSettingsAdvanced -> CheckAndSave");
            }

            // Invalid cookie data, reset the form
            btnUpdate.Text = localization.strings.update;
            txtSessionID.Text = "";
            txtsteamMachineAuth.Text = "";
            txtsteamLoginSecure.Text = "";
            txtSessionID.PasswordChar = '\0';
            txtsteamMachineAuth.PasswordChar = '\0';
            txtsteamLoginSecure.PasswordChar = '\0';
            txtSessionID.Enabled = true;
            txtsteamMachineAuth.Enabled = true;
            txtsteamLoginSecure.Enabled = true;
            txtSessionID.Focus();
            MessageBox.Show(localization.strings.validate_failed);
            btnUpdate.Enabled = true;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            txtSessionID.Enabled = false;
            txtsteamMachineAuth.Enabled = false;
            txtsteamLoginSecure.Enabled = false;
            btnUpdate.Text = localization.strings.validating;
            await CheckAndSave();
        }
    }
}
