using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253007HW1                              //14253007 Anil Avci Odev1
{
    class Program
    {       

        static void Main(string[] args)
        {
            restart:
            try //hata kontrolü yapar.
            {
                char islem, cevap;
                double sonuc = 0, sayi1, sayi2;  //girilecek sayilarin virgüllü olup olmadığını bilmedigim icin double olarak aldim.

                Islem Islem = new Islem();
                Kullanici Kullanici = new Kullanici();

                sayi1 = Kullanici.SayiAl(1); //kullanıcıdan sayıları alma methodu. parametre kaçıncı sayıyı aldığını yazar.
                islem = Kullanici.IslemTipi();
                sayi2 = Kullanici.SayiAl(2);
                sonuc = Islem.Sonuc(sayi1,sayi2,islem);   //method kullanarak matematiksel islemleri yaptım.

                Console.Write("\n\n{0}{1}{2}= {3}   Sonuc={3}\n\n", sayi1, islem, sayi2, sonuc);

                cevap = Kullanici.Devam();

                if (cevap == 'e'|| cevap=='E')     
                {
                    goto restart;
                }
                else if(cevap== 'h' || cevap=='H')     
                {                                       
                    Console.WriteLine("\nProgramdan cikmak icin ENTER tusuna basiniz...");
                    Console.ReadKey();
                }
                else                  
                {
                    Kullanici.Hata();
                    goto restart;
                }
            }
           
            catch   //eğer hatalı giriş yapılırsa buradaki kodlar çalışmaya başlar.
            {
                Kullanici Kullanici = new Kullanici();
                Kullanici.Hata();
                goto restart;
            }
            
        }
    }
}
