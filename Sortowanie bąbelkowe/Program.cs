using System;
using System.Diagnostics;
using System.IO;

namespace Sortowanie_bąbelkowe
{
    class Program
    {
        static void sortuj(int[] sortowanie)
        {
            int n = sortowanie.Length;
            int i = new int();
            int j = new int();
            {
                for (i = 0; i < n - 1; i++)
                {
                    for (j=0; j<n-1-i; j++)
                    {
                        if (sortowanie[j] > sortowanie[j + 1])
                        {
                            int zmienna = sortowanie[j];
                            sortowanie[j] = sortowanie[j + 1];
                            sortowanie[j + 1] = zmienna;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string czytnik1;
            string czytnik2;
            string czytnik3;
            string czytnik4;
            string czytnik5;
            int indeks;
            indeks = 0;
            int[] arr1 = new int[200000];
            int[] arr2 = new int[200000];
            int[] arr3 = new int[200000];
            int[] arr4 = new int[200000];
            int[] arr5 = new int[200000];
            Stopwatch timera = new Stopwatch();
            Stopwatch timerb = new Stopwatch();
            Stopwatch timerc = new Stopwatch();
            Stopwatch timerd = new Stopwatch();
            Stopwatch timere = new Stopwatch();

            StreamReader dane1 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosowea.txt");
            while ((czytnik1 = dane1.ReadLine()) != null)
            {
                arr1[indeks] = int.Parse(czytnik1);
                indeks++;
            }

            timera.Start();
            sortuj(arr1);
            timera.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timera.ElapsedMilliseconds);



            indeks = 0;
            StreamReader dane2 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosoweb.txt");
            while ((czytnik2 = dane2.ReadLine()) != null)
            {
                arr2[indeks] = int.Parse(czytnik2);
                indeks++;
            }

            timerb.Start();
            sortuj(arr2);
            timerb.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timerb.ElapsedMilliseconds);




            indeks = 0;
            StreamReader dane3 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosowec.txt");
            while ((czytnik3 = dane3.ReadLine()) != null)
            {
                arr3[indeks] = int.Parse(czytnik3);
                indeks++;
            }

            timerc.Start();
            sortuj(arr3);
            timerc.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timerc.ElapsedMilliseconds);




            indeks = 0;
            StreamReader dane4 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosowed.txt");
            while ((czytnik4 = dane4.ReadLine()) != null)
            {
                arr4[indeks] = int.Parse(czytnik4);
                indeks++;
            }

            timerd.Start();
            sortuj(arr4);
            timerd.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timerd.ElapsedMilliseconds);


            indeks = 0;
            StreamReader dane5 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosowee.txt");
            while ((czytnik5 = dane5.ReadLine()) != null)
            {
                arr5[indeks] = int.Parse(czytnik5);
                indeks++;
            }

            timere.Start();
            sortuj(arr5);
            timere.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timere.ElapsedMilliseconds);



            


            Console.ReadKey();
        }
    }
}
