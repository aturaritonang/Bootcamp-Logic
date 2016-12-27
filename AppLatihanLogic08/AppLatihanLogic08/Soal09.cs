using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Soal09: BasicLogic
    {
        public Soal09(int n1, int n2, int n3)
        {
            nilaiPanjang = (n1 + n2 - 1) * n3;
            nilaiLebar = (n2 * 2) - 1;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n1, n2, n3);
            Utility.cetakArray(array2D);
        }

        public void IsiArray(int n1, int n2, int n3)
        {
            //mempermudah posisi balik atau pantul
            int peekPos = 0;

            //deret angka genap
            int nilaiGenap = 0;
            for (int bangun1 = 0; bangun1 < n3; bangun1++)
            {
                for (int bangun2 = 0; bangun2 < nilaiLebar; bangun2++)
                {
                    for (int J = 0; J < n1; J++)
                    {
                        array2D[bangun2, nilaiPanjang - 1 - peekPos - J] = nilaiGenap.ToString();
                        nilaiGenap += 2;
                    }
                    if (bangun2 < n2 - 1)
                    {
                        peekPos++;
                    }
                    else
                    {
                        peekPos--;
                    }
                }
            }
        }
    }
}
