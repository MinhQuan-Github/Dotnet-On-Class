using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx2
{
    public class QLNV
    {
        private NV[] _data;
        public int Length{set;get;}
        public QLNV() 
        {
            _data = null;
            Length = 0;
        }
        public void Add(NV o)
        {
            this.Length += 1;
            
            NV [] temp = new NV[this.Length];
            for (int i = 0 ; i < this.Length - 1 ; i++){
                temp[i]=this._data[i];
            }
            temp[this.Length - 1] = o;

            this._data = new NV[this.Length];
            for (int i = 0 ; i < this.Length ; i++){
                this._data[i] = temp[i];
            }
        }
        public void Insert(int index , NV o)
        {
            this.Length += 1;
            
            NV [] temp = new NV[this.Length];
            for (int i = 0 ; i < index - 1 ; i++){
                temp[i]=this._data[i];
            }
            temp[index-1] = o;
            for (int i = index ; i < this.Length ; i++){
                temp[i]=this._data[i-1];
            }

            this._data = new NV[this.Length];
            for (int i = 0 ; i < this.Length ; i++){
                this._data[i] = temp[i];
            }
        }
        public override string ToString()
        {
            string _temp ="";
            for(int i =0;i<this.Length;i++){
                _temp += this._data[i].ID.ToString()+ "    "+_data[i].HoTen.ToString()+ "    " + _data[i].Lop.ToString()+"\n";
            }
            return _temp;
        }
        public int IndexOf(NV o)
        {
            int index = -1;
            for(int i = 0; i < this.Length ; i++){
                if (this._data[i] == o) return i + 1;
            }
            return index;
        }
        public void Remove(NV o)
        {
            NV [] temp = new NV[this.Length - 1];
            int k = 0;
            for(int i = 0 ; i< this.Length; i++){
                if (this._data[i] != o) {
                    temp[i] = this._data[i];
                }
                else 
                {
                    k = i;
                    break;
                }
            }
            for (int i = k ; i < this.Length - 1 ; i++){
                temp[i] = this._data[i+1];
            }
            this.Length -= 1;
            this._data = new NV [this.Length];
            for (int i = 0 ; i < this.Length  ; i++){
                this._data[i] = temp[i];
            }
        }
        public void RemoveAt(int index)
        {
            NV [] temp = new NV[this.Length - 1];
            for(int i = 0 ; i < index - 1; i++){
                temp[i] = this._data[i];
            }
            for (int i = index - 1 ; i < this.Length - 1 ; i++){
                temp[i] = this._data[i+1];
            }
            this.Length -= 1;
            this._data = new NV [this.Length];
            for (int i = 0 ; i < this.Length  ; i++){
                this._data[i] = temp[i];
            }
        }
        public NV[] sort(){ 
            for(int i =0;i<this.Length;i++){
                for(int j =i+1;j<this.Length;j++){
                    if(this._data[i].ID > this._data[j].ID){
                        NV temp = _data[i];
                        _data[i] = _data[j];
                         _data[j] = temp;
                    }
                }
            }
            return _data;
        }
        
    }
}