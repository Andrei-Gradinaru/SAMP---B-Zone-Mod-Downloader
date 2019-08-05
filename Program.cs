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
    class Program
    {
        /*
        static void DownloadCompleted(object sender, AsyncCompletedEventArgs args)
        {
            String CachePath = ((System.Net.WebClient)(sender)).QueryString["myVariable"];
            String updateStatus = System.IO.File.ReadAllText(String.Format($"{CachePath}\\MyFile.Txt"));
            String DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            String Test = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            MessageBox.Show(Test);

            if (updateStatus != "YES")
            {
                // Downloading the new update
                WebClient webClient = new WebClient();
                Uri _uriLink = new Uri("https://chintzy-welder.000webhostapp.com/Downloads/ModsLoader.exe");
                webClient.DownloadFileAsync(_uriLink, String.Format($"{DesktopPath}\\AutoUpdate.exe"));
                System.Threading.Thread.Sleep(3000);
                System.Diagnostics.Process.Start(String.Format($"{DesktopPath}\\AutoUpdate.exe"));
                System.Windows.Forms.Application.Exit();
            }
        }
        */

        [STAThread]
        static void Main()
        {
            /*
            // Checking if there's any update available
            WebClient webClient = new WebClient();
            Uri _uriURL = new Uri("https://chintzy-welder.000webhostapp.com/Mods%20Downloader%20-%20Updates");
            String CachePath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            webClient.QueryString.Add("myVariable", CachePath);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
            webClient.DownloadFileAsync(_uriURL, String.Format($"{CachePath}\\MyFile.txt"));
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new windowApplication());
        }

        

    }
}
