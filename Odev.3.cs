using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Soru1-Foreach  döngüsü ile liste elemanları yazdırma
            ArrayList arrayList = new ArrayList(){0,1,2,3,4,5,6,7,8,9};
            int toplam = 0;
            foreach(int i in arrayList)
            {
                toplam = toplam + i;
                Console.WriteLine(i.ToString() + " ");
                
            }
            Console.WriteLine("Sayıların Toplamı =" + toplam.ToString());
            */

            // Soru2-Hazır yöntem kullanımı

            /*
            Console.WriteLine("Lütfen Bir Cümle Giriniz");
            String ifade = Console.ReadLine();
            String[] splitEt = ifade.Split(' ');
            Console.Write(splitEt.Length + " Tane Kelime Girdiniz");
            */

            // Soru3-Array list ile alfabetik sıralama
            /*
            ArrayList isimler1 = new ArrayList();

            Console.WriteLine("Lütfen 5 adet İsim Giriniz");
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            String c = Console.ReadLine();
            String d = Console.ReadLine();
            String e = Console.ReadLine();

            isimler1.Add(a);
            isimler1.Add(b);
            isimler1.Add(c);
            isimler1.Add(d);
            isimler1.Add(e);

            isimler1.Sort(); //Alfabetik Sıralama

            foreach (var i in isimler1)
            {
                Console.WriteLine(i);
            }
            */

            //Soru 4-For dögüsü ile fibonacci dizisi

            /*
            Console.Write("Fibonacci serisinin kaç terimini görmek istersiniz? ");
            int n = int.Parse(Console.ReadLine());

            
            int a = 0, b = 1;

            Console.WriteLine("Fibonacci Serisi:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);

                
                int sonraki_terimm = a + b;
                a = b;
                b = sonraki_terimm;
            }
            */

            //Soru 5 -While döngüsü ile tahmin oyunu

            /*
            Random rnd = new Random();

            int sayi = rnd.Next(0,10);
            


            Console.WriteLine("Sayı nedir?");
            while (true)
            {
                String girilen_sayi = Console.ReadLine();

                if (sayi.ToString() == girilen_sayi.ToString())
                {
                    Console.WriteLine("Doğru Tahmin!");
                    break;
                }

            }
            */

            //Soru 6-Do while ile basit hesap makinesi
            /*
            bool devam_mi = true;
            try
            {
                do
                {
                    Console.WriteLine("Hesap Makinesi Uygulamasın");
                    Console.WriteLine("Uygulamadan çıkmak için exit yazin");

                    string ifade = Console.ReadLine();

                    if(ifade == "exit")
                    {
                        devam_mi= false;
                    }
                    
                    Console.WriteLine("Lütfen İlk Sayıyı Girin");
                    int deger1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen İkinci Değeri Giriniz");
                    int deger2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen Bir Operatör Seçiniz(/,*,+,-)");
                    String operator = Console.ReadLine();

                    switch(operator)
                    {
                        case "+":
                            Console.WriteLine(deger1 + deger2);
                            break;
                        case "-":
                            Console.WriteLine(deger1-deger2);
                            break;
                        case "*":
                            Console.WriteLine(deger1*deger2);
                            break;
                        case "/":
                            Console.WriteLine(deger1/deger2);
                            break;
                        default:
                            Console.WriteLine("Yanlış Bir Tuş Girdiniz");
                            break;
                    }



                } while(devam_mi == false);
                Console.WriteLine("Uygulamadan Çıkıldı!");

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("HATA!\n");
                Console.WriteLine("Payda da Sıfır olamaz!");
            }
            */

            //Soru 7-For ve while döngüsü ile sayı toplama oyunu

            /*
            List<int> numbers = new List<int>();

            int num = -1; 

           
            while (num != 0)
            {
                Console.Write("Pozitif bir tam sayı girin (0 girerseniz işlem sonlanır): ");
                num = int.Parse(Console.ReadLine()); 

               
                if (num > 0)
                {
                    numbers.Add(num);
                }
                else if (num < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı girin!");
                }
            }

          
            int total = 0;
            foreach (int number in numbers)
            {
                toplam+= number;
            }

           
            Console.WriteLine("\nGirilen sayılar:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        
            Console.WriteLine("\nGirilen sayıların toplamı: " + toplam);
            */







            Console.ReadKey();

        }
    }
}