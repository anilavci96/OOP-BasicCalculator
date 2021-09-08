using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253007HW1
{
    class Islem
    {
            public double Toplama(double num1, double num2)
        {
            double toplam;

            toplam = num1 + num2;

            return toplam;
        }

            public double Cikarma(double num1, double num2)
        {
            double fark;

            fark = num1 - num2;

            return fark;
        }

            public double Carpma(double num1, double num2)
        {
            double carpim;

            carpim = num1 * num2;

            return carpim;
        }

            public double Bolme(double num1, double num2)
        {
            double bolum;

            bolum = num1 / num2;

            return bolum;
        }

            public double Sonuc(double num1, double num2, char islem) //Switch-case yapısı burada...
        {
            double sonuc=0;

            Islem Islem = new Islem();

            switch (islem)         
            {
                case '+':
                    sonuc = Islem.Toplama(num1, num2);
                    break;
                case '-':
                    sonuc = Islem.Cikarma(num1, num2);
                    break;
                case '*':
                    sonuc = Islem.Carpma(num1, num2);
                    break;
                case '/':
                    sonuc = Islem.Bolme(num1, num2);
                    break;
                default:
                    Console.WriteLine("\nIslem tipi girisinde HATA var");
                    break;
            }

            return sonuc;
        }
    }
}
