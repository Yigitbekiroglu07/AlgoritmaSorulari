using System;
namespace Soru4
{   // Doğum tarihi girilen kişinin yaşını hesaplayan uygulamayı yazınız.
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Lütfen doğum tarihinizi girin.");
            DateTime dogumtarihi  = DateTime.Parse(Console.ReadLine()); // String'i DateTime veri tipine dönüştür

            int gün = (DateTime.Now - dogumtarihi).Days; // Bugünün tarihinden doğum tarihini çıkar.  TimeSpan'in Days properties'i bu işlemi gerçekleştirir.

            int yas = gün / 365; // Kullanıcının yaşını bulma

            int kalan = gün % 365; // Kullanıcının bir sonraki yaşı için kalan gününü hesaplama

            // String Interpolation

            Console.WriteLine($"Yaş : {yas} | {yas + 1} yaşınıza kalan gün sayısı: {365 +  (yas * 1/4)  - kalan}"); // yas * 1/4 Şubat'ın 4 yılda bir 29 çekmesinden kaynaklı.
        }
    }
}
