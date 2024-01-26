using System;
namespace Soru1;
// İki sayının toplamını veren uygulamayı yazınız.
class Program
{
    static void Main(String[] args)
    {
        try // Sayı yerine harf veya sözcük girilirse kullanıcıya doğru değer girilmesi yönünde uyarı vermesi için kullanıldı
        {
           Console.WriteLine("Lütfen sayi 1 değerini giriniz.");
           int sayi1 = Convert.ToInt32(Console.ReadLine()); //String'i integer'a çevirir.
           Console.WriteLine("Lütfen sayi 2 değerini giriniz.");
           int sayi2 = int.Parse(Console.ReadLine());  // İlgili değeri integer'a çevirir.
           Console.WriteLine("Toplam: " + (sayi1 + sayi2));
           // Console.ReadLine komutu, kullanıcığının yazmış olduğu değeri string olarak 
           // ekrana getirir. Programı bekleten bir komuttur.
        }
        catch 
        {
            Console.WriteLine("Lütfen doğru bir değer giriniz.");
        }   
        
    }
}