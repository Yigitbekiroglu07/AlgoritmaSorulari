namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pozitif sayılarda çarpma işlemini toplama kullanarak bulan uygulamayı yazınız.
            #region Çözüm1
            //Console.WriteLine("Lütfen sayi1 giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen sayi2 giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int carpmaSonucu = 0;
            //for (int i=1; i<=sayi1; i++)
            //{
            //    carpmaSonucu += sayi2;
            //}
            //Console.WriteLine(carpmaSonucu);
            #endregion
            #region Çözüm2
            //Console.WriteLine("Lütfen sayi1 giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen sayi2 giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int sayac = sayi2; // sayac yerine say2 yazılsa konsolda yazılırken say2  gerçek değerini kaybedecektik.
            //int sonuc = 0;
            //while (sayac > 0)
            //{
            //    sonuc += sayi1;
            //    sayac--;
            //}
            //Console.WriteLine($"{sayi1} x {sayi2} = {sonuc}");


            #endregion
            #region Çözüm3
            //Console.WriteLine("Lütfen sayi1 giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen sayi2 giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int sonuc = 0;
            //int sayac = sayi2;
            //do
            //{
            //    sonuc += sayi1;
            //    sayac--;
            //}

            //while (sayac > 0);

            //Console.WriteLine($"{sayi1} x {sayi2} = {sonuc}");


            #endregion
            #region Çözüm4
            Console.WriteLine("Lütfen sayi1 giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen sayi2 giriniz");
            int sayi2 = int.Parse(Console.ReadLine()); // sabit değer

            Console.WriteLine(Topla(sayi1, sayi2)); 

            #endregion
        }

        static int Topla(int sayi1, int sayi2)
        {
            if(sayi2 > 1)
            {
                return sayi1 + Topla(sayi1, --sayi2);
                
            }
            return sayi1;
        }
    }
}
