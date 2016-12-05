using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanDay03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Input Nomor Soal untuk hari 03 : ");
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

                catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    continue;
                }
            }
        }

        #region Contoh
        static void Contoh() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int H = 0; H < n; H++) {
                if (H > 1)
                {
                    array[H] = array[H - 2] + array[H - 1];
                }
                else
                {
                    array[H] = 1;
                }
                
            }

            for (int I = 0; I < array.Length; I++)
            {
                Console.Write(array[I].ToString() + "\t");
            }
            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal01
        static void Soal01() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int H = 0; H < n; H++)
            {
                if (H > 1)
                {
                    array[H] = array[H - 2] + array[H - 1];
                }
                else
                {
                    array[H] = 1;
                }

            }

            for (int I = 0; I < array.Length; I++)
            {
                Console.Write(array[I].ToString() + "\t");
            }
            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal02
        static void Soal02()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int H = 0; H < n; H++)
            {
                if (H > 2)
                {
                    array[H] = array[H - 3] + array[H - 2] + array[H - 1];
                }
                else
                {
                    array[H] = 1;
                }

            }

            for (int I = 0; I < array.Length; I++)
            {
                Console.Write(array[I].ToString() + "\t");
            }
            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal03
        static void Soal03() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;
            int[] array = new int[n];

            for (int I = 0; I <= mid; I++) 
            {
                if (I > 1)
                {
                    array[I] = array[I - 2] + array[I - 1];
                    array[n - 1 - I] = array[I];
                }
                else
                {
                    array[I] = 1;
                    array[n - 1 - I] = 1;
                }
            }

            for (int J = 0; J < n; J++) {
                Console.Write(array[J].ToString() + "\t");
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal04
        static void Soal04()
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;
            int[] array = new int[n];

            for (int I = 0; I <= mid; I++)
            {
                if (I > 2)
                {
                    array[I] = array[I - 3] + array[I - 2] + array[I - 1];
                    array[n - 1 - I] = array[I];
                }
                else
                {
                    array[I] = 1;
                    array[n - 1 - I] = 1;
                }
            }

            for (int J = 0; J < n; J++)
            {
                Console.Write(array[J].ToString() + "\t");
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal05
        static void Soal05() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;
            int[] array = new int[n];

            for (int I = 0; I <= mid; I++)
            {
                if (I > 1)
                {
                    array[I] = array[I - 2] + array[I - 1];
                    array[n - 1 - I] = array[I];
                }
                else
                {
                    array[I] = 1;
                    array[n - 1 - I] = 1;
                }
            }

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < array.Length; J++) {
                    if (I <= J)
                    {
                        Console.Write(array[J].ToString() + "\t");
                    }
                    else if(n-1-J <= I)
                    {
                        Console.Write(array[J].ToString() + "\t");
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

        #region Soal06
        static void Soal06() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int H = 0; H < n; H++) 
            {
                if (H > 1)
                    array[H] = array[H - 2] + array[H - 1];
                else
                    array[H] = 1;
            }

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I == J)
                    {
                        Console.Write(array[J].ToString() + "\t");
                    }
                    else if(n - 1 - J == I)
                    {
                        Console.Write(array[J].ToString() + "\t");
                    }
                    else if(J > I && n - 1 - J > I)
                    {
                        Console.Write("A\t");
                    }
                    else if(n - 1 - J < I && J > I)
                    {
                        Console.Write("B\t");
                    }
                    else if(I > J && n - 1 - J < I)
                    {
                        Console.Write("C\t");
                    }
                    else if(I > J && n - 1 - J > I)
                    {
                        Console.Write("D\t");
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

        #region Soal07
        static void Soal07() {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int mid = (n + 1) / 2;

            int[] array = new int[n];

            for (int H = 0; H < mid; H++) {
                if (H > 1)
                {
                    array[H] = array[H - 2] + array[H - 1];
                    array[n - 1 - H] = array[H];
                }
                else
                {
                    array[H] = 1;
                    array[n - 1 - H] = array[H];
                }
            }

            for (int I = 0; I < n; I++) {
                for (int J = 0; J < n; J++) {
                    if (I == J)
                    {
                        Console.Write(array[I].ToString() + "\t");
                    }
                    else if(n - 1 - J == I)
                    {
                        Console.Write(array[I].ToString() + "\t");
                    }
                    else if(J > I && n - 1 - J > I)
                    {
                        Console.Write(array[I].ToString() + "\t");
                    }
                    else if (n - 1 - J < I && J > I)
                    {
                        Console.Write(array[J].ToString() + "\t");
                    }
                    else if(I > J && n - 1 - J < I)
                    {
                        Console.Write(array[I].ToString() + "\t");
                    }
                    else if(I > J && n - 1 - J > I)
                    {
                        Console.Write(array[J].ToString() + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal08
        static void Soal08() { 
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;
            int[] array = new int[n];

            for (int H = 0; H < n; H++) {
                if (H <= mid)
                {
                    array[H] = H + 1;
                    array[n - 1 - H] = H + 1;
                }
                else
                    break;
            }

            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    if (I <= J && n - 1 - J >= I && I % 2 == 0)
                    {
                        Console.Write(array[I].ToString() + "\t");
                    }
                    else if (n - 1 - J <= I && I >= J && I % 2 == 0)
                    {
                        Console.Write(array[I].ToString() + "\t");
                    }
                    else if (I <= J && n - 1 - J < I && J % 2 == 0) 
                    {
                        Console.Write(array[J].ToString() + "\t");
                    }
                    else if (I >= J && n - 1 - J > I && J % 2 == 0)
                    {
                        Console.Write(array[J].ToString() + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();
        }
        #endregion

        #region Soal09
        static void Soal09() 
        {
            Console.Write("Masukkan angka : ");
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;
            int[] array = new int[n];

            for (int I = 0; I < n; I++)
            {
                if (I > 1)
                {
                    array[I] = array[I - 2] + array[I - 1];
                    //array[n - 1 - I] = array[I];
                }
                else
                {
                    array[I] = 1;
                    //array[n - 1 - I] = 1;
                }
            }

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i].ToString() + "\t");
            //}

            //Console.WriteLine();

            for (int I = 1; I <= n; I++)
            {
                for (int J = 1; J <= n; J++)
                {
                    // Atas
                    //if (I <= J && n - 1 - J >= I && I % 2 == 0 && I < mid)
                    if (I <= J && I <= n + 1 - J && I % 2 != 0)
                    {
                        Console.Write(array[I / 2].ToString() + "\t");
                    }
                    // Kanan
                    else if (n + 1 - J <= I && I <= J && J % 2 != 0)
                    {
                        Console.Write(array[mid - J / 2].ToString() + "\t");
                    }
                    // Bawah
                    //else if (n - 1 - J <= I && I >= J && I % 2 == 0 && I > mid)
                    else if (I >= J && I >= n + 1 - J && I % 2 != 0)
                    {
                        Console.Write(array[mid - I / 2].ToString() + "\t");
                    }
                    //// Kiri
                    else if (I > J && n + 1 - J > I && J % 2 != 0)
                    {
                        Console.Write(array[J / 2].ToString() + "\t");
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

        #region Soal10
        static void Soal10()
        {
            Console.Write("Masukkan angka soal 10 : ");
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;
            string[] array = new string[n];
            string[] huruf = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            int urutHuruf = 0;

            for (int I = 0; I < n; I++)
            {
                if (I % 2 != 0) {
                    array[I] = huruf[urutHuruf];
                    urutHuruf++;
                }
                else if (I > 3)
                {
                    array[I] = (int.Parse(array[I - 4]) + int.Parse(array[I - 2])).ToString();
                }
                else
                {
                    array[I] = (1).ToString();
                }
            }

            //for (int I = 0; I < array.Length; I++)
            //{
            //    Console.Write(array[I] + "\t");
            //}

            for (int I = 1; I <= n; I++)
            {
                for (int J = 1; J <= n; J++)
                {
                    // Atas
                    //if (I <= J && n - 1 - J >= I && I % 2 == 0 && I < mid)
                    if (I <= J && I <= n + 1 - J)
                    {
                        Console.Write(array[I - 1].ToString() + "\t");
                    }
                    // Kanan
                    else if (n - J <= I && I <= J)
                    {
                        Console.Write(array[n - J].ToString() + "\t");
                    }
                    // Bawah
                    else if (I >= J && I > n - J)
                    {
                        Console.Write(array[n - I].ToString() + "\t");
                    }
                    // Kiri
                    else if (I >= J && n - J >= I)
                    {
                        Console.Write(array[J - 1].ToString() + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();

        }
        #endregion
    }
}
