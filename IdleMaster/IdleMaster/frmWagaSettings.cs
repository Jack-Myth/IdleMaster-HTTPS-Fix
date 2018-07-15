using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleMaster
{
    public partial class frmWagaSettings : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        public frmWagaSettings()
        {
            InitializeComponent();
        }

        private void changeautonextime_Click(object sender, EventArgs e)
        {
            try
            {
                if (timebox.Text == "")
                {
                    MessageBox.Show("请输入正确时间！");
                }
                else if (Convert.ToInt32(timebox.Text) > 5000)
                {
                    MessageBox.Show("设置间隔最大为5000ms！");
                    timebox.Text = "5000";
                }
                else if (Convert.ToInt32(timebox.Text) < 500)
                {
                    MessageBox.Show("设置间隔最小为500ms！");
                    timebox.Text = "500";
                }
                else
                {
                    try
                    {
                        WritePrivateProfileString("AutoNext", "Time", timebox.Text, ".\\Settings.ini");
                        MessageBox.Show("设置保存成功！");
                    }
                    catch
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
            }
            catch
            {
                MessageBox.Show("请输入正确格式！");
                timebox.Text = "";
            }
        }

        private void changeminruntimebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeminruntimetextBox.Text == "")
                {
                    MessageBox.Show("请输入正确时间！");
                }
                else if (Convert.ToInt32(changeminruntimetextBox.Text) > 100)
                {
                    MessageBox.Show("设置时间最大为100小时！");
                    changeminruntimetextBox.Text = "100";
                }
                else if (Convert.ToInt32(changeminruntimetextBox.Text) < 0)
                {
                    MessageBox.Show("设置时间最小为0小时！");
                    changeminruntimetextBox.Text = "0";
                }
                else
                {
                    try
                    {
                        WritePrivateProfileString("AutoNext", "MinRuntime", changeminruntimetextBox.Text, ".\\Settings.ini");
                        MessageBox.Show("设置保存成功！");
                    }
                    catch
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
            }
            catch
            {
                MessageBox.Show("请输入正确格式！");
                changeminruntimetextBox.Text = "";
            }
        }

        private void frmWagaSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("本页设置需要在文件->重新加载或重启程序后生效！","提示");
        }

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);

        private void frmWagaSettings_Load(object sender, EventArgs e)
        {
            try
            {
                //获取自动下一个间隔时间
                StringBuilder temp = new StringBuilder(500);
                GetPrivateProfileString("AutoNext", "Time", "500", temp, 500, ".\\Settings.ini");
                if (temp.ToString() == "")
                {  }
                else
                {
                    timebox.Text = temp.ToString();
                }
                //获取最小运行时间
                temp = new StringBuilder(500);
                GetPrivateProfileString("AutoNext", "MinRuntime", "2", temp, 500, ".\\Settings.ini");
                if (temp.ToString() == "")
                {  }
                else
                {
                    changeminruntimetextBox.Text =temp.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序发生错误，即将退出！\r\n错误信息：" + ex.Message);
                System.Environment.Exit(0);
            }
        }
    }
}
