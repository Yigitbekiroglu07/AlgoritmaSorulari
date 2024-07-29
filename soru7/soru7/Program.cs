namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pozitif sayılarda bölme işlemini çıkarma kullanarak yapan uygulamayı yazınız
            #region Çözüm1
            //Console.WriteLine("Lütfen bölmek istediğiniz sayiyi giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen böleceğiniz sayiyi giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine()); //sabit

            //int sonuc = 0;
            //int kalan = 0;
            //int donguAdeti = sayi1;

            //for(int i = 0; i < donguAdeti; i++) // en az sayi1 kadar dönmesi fazlasıyla yeter. Örneğin 7/2 yaparsak 3 kere döner elimizde 7 tane var fazlasıyla yeterli.
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;

            //    if (sayi1 < sayi2)
            //    {
            //        kalan = sayi1;
            //        break;
            //    }

            //}
            //Console.WriteLine($"{donguAdeti} / {sayi2} = {sonuc} | kalan = {kalan}");
            #endregion
            #region Çözüm2
            //Console.WriteLine("Lütfen bölmek istediğiniz sayiyi giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen böleceğiniz sayiyi giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine()); //sabit

            //int sayac = sayi1;
            //int _sayi1 = sayi1; // sayi1'in ilk değerini tutmak için
            //int sonuc = 0;
            //int kalan = 0;
            //while (sayac > 0)
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;
            //    sayac--;
            //    if (sayi1 < sayi2) // 7'nin 10'a bölümünden kalan 7'dir.
            //    {
            //        kalan = sayi1;
            //        break;
            //    }


            //}
            //Console.WriteLine($"{_sayi1}/{sayi2} = {sonuc} | kalan = {kalan}");


            #endregion
            #region Çözüm3
            //Console.WriteLine("Lütfen bölmek istediğiniz sayiyi giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen böleceğiniz sayiyi giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine()); //sabit
            //int _sayi1 = sayi1;
            //int sonuc = 0;
            //int kalan = 0;
            //do
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;
            //    if (sayi1 < sayi2)
            //    {
            //        kalan = sayi1;
            //        break;
            //    }


            //} while (true); 

            //Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc} | kalan = {kalan}");



            #endregion
            #region Çözüm4
            Console.WriteLine("Lütfen bölmek istediğiniz sayiyi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen böleceğiniz sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine()); //sabit

            int bolmeSonucu = Bol(sayi1,sayi2);
            Console.WriteLine($"{sayi1} / {sayi2} = {bolmeSonucu}");
            int kalan = Kalan(sayi1,sayi2);
            Console.WriteLine($"Kalan = {kalan}");
            #endregion
        }
       static int Bol(int sayi1, int sayi2) // static yapılma sebebi main içinde kullanabilmek. Static fonk, static fonk içinde kullanılabilir ( Main fonksiyonu da static)
        {
            sayi1 -= sayi2;
            if(sayi1>=sayi2)
                return 1 + Bol(sayi1, sayi2);
            return 1;
        }

      static int Kalan(int sayi1, int sayi2)
        {
            sayi1 -= sayi2;
            if (sayi1 >= sayi2)
            {
                return Kalan(sayi1, sayi2);
            }
              
            return sayi1;
        }  
    }
}
