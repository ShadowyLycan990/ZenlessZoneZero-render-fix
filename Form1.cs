using Microsoft.Win32;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZZZ_UnityPlayer
{
    public partial class Form1 : Form
    {
        private string gameDirectory;

        public Form1()
        {
            InitializeComponent();
            DetectGameDirectory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void DetectGameDirectory()
        {
            string[] registryPaths = {
                @"Software\Cognosphere\HYP\1_1\nap_global",
                @"Software\Cognosphere\HYP\1_0\nap_global"
            };

            foreach (string path in registryPaths)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(path))
                {
                    if (key != null)
                    {
                        gameDirectory = key.GetValue("GameInstallPath") as string;
                        if (!string.IsNullOrEmpty(gameDirectory))
                        {
                            richTextBox1.Text = $"Game Directory: {gameDirectory}";
                            break;
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(gameDirectory))
            {
                richTextBox1.Text = "Game Directory not found!";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string unityPlayerPath = Path.Combine(gameDirectory, "UnityPlayer.dll");
            string tempPath = Path.GetTempPath();
            string zipFilePath = Path.Combine(tempPath, "UnityPlayer.zip");
            string downloadUrl = "https://launcher-webstatic.hoyoverse.com/launcher-public/2024/07/04/1720063395875/UnityPlayer.zip";

            if (File.Exists(unityPlayerPath))
            {
                richTextBox1.AppendText("\nDeleting UnityPlayer.dll file...");
                File.Delete(unityPlayerPath);
            }

            if (File.Exists(zipFilePath))
            {
                richTextBox1.AppendText("\nUsing existing UnityPlayer.zip file...");
            }
            else
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadProgressChanged += (s, ev) =>
                    {
                        progressBar1.Value = ev.ProgressPercentage;
                        if (richTextBox1.Lines.Length > 0 && richTextBox1.Lines[richTextBox1.Lines.Length - 1].Contains("Downloading"))
                        {
                            var lines = richTextBox1.Lines;
                            lines[richTextBox1.Lines.Length - 1] = $"Downloading the fixed UnityPlayer file... {ev.ProgressPercentage}%";
                            richTextBox1.Lines = lines;
                        }
                        else
                        {
                            richTextBox1.AppendText($"\r\nDownloading the fixed UnityPlayer file... {ev.ProgressPercentage}%");
                        }
                    };

                    richTextBox1.AppendText("\r\nDownloading the fixed UnityPlayer file...");
                    await client.DownloadFileTaskAsync(new Uri(downloadUrl), zipFilePath);
                }
            }

            richTextBox1.AppendText("\r\nExtracting the new UnityPlayer file...");
            using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
            {
                int totalEntries = archive.Entries.Count;
                int processedEntries = 0;

                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.Equals("UnityPlayer.dll", StringComparison.OrdinalIgnoreCase))
                    {
                        string destinationPath = Path.Combine(gameDirectory, entry.FullName);
                        entry.ExtractToFile(destinationPath, true);

                        processedEntries++;
                        int progress = (int)((double)processedEntries / totalEntries * 100);
                        progressBar1.Value = progress;
                        if (richTextBox1.Lines.Length > 0 && richTextBox1.Lines[richTextBox1.Lines.Length - 1].Contains("Extracting"))
                        {
                            var lines = richTextBox1.Lines;
                            lines[richTextBox1.Lines.Length - 1] = $"Extracting the new UnityPlayer file... {progress}%";
                            richTextBox1.Lines = lines;
                        }
                        else
                        {
                            richTextBox1.AppendText($"\r\nExtracting the new UnityPlayer file... {progress}%");
                        }
                        break;
                    }
                }
            }

            richTextBox1.AppendText("\r\nFix finished! You can launch the game now via HoYoPlay launcher!");
            
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog(this);
            }
        }
    }
}
