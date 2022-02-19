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
            
            /*Console.Write("1. Sayı : ");
            int firstnum=int.Parse(Console.ReadLine());
            Console.Write("2. Sayı : ");
            int secondnum=int.Parse(Console.ReadLine());
            Console.WriteLine(firstnum+" ve "+secondnum+" Sayının Toplamı : "+(firstnum+secondnum));*/

            //Alıştırma 3: Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program 
            /*Console.Write("Kısa Kenar : ");
            int n=int.Parse(Console.ReadLine());
            Console.Write("Uzun Kenar : ");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine( "Alan : "+(n*m));
            Console.WriteLine( "Çevre : "+(n+m)*2);*/


            //Alıştırma 4: Girilen sayının tek mi çift mi olduğunu bulan program

            Console.Write("Bir sayı giriniz : ");
            int num=int.Parse(Console.ReadLine());
            if(num%2==0)
                Console.Write(num+" çifttir.");
            else
                Console.Write(num+" tektir.");
        }
    }
}
