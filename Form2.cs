using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZZZ_Render_Fix
{
    public partial class Form2 : Form
    {
        private string gameInstallPath = "";
        private string executablePath = "";

        public Form2()
        {
            InitializeComponent();
            LoadRegistryValue();
        }

        private void LoadRegistryValue()
        {
            try
            {
                string[] registryPaths = new string[]
                {
                    @"Software\Cognosphere\HYP\1_1\nap_global",
                    @"Software\Cognosphere\HYP\1_0\nap_global"
                };

                foreach (string path in registryPaths)
                {
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(path))
                    {
                        if (key != null)
                        {
                            gameInstallPath = key.GetValue("GameInstallPath") as string;
                            if (!string.IsNullOrEmpty(gameInstallPath))
                            {
                                executablePath = Path.Combine(gameInstallPath, "ZenlessZoneZero.exe");
                                if (System.IO.File.Exists(executablePath))
                                {
                                    richTextBox1.Text = "Game detected at: " + executablePath;
                                    return;
                                }
                                else
                                {
                                    richTextBox1.Text = "ZenlessZoneZero.exe not found in the specified directory.";
                                }
                            }
                            else
                            {
                                richTextBox1.Text = "GameInstallPath not found in registry.";
                            }
                        }
                        else
                        {
                            richTextBox1.Text = "Registry key not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Error reading registry: " + ex.Message;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(executablePath))
            {
                string arguments = "";
                if (rbDirectX12.Checked)
                    arguments = "-force-d3d12";
                else if (rbDirectX11.Checked)
                    arguments = "-force-d3d11";
                else if (rbDirectX11Single.Checked)
                    arguments = "-force-d3d11-singlethreaded";
                else if (rbOpenGL.Checked)
                    arguments = "-force-glcore";
                else if (rbVulkan.Checked)
                    arguments = "-force-vulkan";

                Process.Start(executablePath, arguments);
            }
            else
            {
                MessageBox.Show("Executable not found!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(executablePath))
            {
                try
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string shortcutPath = Path.Combine(desktopPath, "Zenless Zone Zero.lnk");

                    WshShell shell = new WshShell();
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                    shortcut.TargetPath = executablePath;
                    shortcut.WorkingDirectory = gameInstallPath;
                    shortcut.Arguments = GetSelectedArguments();
                    shortcut.Save();

                    MessageBox.Show("Shortcut created on desktop!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating shortcut: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Executable not found!");
            }
        }

        private string GetSelectedArguments()
        {
            if (rbDirectX12.Checked)
                return "-force-d3d12";
            else if (rbDirectX11.Checked)
                return "-force-d3d11";
            else if (rbDirectX11Single.Checked)
                return "-force-d3d11-singlethreaded";
            else if (rbOpenGL.Checked)
                return "-force-glcore";
            else if (rbVulkan.Checked)
                return "-force-vulkan";
            else
                return string.Empty;
        }
    }
}
