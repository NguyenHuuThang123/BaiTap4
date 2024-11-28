using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8
{
    internal class NhanVien
    {
        public string ID;
        public string Name;
        public string Luong;

        public NhanVien() { }

        public NhanVien(string id, string name, string luong)
        {
            ID = id;
            Name = name;
            Luong = luong;
        }
    }
}
