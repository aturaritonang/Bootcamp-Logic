using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal06 : BasicLogic
    {
        public Soal06(int n)
        {
            nilaiLebar = n * n;
            nilaiPanjang = n * n;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D, true);
        }

        public void IsiArray(int n) 
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //tentukan posisi
                int posV = bangun * n;
                int posH = bangun * n;

                //tentukan ruang
                int nLebar = (bangun + 1) * n;
                int nPanjang = (bangun + 1) * n;

                //cari margin dan balik mantul
                int midL = nPanjang - (n / 2) - 1;
                int midR = nPanjang - (n / 2) - 1;
                int mid = nPanjang - (n / 2) - 1;

                for (int I = posV; I < nLebar; I++)
                {
                    for (int J = posH; J < nPanjang; J++)
                    {
                        if (J >= midL && J <= midR)
                        {
                            array2D[I, J] = "*";
                        }
                    }

                    if (I < mid)
                    {
                        midL--;
                        midR++;
                    }
                    else
                    {
                        midL++;
                        midR--;
                    }
                }
            }
        }
    }
}
