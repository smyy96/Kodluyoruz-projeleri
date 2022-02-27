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

        }




        static void Main(string[] args)
        {
            //soru1();
            //soru2();
            //soru3();
            
        }
    }
}
