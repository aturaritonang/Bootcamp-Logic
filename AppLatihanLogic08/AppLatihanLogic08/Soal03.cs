using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Soal03 : BasicLogic
    {
        public Soal03(int n1, int n2)
        {
            nilaiLebar = n1 + n2 - 1;
            nilaiPanjang = n2;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n1, n2);
            Utility.cetakArray(array2D);
        }

        public void IsiArray(int n1, int n2) 
        {
            for (int bangun = 0; bangun < n2; bangun++)
            {
                for (int I = 0; I < n1; I++)
                {
                    array2D[I + bangun, bangun] = "*";
                }
            }
        }
    }
}
