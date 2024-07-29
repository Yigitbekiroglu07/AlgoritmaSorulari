// İki Sayının Toplamını Veren Uygulamayı Yazınız
#region Çözüm1
//int sayi1 = 10, sayi2 = 20;
// Console.WriteLine(sayi1 + sayi2);
#endregion
#region Çözüm 2
// Console.WriteLine("Lütfen bir sayi giriniz");
// Console.ReadLine(); // Yazılan sayıyı string olarak getirir.
// int sayi1 = Convert.ToInt32(Console.ReadLine()); // Girilen ifadeyi integer'a çevirir
// Console.WriteLine("Lütfen ikinci sayiyi giriniz");
// int sayi2 = int.Parse(Console.ReadLine()); // String ifadeleri diğer tiplere dönüştürürken kullanılır. Diğer tip Parse'dan önce yazılan ifadedir.
// Console.WriteLine(sayi1 + sayi2);
#endregion
#region Çözüm 3
try
{

    Console.WriteLine("Lütfen bir sayi giriniz");
    int sayi1 = Convert.ToInt32(Console.ReadLine()); // Girilen ifadeyi integer'a çevirir
    Console.WriteLine("Lütfen ikinci sayiyi giriniz");
    int sayi2 = int.Parse(Console.ReadLine()); // String ifadeleri diğer tiplere dönüştürürken kullanılır. Diğer tip Parse'dan önce yazılan ifadedir.
    
    Console.WriteLine(sayi1 + sayi2);
}
catch
{
    Console.WriteLine("Lütfen doğru bir sayi değeri giriniz");
}
#endregion