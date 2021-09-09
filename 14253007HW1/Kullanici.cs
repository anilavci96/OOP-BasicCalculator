using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253007HW1
{
    class Kullanici
    {
        public double SayiAl(int i)
        {
            Console.Write("{0}.Sayiyi giriniz: ",i);
            string InputSayi = Console.ReadLine();
            double sayi = Convert.ToDouble(InputSayi);

            return sayi;
        }

        public char IslemTipi()
        {
            Console.Write("\nIslem tipini seciniz(+ - * /): ");
            string InputIslemTipi = Console.ReadLine();
            char islemTipi = Convert.ToChar(InputIslemTipi);

            return islemTipi;
        }

        public void Hata()
        {
            Console.WriteLine("HATALI GIRIS YAPTINIZ...");
            Console.WriteLine("Programi yeniden baslatmak icin ENTER tusuna basiniz...");
            Console.ReadKey();
            Console.Write("\n\n");
            
        }

        public char Devam()
        {
            Console.WriteLine("Devam etmek istiyor musunuz?(e/h):");
            string Inputcevap = Console.ReadLine();    
            char cevap = Convert.ToChar(Inputcevap);

            return cevap;
        }

        
    }
}
