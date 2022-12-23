# VALUE TYPES (VERİ TİPLERİ)
Veri tipleri, değişkenleri bellekte geçici süreliğine tutabileceğimiz yapılardır. Veri tipleri sayısal veya metinsel olabilir. Bu yüzden değişkenlerimizde doğru veri tiplerini kullanmamız çok önemlidir. Birden fazla veri tipleri vardır ve bunları iki türe ayırabiliriz. Bu veri tipleri Primitive(Değer) ve Referans olmak üzere ikiye ayrılır.

## Primitive (Değer) Veri Tipleri
Değer veri tipleri genellikle sayısal değişkenler için kullanılır ve kendi içerisinde de tam sayı ve ondalıklı sayı olmak üzere ikiye ayrılır. Bunlar;

### Tam Sayı Veri Tipleri

-Byte: Bellek üzerinde 1 byte yer kaplar. 0’dan başlayarak 255 değerine kadar olan tam sayı aralığında değerler alabilir.

-Sbyte: Byte gibi bellek üzerinde kapladığı yer aynıdır. -128 ile 127 arasında bulunan tam sayı değerlerini alabilir.

-Short: 2 Byte boyutundadır. -32768 ile 32767 arasında bulunan tam sayı değerlerini alır.

-Ushort: Sbyte gibi pozitif değerleri alır. 0 ile 65535 arasında bulunan tam sayıları alır.

-Integer (int): Herkesin sıklıkla kullandığı veri tipidir. Bellek üzerinde 4 Byte yer kaplar. -2³¹ ile 2³¹ -1 arasında bulunan tam sayıları alır.

-Uint: Integer veri tipinin pozitif değerler alan halidir. 0 ile 2×2³¹-1 arasındaki değerleri alır.

-Long: Bellek üzerinde 8 Byte yer kaplar. Integer veri tipinden daha uzun tam sayı değerlerini bünyesinde tutabilir. -2⁶³ ile 2⁶³-1 arasındaki değerler tanımlanabilir.

-Ulong: 0 ile 2×2⁶³ arasındaki tam sayıları tutan veri tipidir.


### Ondalıklı Sayı Veri Tipleri

-Float: Bellekte 4 Byte yer kaplar. Ondalık sayı türünde eleman tutan veri tipidir. -3.4*10³⁸ ile 3.4*10³⁸ arasında bulunan değerleri alır.

-Double: Bellek üzerinde 8 Byte yer kaplar. Ondalık sayı türünde elemanlar alan veri tipidir. -1.7*10³⁰⁸ ile 1.7*10³⁰⁸ arasındaki değerleri alır.

-Decmial: Ondalıklı elemanları tutan veri tipidir. Virgülden sonra 28 basamağa kadar destekleyen 128 bit uzunluğuna sahip kesirli bir sayımız var ise kullanacağımız 
veri tipidir.


### Diğer Veri Tipleri

-Char: Tek karakter türünde değerler alır. Tanımlamaları oluştururken yalnızca bir rakam, işaret veya harf kullanabiliriz. Yapılan tanımlamalar diğer veri tiplerinin aksine tek tırnak arasında yapılmalıdır.

-Boolean: Diğer veri tiplerinin aksine sadece 2 adet değer alır. Bu değerler true veya false’dir. Bellek üzerinde bir bit yer kaplar. Mantıksal veri tipleri olarak da bilinir.

***ÖNEMLİ** Değer veri tipleri bellekte stack bölgesinde tutulurken, referans veri tipleri belleğin heap bölgesinde tutulur. Stack bölgesinde compiler bellekte tutulan değişkenlerin veri türünü bilmesi gerekir. Çünkü bellekte buna göre yer ayrılır ve anlaşılacağı üzere primitive veri tiplerinin belli bir sınırı vardır (bu sayede seçilen veri tipine göre yer ayırabilir.) Heap bölgesinde ise derleyicinin bunu bilmesine gerek yoktur.*

Kullandığım Kaynaklar <br/>
[BTK Akademi](https://www.btkakademi.gov.tr/portal/course/player/deliver/c-7008) <br/>
[C# Veri Tipleri](https://emrecelen.com.tr/c-sharp-veri-tipleri-ve-degisken-tanimlama/)
