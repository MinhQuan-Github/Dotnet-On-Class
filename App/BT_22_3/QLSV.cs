using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_22_3
{   

    public class QLSV
    {
        public List<SV> GetAllSV()
        {
            List<SV> result = new List<SV>();
            foreach(DataRow data in DBSV.Instance.DTSV.Rows)
            {
                result.Add(GetSVByDataRow(data));
            }
            return result;
        }
        public SV GetSVByDataRow(DataRow data)
        {
            return new SV
            {
                MSSV = data["MSSV"].ToString(),
                NameSV = data["NameSV"].ToString(),
                LopSH = data["LopSH"].ToString(),
                Gender = Convert.ToBoolean(data["Gender"].ToString()),
                NS = Convert.ToDateTime(data["NS"].ToString()),
                DTB = Convert.ToDouble(data["DTB"].ToString()),
                Anh = Convert.ToBoolean(data["Anh"].ToString()),
                HB = Convert.ToBoolean(data["HB"].ToString()),
                CMND = Convert.ToBoolean(data["CMND"].ToString()),
            };
        }
        public List<SV> GetSVByLopSH(string LSH,string txt = "")
        {
            List<SV> data = new List<SV>();
            if(LSH == "All")
            {
                foreach(SV i in GetAllSV())
                {
                    if (i.NameSV.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            else
            {
                foreach(SV i in GetAllSV())
                {
                    if (i.LopSH == LSH && i.NameSV.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            return data;
        }
        public List<string> GetAllLSH()
        {
            List<string> data = new List<string>();
            foreach(SV i in GetAllSV())
            {
                data.Add(i.LopSH);
            }
            return data;
        }
        public SV GetSVByMSSV(string mssv)
        {
            SV sv = new SV();
            foreach (SV i in GetAllSV())
            {
                if (i.MSSV == mssv)
                {
                    sv = i;
                    break;
                }
            }
            return sv;
        }
        public bool AddUpdate(string mssv)
        {
            bool Add = true;
            foreach(SV s in GetAllSV())
            {
                if (s.MSSV == mssv)
                {
                    Add = false;
                }
            }
            return Add;
        }
        public void ExecuteDB(SV s)
        {
            if (AddUpdate(s.MSSV))
            {
                DBSV.Instance.AddRow(s);
            } 
            else
            {
                DBSV.Instance.UpdateRow(s);
            }
        }
        public void DelSV(List<string> mssv)
        {
            foreach (string i in mssv)
            {
                DBSV.Instance.DelRow(i);
            }
        }
        public List<SV> ListSVNow(List<string> now)
        {
            List<SV> data = new List<SV>();
            foreach(string i in now)
            {
                foreach (SV j in GetAllSV())
                {
                    if (i == j.MSSV)
                    {
                        data.Add(j);
                    }
                }
            }
            return data;
        }
        public List<SV> GetAllSVSortByMSSV()
        {
            List<SV> list = GetAllSV();

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (Convert.ToInt32(list[i].MSSV.ToString()) > Convert.ToInt32(list[j].MSSV.ToString()))
                    {
                        SV ssv = list[i];
                        list[i] = list[j];
                        list[j] = ssv;
                    }
                }
            }
            return list;
        }
        public List<SV> GetAllSVSortByName()
        {
            List<SV> list = GetAllSV();
            
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].NameSV.CompareTo(list[j].NameSV) > 0)
                    {
                        SV ssv = list[i];
                        list[i] = list[j];
                        list[j] = ssv;
                    }
                }
            }
            return list;
        }
        public List<SV> GetAllSVSortByLop()
        {
            List<SV> list = GetAllSV();

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].LopSH.CompareTo(list[j].LopSH) > 0)
                    {
                        SV ssv = list[i];
                        list[i] = list[j];
                        list[j] = ssv;
                    }
                }
            }
            return list;
        }
    }
}
