using System;
namespace Soru2
{
// Kullanıcının girdiği iki sayının karelerinin toplamını veren uygulamayı yazınız. 
    class Program
    {
        static void Main(String[] args)
        {
            // Math.Pow(2,3) >>> 2'nin 3. kuvveti
            Console.WriteLine("Lütfen 1. ve 2. sayilarini giriniz");
            double sonuc = Math.Pow(int.Parse(Console.ReadLine()), 2) +
                           Math.Pow(int.Parse(Console.ReadLine()), 2);
            Console.WriteLine(sonuc);
            // Pow double olduuğu için sonuc double dönecektir.
        }
    }
}