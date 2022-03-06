using System;
using System.Linq;

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

        public static void soru5()//1’den başlayıp 200’e kadar klavyeden girilen sayıya bölünen kaç adet sayı olduğunu veren program. (Örneğin klavyeden 6 girişi yapıldığında 1 ile 200 arasında 6’ya bölünen kaç adet sayı olduğunu ekrana yazdırması gerekir.)
        {
            int count=0;
            Console.Write("Enter a number: ");
            int num=int.Parse(Console.ReadLine());
            for(int i=num;i<=200;i++){
                if(i%num==0){
                    count++;
                    Console.Write(" "+i);
                }
            }
            Console.Write("\n Bölünen sayısı: "+count);

        }




        public static void soru6()//Verilen bir kişi adını bir dizide arayan ve bulunup bulunamadığını belirten program. (Diziyi siz girebilirsiniz ya da kullanıcıdan alabilirsiniz.)
        {
           string[] names=new string[]{"sümeyye","büşra","kader","ömer","faruk"};    
           Console.Write("Aranacak isim: ");
           string name=Console.ReadLine().ToLower();
           if(names.Contains(name)) {
               Console.WriteLine("Bulundu");
           }
           else{
               Console.WriteLine("Bulunmadı");
           }
        }



        static void Main(string[] args)
        {
            //soru1();
            //soru2();
            //soru3();
            //soru4();
            //soru5();
            soru6();
        }
    }
}
