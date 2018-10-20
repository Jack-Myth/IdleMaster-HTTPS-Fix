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

namespace IdleMaster
{
    public partial class AlwaysIdleList : Form
    {
        private List<int> AppIDList=new List<int>();

        public AlwaysIdleList()
        {
            InitializeComponent();
        }

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            int AppID;
            if (this.appidInput.Text!="" &&int.TryParse(this.appidInput.Text,out AppID))
            {
                if(Settings.Default.AlwaysIdleList.IndexOf(AppID.ToString())!=-1)
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
                var document = new HtmlAgilityPack.HtmlDocument();
                var DocStr = await CookieClient.GetHttpAsync("https://store.steampowered.com/app/" + AppID.ToString(),3,true);
                document.LoadHtml(DocStr);
                HtmlNode Namenode = document.DocumentNode.SelectSingleNode("//div[@class=\"apphub_AppName\"]/text()");
                if(Namenode !=null&&tmpRef== this.checkedListBox1.Items[ItemIndex])
                {
                    this.checkedListBox1.Items[ItemIndex] = Namenode.InnerText;
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
            for (int i=0;i<Settings.Default.AlwaysIdleList.Count;i++)
            {
                int AppID = int.Parse(Settings.Default.AlwaysIdleList[i]);
                AppIDList.Add(AppID);
                int CurIndex = this.checkedListBox1.Items.Add(Settings.Default.AlwaysIdleList[i]);
                if(EnabledList.IndexOf(Settings.Default.AlwaysIdleList[i])!=-1)
                {
                    this.checkedListBox1.SetItemChecked(CurIndex, true);
                }
            }
            var ItemList = this.checkedListBox1.Items;
            var tmpAppIDList = AppIDList;
            for(int i=0;i<ItemList.Count;i++)
            {
                var document = new HtmlAgilityPack.HtmlDocument();
                var DocStr = await CookieClient.GetHttpAsync("https://store.steampowered.com/app/" + tmpAppIDList[i].ToString(),3,true);
                document.LoadHtml(DocStr);
                HtmlNode Namenode = document.DocumentNode.SelectSingleNode("//div[@class=\"apphub_AppName\"]/text()");
                if (Namenode != null)
                {
                    ItemList[i] = Namenode.InnerText;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int CurIndexOf = this.checkedListBox1.Items.IndexOf(this.checkedListBox1.SelectedItem);
            AppIDList.RemoveAt(CurIndexOf);
            this.checkedListBox1.Items.RemoveAt(CurIndexOf);
            UpdateEnabledList();
        }
    }
}
