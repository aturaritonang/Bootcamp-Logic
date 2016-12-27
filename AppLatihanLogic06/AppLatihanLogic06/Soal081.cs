using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal081: BasicLogic
    {
        public Soal081(int n)
        {
            nilaiLebar = n * n;
            nilaiPanjang = n * n;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //tentukan posisi
                int iposV = bangun * n;
                int iposH = bangun * n;

                //tentukan ruang
                int cetL = (bangun + 1) * n;
                int cetP = (bangun + 1) * n;

                //cari margin dan balik mantul
                int mKiri = cetP - (n / 2) - 1;
                int mKanan = cetP - (n / 2) - 1;

                //nilai tengah
                int midVer = cetP - (n / 2) - 1;
                int midHor = cetP - (n / 2) - 1;

                for (int I = iposV; I < cetL; I++)
                {
                    //tentukan nilai deret
                    int deret = (bangun + 1) * ((n / 2) + 1);

                    for (int J = iposH; J < cetP; J++)
                    {
                        if (J >= mKiri && J <= mKanan)
                        {
                            array2D[I, J] = deret.ToString();

                            if (J < midHor)
                                deret -= 1;
                            else
                                deret += 1;
                        }
                    }

                    if (I < midVer)
                    {
                        mKiri--;
                        mKanan++;
                    }
                    else
                    {
                        mKiri++;
                        mKanan--;
                    }
                }
            }
        }
    }
}
