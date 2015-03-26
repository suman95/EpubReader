using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using eBdb.EpubReader;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace ebupreader
{
    public partial class Form2 : Form
    {
        string t;
     
        public Form2(string title, string text)
        {
            InitializeComponent();
           
            label4.Text = title;
            //t = text;
            webBrowser2.Navigate(text);
           //richTextBox2.Text = text;
           //richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, richTextBox2.Font.Size + size);
           /* if(d==1)
            {
             //   richTextBox2.BackColor = Color.Black;
               // richTextBox2.ForeColor = Color.White;
               // d = 1;
            }
            else
            {
                richTextBox2.BackColor = Color.White;
                richTextBox2.ForeColor = Color.Black;
            }*/
            
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
           // richTextBox2.BackColor = Color.Black;
            //richTextBox2.ForeColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //richTextBox2.BackColor = Color.White;
            //richTextBox2.ForeColor = Color.Black;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, richTextBox2.Font.Size + 2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, richTextBox2.Font.Size - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button18_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start("https://www.wordnik.com/words/" + richTextBox2.SelectedText.ToString());
        }
    }
}
