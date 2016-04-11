using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustafa14253055HW1
{
    class DortIslem
    {
        public bool karakterKontrol(char girilenchar)
        {
            if (girilenchar == '+' || girilenchar == '-' || girilenchar == '*' || girilenchar == '/')
                return true;

            return false;
        }
        
        public void fgelenKarakter(char gelenKarakter,float sayi1,float sayi2){
        switch(gelenKarakter)
    {
            case '+':
            {
                Console.WriteLine("Sonuc: {0}", sayi1 + sayi2);
                break;
            }
            case '-':
            {
                Console.WriteLine("Sonuc: {0}", sayi1 - sayi2);
                break;
            }
            case '*':
            {
                Console.WriteLine("Sonuc: {0}", sayi1 * sayi2);
                break;
            }
            case '/':
            {
                Console.WriteLine("Sonuc: {0}", sayi1 / sayi2);
                break;
            }
            default:
            {

                Console.WriteLine("Hatali Giris Yaptiniz Tekrar Deneyiniz");
                break;
            }

    }
        }


    }
}

