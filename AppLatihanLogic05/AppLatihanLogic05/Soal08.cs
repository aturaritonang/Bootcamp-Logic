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
            nilaiLebar = Utility.FaktorialSegiEmpat(n);
            nilaiPanjang = Utility.FaktorialSegiEmpat(n);

            array2D = new string[nilaiLebar, nilaiPanjang];

            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            int deretGanjil = 1;
            int deretGenap = 2;

            for (int bangun = 0; bangun < n; bangun++)
            {
                //cari posisi untuk cetak
                int posV = Utility.FaktorialSegiEmpat(bangun);
                int posH = Utility.FaktorialSegiEmpat(bangun);

                //cari ruang untuk cetak
                int nLb = Utility.FaktorialSegiEmpat(bangun + 1);
                int nPj = Utility.FaktorialSegiEmpat(bangun + 1);

                //arah awal
                bool kiri = true;

                for (int I = posV; I < nLb; I++)
                {
                    if (kiri)
                    {
                        for (int J = posH; J < nPj; J++)
                        {
                            if (bangun % 2 != 0)
                            {
                                array2D[I, J] = deretGenap.ToString();
                                deretGenap += 2;
                            }
                            else
                            {
                                array2D[I, J] = deretGanjil.ToString();
                                deretGanjil += 2;
                            }

                        }
                        kiri = false;
                    }
                    else 
                    {
                        for (int J = nPj - 1; J >= posH; J--)
                        {
                            if (bangun % 2 != 0)
                            {
                                array2D[I, J] = deretGenap.ToString();
                                deretGenap += 2;
                            }
                            else
                            {
                                array2D[I, J] = deretGanjil.ToString();
                                deretGanjil += 2;
                            }

                        }
                        kiri = true;
                    }
                }
            }
        }
    }
}
