using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab2
{
    public partial class BT2 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        public BT2()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Tệp văn bản (*.txt)|*.txt";
            ofd.ShowDialog();
            string filePath = ofd.FileName;
            int countLines = 0;
            int countWords = 0;
            try
            {
                StringBuilder content = new StringBuilder();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        content.AppendLine(line);
                        string[] words = line.Split(' ');
                        countWords += words.Length;
                    }
                }
                tb_ShowText.Text = content.ToString();
                countLines = tb_ShowText.GetLineFromCharIndex(content.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc tệp: " + ex.Message);
            }
            // Cắt đường dẫn
            int index = filePath.LastIndexOf("\\");
            // Hiển thị tên file
            tb_FileName.Text = filePath.Substring(index + 1);
            // Hiển thị URL
            tb_URL.Text = filePath;
            // Hiển thị số dòng
            tb_Line.Text = countLines.ToString();
            // Hiển thị số từ
            tb_Word.Text = countWords.ToString();
            // Hiển thị số kí tự
            /*string newText = tb_ShowText.Text.Replace("\n", "");*/
            string newText = tb_ShowText.Text;
            newText = tb_ShowText.Text.Replace("\r\n", "");
            string countChars = newText.Length.ToString();
            tb_Char.Text = countChars;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
