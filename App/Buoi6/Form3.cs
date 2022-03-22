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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ShowDGV();
            //ShowLV();
        }
        private void ShowDGV()
        {
            List<SV> data = new List<SV>();
            data.AddRange(new SV[]
            {
                new SV{MSSV="102",NameSV="NVA",Gender=true,LopSH="20T"},
                new SV{MSSV="102",NameSV="NVA",Gender=true,LopSH="20T"},
                new SV{MSSV="102",NameSV="NVA",Gender=true,LopSH="20T"}
            });
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName="MSSV",DataType=typeof(string)},
                new DataColumn{ColumnName="NameSV",DataType=typeof(string)},
                new DataColumn{ColumnName="Gender",DataType=typeof(bool)},
                new DataColumn{ColumnName="LopSH",DataType=typeof(string)}
            });
            dt.Rows.Add("105", "NVF", true, "17T");
            foreach(SV i in data)
            {
                dt.Rows.Add(i.MSSV, i.NameSV, i.Gender, i.LopSH);
            }
            dataGridView1.DataSource = dt;
        }
        private void ShowLV()
        {
            listView1.Columns.AddRange(new ColumnHeader[]
            {
                new ColumnHeader{Name="MSSV",Text="MSSV"},
                new ColumnHeader{Name="NameSV",Text="Ho va ten"},
                new ColumnHeader{Name="Gender",Text="Gioi Tinh"},
                new ColumnHeader{Name="LopSH",Text="Lop SH"},
            });
            ListViewItem i1 = new ListViewItem(Text = "102");
            i1.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem{Text="NVA"},
                new ListViewItem.ListViewSubItem{Text=true.ToString()},
                new ListViewItem.ListViewSubItem{Text="21T" },
            }) ;
            ListViewItem i2 = new ListViewItem(Text = "103");
            i1.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem{Text="NVB"},
                new ListViewItem.ListViewSubItem{Text=true.ToString()},
                new ListViewItem.ListViewSubItem{Text="20T" },
            });
            ListViewItem i3 = new ListViewItem(Text = "105");
            i1.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem{Text="NVC"},
                new ListViewItem.ListViewSubItem{Text=false.ToString()},
                new ListViewItem.ListViewSubItem{Text="19T" },
            });
            listView1.Items.AddRange(new ListViewItem[] { i1, i2, i3 });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string s = "";
                foreach(ListViewItem i in listView1.SelectedItems)
                {
                    string MSSV = i.Text;
                    //string NameSV = i.SubItems[1].Text;
                    bool Gender = Convert.ToBoolean(i.SubItems[2].Text);
                    string LopSH = i.SubItems[3].Text;
                    s += MSSV + "," + /*NameSV*/  ", " + Gender + "," + LopSH;
                }
                MessageBox.Show(s);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string s = "";
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MSSV = i.Cells[0].Value.ToString();
                    string NameSV = i.Cells["NameSV"].Value.ToString();
                    bool Gender = Convert.ToBoolean(i.Cells["Gender"].Value.ToString());
                    string LopSH = i.Cells["LopSH"].Value.ToString();
                    s += MSSV + "," + Name + "," + Gender + "," + LopSH;

                }
                MessageBox.Show(s);
            }
        }
    }
}
