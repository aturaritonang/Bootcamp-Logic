using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal011: BasicLogic
    {
        public Soal011(int n)
        {
            nilaiLebar = ((n * 2) - 1) + (n * 2);
            nilaiPanjang = ((n * 2) - 1) + (n * 2);

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            //tentukan tengah vertical & horizontal
            //Karena nilai tinggi dan lebar adalah sama, maka ambil dari nilai tinggi saja.
            int mid = nilaiLebar / 2;

            for (int bangun = 0; bangun < 4; bangun++)
            {
                //tentukan koordinat cetak
                int posV = 0;
                int posH = 0;

                //tentukan area untuk bangun, tinggi dan lebarnya
                int nPj = 0;
                int nLb = 0;

                if (bangun == 0) 
                {
                    //bangun atas
                    posV = 0;
                    posH = n;
                    
                    nLb = n;
                    nPj = n + ((n * 2) - 1);
                }
                else if (bangun == 1) 
                { 
                    //bangun kanan
                    posV = n;
                    posH = n + (n * 2) - 1;

                    nLb = n + ((n * 2) - 1);
                    nPj = nilaiLebar;
                }
                else if (bangun == 2) 
                {
                    //bangun bawah
                    posV = nilaiLebar - n;
                    posH = n;

                    nLb = nilaiLebar;
                    nPj = n + ((n * 2) - 1);
                }
                else 
                {
                    //bangun kiri
                    posV = n;
                    posH = 0;

                    nLb = posV + ((n * 2) - 1);
                    nPj = n;
                }

                //tentukan nilai margin
                int marLeft = 0;
                int marRight = 0;

                if (bangun == 0)
                {
                    marLeft = mid;
                    marRight = mid;
                }
                else if (bangun == 1)
                {
                    marLeft = nilaiPanjang - n;
                    marRight = nilaiPanjang - n;
                }
                else if (bangun == 2)
                {
                    marLeft = n;
                    marRight = nilaiPanjang - n - 1;
                }
                else
                {
                    marLeft = n - 1;
                    marRight = n - 1;
                }

                for (int I = posV; I < nLb; I++)
                {
                    for (int J = posH; J < nPj; J++)
                    {
                        if (J >= marLeft && J <= marRight)
                        {
                            array2D[I, J] = "*";
                        }
                    }

                    if (bangun == 0)
                    {
                        marLeft -= 1;
                        marRight += 1;
                    }
                    else if (bangun == 1)
                    {
                        if (I <= nLb / 2)
                            marRight += 1;
                        else
                            marRight -= 1;
                    }
                    else if (bangun == 2)
                    {
                        marLeft += 1;
                        marRight -= 1;
                    }
                    else
                    {
                        if (I <= nLb / 2)
                            marLeft -= 1;
                        else
                            marLeft += 1;
                    }
                }
            }
        }
    }
}
