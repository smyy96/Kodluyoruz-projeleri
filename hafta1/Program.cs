using System;

namespace kodluyoruz_projeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınız : ");
            string name=Console.ReadLine();
            Console.Write("Soyadınız : ");
            string surname=Console.ReadLine();
            Console.WriteLine("Merhaba "+name+" "+surname);
        }
    }
}
