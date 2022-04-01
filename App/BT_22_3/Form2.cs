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
    public partial class Form2 : Form
    {
        public delegate void mydel(string LSH , string txt);
        public mydel d { get; set; }

        public QLSV qlsv = new QLSV();
        public string MSSV { get; set; }
        public Form2(string mssv)
        {
            InitializeComponent();
            this.MSSV = mssv;
            foreach (string i in qlsv.GetAllLSH().Distinct())
            {
                cbbLopSH.Items.Add(i);
            }
            GUI();
        }

        public void GUI()
        {
            if (this.MSSV != "")
            {
                tbMSSV.Enabled = false;
                tbMSSV.Text = qlsv.GetSVByMSSV(this.MSSV).MSSV;
                tbName.Text = qlsv.GetSVByMSSV(this.MSSV).NameSV;
                tbDTB.Text = qlsv.GetSVByMSSV(this.MSSV).DTB.ToString();
                cbbLopSH.SelectedItem = qlsv.GetSVByMSSV(MSSV).LopSH.ToString();
                if (qlsv.GetSVByMSSV(this.MSSV).Gender)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                dateTimeNS.Value = qlsv.GetSVByMSSV(this.MSSV).NS;
                cbAnh.Checked = qlsv.GetSVByMSSV(this.MSSV).Anh;
                cbHB.Checked = qlsv.GetSVByMSSV(this.MSSV).HB;
                cbCMND.Checked = qlsv.GetSVByMSSV(this.MSSV).CMND;
            }
            else
            {
                rbMale.Checked = true;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            
            if (tbMSSV.Text == "")
            {
                MessageBox.Show("Nhap MSSV!");
                return;
            }
            else if (tbName.Text == "")
            {
                MessageBox.Show("Nhap Ten!");
                return;
            }
            else if (cbbLopSH.SelectedItem == null)
            {
                MessageBox.Show("Chon Lop!");
                return;
            }
            else if (dateTimeNS == null)
            {
                MessageBox.Show("Chon ngay sinh!");
                return;
            }
            else if (tbDTB.Text.ToString() == "")
            {
                MessageBox.Show("Nhap Diem trung binh!");
                return;
            }
            SV sv = new SV()
            {
                MSSV   = tbMSSV.Text.ToString(),
                NameSV = tbName.Text.ToString(),
                LopSH  = cbbLopSH.SelectedItem.ToString(),
                Gender = (rbMale.Checked) ? true : false,
                NS     = dateTimeNS.Value,
                DTB    = Convert.ToDouble(tbDTB.Text.ToString()),
                Anh    = (cbAnh.Checked) ? true : false,
                HB     = (cbHB.Checked) ? true : false,
                CMND   = (cbCMND.Checked) ? true : false
            };
            qlsv.ExecuteDB(sv);
            d("All", "");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
