# Proje Açıklaması

Bu projede dört farklı C# programı yer almaktadır. Her biri farklı metot yapılarının kullanımını göstermektedir.

## 1. Şarkı Sözü Yazdırma

- Burada, bir `void` metot kullanılarak ekrana bir şarkı sözü yazdırılıyor.
- Bu işlem için sadece `Console.WriteLine("Seni kendime sakladım!")` ile ekrana yazı yazdırdık. Geriye herhangi bir değer döndürülmüyor.

## 2. Rastgele Sayı Üretme ve Kalanını Bulma

- Bu kısımda, `Random` sınıfı kullanılarak iki sayı aralığında rastgele bir sayı üretiliyor. Üretilen sayının 2'ye bölümünden kalan bulunarak ekrana yazdırılıyor.
- Bunu yapmak için, `Random rastgele = new Random()` ile rastgele sayı ürettik ve `sayi % 2` işlemiyle kalanı bulduk.

## 3. İki Sayının Çarpımını Bulma

- Bu bölümde, parametre olarak iki sayı alıp, bu sayıların çarpımını geriye döndüren bir metot tanımlandı.
- Bunu yapmak için `return a * b;` ifadesini kullanarak çarpım sonucunu döndürdük ve bu değeri ekrana yazdırdık.

## 4. Hoş Geldiniz Mesajı Yazdırma

- Burada, bir metot parametre olarak isim ve soyisim alıyor. Sonrasında ekrana "Hoş Geldiniz {isim} {soyisim}" şeklinde bir mesaj yazdırılıyor.
- Bu işlem için `Console.WriteLine($"Hoş Geldiniz {isim} {soyisim} ");` ifadesiyle isim ve soyisim bilgileri kullanılarak kişiselleştirilmiş bir mesaj oluşturduk.

## Kullandığım Araçlar ve Teknolojiler
Programlama Dili: C#
IDE: Visual Studio
