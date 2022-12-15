using System.IO.Compression;

namespace Exactractor
{
    public partial class Form1 : Form
    {
        private static string rootPath = Directory.GetCurrentDirectory();
        private string zipFile = Path.Combine(rootPath, "file.zip");

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(zipFile))
            {
                textBox1.Text = "Extracting";
                ZipFile.ExtractToDirectory(zipFile, rootPath, true);
                for (int i = 0; i < 100; i++)
                {
                    progressBar1.Value ++;
                }
                await Task.Delay(1000);
                textBox1.Text = "Extraction Complete";
                await Task.Delay(1000);
                textBox1.Text = "Deleting Zip..";
                await Task.Delay(1000);
                textBox1.Text = "Done.";
            }
            else
            {
                textBox1.Text = "File doesn't Exist";
            }
        }
    }
}