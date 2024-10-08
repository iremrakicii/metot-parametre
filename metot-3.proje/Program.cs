class Program
{
    static void Main()
    {
        //Parametre Alan ve Geriye Değer Döndüren Bir Metot
        // Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
        int carpim = CarpimSonucu(5, 6);
        Console.WriteLine("Çarpım:" + carpim);
    }
    static int CarpimSonucu(int a, int b)
    {
        return a * b;
    }
}
