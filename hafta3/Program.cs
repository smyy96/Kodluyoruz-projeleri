using System;

namespace hafta3
{
    class Program
    {
        public static void soru1(){
           
           string[] words=Console.ReadLine().Split(' ');
           Console.WriteLine(words.Length);
        }
        static void Main(string[] args)
        {
            soru1();
        }
    }
}
