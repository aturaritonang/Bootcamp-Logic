using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanDay01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input Nomor Soal untuk hari 01 : ");
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
        }

        public Program()
        {

        }

        #region Soal01
        static void Soal01()
        {
            Console.Write("Masukkan Angka : ");
            int n = int.Parse(Console.ReadLine());

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I == J)
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal02
        static void Soal02()
        {
            Console.Write("Masukkan Angka : ");
            int n = int.Parse(Console.ReadLine());

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I + J == n - 1)
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal03
        static void Soal03()
        {
            Console.Write("Masukkan Angka : ");
            int n = int.Parse(Console.ReadLine());

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I == J)
                        Console.Write("*\t");
                    else if (I + J == n - 1)
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal04
        static void Soal04()
        {
            Console.Write("Masukkan Angka : ");
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I == J)
                        Console.Write("*\t");
                    else if (I + J == n - 1)
                        Console.Write("*\t");
                    else if (mid == I)
                        Console.Write("*\t");
                    else if (mid == J)
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal05
        static void Soal05()
        {
            Console.Write("Masukkan Angka : ");
            int n = int.Parse(Console.ReadLine());
            //int mid = n / 2;

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I == J)
                        Console.Write("*\t");
                    else if (I + J == n - 1)
                        Console.Write("*\t");
                    else if (I == 0)
                        Console.Write("*\t");
                    else if (J == 0)
                        Console.Write("*\t");
                    else if (I == n - 1)
                        Console.Write("*\t");
                    else if (J == n - 1)
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal06
        static void Soal06()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I >= J)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

        }
        #endregion

        #region Soal07
        static void Soal07()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (n - (I + 1) <= J)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal08
        static void Soal08()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    //&& n - I <= J
                    if (I <= J && n - I > J)
                    {
                        Console.Write("*\t");
                    }
                    else if ((n - 1) - J <= I && I >= J)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal09
        static void Soal09()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I >= J && (n - 1) - J >= I)
                    {
                        Console.Write("*\t");
                    }
                    else if ((n - 1 - J) <= I && J >= I)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal10
        static void Soal10()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I >= J && I <= mid)
                    {
                        Console.Write("*\t");
                    }
                    else if (I <= J && I + 1 > mid)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
        #endregion
    }
}
