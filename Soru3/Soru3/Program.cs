using System;
namespace Soru3
{  
    // 1'den 10'a kadar olan sayıların küplerin toplamını bulan uygulamayı yazınız.
    class Program
    {
        
        static void Main(String[] args)
        {
            double toplamSonucu = 0;
            // Süslü parantez içinde yazılmama sebebi, yazılırsa
            // her seferinde toplamSonucu 0 olarak kabul edecek ve toplamayacak.
            for (int i = 1; i < 10; i++)
            {
                
                toplamSonucu += Math.Pow(i, 3);
                    
            }
            Console.WriteLine(toplamSonucu);
        }
        
    }
}
