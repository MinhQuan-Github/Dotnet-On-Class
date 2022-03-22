using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point ps;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    Graphics g = this.CreateGraphics();
            //    Pen p = new Pen(Color.Red ,2f);
            //    g.DrawLine(p, ps, e.Location);
            //}
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    Graphics g = this.CreateGraphics();
            //    Pen p = new Pen(Color.Red, 2f);
            //    g.DrawLine(p, ps, e.Location);
            //}
        }

        private void buttonEqual_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            switch(e.KeyCode)
            {
                case Keys.D1:
                    button1.PerformClick();
                    break;
                case Keys.D2:
                    button2.PerformClick();
                    break;
                case Keys.D3:
                    button3.PerformClick();
                    break;
                case Keys.D4:
                    button4.PerformClick();
                    break;
                case Keys.D5:
                    button5.PerformClick();
                    break;
                case Keys.D6:
                    button6.PerformClick();
                    break;
                case Keys.D7:
                    button7.PerformClick();
                    break;
                case Keys.D8:
                    button8.PerformClick();
                    break;
                case Keys.D9:
                    button9.PerformClick();
                    break;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }
    }
}
