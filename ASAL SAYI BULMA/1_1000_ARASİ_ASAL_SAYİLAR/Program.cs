using System.ComponentModel.Design;

namespace _1_1000_ARASİ_ASAL_SAYİLAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayac =0;
            Console.WriteLine("Bitiş sayısını giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi==0 || sayi==1 || sayi<0)
            {
                Console.WriteLine("Asal sayı hesaplaması için lütfen doğru giriniz\n zira bu sayı asal sayı değildir ");
            }
            else
            {

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                        break;
                    }
                      


                }
                if (sayac == 0)
                {
                    Console.WriteLine("{0} sayısı asal sayıdır", sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı asal bir sayı değildir", sayi);
                }
                Console.ReadKey();
            }

           

        }
    }
}