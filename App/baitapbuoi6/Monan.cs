using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi6
{
    class Monan
    {
        int size;
        public string[] monAn { get; set; }
        public int[] SoLuong { get; set; }
        public Monan(string s)
        {
            if (monAn == null)
            {
                size++;
                monAn = new string[size];
                SoLuong = new int[size];
                monAn[size - 1] = s;
                SoLuong[size - 1] = 1;
            }else
            {
                int temp = -1;
                for(int i = 0; i < size ; i++)
                {
                    if (monAn[i] == s)
                    {
                        SoLuong[i]++;
                        temp = 0;
                    }
                }
                if (temp != 0)
                {
                    string[] arr = monAn;
                    int[] sl = SoLuong;
                    size++;
                    monAn = new string[size];
                    SoLuong = new int[size];
                    for(int i = 0; i < size - 1; i++)
                    {
                        monAn[i] = arr[i];
                        SoLuong[i] = sl[i];
                    }
                    monAn[size - 1] = s;
                    SoLuong[size - 1] = 1;
                }
            }
        }
        public void add(string s)
        {
            if (monAn == null)
            {
                size++;
                monAn = new string[size];
                SoLuong = new int[size];
                monAn[size - 1] = s;
                SoLuong[size - 1] = 1;
            }
            else
            {
                int temp = -1;
                for (int i = 0; i < size; i++)
                {
                    if (monAn[i] == s)
                    {
                        SoLuong[i]++;
                        temp = 0;
                    }
                }
                if (temp != 0)
                {
                    string[] arr = monAn;
                    int[] sl = SoLuong;
                    size++;
                    monAn = new string[size];
                    SoLuong = new int[size];
                    for (int i = 0; i < size - 1; i++)
                    {
                        monAn[i] = arr[i];
                        SoLuong[i] = sl[i];
                    }
                    monAn[size - 1] = s;
                    SoLuong[size - 1] = 1;
                }
            }
        }
    }
}
