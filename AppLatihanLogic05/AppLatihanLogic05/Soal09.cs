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
            nilaiLebar = Utility.FaktorialSegiEmpat(n);
            nilaiPanjang = (n * 2) - 1;
            nilaiTengah = nilaiPanjang / 2;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n) 
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //Tentukan nilai margin
                int marginL = nilaiPanjang / 2;
                int marginR = nilaiPanjang / 2;

                //cari posisi untuk cetak
                int posV = Utility.FaktorialSegiEmpat(bangun);
                int posH = (nilaiPanjang / 2) - bangun;

                //cari ruang untuk cetak
                int nT = Utility.FaktorialSegiEmpat(bangun + 1);
                int nL = (nilaiPanjang / 2) + bangun + 1;

                for (int I = posV; I < nT; I++)
                {
                    for (int J = posH; J < nL; J++)
                    {
                        if (J >= marginL && J <= marginR)
                        {
                            array2D[I, J] = "*";
                        }
                    }
                    marginL -= 1;
                    marginR += 1;
                }
            }
        }
    }
}
