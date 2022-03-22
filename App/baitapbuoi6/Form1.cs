using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapbuoi6
{
    public partial class Form1 : Form
    {
        DataTable[] data=new DataTable[3];
        public Form1()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "Móm ăn", DataType = typeof(string)},
                new DataColumn{ColumnName = "Số lượng", DataType= typeof(int)}
            });
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] s = { "ban 1", "ban 2", "ban 3" };
            for(int i = 0; i < 3; i++)
            {
                if (comboBox1.Text != s[i])
                {

                }
            }
        }
    }
}
