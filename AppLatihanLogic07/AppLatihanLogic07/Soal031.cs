using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal031: BasicLogic
    {
        public Soal031(int n)
        {
            nilaiLebar = (n * 2) + 1;
            nilaiPanjang = (n * 4) - 1;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            //cari posisi tengah area
            int mid = ((n * 4) - 1) / 2;

            for (int bangun = 0; bangun < n; bangun++)
            {
                //tentukan titik koordinat
                int posV = bangun * 2;
                int posH = bangun * 2;

                //cari area untuk bangun
                int nLb = nilaiLebar;
                int nPj = nilaiPanjang - (bangun * 2);

                for (int I = posV; I < nLb; I++)
                {
                    for (int J = posH; J < nPj; J++)
                    {
                        if (I == posV || J == posH || J == nPj - 1) 
                        {
                            array2D[I, J] = "*";
                        }
                    }
                }
            }
        }
    }
}
