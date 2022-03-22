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
    public partial class Form2 : Form
    {
        public Form2()
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
    }
}
