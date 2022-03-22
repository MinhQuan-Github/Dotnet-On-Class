using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void But1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.d = new Form2.MyDel(ShowText);
            f.Show();
        }

        private void ShowText(string s)
        {
            txt1.Text = s;
        }
        //private void txt1_TextChanged(object sender, EventArgs e)
        //{
            //Form2 f = new Form2();
            //txt1.Text = f.
        //}
    }
}
