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
    public partial class Form2 : Form
    {
        public delegate void MyDel(string s);
        public MyDel d;
        public Form2()
        {
            InitializeComponent();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            d(txt2.Text);
        }
    }
}
