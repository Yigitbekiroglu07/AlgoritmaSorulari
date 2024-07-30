using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen pozitif sayının kaç basamaklı oldığunu söyleyen uygulamayı yazınız
            #region Çözüm1
            //Console.WriteLine("lütfen sayiyi giriniz");
            //float sayi = float.Parse(Console.ReadLine());
            //int sayac = 0;
            //for(; sayi>=10;) // For döngüsü böyle kullanılabilir.
            //{
            //    sayi/=10;
            //    sayac++;
            //}
            //if (sayi < 10)
            //{
            //    sayac = 1;

            //}

            //Console.WriteLine(sayac);

            #endregion
            #region Çözüm2
            //Console.WriteLine("lütfen sayiyi giriniz");
            //float sayi = float.Parse(Console.ReadLine());
            //int sayac = 0;
            //float _sayi = sayi;
            //for(; ; ) // Sonsuz döngü
            //{
            //    sayi /= 10;
            //    sayac++;
            //    if (sayi < 10)
            //        break;
            //}
            //sayac++;
            //Console.WriteLine($"{_sayi} {sayac} basamaklıdır.");
            #endregion
            #region Çözüm3
            //Console.WriteLine("lütfen sayiyi giriniz");
            //float sayi = float.Parse(Console.ReadLine());
            //int sayac = 1;
            //float _sayi = sayi;
            //while (true) 
            //{
            //    sayi /= 10;
            //    sayac++;
            //    if (sayi < 10)
            //        break;

            //}
            //Console.WriteLine($"{sayi} {sayac} basamaklıdır.");


            #endregion
            #region Çözüm4
            //Console.WriteLine("lütfen sayiyi giriniz");
            //float sayi = float.Parse(Console.ReadLine());
            //int sayac = 1;
            //float _sayi = sayi;
            //while (sayi >= 10 ) // true yazılmayacaksa if bloğu kaldırılmalı
            //{
            //    sayi /= 10;
            //    sayac++;
            //}
            //Console.WriteLine($"{sayi} {sayac} basamaklıdır.");

            #endregion
            #region Çözüm5
            //Console.WriteLine("lütfen sayiyi giriniz");
            //float sayi = float.Parse(Console.ReadLine());
            //int sayac = 0;
            //float _sayi = sayi;
            //do 
            //{
            //    sayi /= 10;
            //    sayac++;
            //} 
            //while (sayi >= 10);    



            //Console.WriteLine($"{sayi} {++sayac} basamaklıdır."); // ++sayac, arttır daha sonra yazdır demek. sayac++ yazdır, daha sonra arttır demek.

            #endregion
            #region Çözüm6
            Console.WriteLine("lütfen sayiyi giriniz");
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = BasamakSayisi(sayi);    

            Console.WriteLine($"{sayi} {sonuc} basamaklıdır");   

            #endregion
        }
        
        static int BasamakSayisi(int sayi)
        {
            sayi /= 10;
            if(sayi>=10)
            return 1 + BasamakSayisi(sayi);

            return 2;
            
        }
        
    }
}
