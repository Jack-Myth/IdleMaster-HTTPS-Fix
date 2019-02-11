using System;
using System.Windows.Forms;
using IdleMaster.Properties;
using System.Threading;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Text;

namespace IdleMaster
{
    public partial class frmSettings : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radIdleDefault.Checked)
            {
                Settings.Default.sort = "default";
            }
            if (radIdleLeastDrops.Checked)
            {
                Settings.Default.sort = "leastcards";
            }
            if (radIdleMostDrops.Checked)
            {
                Settings.Default.sort = "mostcards";
            }
            if (radIdleMostValue.Checked)
            {
                Settings.Default.sort = "mostvalue";
            }

            if (cboLanguage.Text != "")
            {
                if (cboLanguage.Text != Settings.Default.language)
                {
                    MessageBox.Show(localization.strings.please_restart);
                }
                Settings.Default.language = cboLanguage.Text;
            }

            if (radOneThenMany.Checked)
            {
                Settings.Default.OnlyOneGameIdle = false;
                Settings.Default.OneThenMany = true;
            }
            else
            {
                Settings.Default.OnlyOneGameIdle = radOneGameOnly.Checked && !radManyThenOne.Checked;
                Settings.Default.OneThenMany = false;
            }
            Settings.Default.minToTray = chkMinToTray.Checked;
            Settings.Default.ignoreclient = chkIgnoreClientStatus.Checked;
            Settings.Default.showUsername = chkShowUsername.Checked;
            Settings.Default.LoginTimeout = Maxtimeout.SelectedIndex;
            Settings.Default.LoginPageRedirect = PageRedit.SelectedIndex;
            Settings.Default.MaxIdleCount = int.Parse(textBox1.Text);
            Settings.Default.Save();
            Close();
        }
        //以下为魔改代码
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        private string MinRuntime_s;
        private void LoadForm()
        {
            try
            {
                //获取最小运行时间
                StringBuilder temp = new StringBuilder(500);
                GetPrivateProfileString("AutoNext", "MinRuntime", "2", temp, 500, ".\\Settings.ini");
                if (temp.ToString() == "")
                { MinRuntime_s = "2"; }
                else
                {
                    MinRuntime_s = temp.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序发生错误，即将退出！\r\n错误信息：" + ex.Message);
                System.Environment.Exit(0);
            }
        }
    

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadForm();
            if (Settings.Default.language != "")
            {
                cboLanguage.SelectedItem = Settings.Default.language;
            }
            else
            {
                switch (Thread.CurrentThread.CurrentUICulture.EnglishName)
                {
                    case "Chinese (Simplified, China)":
                    case "Chinese (Traditional, China)":
                    case "Portuguese (Brazil)":
                        cboLanguage.SelectedItem = Thread.CurrentThread.CurrentUICulture.EnglishName;
                        break;
                    default:
                        cboLanguage.SelectedItem = Regex.Replace(Thread.CurrentThread.CurrentUICulture.EnglishName, @"\(.+\)", "").Trim();
                        break;
                }
            }

            switch (Settings.Default.sort)
            {
                case "leastcards":
                    radIdleLeastDrops.Checked = true;
                    break;
                case "mostcards":
                    radIdleMostDrops.Checked = true;
                    break;
                case "mostvalue":
                    radIdleMostValue.Checked = true;
                    break;
                default:
                    break;
            }

            // Load translation
            this.Text = localization.strings.idle_master_settings;
            grpGeneral.Text = localization.strings.general;
            grpIdlingQuantity.Text = localization.strings.idling_behavior;
            grpPriority.Text = localization.strings.idling_order;
            btnOK.Text = localization.strings.accept;
            btnCancel.Text = localization.strings.cancel;
            ttHints.SetToolTip(btnAdvanced, localization.strings.advanced_auth);
            chkMinToTray.Text = localization.strings.minimize_to_tray;
            ttHints.SetToolTip(chkMinToTray, localization.strings.minimize_to_tray);
            chkIgnoreClientStatus.Text = localization.strings.ignore_client_status;
            ttHints.SetToolTip(chkIgnoreClientStatus, localization.strings.ignore_client_status);
            chkShowUsername.Text = localization.strings.show_username;
            ttHints.SetToolTip(chkShowUsername, localization.strings.show_username);
            radOneGameOnly.Text = localization.strings.idle_individual;
            ttHints.SetToolTip(radOneGameOnly, localization.strings.idle_individual);

            //以下为魔改代码
            //radManyThenOne.Text = localization.strings.idle_simultaneous;
            //ttHints.SetToolTip(radManyThenOne, localization.strings.idle_simultaneous);
            //radOneThenMany.Text = localization.strings.idle_onethenmany;
            //ttHints.SetToolTip(radOneThenMany, localization.strings.idle_onethenmany);
            radManyThenOne.Text = localization.strings.idle_simultaneous.Replace("2", MinRuntime_s);
            ttHints.SetToolTip(radManyThenOne, localization.strings.idle_simultaneous.Replace("2", MinRuntime_s));
            radOneThenMany.Text = localization.strings.idle_onethenmany.Replace("2", MinRuntime_s);
            ttHints.SetToolTip(radOneThenMany, localization.strings.idle_onethenmany.Replace("2", MinRuntime_s));

            radIdleDefault.Text = localization.strings.order_default;
            ttHints.SetToolTip(radIdleDefault, localization.strings.order_default);
            radIdleMostValue.Text = localization.strings.order_value;
            ttHints.SetToolTip(radIdleMostValue, localization.strings.order_value);
            radIdleMostDrops.Text = localization.strings.order_most;
            ttHints.SetToolTip(radIdleMostDrops, localization.strings.order_most);
            radIdleLeastDrops.Text = localization.strings.order_least;
            ttHints.SetToolTip(radIdleLeastDrops, localization.strings.order_least);
            lblLanguage.Text = localization.strings.interface_language;

            if (Settings.Default.OneThenMany)
            {
                radOneThenMany.Checked = true;
            }
            else
            {
                radOneGameOnly.Checked = Settings.Default.OnlyOneGameIdle;
                radManyThenOne.Checked = !Settings.Default.OnlyOneGameIdle;
            }

            if (Settings.Default.minToTray)
            {
                chkMinToTray.Checked = true;
            }

            if (Settings.Default.ignoreclient)
            {
                chkIgnoreClientStatus.Checked = true;
            }

            if (Settings.Default.showUsername)
            {
                chkShowUsername.Checked = true;
            }

            Maxtimeout.SelectedIndex = Settings.Default.LoginTimeout;
            PageRedit.SelectedIndex = Settings.Default.LoginPageRedirect;
            textBox1.Text = Settings.Default.MaxIdleCount.ToString();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            var frm = new frmSettingsAdvanced();
            frm.ShowDialog();
        }
        //以下是魔改代码
        private static frmWagaSettings newForm;
        private void btnWaga_Click(object sender, EventArgs e)
        {
            if (newForm == null || newForm.IsDisposed)
            {
                newForm = new frmWagaSettings();
                newForm.Show();
            }
            else
            {
                newForm.WindowState = FormWindowState.Normal;
                newForm.Activate();
            }
        }

        private void buttonhs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("论坛里有人问为什么读取完用户信息之后，对话框消失却什么也没发生\n" +
                "我实际使用的时候也发现了这一点，但是在我这里，第二次登陆基本就能够使用了\n" +
                "所以，我怀疑这个问题的原因是IdleMaster没能够读取完用户信息，就因为超时而停止了读取。\n" +
                "所以这里提供了一个设置值，如果出现网络情况不好而迟迟无法在短时间内读取完成的话，这个设置或许能够有所帮助。", "这是什么选项？");
        }

        private void buttonhs2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此设置同样是为了解决登陆问题而设置的。" +
                "在Idle Master登陆后，会通过访问Steam的页面来获得Cookie。" +
                "这个页面被Idle Master定为用户的个人主页，" +
                "但是有些大佬的个人主页，特别生动多彩，" +
                "这就导致这个页面迟迟无法加载完毕，而导致了超时。" +
                "这个选项的作用就是让Idle访问其他比较朴实的页面（比如徽章和组）来避免加载大量资源而造成超时。", "这是什么选项？");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此处可以设置同时挂卡的最大上限，Idle默认可以同时运行30个游戏，你可以修改这个参数，来限制IdleMaster的运行数量。" +
                "但是，由于Steam本身的限制，无论运行多少游戏，最多只有30个游戏会记录时长，请自行斟酌","这是什么？");
        }
    }
}
