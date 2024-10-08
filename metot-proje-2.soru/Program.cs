class Program2
{
    // Geriye Tamsayı Döndüren Bir metot
    // Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
    static void Main()
    {


        int kalan = Kalansayi(10, 50);
        Console.WriteLine("Kalan:" + kalan);


    }

    static int Kalansayi(int a, int b)
    {
        return a % 2;
        return b % 2;
    }
}
