using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BT_22_3
{
    public class DBSV
    {
        private static DBSV _Instance;
        public static DBSV Instance 
        { 
            get 
            { 
                if (_Instance == null)
                {
                    _Instance = new DBSV();
                }
                return _Instance;
            }
            private set {}
        }
        
        public DataTable DTSV { get; set; }
        private DBSV()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[] {
                new DataColumn { ColumnName = "MSSV" , DataType = typeof(string)},
                new DataColumn { ColumnName = "NameSV" , DataType = typeof(string)},
                new DataColumn { ColumnName = "LopSH" , DataType = typeof(string)},
                new DataColumn { ColumnName = "Gender" , DataType = typeof(bool)},
                new DataColumn { ColumnName = "NS" , DataType = typeof(DateTime)},
                new DataColumn { ColumnName = "DTB" , DataType = typeof(double)},
                new DataColumn { ColumnName = "Anh" , DataType = typeof(bool)},
                new DataColumn { ColumnName = "HB" , DataType = typeof(bool)},
                new DataColumn { ColumnName = "CMND" , DataType = typeof(bool)}
            });
            DTSV.Rows.Add("101", "NVA","20T1",true,DateTime.Now,1.1,true,true,false);
            DTSV.Rows.Add("102", "NVB", "20T2", true, DateTime.Now, 2.2, true, false, false);
            DTSV.Rows.Add("103", "NVC", "20T1", true, DateTime.Now, 3.3, true, true, false);
        }
        public void AddRow(SV s)
        {
            DTSV.Rows.Add(
                s.MSSV.ToString(),
                s.NameSV.ToString(),
                s.LopSH.ToString(),
                s.Gender,
                s.NS,
                s.DTB.ToString(),
                s.Anh,
                s.HB,
                s.CMND
            );
        }
        public void UpdateRow(SV s)
        {
            foreach(DataRow data in DTSV.Rows)
            {
                if (s.MSSV == data["MSSV"].ToString())
                {
                    data["NameSV"] = s.NameSV.ToString();
                    data["LopSH"] = s.LopSH.ToString();
                    data["Gender"] = s.Gender;
                    data["NS"] = s.NS;
                    data["DTB"] = s.DTB.ToString();
                    data["Anh"] = s.Anh;
                    data["Anh"] = s.HB;
                    data["CMND"] = s.CMND;
                    return;
                }
            }
        }
        public void DelRow(string MSSV)
        {
            foreach(DataRow data in DTSV.Rows)
            {
                if (data[0].ToString() == MSSV)
                {
                    DTSV.Rows.Remove(data);
                    return;
                }
            }
        }
    }
}