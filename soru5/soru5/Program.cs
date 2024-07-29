using System;

namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayının faktöriyelini hesaplayan uygulamyı yazınız

            #region Çözüm1
            // Console.WriteLine("Lütfen bir sayi giriniz");
            // int sayi = int.Parse(Console.ReadLine());
            // int sonuc = 1; // Çarpımda 0 yaparsa sonuç 0 çıkacağından bire eşitledik.
            // for (int i = sayi; i > 0; i--) 
            // { 
            //   sonuc = sonuc * i;  
            // }

            // Console.WriteLine(sonuc);

            #endregion
            #region Çözüm 2
            // Console.WriteLine("Lütfen bir sayi giriniz");
            // int sayi = int.Parse(Console.ReadLine());
            // int sonuc = 1;

            //  while(sayi > 0) 
            //  {
            //      sonuc *= sayi;
            //     sayi--; 
            //  }

            //  Console.WriteLine(sonuc);


            #endregion
            #region Çözüm 3
            // // Console.Writeline("lütfen bir sayi giriniz");
            // // int sayi = int.parse(console.readline());
            // // int sonuc = 1;
            // // do 
            ////  {
            // //     if (sayi == 0)
            //          break;
            //      sonuc *= sayi;  
            //      sayi--; 
            //  } 
            //  while (true);
            //  console.writeline(sonuc);

            #endregion
            #region Çözüm 4 
            Console.WriteLine("lütfen bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktoriyel(sayi));
            #endregion
        }

        static int Faktoriyel(int sayi)
        {
            if(sayi>1)
            
                return sayi * Faktoriyel(--sayi);
                return sayi;

            
        }
    }
}
