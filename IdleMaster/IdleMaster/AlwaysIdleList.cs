using IdleMaster.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IdleMaster
{
    public partial class AlwaysIdleList : Form
    {
        private List<int> AppIDList = new List<int>();
        private List<Process> ProcessList = new List<Process>();
        bool Idling = false;
        int TargetAwait = 0;
        int CurAwait = 0;

        public AlwaysIdleList()
        {
            InitializeComponent();
        }

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            int AppID;
            if (this.appidInput.Text != "" && int.TryParse(this.appidInput.Text, out AppID))
            {
                if (Settings.Default.AlwaysIdleList.IndexOf(AppID.ToString()) != -1)
                {
                    MessageBox.Show("This Game has already been added!");
                    return;
                }
                Settings.Default.AlwaysIdleList.Add(AppID.ToString());
                Settings.Default.EnabledAlwaysIdleList.Add(AppID.ToString());
                Settings.Default.Save();
                int ItemIndex = this.checkedListBox1.Items.Add(AppID.ToString());
                Object tmpRef = this.checkedListBox1.Items[ItemIndex];
                AppIDList.Add(AppID);
                string AppName = await GetAppNameByID(AppID);
                if (tmpRef == this.checkedListBox1.Items[ItemIndex])
                {
                    this.checkedListBox1.Items[ItemIndex] = AppName;
                }
            }
        }

        private void UpdateEnabledList()
        {
            Settings.Default.EnabledAlwaysIdleList.Clear();
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                if (this.checkedListBox1.GetItemChecked(i))
                {
                    Settings.Default.EnabledAlwaysIdleList.Add(AppIDList[i].ToString());
                }
            }
            Settings.Default.Save();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateEnabledList();
        }

        private async void AlwaysIdleList_LoadAsync(object sender, EventArgs e)
        {
            //Settings.Default.AlwaysIdleList.Clear();
            //Settings.Default.Save();
            var EnabledList = Settings.Default.EnabledAlwaysIdleList;
            for (int i = 0; i < Settings.Default.AlwaysIdleList.Count; i++)
            {
                int AppID = int.Parse(Settings.Default.AlwaysIdleList[i]);
                AppIDList.Add(AppID);
                int CurIndex = this.checkedListBox1.Items.Add(Settings.Default.AlwaysIdleList[i]);
                if (EnabledList.IndexOf(Settings.Default.AlwaysIdleList[i]) != -1)
                {
                    this.checkedListBox1.SetItemChecked(CurIndex, true);
                }
            }
            var ItemList = this.checkedListBox1.Items;
            var tmpAppIDList = AppIDList;
            for (int i = 0; i < ItemList.Count; i++)
            {
                ItemList[i] = await GetAppNameByID(AppIDList[i]);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Enabled == false && this.checkedListBox1.SelectedItem == null)
                return;
            int CurIndexOf = this.checkedListBox1.Items.IndexOf(this.checkedListBox1.SelectedItem);
            Settings.Default.EnabledAlwaysIdleList.Remove(AppIDList[CurIndexOf].ToString());
            Settings.Default.AlwaysIdleList.Remove(AppIDList[CurIndexOf].ToString());
            AppIDList.RemoveAt(CurIndexOf);
            this.checkedListBox1.Items.RemoveAt(CurIndexOf);
            UpdateEnabledList();
        }

        private void btmSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, true);
            }
            UpdateEnabledList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            UpdateEnabledList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Idling)
            {
                //Stop Idle
                foreach (Process p in ProcessList)
                    p.Kill();
                this.button2.Text = "▶开始";
                this.checkedListBox1.Enabled = true;
                Idling = false;
            }
            else
            {
                foreach (string str in Settings.Default.EnabledAlwaysIdleList)
                {
                    ProcessList.Add(Process.Start(new ProcessStartInfo("steam-idle.exe", str) { WindowStyle = ProcessWindowStyle.Hidden }));
                }
                this.button2.Text = "■停止";
                this.checkedListBox1.Enabled = false;
                Idling = true;
            }
        }

        private void AlwaysIdleList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            foreach (Process p in ProcessList)
                p.Kill();
        }

        private void AlwaysIdleList_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.notifyIcon1.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Program.Mode = 0;
            Close();
        }

        private async Task<string> GetAppNameByID(int AppID)
        {
            TargetAwait++;
            this.pictureBox1.Visible = true;
            var DocStr = await CookieClient.GetHttpAsync("https://store.steampowered.com/api/appdetails?appids="+AppID.ToString()+ "&filters=basic", 3, true);
            CurAwait++;
            if (TargetAwait <= CurAwait)
                this.pictureBox1.Visible = false;
            JObject MainJson = JsonConvert.DeserializeObject<JObject>(DocStr);
            JObject jb = MainJson.GetValue(AppID.ToString()).ToObject<JObject>();
            if(jb.GetValue("success").ToObject<bool>()==true)
            {
                return jb.GetValue("data").ToObject<JObject>().GetValue("name").ToString();
            }
            return AppID.ToString();
            //https://store.steampowered.com/api/appdetails/?appids=
        }
    }
}
