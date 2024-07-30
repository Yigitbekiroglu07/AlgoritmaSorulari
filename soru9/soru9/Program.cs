namespace soru9
{
     class Program
    {
        static void Main(string[] args)
        {
            // Girilen 3 basamaklı sayının basamaklarının küpleri toplamı sayının kendisine eşit olup olmadığını bulan uygulama?
            #region Çözüm1
            Console.WriteLine("Lütfen 3 basamaklı bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(Basamak(sayi));
            if(Basamak(sayi)) 
            {
                int _sayi = sayi;
                double kupToplam = 0;
                while(true)
                {
                   int basamak = _sayi % 10;
                    _sayi /= 10;

                    kupToplam += Math.Pow(basamak, 3);
                    // kuptoplam = basamak * basamak * basamak

                    if (_sayi < 10)
                    {
                        basamak = _sayi % 10;
                        kupToplam += Math.Pow(basamak, 3);
                        break;
                    }
                        
                }
                if (kupToplam == sayi)
                {
                    Console.WriteLine("eşittir.");
                }  
                else
                {
                    Console.WriteLine("eşit değildir");
                }
            }
            else
            {
                Console.WriteLine("Sadece 3 basamakllı bir sayi giriniz");
            }
            #endregion
        }
        static bool Basamak(int sayi)
        {
            // while(sayi>=10)
            int basamakSayisi = 1;
            while (true)
            {
                basamakSayisi++;
                sayi /= 10;

                if (sayi < 10)
                    break;
            }
            // if (basamakSayisi == 3)
            // return true;
            // return false;

            return basamakSayisi == 3 ? true : false;
        }


    }

 
}
