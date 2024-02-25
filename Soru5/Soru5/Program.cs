using System;
namespace Soru5;

class Program
{
    static void Main(String[] args)
    {
        // Girilen sayının faktöriyelini hesaplayan uygulamayı yazınız.
        Console.WriteLine("Lütfen bir sayi giriniz");
        int sayi = int.Parse(Console.ReadLine());
        int sonuc = 1;
        for (int i = sayi; i > 0; i--)
        {
            sonuc *= i;
        }

        Console.WriteLine(sonuc);
    }
}
