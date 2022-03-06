using System;

namespace hafta3
{
    class Program
    {
        public static void soru1(){ //Klavyeden girilen metnin kaç kelimeden oluştuğunu bulan program.
           
           Console.Write("Cümle giriniz: ");
           string[] words=Console.ReadLine().Split(' ');
           Console.WriteLine("Kelime sayısı: "+words.Length);
        }


        public static void soru2() //Verilen bir karakter dizininin substring() metodunu kullanarak string içerisinde arama yapan ve kaç defa geçtiğini bulan program.
        {
            int count=0;
             Console.Write("Cümle giriniz: ");
             string[] words=Console.ReadLine().Split(' ');
             Console.Write("Aranacak kelimeyi giriniz: ");
             string word=Console.ReadLine();
             for(int i=0;i<words.Length;i++){
                 if(words[i].Substring(0)==word){
                     count++;   
                 }
             }
             Console.Write(word+" cümle içindeki sayısı "+count+"dir.");

        }
        static void Main(string[] args)
        {
            //soru1();
            soru2();
        }
    }
}
