using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Windows;
using System.Windows.Forms;
using System.IO;
using eBdb.EpubReader;
//using eBdb.EpubReader.Properties;
using Ionic.Zip;
using Ionic.Zlib;
using Ionic.BZip2;
using Ionic.Crc;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
//using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.IO.File;
using System.Diagnostics;

//


namespace ebupreader
{

  
    
    public partial class Form1 : Form
    {

        List<string> _items = new List<string>();
       // string plaintext;
        int d = 0, size =0 ;
        string x;
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DialogResult d = openFileDialog1.ShowDialog();
            if(d==DialogResult.OK)
            {

                Epub epub = new Epub(@openFileDialog1.FileName.ToString());
                label1.Text = epub.Title[0];
               // plaintext = epub.GetContentAsPlainText();
                string text = epub.GetContentAsHtml();
                x = "E:\\ebooks\\html\\" + epub.Title[0] + ".html";
                //File.Create(x);
                if (File.Exists(x))
                { }
                else
                {
                    File.WriteAllText(x, text);
                }
                webBrowser1.Navigate(x);
                //webBrowser1.Visible = false;
                //richTextBox1.Text = text;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //richTextBox1.Font.Size = (int)richTextBox1.Font.Size ;
           // richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size + 2);
           // webBrowser1.
            size += 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {

           // richTextBox1.BackColor = Color.White;
           // richTextBox1.ForeColor = Color.Black;
            d = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {

           // richTextBox1.BackColor = Color.Black;
           // richTextBox1.ForeColor = Color.White;
            d = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size - 2);
            size -= 2;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Form1.
            Form2 frm2 = new Form2(label1.Text,x);
            frm2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           // Process.Start("https://www.wordnik.com/words/" + richTextBox1.SelectedText.ToString());
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


    }
}
