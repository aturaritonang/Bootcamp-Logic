using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Soal09 : BaseLogic
    {
        public Soal09(int n)
        {
            nilaiTinggi = Utility.FaktorialSegiEmpat(n);
            nilaiLebar = (n * 2) - 1;

            array2D = new string[nilaiTinggi, nilaiLebar];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n) 
        {
            for (int bangun = 1; bangun <= n; bangun++)
            {
                int marginL = ((n * 2) - 1) / 2;
                int marginR = ((n * 2) - 1) / 2;

                //cari posisi untuk cetak
                int posV = Utility.FaktorialSegiEmpat(bangun - 1);

                //cari ruang untuk cetak
                int nT = Utility.FaktorialSegiEmpat(bangun);
                int lebar = (bangun * 2) - 1;

                for (int I = posV; I < nT; I++)
                {
                    for (int J = marginL; J <= marginR; J++)
                    {
                        array2D[I, J] = "*";
                    }
                    marginL -= 1;
                    marginR += 1;
                }
            }
        }
    }
}
