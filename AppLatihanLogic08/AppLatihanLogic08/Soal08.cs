using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Soal08: BasicLogic
    {
        public Soal08(int n1, int n2)
        {
            nilaiPanjang = n1 + n2 - 1;
            nilaiLebar = (n2 * 2) - 1;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n1, n2);
            Utility.cetakArray(array2D);
        }

        public void IsiArray(int n1, int n2) 
        {
            //deret angka genap
            int nilaiGanjil = 1;

            for (int bangun = 0; bangun < n2; bangun++)
            {
                for (int J = 0; J < n1; J++)
                {
                    array2D[bangun, bangun + J] = nilaiGanjil.ToString();
                    array2D[nilaiLebar - 1 - bangun, bangun + J] = nilaiGanjil.ToString();
                    nilaiGanjil += 2;
                }
            }
        }
    }
}
