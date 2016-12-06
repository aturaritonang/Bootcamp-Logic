using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Soal08 : BaseLogic
    {
        public Soal08(int n)
        {
            nilaiTinggi = Utility.FaktorialSegiEmpat(n);
            nilaiLebar = Utility.FaktorialSegiEmpat(n);

            array2D = new string[nilaiTinggi, nilaiLebar];

            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            int nilBangunGenap = 1;
            int nilBagunGanjil = 2;

            for (int bangun = 0; bangun < n; bangun++)
            {
                //cari posisi untuk cetak
                int posV = Utility.FaktorialSegiEmpat(bangun);
                int posH = Utility.FaktorialSegiEmpat(bangun);

                //cari ruang untuk cetak
                int nT = Utility.FaktorialSegiEmpat(bangun + 1);
                int nL = Utility.FaktorialSegiEmpat(bangun + 1);

                //arah
                bool kiri = true;

                for (int I = posV; I < nT; I++)
                {
                    if (kiri)
                    {
                        for (int J = posH; J < nL; J++)
                        {
                            if (bangun % 2 != 0)
                            {
                                array2D[I, J] = nilBagunGanjil.ToString();
                                nilBagunGanjil += 2;
                            }
                            else
                            {
                                array2D[I, J] = nilBangunGenap.ToString();
                                nilBangunGenap += 2;
                            }

                        }
                        kiri = false;
                    }
                    else 
                    {
                        for (int J = nL - 1; J >= posH; J--)
                        {
                            if (bangun % 2 != 0)
                            {
                                array2D[I, J] = nilBagunGanjil.ToString();
                                nilBagunGanjil += 2;
                            }
                            else
                            {
                                array2D[I, J] = nilBangunGenap.ToString();
                                nilBangunGenap += 2;
                            }

                        }
                        kiri = true;
                    }
                }
            }
        }
    }
}
