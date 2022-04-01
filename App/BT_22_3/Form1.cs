using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_22_3
{
    public partial class Form1 : Form
    {
        private QLSV bll = new QLSV();
        public Form1()
        {
            InitializeComponent();
            loadCbbLSH();
        }
        private void loadCbbLSH()
        {
            cbbLSH.Items.Add("All");
            foreach(string i in bll.GetAllLSH().Distinct())
            {
                cbbLSH.Items.Add(i);
            }
        }

        // Show Function
        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (cbbLSH.SelectedIndex != -1)
            {
                string LSH = cbbLSH.SelectedItem.ToString();
                showDTG(LSH, "");
            }
        }
        
        // Add Function
        private void AddButton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("");
            f.d = new Form2.mydel(showDTG);
            f.Show();
        }

        // Update Function
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MSSV = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
                Form2 f = new Form2(MSSV);
                f.d = new Form2.mydel(showDTG);
                f.Show();
            }
        }

        // Update data form datagridview
        public void showDTG(string LSH , string txt = "" )
        {
            dataGridView1.DataSource = bll.GetSVByLopSH(LSH, txt);
        }

        // Search Function
        private void searchButton_Click(object sender, EventArgs e)
        {
            string LSH;
            if (cbbLSH.SelectedIndex == -1)
            {
                LSH = "All";
                cbbLSH.SelectedItem = "All";
            }
            else
            {
                LSH = cbbLSH.SelectedItem.ToString();
            }          
            string txt = tbSearch.Text.ToString();
            showDTG(LSH, txt);
        }

        //Cancel Function
        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sort Function
        private void SortButton_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex != -1)
            {
                if (cbbSort.SelectedItem.ToString() == "Ten")
                {
                    dataGridView1.DataSource = bll.GetAllSVSortByName();
                    cbbLSH.SelectedIndex = -1;
                }
                else if (cbbSort.SelectedItem.ToString() == "MSSV")
                {
                    dataGridView1.DataSource = bll.GetAllSVSortByMSSV();
                    cbbLSH.SelectedIndex = -1;
                }
                else if (cbbSort.SelectedItem.ToString() == "Lop")
                {
                    dataGridView1.DataSource = bll.GetAllSVSortByLop();
                    cbbLSH.SelectedIndex = -1;
                }
            }
            
        }

        //Delete Function
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> del = new List<string>();
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    del.Add(row.Cells["MSSV"].Value.ToString());
                }
                bll.DelSV(del);
                cbbLSH.SelectedIndex = 0;
                showDTG(cbbLSH.SelectedItem.ToString(), "");
            }
        }
    }
}
