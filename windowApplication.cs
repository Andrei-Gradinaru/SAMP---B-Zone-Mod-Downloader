using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp4
{
    public partial class windowApplication : Form
    {
        public windowApplication()
        {
            InitializeComponent();

            // Getting current program version
            String Version = versionInfo.Text;
            String MyVersion = string.Empty;

            for(int i=0; i<Version.Length; i++)
                if (Char.IsDigit(Version[i]))
                    MyVersion += Version[i];

            // Checking which version is latest
            WebClient wbClient = new WebClient();
            Uri _uriAdress = new Uri("https://chintzy-welder.000webhostapp.com/Mods%20Downloader%20-%20Updates");
            String CachePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            wbClient.QueryString.Add("MyVersion", MyVersion);
            wbClient.QueryString.Add("CachePath", CachePath);
            wbClient.DownloadFileCompleted += new AsyncCompletedEventHandler(isFileDownloaded);
            wbClient.DownloadFileAsync(_uriAdress, String.Format($"{CachePath}\\mod-version.txt"));
        }

        void isFileDownloaded(object sender, AsyncCompletedEventArgs args)
        {
            String CachePath = ((System.Net.WebClient)(sender)).QueryString["CachePath"];
            String MyVersion = ((System.Net.WebClient)(sender)).QueryString["MyVersion"];
            String updVersion = System.IO.File.ReadAllText($"{CachePath}\\mod-version.txt");

        

            if (updVersion != MyVersion)
            {
                MessageBox.Show("New Update Found! \n\nPress Ok and be patience until the new application will start.\nMake sure you will delete the old application.");
                WebClient newWeb = new WebClient();
                Uri _uriAdress = new Uri("https://chintzy-welder.000webhostapp.com/Downloads/ModsLoader.exe");
                String DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                System.IO.Directory.CreateDirectory($"{DesktopPath}\\Downloads");
                newWeb.DownloadFileAsync(_uriAdress, String.Format($"{DesktopPath}\\Downloads\\Mods DownloaderV{updVersion}.exe"));
                System.Threading.Thread.Sleep(3000);
                System.Diagnostics.Process.Start($"{DesktopPath}\\Downloads\\Mods DownloaderV{updVersion}.exe");
                System.Windows.Forms.Application.Exit();
            }
        }

        // Global Vars
        String statusVar;

        void DownloadCompleted(object sender, AsyncCompletedEventArgs args)
        {
            // Getting external params
            String SelectedFileListBox = ((System.Net.WebClient)(sender)).QueryString["selectedFile"];

            // Updating Status Label
            statusLabel.Text += String.Format($"\n  - {SelectedFileListBox} downloaded");
        }
        

        // No Code
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // No Code
        private void ListBox1Label_Click(object sender, EventArgs e)
        { }
        private void ListBox2Label_Click(object sender, EventArgs e)
        { }
        private void ListBox3Label_Click(object sender, EventArgs e)
        { }
        private void ListBox4Label_Click(object sender, EventArgs e)
        { }

        // No Code
        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
            listBox4.ClearSelected();
        }

        private void OnlineInfoButton_Click(object sender, EventArgs e)
        {
            String _listBox1_CurrentSelectedItem = listBox1.GetItemText(listBox1.SelectedItem);
            String _listBox2_CurrentSelectedItem = listBox2.GetItemText(listBox2.SelectedItem);
            String _listBox3_CurrentSelectedItem = listBox3.GetItemText(listBox3.SelectedItem);
            String _listBox4_CurrentSelectedItem = listBox4.GetItemText(listBox4.SelectedItem);

            int HideThem = 1;
            if (HideThem == 1)
            {
                if (_listBox1_CurrentSelectedItem == "" && _listBox2_CurrentSelectedItem == ""
                 && _listBox3_CurrentSelectedItem == "" && _listBox4_CurrentSelectedItem == ""
                )
                {
                    statusLabel.Text = "Warning: You didn't choose a file.";
                    return;
                }

                if (_listBox1_CurrentSelectedItem != "" && _listBox2_CurrentSelectedItem != "")
                {
                    statusLabel.Text = "Warning: You can't use this when you have chosen more than 1 mod.";
                    return;
                }

                if (_listBox1_CurrentSelectedItem != "" && _listBox3_CurrentSelectedItem != "")
                {
                    statusLabel.Text = "Warning: You can't use this when you have chosen more than 1 mod.";
                    return;
                }

                if (_listBox1_CurrentSelectedItem != "" && _listBox4_CurrentSelectedItem != "")
                {
                    statusLabel.Text = "Warning: You can't use this when you have chosen more than 1 mod.";
                    return;
                }

                if (_listBox2_CurrentSelectedItem != "" && _listBox3_CurrentSelectedItem != "")
                {
                    statusLabel.Text = "Warning: You can't use this when you have chosen more than 1 mod.";
                    return;
                }

                if (_listBox2_CurrentSelectedItem != "" && _listBox4_CurrentSelectedItem != "")
                {
                    statusLabel.Text = "Warning: You can't use this when you have chosen more than 1 mod.";
                    return;
                }

                if (_listBox3_CurrentSelectedItem != "" && _listBox4_CurrentSelectedItem != "")
                {
                    statusLabel.Text = "Warning: You can't use this when you have chosen more than 1 mod.";
                    return;
                }
            }

            // Listbox 1
            if (_listBox1_CurrentSelectedItem == "FPSUnlock")               System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/5-fpsunlock-onoff/");
            if (_listBox1_CurrentSelectedItem == "Mousefix")                System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/64-sensivityfix/");
            if (_listBox1_CurrentSelectedItem == "Harta pe M")              System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/59-harta-pe-m/");
            if (_listBox1_CurrentSelectedItem == "Fast Weapon Switch")      System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/8-fast-weapon-switch/");
            if (_listBox1_CurrentSelectedItem == "Infinite Run")            System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/24-infinite-runcs/");
            if (_listBox1_CurrentSelectedItem == "Crosshair Resize")        System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/17-m%C4%83rirea-sau-mic%C8%99orarea-%C8%9Bintei/");
            if (_listBox1_CurrentSelectedItem == "Digital Info")            System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/20-digital-info/");
            if (_listBox1_CurrentSelectedItem == "Auto Pin")                System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/31-auto-pin/");
            if (_listBox1_CurrentSelectedItem == "Online Faction Members")  System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/3-online-faction-members/");
            if (_listBox1_CurrentSelectedItem == "Reconnect")               System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/88-reconnect/");
            if (_listBox1_CurrentSelectedItem == "Rainbow Car")             System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/123-rainbow-car/");
            if (_listBox1_CurrentSelectedItem == "Anti Crasher")            System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/89-anti-crasher/");
            if (_listBox1_CurrentSelectedItem == "Money Info")              System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/105-moneycs/");
            if (_listBox1_CurrentSelectedItem == "Auto Radio Off")          System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/67-cleo-radio-off/");
            if (_listBox1_CurrentSelectedItem == "Custom Textdraw Creator") System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/45-custom-textdraw-creator/");
            if (_listBox1_CurrentSelectedItem == "AutoCorrector")           System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/118-autocorrector/");
            if (_listBox1_CurrentSelectedItem == "Texture Render")          System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/40-texture-render/");

            // Listbox 2
            if (_listBox2_CurrentSelectedItem == "Rainbow Chat")        System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/55-asi-rainbowchat/");
            if (_listBox2_CurrentSelectedItem == "Change Skin")         System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/16-changeskinasi/");
            if (_listBox2_CurrentSelectedItem == "Discord Plugin")      System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/126-sa-mp-discord-plugin/");
            if (_listBox2_CurrentSelectedItem == "BulletTrack")         System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/22-bullettracksf/");
            if (_listBox2_CurrentSelectedItem == "Fake FPS")            System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/34-fake-fps/");

            // ListBox 3
            if (_listBox3_CurrentSelectedItem == "SAMP 0.3.7 RC1")      System.Diagnostics.Process.Start("https://dracoblue.net/downloads/samp-client/");
            if (_listBox3_CurrentSelectedItem == "SAMPFUNCS 5.4.1")     System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/7-sampfuncs/");
            if (_listBox3_CurrentSelectedItem == "CLEO")                System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/4-cleo-4/");

            // ListBox 4
            if (_listBox4_CurrentSelectedItem == "SAMP Addon")              System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/81-samp-addon/");
            if (_listBox4_CurrentSelectedItem == "Alci's IMG Editor")       System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/90-alcis-img-editor/");
            if (_listBox4_CurrentSelectedItem == "Spark IMG Editor")        System.Diagnostics.Process.Start("https://www.gtagarage.com/mods/show.php?id=1503");
            if (_listBox4_CurrentSelectedItem == "TXD Workshop")            System.Diagnostics.Process.Start("https://www.gtagarage.com/mods/show.php?id=8320");
            if (_listBox4_CurrentSelectedItem == "Automatic Gang Evidence") System.Diagnostics.Process.Start("https://forum.b-zone.ro/files/file/150-program-pentru-crearea-automat%C4%83-a-eviden%C8%9Belor/");

            statusLabel.Text = String.Format($"Status: Accesing {_listBox1_CurrentSelectedItem} Online Info");
        }

        private void WindowApplication_Load(object sender, EventArgs e)
        {

        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            // Creating Desktop Path 
            String DestkopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String DownloadPath = String.Format($"{DestkopPath}\\B-Zone Downloads");
            System.IO.Directory.CreateDirectory(DownloadPath);

            // Checking which files are selected
            String SelectedFileListBox_1 = listBox1.GetItemText(listBox1.SelectedItem);
            String SelectedFileListBox_2 = listBox2.GetItemText(listBox2.SelectedItem);
            String SelectedFileListBox_3 = listBox3.GetItemText(listBox3.SelectedItem);
            String SelectedFileListBox_4 = listBox4.GetItemText(listBox4.SelectedItem);

            statusVar = "Status:";

            // Downloading Files
            if (SelectedFileListBox_1 != "")
            {
                statusVar += String.Format($"\n  - downloading file {SelectedFileListBox_1}");
                statusLabel.Text = statusVar;

                using (WebClient myWebClient = new WebClient())
                {
                    Uri _uriLink = new Uri(String.Format("https://chintzy-welder.000webhostapp.com/Downloads/" + $"{SelectedFileListBox_1}.rar"));
                    myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                    String FileName = String.Format($"{DownloadPath}\\{SelectedFileListBox_1}.rar");
                    myWebClient.DownloadFileAsync(_uriLink, FileName);
                    myWebClient.QueryString.Add("selectedFile", SelectedFileListBox_1);
                }
            }
            
            if (SelectedFileListBox_2 != "")
            {
                statusVar += String.Format($"\n  - downloading file {SelectedFileListBox_2}");
                statusLabel.Text = statusVar;

                using (WebClient myWebClient = new WebClient())
                {
                    Uri _uriLink = new Uri(String.Format("https://chintzy-welder.000webhostapp.com/Downloads/" + $"{SelectedFileListBox_2}.rar"));
                    myWebClient.DownloadFileCompleted += DownloadCompleted;
                    String FileName = String.Format($"{DownloadPath}\\{SelectedFileListBox_2}.rar");
                    myWebClient.DownloadFileAsync(_uriLink, FileName);
                    myWebClient.QueryString.Add("selectedFile", SelectedFileListBox_2);
                }
            }

            if (SelectedFileListBox_3 != "")
            {
                if (SelectedFileListBox_3 == "SAMP 0.3.7 RC1")
                {
                    MessageBox.Show($"File {SelectedFileListBox_3} is too big. \nYou will be redirected to my DropBox account.");
                    System.Diagnostics.Process.Start("https://dracoblue.net/download-release/samp-client-0.3.7/sa-mp-0.3.7-install.exe");
                }
                else
                {
                    statusVar += String.Format($"\n  - downloading file {SelectedFileListBox_3}");
                    statusLabel.Text = statusVar;

                    using (WebClient myWebClient = new WebClient())
                    {
                        Uri _uriLink = new Uri(String.Format("https://chintzy-welder.000webhostapp.com/Downloads/" + $"{SelectedFileListBox_3}.rar"));
                        String FileName = String.Format($"{DownloadPath}\\{SelectedFileListBox_3}.rar");
                        myWebClient.DownloadFileCompleted += DownloadCompleted;
                        myWebClient.DownloadFileAsync(_uriLink, FileName);
                        myWebClient.QueryString.Add("selectedFile", SelectedFileListBox_3);
                    }
                }
            }

            if (SelectedFileListBox_4 != "")
            {
                if (SelectedFileListBox_4 == "SAMP Addon")
                {
                    MessageBox.Show($"File {SelectedFileListBox_4} is too big. \nYou will be redirected to original download page.");
                    System.Diagnostics.Process.Start("https://www.dropbox.com/s/1v391e0n211rjsk/SAMP_Addon.rar?dl=0");
                }
                else
                {
                    statusVar += String.Format($"\n  - downloading file {SelectedFileListBox_4}");
                    statusLabel.Text = statusVar;

                    using (WebClient myWebClient = new WebClient())
                    {
                        Uri _uriLink = new Uri(String.Format("https://chintzy-welder.000webhostapp.com/Downloads/" + $"{SelectedFileListBox_4}.rar"));
                        String FileName = String.Format($"{DownloadPath}\\{SelectedFileListBox_4}.rar");
                        myWebClient.DownloadFileCompleted += DownloadCompleted;
                        myWebClient.DownloadFileAsync(_uriLink, FileName);
                        myWebClient.QueryString.Add("selectedFile", SelectedFileListBox_4);
                    }
                }
            }

            // Opening the path Download
            System.Diagnostics.Process.Start(DownloadPath);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
