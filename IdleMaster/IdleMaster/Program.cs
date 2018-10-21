using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace IdleMaster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static public int Mode = 0;
        [STAThread]
        static void Main()
        {
            // Set the Browser emulation version for embedded browser control
            try
            {
                RegistryKey ie_root = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION");
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
                String programName = Path.GetFileName(Environment.GetCommandLineArgs()[0]);
                key.SetValue(programName, (int)10001, RegistryValueKind.DWord);
            }
            catch (Exception)
            {

            }

            Application.ThreadException += (o, a) => Logger.Exception(a.Exception);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                int LastMode = Mode;
                switch (Mode)
                {
                    case 0:
                        Application.Run(new frmMain());
                        break;
                    case 1:
                        Application.Run(new AlwaysIdleList());
                        break;
                }
                if (LastMode == Mode)
                    break;
            }
            
        }

        public static DialogResult ShowInputDialog(ref string input,string Title="Input",IWin32Window owner=null)
        {
            System.Drawing.Size size = new System.Drawing.Size(300, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ClientSize = size;
            inputBox.Text = Title;
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;
            DialogResult result = inputBox.ShowDialog(owner);
            input = textBox.Text;
            return result;
        }
    }
}
