// Kullanıcının girdiği iki sayının karelerinin toplamını veren uygulamayı yazınız
#region Çözüm1
//Console.WriteLine("Lütfen sayi1 giriniz");
// int sayi1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Lütfen sayi2 giriniz");
// int sayi2 = Convert.ToInt32(Console.ReadLine());

// int sonuc = sayi1*sayi1 + sayi2*sayi2;
// Console.WriteLine(sonuc);

#endregion
#region Çözüm2
// Console.WriteLine("Lütfen sayi1 degerini giriniz");
// int sayi1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Lütfen sayi2 giriniz");
// int sayi2 = Convert.ToInt32(Console.ReadLine());
// Math.Pow(2,3) >> 2'nin 3. Kuvveti
// double sonuc = Math.Pow(sayi1, 2 ) + Math.Pow(sayi2, 2);
// Console.WriteLine(sonuc);
#endregion
#region Çözüm3
Console.WriteLine("Lütfen sayi1 ve sayi2 degerini giriniz");
double sonuc = Math.Pow(int.Parse(Console.ReadLine()),2) + Math.Pow(int.Parse(Console.ReadLine()),2);
Console.WriteLine(sonuc);

#endregion