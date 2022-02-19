using System;

namespace kodluyoruz_projeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alıştırma 1: Ad ve soyad bilgisini string değişenlere alarak ekranda yazdırma
           
           /* Console.Write("Adınız : ");
            string name=Console.ReadLine();
            Console.Write("Soyadınız : ");
            string surname=Console.ReadLine();
            Console.WriteLine("Merhaba "+name+" "+surname);*/


            //Alıştırma 2: Kullanıcıdan 2 sayı isteyerek bu sayıların toplamını bulan program
            Console.Write("1. Sayı : ");
            int firstnum=int.Parse(Console.ReadLine());
            Console.Write("2. Sayı : ");
            int secondnum=int.Parse(Console.ReadLine());
            Console.WriteLine(firstnum+" ve "+secondnum+" Sayının Toplamı : "+(firstnum+secondnum));     
            
        }
    }
}
