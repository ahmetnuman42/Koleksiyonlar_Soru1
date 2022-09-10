using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Koleksiyonlar_Soru1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string sayi = " ";
            ArrayList asal = new ArrayList();
            ArrayList non_asal = new ArrayList();
            int kontrol = 0;
            Console.WriteLine("20 adet sayı giriniz");
            for(int i = 0; i < 20; i++)
            {
               bas:
               sayi = Console.ReadLine();
                if (Sayimi(sayi)) 
                {
                    int sayi1 = Convert.ToInt32(sayi);
                    for (int j = 2; j < sayi1; j++)
                    {
                        if (sayi1 % j == 0)
                        {
                            kontrol++;
                        }
                    }
                    if (kontrol == 0)
                    {
                        asal.Add(sayi);
                    }
                    else
                    {
                        non_asal.Add(sayi);
                    }
                    kontrol = 0;
                }
                else
                {
                    Console.WriteLine("Yanlış Değer girdiniz,Tekrar giriniz");
                    goto bas;
                }
            }
            asal.Sort();
            asal.Reverse();
            non_asal.Sort();
            non_asal.Reverse();
            int asal_top = 0;
            int nonasal_top = 0;

            Console.WriteLine("Asal Sayılar");
            foreach(var a in asal)
            {                
                asal_top = asal_top + Convert.ToInt32(a);
                Console.Write(" " + a);                
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olmayan Sayılar");
            foreach(var b in non_asal)
            {               
                nonasal_top = nonasal_top + Convert.ToInt32(b);
                Console.Write(" " + b);
            }
            Console.WriteLine();

            Console.WriteLine("Asal olanların sayısı= {0}  Asal olanların ortalaması={1}", asal.Count, asal_top / asal.Count);
            Console.WriteLine("Asal olmayanların sayısı= {0}  Asal olmayanların Ortalaması={1}", non_asal.Count, nonasal_top / non_asal.Count);

        }

        public static bool Sayimi(string sayi)
        {
            if (String.IsNullOrEmpty(sayi) == true)
            {
                return false;
            }
            else
            {
                Regex sayikontrol = new Regex("^[0-9]*$");
                return sayikontrol.IsMatch(sayi);
            }
        }
    }
}
