using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal061: BasicLogic
    {
        public Soal061(int n)
        {
            nilaiLebar = n;
            nilaiPanjang = n * n + (n - 1);

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }
        public void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //cari koordinat
                int posV = 0;
                int posH = (bangun * n) + bangun;

                //cari luas cetak
                int nLb = n;
                int nPj = posH + n;

                for (int I = posV; I < nLb; I++)
                {
                    for (int J = posH; J < nPj; J++)
                    {
                        if (I == posV || J == posH || I == n - 1 || J == nPj - 1)
                            array2D[I, J] = "*";
                    }
                }
            }
        }
    }
}
