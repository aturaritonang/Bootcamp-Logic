using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal10 : BasicLogic
    {
        public Soal10(int n)
        {
            nilaiLebar = n;
            nilaiPanjang = n;
            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n) {
            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J <= I; J++)
                {
                    if (I % 2 != 0)
                    {
                        array2D[I, n - 1 - J] = (I + 1).ToString();
                    }
                    else
                    {
                        array2D[I, J] = (I + 1).ToString();
                    }
                }
            }
        }
    }
}
