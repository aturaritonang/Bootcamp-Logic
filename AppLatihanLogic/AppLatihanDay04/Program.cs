using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanDay04
{
    public class Program
    {

        
        public Program()
        {
            
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input Nomor Soal untuk hari 04 : ");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1: Soal01(); break;
                    case 2: Soal02(); break;
                    case 3: Soal03(); break;
                    case 4: Soal04(); break;
                    case 5: Soal05(); break;
                    case 6: Soal06(); break;
                    case 7: Soal07(); break;
                    case 8: Soal08(); break;
                    case 9: Soal09(); break;
                    case 10: Soal10(); break;
                }
                Console.Write("Ke soal yang lain? [Y/y] untuk ya : ");
                string answer = Console.ReadLine();
                if (answer.ToUpper() != "Y")
                {
                    break;
                }
            }
        }

        #region Soal01
        static void Soal01() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n;

            //Nilai Lebar Array
            int nL = (n * 2) - 1;

            //Batas Kiri
            int nKiri = n;

            //Batas Kanan
            int nKanan = n;

            int[,] array = new int[nP, nL];

            for (int I = 0; I < nP; I++)
            {
                int angka = 1;
                for (int J = 0; J < nL; J++)
                {
                    if (J >= nKiri - 1 && J <= nKanan - 1)
                    {
                        array[I, J] = angka;
                        angka++;
                    }
                }
                nKiri--;
                nKanan++;
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] > 0)
                        Console.Write(array[I, J].ToString() + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal02
        static void Soal02() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n;

            //Nilai Lebar Array
            int nL = (n * 2) - 1;

            //Batas Kiri
            int nKiri = 1;

            //Batas Kanan
            int nKanan = nL;

            int[,] array = new int[nP, nL];

            for (int I = 0; I < nP; I++)
            {
                int angka = 1;
                for (int J = 0; J < nL; J++)
                {
                    if (J >= nKiri - 1 && J <= nKanan - 1)
                    {
                        array[I, J] = angka;
                        angka++;
                    }
                }
                nKiri++;
                nKanan--;
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] > 0)
                        Console.Write(array[I, J].ToString() + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal03
        static void Soal03() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n;

            //Nilai Lebar Array
            int nL = n;

            //Nilai Tengah
            int nT = (n + 1) / 2;

            //Batas Kiri
            int nKiri = nT;

            //Batas Kanan
            int nKanan = nT;

            int[,] array = new int[nP, nL];

            for (int I = 0; I < nP; I++)
            {
                int angka = 1;
                for (int J = 0; J < nL; J++)
                {
                    if (J >= nKiri - 1 && J <= nKanan - 1) {
                        array[I, J] = angka;
                        angka++;
                    }
                }

                if (I + 1 < nT)
                {
                    nKiri--;
                    nKanan++;
                }
                else
                {
                    nKiri++;
                    nKanan--;
                }
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] > 0)
                        Console.Write(array[I, J].ToString() + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal04
        static void Soal04() {
            string[] abjad = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", 
            "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n;

            //Nilai Lebar Array
            int nL = (n * 2) - 1;

            //Batas Kiri
            int nKiri = n;

            //Batas Kanan
            int nKanan = n;

            string[,] array = new string[nP, nL];

            for (int I = 0; I < nP; I++)
            {
                int angka = 1;
                for (int J = 0; J < nL; J++)
                {
                    if (J >= nKiri - 1 && J <= nKanan - 1)
                    {
                        array[I, J] = abjad[angka - 1];
                        angka++;
                    }
                }
                nKiri--;
                nKanan++;
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] != "")
                        Console.Write(array[I, J] + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal05
        static void Soal05()
        {
            string[] abjad = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", 
            "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n;

            //Nilai Lebar Array
            int nL = (n * 2) - 1;

            //Batas Kiri
            int nKiri = 1;

            //Batas Kanan
            int nKanan = nL;

            string[,] array = new string[nP, nL];

            for (int I = 0; I < nP; I++)
            {
                int angka = 1;
                for (int J = 0; J < nL; J++)
                {
                    if (J >= nKiri - 1 && J <= nKanan - 1)
                    {
                        array[I, J] = abjad[angka - 1];
                        angka++;
                    }
                }
                nKiri++;
                nKanan--;
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] != "")
                        Console.Write(array[I, J] + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal06
        static void Soal06()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n;

            //Nilai Lebar Array
            int nL = (n * 2) - 1;

            //Batas Kiri
            int nKiri = n;

            //Batas Kanan
            int nKanan = n;

            int[,] array = new int[nP, nL];

            for (int I = 0; I < nP; I++)
            {
                int angka = 1;
                for (int J = 0; J < nL; J++)
                {
                    if (J >= nKiri - 1 && J <= nKanan - 1)
                    {
                        array[I, J] = angka;
                        if (J + 1 >= n)
                            angka -= 2;
                        else
                            angka += 2;
                    }
                }
                nKiri--;
                nKanan++;
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] > 0)
                        Console.Write(array[I, J].ToString() + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal07
        static void Soal07()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n;

            //Nilai Lebar Array
            int nL = (n * 2) - 1;

            //Batas Kiri
            int nKiri = 1;

            //Batas Kanan
            int nKanan = nL;

            int[,] array = new int[nP, nL];

            for (int I = 0; I < nP; I++)
            {
                int angka = 1;
                for (int J = 0; J < nL; J++)
                {
                    if (J >= nKiri - 1 && J <= nKanan - 1)
                    {
                        array[I, J] = angka;
                        if (J + 1 < n)
                            angka += 2;
                        else
                            angka -= 2;
                    }
                }
                nKiri++;
                nKanan--;
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] > 0)
                        Console.Write(array[I, J].ToString() + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal08
        static void Soal08()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n;

            //Nilai Lebar Array
            int nL = n;

            //Nilai Tengah
            int nT = (n + 1) / 2;

            //Batas Kiri
            int nKiri = nT;

            //Batas Kanan
            int nKanan = nT;

            int[,] array = new int[nP, nL];

            for (int I = 0; I < nP; I++)
            {
                int angka = 1;
                for (int J = 0; J < nL; J++)
                {
                    if (J >= nKiri - 1 && J <= nKanan - 1)
                    {
                        array[I, J] = angka;
                        if (J + 1 < nT)
                            angka += 2;
                        else
                            angka -= 2;
                    }
                }

                if (I + 1 < nT)
                {
                    nKiri--;
                    nKanan++;
                }
                else
                {
                    nKiri++;
                    nKanan--;
                }
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] > 0)
                        Console.Write(array[I, J].ToString() + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal09
        static void Soal09() {
            Console.Write("Masukkan angka 1 : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Masukkan angka 2 : ");
            int n2 = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n1;

            //Nilai Lebar Array
            int nL = n1;

            int nL1 = n1 * n2 - n2 + 1;

            //Nilai Tengah
            int nT = (n1 + 1) / 2;

            //Batas Kiri
            int nKiri = nT;

            //Batas Kanan
            int nKanan = nT;

            int[,] array = new int[nP, nL1];

            for (int I = 0; I < nP; I++)
            {
                for (int bangun = 0; bangun < n2; bangun++)
                {
                    int angka = 1;
                    for (int J = 0; J < nL; J++)
                    {
                        if (J >= nKiri - 1 && J <= nKanan - 1)
                        {
                            array[I, (bangun * nL) + J - bangun] = angka;
                            if (J + 1 < nT)
                                angka += 2;
                            else
                                angka -= 2;
                        }
                    }

                }
                if (I + 1 < nT)
                {
                    nKiri--;
                    nKanan++;
                }
                else
                {
                    nKiri++;
                    nKanan--;
                }
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] > 0)
                        Console.Write(array[I, J].ToString() + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal10
        static void Soal10()
        {
            string[] abjad = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", 
            "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Console.Write("Masukkan angka 1 : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Masukkan angka 2 : ");
            int n2 = int.Parse(Console.ReadLine());

            //Nilai Panjang Array
            int nP = n1;

            //Nilai Lebar Array
            int nL = n1;

            int nL1 = n1 * n2 - n2 + 1;

            //Nilai Tengah
            int nT = (n1 + 1) / 2;

            //Batas Kiri
            int nKiri = nT;

            //Batas Kanan
            int nKanan = nT;

            string[,] array = new string[nP, nL1];

            for (int I = 0; I < nP; I++)
            {
                for (int bangun = 0; bangun < n2; bangun++)
                {
                    int angka = 1;
                    for (int J = 0; J < nL; J++)
                    {
                        if (J >= nKiri - 1 && J <= nKanan - 1)
                        {
                            array[I, (bangun * nL) + J - bangun] = abjad[angka - 1];
                            if (J + 1 < nT)
                                angka++;
                            else
                                angka--;
                        }
                    }

                }
                if (I + 1 < nT)
                {
                    nKiri--;
                    nKanan++;
                }
                else
                {
                    nKiri++;
                    nKanan--;
                }
            }

            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    if (array[I, J] != "")
                        Console.Write(array[I, J] + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion
    }
}
