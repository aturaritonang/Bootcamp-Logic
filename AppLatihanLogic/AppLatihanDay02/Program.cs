using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanDay02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input Nomor Soal untuk hari 02 : ");
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
                if (answer.ToUpper() != "Y") {
                    break;
                }
            }
        }

        public Program()
        {

        }

        #region Soal01
        static void Soal01() 
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int nilai = 1;

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I == J)
                    {
                        Console.Write(nilai.ToString() + "\t");
                        nilai += 2;
                    }
                    else 
                    {
                        Console.Write("\t");
                    }
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
            int nilai = (n - 1) * 2;

            for (int I = 0; I < n; I++) 
            {
                for (int J = 0; J < n; J++) 
                {
                    if ((n - 1) - J == I)
                    {
                        Console.Write(nilai.ToString() + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                nilai -= 2;
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
            int nilaiGanjil = 1;
            int nilaiGenap = (n - 1) * 2;

            for (int I = 0; I < n; I++) {
                for (int J = 0; J < n; J++) {
                    if (I == J) {
                        Console.Write(nilaiGanjil.ToString() + "\t");
                    }
                    else if ((n - 1) - J == I)
                    {
                        Console.Write(nilaiGenap.ToString() + "\t");
                    }
                    else 
                    {
                        Console.Write("\t");
                    }
                }
                nilaiGanjil += 2;
                nilaiGenap -= 2;
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal04
        static void Soal04() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int nilaiGanjil = 1;
            int nilaiGenap = (n - 1) * 2;
            int nilaiTengah = n / 2;

            for (int I = 0; I < n; I++) {
                for (int J = 0; J < n; J++) {
                    if (I == J) {
                        Console.Write(nilaiGanjil.ToString() + "\t");
                    }
                    else if (J == nilaiTengah) {
                        Console.Write(nilaiGanjil.ToString() + "\t");
                    }
                    else if (n - 1 - J == I)
                    {
                        Console.Write(nilaiGenap.ToString() + "\t");
                    }
                    else if (I == nilaiTengah) 
                    {
                        Console.Write((J * 2).ToString() + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                nilaiGanjil += 2;
                nilaiGenap -= 2;
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal05
        static void Soal05() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int nGanjil = 1;

            for (int I = 0; I < n; I++) {
                for (int J = 0; J < n; J++) {
                    if (I >= J)
                    {
                        Console.Write(nGanjil.ToString() + "\t");
                    }
                    else 
                    {
                        Console.Write("\t");
                    }
                    nGanjil += 2;
                }
                nGanjil = 1;
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal06
        static void Soal06() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int nGenap = (n - 1) * 2;

            for (int I = 0; I < n; I++) {
                for (int J = 0; J < n; J++) {
                    if (n - 1 - J <= I)
                    {
                        Console.Write(nGenap.ToString() + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
                nGenap -= 2;
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal07
        static void Soal07() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int nGanjil = 1;
            int nGenap = (n - 1) * 2;

            for (int I = 0; I < n; I++) {
                for (int J = 0; J < n; J++) {
                    if (I == J) {
                        Console.Write(nGanjil.ToString() + "\t");
                    }
                    else if ((n - 1) - J == I) {
                        Console.Write(nGenap.ToString() + "\t");
                    }
                    else if (I < J && (n - 1 - J) > I) {
                        Console.Write("A\t");
                    }
                    else if ((n - 1 - J) < I && I >= J) {
                        Console.Write("B\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                nGanjil += 2;
                nGenap -= 2;
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress enter to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal08
        static void Soal08()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int nGanjil = 1;
            int nGenap = (n - 1) * 2;

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I == J)
                    {
                        Console.Write(nGanjil.ToString() + "\t");
                    }
                    else if ((n - 1) - J == I)
                    {
                        Console.Write(nGenap.ToString() + "\t");
                    }
                    else if (I > J && (n - 1 - J) > I)
                    {
                        Console.Write("A\t");
                    }
                    else if ((n - 1 - J) < I && I <= J)
                    {
                        Console.Write("B\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                nGanjil += 2;
                nGenap -= 2;
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress enter to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal09
        static void Soal09() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int nGanjil = 1;

            for (int I = 0; I < n; I++) {
                for (int J = 1; J <= n; J++) {
                    Console.Write(nGanjil.ToString() + "\t");
                    if (J <= n / 2)
                    {
                        nGanjil += 2;
                    }
                    else 
                    {
                        nGanjil -= 2;
                    }
                }
                nGanjil = 1;
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal10
        static void Soal10() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int nGenap = 0;

            for (int I = 0; I < n; I++) {
                for (int J = 0; J < n; J++) {
                    Console.Write(nGenap.ToString() + "\t");
                }
                if (I < n / 2)
                    nGenap += 2;
                else
                    nGenap -= 2;

                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion
    }
}
