namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Doğum tarihi girilen kişinin yaşını hesaplayan uygulamayı yazınız.
            #region Çözüm1
            // Console.WriteLine("Lütfen doğum tarihinizi yazınız");
            // DateTime doğumtarihi = Convert.ToDateTime(Console.ReadLine());
            //  sonuc = DateTime.Now - doğumtarihi;
            // Console.WriteLine(sonuc.Days / 365);

            #endregion
            #region Çözüm 2
            // Console.WriteLine("Lütfen doğum tarihinizi yazınız");
            // DateTime dogumtarihi = DateTime.Parse(Console.ReadLine());
            // DateTime bugun = DateTime.Now;

            // int yas = bugun.Year - dogumtarihi.Year;

            // if(dogumtarihi > bugun.AddYears(-yas))
            // {
            //    yas--;
            // }

            // Console.WriteLine(yas);



            #endregion
            #region Çözüm3
            Console.WriteLine("Lütfen doğum tarihinizi giriniz");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());  
            int gun = (DateTime.Now -  dogumTarihi).Days; // Days property'si int döner.

            int yas = gun / 365; // yaşı verir.
            int kalan = gun % 365; // bir sonraki yaşına kaç gün kaldığını verir.

            Console.WriteLine($"Yaş: {yas} | {yas +1} kalan gün sayısı : {365 + (yas * 1 /4) - kalan}"); // Şubat ayı 4 yılda bir 29 çektiğinden yaş 1/4 ile çarpılır.

            #endregion
        }
    }
}
