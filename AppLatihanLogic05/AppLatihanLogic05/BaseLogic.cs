using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class BaseLogic
    {
        public BaseLogic()
        {
        }

        public BaseLogic(int nT, int nL, int nTe)
        {
            nilaiLebar = nT;
            nilaiPanjang = nL;
            nilaiTengah = nTe;
        }
        public BaseLogic(string[,] arr, int nT, int nL, int nTe)
        {
            array2D = arr;
            nilaiLebar = nT;
            nilaiPanjang = nL;
            nilaiTengah = nTe;
        }
        public string[,] array2D { get; set; }
        public int nilaiLebar { get; set; }
        public int nilaiPanjang { get; set; }
        public int nilaiTengah { get; set; }
        
    }
}
