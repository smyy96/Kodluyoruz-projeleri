using System;

namespace _2.hafta
{
    class Program
    {
        public static void soru1(){ //1 – 1.000.000 Arasındaki Asal Sayıları Listeleme
            bool status=false;
            for(long i=2;i<=1000000;i++){
                status=false;
                for(long x=2;x<=i/2;x++){
                    if(i%x==0){
                        status=true;
                        break;
                    }
                }
                if(status==false){
                    Console.WriteLine(i);
                }
                
            }
        }



        public static void soru2(){ //1-N arası 3 e ve 7’ye Tam Bölünen Sayıları Listeleme
            Console.Write("Enter a number : ");
            int N=int.Parse(Console.ReadLine());
            for(int i=1;i<=N;i++){
                if(i%3==0 && i%7==0){
                    Console.WriteLine(i);
                }
            }
        }


        public static void soru3(){//Diziyi Alfabetik Olarak Sıralama (Kullanıcının gireceği kelimelerden oluşan diziyi alfabetik olarak sıralama)
            
            Console.Write("N : ");
            int n=int.Parse(Console.ReadLine());
            string[] arr=new string[n];

            Console.WriteLine("Enter words : ");
            for(int i=0;i<n;i++){

                arr[i]=Console.ReadLine();
            }

            Console.WriteLine("\nSequence words");
            Array.Sort(arr);
            foreach(string i in arr){
                Console.WriteLine(i);
            }

        }


        public static void soru4(){//Girilen Metindeki Sesli Harfleri Bulan Program
            string vowels="aeıioöuü";
            Console.Write("Enter a text : ");
            string n=Console.ReadLine();
            for(int i=0;i<n.Length;i++){
                for(int x=0;x<vowels.Length;x++){
                    if(vowels[x]==n[i])
                    {
                        Console.Write(n[i]+" ");
                    }
                }
                
            }
        }


         public static void soru5(){
             //Kullanıcıdan 10 adet sayı alarak bu sayıların toplamını ekranda gösteren program
            int sum=0;
            for(int i =1;i<=10;i++){
                Console.Write(i+". number: ");
                sum+=int.Parse(Console.ReadLine());
            }
            Console.Write("Sum number : "+sum);  
        
         }


         public static void soru6(){ 
            //Bilgisayarın rastgele tuttuğu 10 sayıdan çift ve tek olanların sayısını gösteren program
            Random random=new Random();
            int num=0;
            for(int i=0;i<10;i++){
                num = random.Next();
                if(num%2==0)
                    Console.WriteLine(num+" is an even number.");
                else
                    Console.WriteLine(num+" is an odd number.");

            }
         }

         public static void soru7(){ // Kullanıcının girdiği metni kullanıcının girdiği sayıda ekranda yazdıran Program
            Console.Write("Enter a text : ");
            string text=Console.ReadLine();
            Console.Write("The number of repetitions : ");
            int numRepet=int.Parse(Console.ReadLine());
            while(numRepet!=0){
                Console.WriteLine(text);
                numRepet-=1;
            }    
         }

        static void Main(string[] args)
        {
            //soru1();
            //soru2();
            //soru3();
            //soru4();
            //soru5();
            //soru6();
            soru7();
        }
    }
}
