using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BaiTapVeNhaB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                textBox1.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button_ABC_Click(object sender, EventArgs e)
        {
            //FileInfo theSouceFile = new FileInfo(@"C: \Users\HP\source\repos\test1\BaiTapVeNhaB5.cs");
            string pass = "1234";
            //StreamReader reader=new StreamReader("file.txt");
            StreamWriter writer = new StreamWriter("file.txt",true);
            string text;
            if (textBox1.Text == pass)
            {
                text = DateTime.Now + "     Restricted Access";
                textBox2.Text=text;
            }
            else
            {
                text = DateTime.Now + "     Restricted Access";
                textBox2.Text = text;
            }

                //text = reader.ReadLine();
                writer.WriteLine(text);
                //Console.WriteLine(text);

            //reader.Close();
            writer.Close();
        }
    }
}
