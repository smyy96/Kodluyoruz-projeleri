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



        public static void soru3()//Girilen sayı çift ise yarısını , tek ise 2 katını alarak ekrana yazdıran program.(Örneğin klavyeden 14 sayısı girilirse ekrana 7,11 sayısı girilirse ekrana 22 yazılması gerekir.)
        {
            Console.Write("Enter a number: ");
            int num=int.Parse(Console.ReadLine());
            if(num%2==0){
                Console.Write(num/2);
            }
            else{
                Console.Write(num*2);
            }

        }






        public static void soru4()//Klavyeden girilen bir sayının faktöriyelini alan program.
        {
            int fak=1;
            Console.Write("Enter a number: ");
            int num=int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++){
                fak*=i;
            }
            Console.Write(fak);
            
        }




        static void Main(string[] args)
        {
            //soru1();
            //soru2();
            //soru3();
            soru4();
        }
    }
}
