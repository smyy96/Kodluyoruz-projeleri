using System;

namespace kodluyoruz_projeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alıştırma 1: Ad ve soyad bilgisini string değişenlere alarak ekranda yazdırma
            Console.Write("Adınız : ");
            string name=Console.ReadLine();
            Console.Write("Soyadınız : ");
            string surname=Console.ReadLine();
            Console.WriteLine("Merhaba "+name+" "+surname);




            //Alıştırma 2: Kullanıcıdan 2 sayı isteyerek bu sayıların toplamını bulan program
            Console.Write("1. Sayı : ");
            int firstnum=int.Parse(Console.ReadLine());
            Console.Write("2. Sayı : ");
            int secondnum=int.Parse(Console.ReadLine());
            Console.WriteLine(firstnum+" ve "+secondnum+" Sayının Toplamı : "+(firstnum+secondnum));




            //Alıştırma 3: Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program 
            Console.Write("Kısa Kenar : ");
            int n=int.Parse(Console.ReadLine());
            Console.Write("Uzun Kenar : ");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine( "Alan : "+(n*m));
            Console.WriteLine( "Çevre : "+(n+m)*2);





            //Alıştırma 4: Girilen sayının tek mi çift mi olduğunu bulan program
            Console.Write("Bir sayı giriniz : ");
            int numb=int.Parse(Console.ReadLine());
            if(numb%2==0)
                Console.Write(numb+" çifttir.");
            else
                Console.Write(numb+" tektir.");


            //Alıştırma 5: Girilen sayının 0-100 arasında olup olmadığını kontrol eden program
            Console.Write("Bir sayı giriniz : ");
            int num=int.Parse(Console.ReadLine());
            if(num>=0 && num<=100)
                Console.Write(num+" sayısı 0-100 arasındadır.");
            else
                Console.Write(num+" sayısı 0-100 arasında değildir.");


            //6: Vücut Kitle İndeksi hesaplayan program
            Console.Write("Kilonuz : ");
            double weight=double.Parse(Console.ReadLine());
            Console.Write("Boyunuz : ");
            float height=float.Parse(Console.ReadLine());
            Console.WriteLine( "Vücut kitle indeksi : "+(weight/(height*height)));


            //Alıştırma 7: Cümledeki harf sayısını bulan program
            Console.Write("Cümle giriniz : ");
            string word=Console.ReadLine();
            Console.Write(word.Trim().Replace(" ", string.Empty).Length);

        }
    }
}
