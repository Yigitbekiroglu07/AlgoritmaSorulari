// Sıralama Algoritması - Bubble Sort (Baloncuk Sıralaması)
int[] numbers = { 5, 2, 7, 9, 1, 0, 6, 3, 4 };

BubbleSort(numbers);

Console.WriteLine(string.Join(", ", numbers));

Console.ReadLine(); 

// Space Complexity: O(1) >> Bellekte ekstra yer harcanmadı.
// Time Complexity : O(n*n) >> Her bir eleman için tüm listeyi dönüyoruz

void BubbleSort<T>(T[] array) // Dışardan istenilen değişken gönderilsin diye generic yapıldı.
{
    for(int i = 0; i < array.Length; i++) // Elimizdeki sayı
    {
        for(int j = 0; j < array.Length -i -1; j++) // Karşılaştıracağımız sayı, -i yazılma sebebi son elemanla karşılaştırmamk için
        {
            if(Comparer<T>.Default.Compare(array[j], array[j+1])>0) // Kıyaslama yapmak için
            {
                var temp = array[j]; 
                array[j] = array[j+1];
                array[j+1] = temp;  
            }
        } 
    }

}
