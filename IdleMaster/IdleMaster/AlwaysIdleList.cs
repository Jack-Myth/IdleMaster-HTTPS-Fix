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
using System.Runtime.InteropServices;

namespace IdleMaster
{

    public partial class AlwaysIdleList : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);
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

        private void UpdateEnabledList(int CurItem,CheckState NewValue)
        {
            if (NewValue == CheckState.Checked)
            {
                if (Settings.Default.EnabledAlwaysIdleList.IndexOf(AppIDList[CurItem].ToString()) == -1)
                    Settings.Default.EnabledAlwaysIdleList.Add(AppIDList[CurItem].ToString());
            }
            else
                Settings.Default.EnabledAlwaysIdleList.Remove(AppIDList[CurItem].ToString());
            Settings.Default.Save();
            int EnabledGameCount = Settings.Default.EnabledAlwaysIdleList.Cast<string>().Distinct().Count();
            this.GameCount.Text = EnabledGameCount.ToString() + "/30";
            if (EnabledGameCount > 30)
                this.GameCount.ForeColor = Color.Red;
            else
                this.GameCount.ForeColor = Color.Black;
        }

        private async void AlwaysIdleList_LoadAsync(object sender, EventArgs e)
        {
            //Settings.Default.AlwaysIdleList.Clear();
            //Settings.Default.Save();
            var EnabledList = new System.Collections.Specialized.StringCollection();
            EnabledList = Settings.Default.EnabledAlwaysIdleList;
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
            if (checkedListBox1.Enabled == false || this.checkedListBox1.SelectedItem == null)
                return;
            int CurIndexOf = this.checkedListBox1.Items.IndexOf(this.checkedListBox1.SelectedItem);
            Settings.Default.EnabledAlwaysIdleList.Remove(AppIDList[CurIndexOf].ToString());
            Settings.Default.AlwaysIdleList.Remove(AppIDList[CurIndexOf].ToString());
            AppIDList.RemoveAt(CurIndexOf);
            this.checkedListBox1.Items.RemoveAt(CurIndexOf);
            Settings.Default.Save();
        }

        private void btmSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Idling)
            {
                //Stop Idle
                foreach (Process p in ProcessList)
                    p.Kill();
                ProcessList.Clear();
                this.button2.Text = "▶开始";
                this.checkedListBox1.Enabled = true;
                this.btnDel.Enabled = true;
                this.btnSelectAll.Enabled = true;
                this.btnDeselectAll.Enabled = true;
                this.btnAdd.Enabled = true;
                this.btnImport.Enabled = true;
                Idling = false;
            }
            else
            {
                int EnabledGameCount = Settings.Default.EnabledAlwaysIdleList.Cast<string>().Distinct().Count();
                if (EnabledGameCount>30)
                {
                    if (MessageBox.Show("Steam最多只接受同时运行30个游戏，超出的部分将不会记录，仍然继续？", "所选游戏数目大于30", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }
                foreach (string str in Settings.Default.EnabledAlwaysIdleList)
                {
                    ProcessList.Add(Process.Start(new ProcessStartInfo("steam-idle.exe", str) { WindowStyle = ProcessWindowStyle.Hidden }));
                }
                this.button2.Text = "■停止";
                this.checkedListBox1.Enabled = false;
                this.btnSelectAll.Enabled = false;
                this.btnDeselectAll.Enabled = false;
                this.btnAdd.Enabled = false;
                this.btnImport.Enabled = false;
                this.btnDel.Enabled = false;
                Idling = true;
            }
        }

        private void AlwaysIdleList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            foreach (Process p in ProcessList)
                p.Kill();
            ProcessList.Clear();
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
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Program.Mode = 0;
            Close();
        }

        private async Task<string> GetAppNameByID(int AppID)
        {
            //Try get Name from Cached INI
            StringBuilder temp = new StringBuilder(1000);
            GetPrivateProfileString("SteamAppCachedName", AppID.ToString(), "", temp, 1000, "./SteamAppCached.ini");
            string CachedName = temp.ToString();
            if (CachedName != "")
                return CachedName;
            //If this AppID has not been cached.
            TargetAwait++;
            this.pictureBox1.Visible = true;
            var DocStr = await CookieClient.GetHttpAsync("https://store.steampowered.com/api/appdetails?appids="+AppID.ToString()+ "&filters=basic", 3, true);
            CurAwait++;
            if (TargetAwait <= CurAwait)
                this.pictureBox1.Visible = false;
            JObject MainJson = JsonConvert.DeserializeObject<JObject>(DocStr);
            JObject jb = MainJson.GetValue(AppID.ToString()).ToObject<JObject>();
            if (jb.GetValue("success").ToObject<bool>() == true)
            {
                string AppName = jb.GetValue("data").ToObject<JObject>().GetValue("name").ToString();
                WritePrivateProfileString("SteamAppCachedName", AppID.ToString(), AppName, "./SteamAppCached.ini");
                return AppName;
            }
            else
            {
                TargetAwait++;
                this.pictureBox1.Visible = true;
                DocStr = await CookieClient.GetHttpAsync("https://store.steampowered.com/api/appdetails?appids=" + AppID.ToString() + "&cc=us&filters=basic", 3, true);
                CurAwait++;
                if (TargetAwait <= CurAwait)
                    this.pictureBox1.Visible = false;
                JObject MainJson2 = JsonConvert.DeserializeObject<JObject>(DocStr);
                JObject jb2 = MainJson2.GetValue(AppID.ToString()).ToObject<JObject>();
                if (jb2.GetValue("success").ToObject<bool>() == true)
                {
                    string AppName = jb2.GetValue("data").ToObject<JObject>().GetValue("name").ToString();
                    WritePrivateProfileString("SteamAppCachedName", AppID.ToString(), AppName, "./SteamAppCached.ini");
                    return AppName;
                }
                else
                {
                    return "无效ID:" + AppID.ToString() + ",游戏可能锁区，请右键自行输入名称";
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateEnabledList(e.Index,e.NewValue);
        }

        private void checkedListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.checkedListBox1.SelectedIndex = this.checkedListBox1.IndexFromPoint(e.X, e.Y);
            this.toolStripTextBox1.Text = (string)this.checkedListBox1.SelectedItem;
        }

        private void ChangeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string InputMsg = "";
            InputMsg = (string)this.checkedListBox1.SelectedItem;
            if (Program.ShowInputDialog(ref InputMsg,"输入新名称",this)==DialogResult.OK)
            {
                WritePrivateProfileString("SteamAppCachedName", AppIDList[this.checkedListBox1.SelectedIndex].ToString(), InputMsg, "./SteamAppCached.ini");
                this.checkedListBox1.SelectedItem = InputMsg;
            }
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurIndexOf = this.checkedListBox1.Items.IndexOf(this.checkedListBox1.SelectedItem);
            Settings.Default.EnabledAlwaysIdleList.Remove(AppIDList[CurIndexOf].ToString());
            Settings.Default.AlwaysIdleList.Remove(AppIDList[CurIndexOf].ToString());
            AppIDList.RemoveAt(CurIndexOf);
            this.checkedListBox1.Items.RemoveAt(CurIndexOf);
            Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "选择保存位置";
            saveFileDialog1.Filter = "INI|*.ini";
            saveFileDialog1.FileName = "";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if (System.IO.File.Exists(saveFileDialog1.FileName))
                    System.IO.File.Delete(saveFileDialog1.FileName);
                for (int i = 0; i < Settings.Default.AlwaysIdleList.Count; i++)
                {
                    if (Settings.Default.EnabledAlwaysIdleList.IndexOf(Settings.Default.AlwaysIdleList[i]) != -1)
                        WritePrivateProfileString("AppIDs", Settings.Default.AlwaysIdleList[i], "1", saveFileDialog1.FileName);
                    else
                        WritePrivateProfileString("AppIDs", Settings.Default.AlwaysIdleList[i], "0", saveFileDialog1.FileName);
                }
            }
        }

        private async void btnImport_ClickAsync(object sender, EventArgs e)
        {
            openFileDialog1.Title = "选择配置文件";
            openFileDialog1.FileName = "INI|*.ini";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] buffer = new byte[65536];
                GetPrivateProfileSection("AppIDs", buffer, 65536, openFileDialog1.FileName);
                String[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');
                List<int> needNameList=new List<int>();
                foreach (String entry in tmp)
                {
                    string[] KVPair = entry.Split("=".ToCharArray(), 2);
                    StringBuilder isEnabled=new StringBuilder(10);
                    if (Settings.Default.AlwaysIdleList.IndexOf(KVPair[0]) != -1)
                        continue;
                    Settings.Default.AlwaysIdleList.Add(KVPair[0]);
                    int curindex = this.checkedListBox1.Items.Add(KVPair[0]);
                    needNameList.Add(curindex);
                    AppIDList.Add(int.Parse(KVPair[0]));
                    if (KVPair[1]=="1")
                    {
                        this.checkedListBox1.SetItemChecked(curindex, true);
                    }
                }
                Settings.Default.Save();
                for(int i= 0;i<needNameList.Count;i++)
                {
                    if(needNameList[i] < AppIDList.Count)
                        this.checkedListBox1.Items[needNameList[i]] = await GetAppNameByID(AppIDList[i]);
                }
            }
        }

        private void DelAllCheckedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i<this.checkedListBox1.Items.Count)
            {
                if(this.checkedListBox1.GetItemChecked(i))
                {
                    Settings.Default.EnabledAlwaysIdleList.Remove(AppIDList[i].ToString());
                    Settings.Default.AlwaysIdleList.Remove(AppIDList[i].ToString());
                    AppIDList.RemoveAt(i);
                    this.checkedListBox1.Items.RemoveAt(i);
                    continue;
                }
                i++;
            }
            Settings.Default.Save();
        }

        private void DelAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要删除所有吗？","？？？",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Settings.Default.EnabledAlwaysIdleList.Clear();
                Settings.Default.AlwaysIdleList.Clear();
                AppIDList.Clear();
                this.checkedListBox1.Items.Clear();
                Settings.Default.Save();
            }
        }
    }
}
