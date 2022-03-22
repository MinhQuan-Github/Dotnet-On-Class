using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapvenhab6
{
    public partial class Form1 : Form
    {

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
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        
    }
}
