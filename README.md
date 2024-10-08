# Bootcamp Görevleri - C# Kod Örnekleri

Bu repo, patika.dev bootcamp görevleri için yazılmış olan çeşitli C# kod örneklerini içermektedir. Aşağıda, her bir örneğin işleyişi ve açıklamaları detaylı bir şekilde yer almaktadır.

## 1. Rastgele Bir Sayının 2'ye Bölümünden Kalanını Döndüren Metot

### Görev:
Rastgele bir sayı üretip, bu sayının 2'ye bölümünden kalanı geriye döndüren bir metot yazılması istenmiştir.

### Açıklama:
- `Kalansayi` metodu, verilen iki sayı aralığında (`a` ve `b`) rastgele bir sayı üretir.
- Üretilen sayının 2'ye bölümünden kalanı bulur ve bunu geri döndürür.
- `Random` sınıfı kullanılarak rastgele sayı üretilmiştir.
- `Main` metodunda bu kalan ekrana yazdırılmıştır.

---

## 2. Hatalı Bir Metot Örneği

### Görev:
Yukarıdaki kodun hatalı bir versiyonu gösterilmiştir. Bu hata, birden fazla `return` ifadesi kullanılması ve sadece ilk `return` ifadesine ulaşılması nedeniyle, fonksiyonun beklenen şekilde çalışmamasına sebep olmaktadır.

### Açıklama:
- Metot, iki farklı `return` ifadesi içeriyor ancak ikinci `return` ifadesine hiçbir zaman ulaşılmayacak.
- Bu yapı mantık hatası barındırmaktadır çünkü bir fonksiyondan tek bir `return` ifadesi çalıştırılabilir.

---

## 3. İki Sayının Çarpımını Geri Döndüren Metot

### Görev:
Parametre olarak aldığı iki sayının çarpımını geri döndüren bir metot yazılması istenmiştir.

### Açıklama:
- `CarpimSonucu` metodu iki adet tamsayı parametre alır (`a` ve `b`).
- Bu iki sayının çarpımını hesaplayıp sonucu geri döndürür.
- `Main` metodunda, bu metot çağrılır ve çarpım sonucu ekrana yazdırılır.

---

## 4. İsim ve Soyisim Alıp Mesaj Gösteren Metot

### Görev:
Parametre olarak isim ve soyisim bilgilerini alıp ekrana `"Hoş Geldiniz {isim} {soyisim}"` şeklinde mesaj yazdıran bir metot yazılması istenmiştir.

### Açıklama:
- `İsimSoyisim` metodu, `string` türünde iki parametre alır: isim ve soyisim.
- Bu bilgileri kullanarak, ekrana `"Hoş Geldiniz {isim} {soyisim}"` mesajını basar.
- Geriye bir değer döndürmez (`void` metottur).
- `Main` metodunda isim ve soyisim verilerek, karşılama mesajı gösterilir.
  
---

## Sonuç
Bu örnekler, C# dilinde metotlarla çalışma, parametre alma ve değer döndürme konularını pekiştirmeye yönelik olarak yazılmıştır. Kodlar üzerinde incelemeler yaparak daha karmaşık projeler geliştirebilirsiniz.
