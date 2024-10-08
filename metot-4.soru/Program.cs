class Program
{
    //Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
    //Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın
    static void Main()
    {
        İsimSoyisim("irem", "rakıcı");
        Console.WriteLine("");
    }

    static void İsimSoyisim(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim} ");

    }
}
