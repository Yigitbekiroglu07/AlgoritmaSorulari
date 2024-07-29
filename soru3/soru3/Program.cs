namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
            // 1'den 10'a kadar ( 1 ve 10 dahil ) sayıların toplamı kaçtır?
        {
            #region Çözüm1
            //double toplamsonuc = 0;
            // for(int i = 0; i < 11; i++) 
            // {
            //    toplamsonuc += Math.Pow(i, 3);

            // }
            // Console.WriteLine(toplamsonuc);
            #endregion
            #region Çözüm2
            // int sayac = 0;
            // double toplamsonuc = 0;
            // while(sayac < 11) 
            // {
            //    toplamsonuc += Math.Pow(sayac,3);
            //    sayac++;

            //  }

            // Console.WriteLine(toplamsonuc);


            #endregion
            #region Çözüm 3
            // int sayac = 1;
            // double toplmasonuc = 0;
            // do 
            // {
            //    toplmasonuc += Math.Pow(sayac, 3);
            //    sayac++;
            // } 
            // while (sayac < 11);
            // Console.WriteLine(toplmasonuc);


            #endregion
            #region Çözüm 4
            int sayac = 1;
            double toplamsonuc = 0;
            string sonuc = "";
            while (sayac<=10) 
            {

                toplamsonuc += Math.Pow(sayac, 3);
                if(sayac!=10)
                    sonuc += $"{sayac}³ + ";
                else
                    sonuc += $"{sayac}³ + {toplamsonuc}";

                sayac++;
            }
            Console.Write(sonuc);

            #endregion
        }
    }
}
