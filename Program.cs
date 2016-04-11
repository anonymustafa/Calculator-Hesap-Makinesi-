using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustafa14253055HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem islem = new DortIslem();
            float num1, num2;
            char girilenKarakter;
            birincidekiHata:
            basaDon:
            Console.WriteLine("Birinci Sayiyi Giriniz:");
            
            if(float.TryParse(Console.ReadLine(), out num1))
            {
            islemdekiHata:
                Console.WriteLine("Yapmak Istediginiz Islemi Giriniz {+,-,*,/}");
                if (char.TryParse(Console.ReadLine(), out girilenKarakter) && islem.karakterKontrol(girilenKarakter)==true)
                {
                    
                ikincidekiHata:
                    Console.WriteLine("Ikinci Sayiyi Giriniz:");

                    if (float.TryParse(Console.ReadLine(), out num2))
                    
                        islem.fgelenKarakter(girilenKarakter, num1, num2);
                        
                    else
                    {
                        
                        Console.WriteLine("2.Sayiyi Hatali Girdiniz Tekrar Giriniz");
                        goto ikincidekiHata;

                    }
                }
                else
                {
                    Console.WriteLine("Islemi Hatali Girdiniz Tekrar Giriniz");
                    goto islemdekiHata;
                }
                
                }
            else
            {
                Console.Clear();
                Console.WriteLine("1.Sayiyi Hatali Girdiniz Tekrar Giriniz");
                goto birincidekiHata;

            }
            hataliEH:
           Console.WriteLine("Devam Etmek Icin (e) Bitirmek Icin (h) basiniz");
           char sonChar= Convert.ToChar(Console.ReadLine());

            if (sonChar=='e')
            {
                Console.Clear();
                goto basaDon;
            }
           
            else if (sonChar=='h'){
                Console.WriteLine("Islemi Bitirdiniz");
                Console.ReadKey();
            }

            else { 
                Console.WriteLine("Yanlış Karakter Girdiniz Tekrar Giris Yapiniz");
            goto hataliEH;
            }

        }
    }
}    
            
            
            
            





 
