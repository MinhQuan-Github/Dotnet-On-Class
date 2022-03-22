using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.SelectedIndex -> tra ve vi tri item dang duoc lua chon
            //listBox1.SelectedItem -> tra ve mot item dang duoc lua chon
            //listBox1.SelectedItems -> tra ve mot mang item tu chon
            if (listBox1.SelectedItems.Count == 1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItems);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkBox1.Text = comboBox1.SelectedItem.ToString();
            checkBox1.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                MessageBox.Show(rbMale.Checked.ToString());
        }

        private void rbFe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFe.Checked)
                MessageBox.Show(rbFe.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
