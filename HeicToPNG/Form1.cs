using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeicToPNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                folderNameLabel.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                progressBar1.Value = 0;
                string[] allfiles = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.heic", 
                    SearchOption.AllDirectories);
                progressBar1.Maximum = allfiles.Length;

                if (allfiles.Length== 0)
                {
                    MessageBox.Show("В папке не найдно heic файлов");
                    return;
                }

                foreach (var file in allfiles)
                {
                    FileInfo info = new FileInfo(file);
                    using (MagickImage image = new MagickImage(info.FullName))
                    {
                        // Save frame as jpg
                        image.Write(Path.Combine(folderBrowserDialog1.SelectedPath, info.Name.Replace(info.Extension, ".png")), MagickFormat.Png);
                        progressBar1.Value++;

                        if (deleteOriginalCheckBox.Checked)
                        {
                            File.Delete(file);
                        }
                    }
                }


                MessageBox.Show("Все обработалось");
            }
            else
            {
                MessageBox.Show("Нужно выбрать папку");
            }
        }
    }
}
