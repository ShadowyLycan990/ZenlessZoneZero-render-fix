using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZZZ_UnityPlayer
{
    public partial class Form3 : Form
    {
        public string SelectedDirectory { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedDirectory = folderBrowserDialog.SelectedPath;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
