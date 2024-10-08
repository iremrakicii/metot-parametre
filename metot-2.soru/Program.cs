class Program2
{
    // Geriye Tamsayı Döndüren Bir metot
    // Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
    static void Main()
    {

        int kalan = KalanSayi(10, 50);
        Console.WriteLine("Kalan:" + kalan);

    }

    static int KalanSayi(int a, int b)
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(a, b);
        return sayi % 2;
    }
}
