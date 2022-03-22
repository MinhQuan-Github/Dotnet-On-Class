using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_15_3
{
    public partial class Form1 : Form
    {
        DataTable [] dataTable = new DataTable[10];
        int selectedTable = -1;

        public Form1()
        {
            InitializeComponent();
            initialData();
        }

        public void initialData()
        {
            for (int i = 0; i < 10; i++)
            {
                DataTable data = new DataTable();
                data.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("Món ăn" , typeof(string)),
                new DataColumn("Số lượng" , typeof(int))
                });
                dataTable[i] = data;
            }
        }

        public void foodDrinkClick(object sender, EventArgs e)
        {
            if (selectedTable != -1)
            {
                for (int i = 0; i < dataTable[selectedTable].Rows.Count; i++)
                {
                    if (dataTable[selectedTable].Rows[i][0].Equals(((Button)sender).Text))
                    {
                        dataTable[selectedTable].Rows[i][1] = Convert.ToInt32(dataTable[selectedTable].Rows[i][1]) + 1;
                        return;
                    }
                }
                string name = ((Button)sender).Text;
                dataTable[selectedTable].Rows.Add(name, 1);
            }
            else
            {
                MessageBox.Show("Chọn bàn !!");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataTable[selectedTable].Clear();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order cho ban " + (selectedTable + 1) + " thanh cong");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataTable[comboBox1.SelectedIndex];
            selectedTable = comboBox1.SelectedIndex;
        }
    }
}
