using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_tane_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //Örnek 1:Çarpım Tablosu
            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine("{0}x{1}={2}", i, j, i * j);
            //    }
            //    Console.WriteLine("-----------");
            //}  Console.ReadKey();

            //Örnek 2:1'den 100'e kadar olan sayıların toplamının ortalaması
            //sonucun reel çıkma olasılığından dolayı double türünü kullandık.
            //double toplam = 0;
            //for (int i = 1; i <=100; i++)
            //{
            //    toplam = toplam + i;
            //}
            //toplam = toplam / 100;
            //Console.WriteLine(toplam);
            //Console.ReadKey();

            //Örnek 3: Kullanıcının istediği metni, istediği kadar yazdırma.
            //Console.WriteLine("Metni Girin: ");
            //string metin = Console.ReadLine();
            //Console.WriteLine("Kaç defa yazdırılsın?: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    Console.WriteLine(metin);
            //    Console.WriteLine("---------");
            //}
            //Console.ReadKey();

            //Örnek 4: Kullanıcın girdiği 5 tane sayılardan hangileri 10'dan büyükse onların toplamı
            //int sayi, toplam = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i + ".Sayıyı Girin : ");
            //    sayi = Int32.Parse(Console.ReadLine());
            //    if (sayi > 10)
            //    {
            //        toplam = toplam + sayi;
            //    }
            //}
            //Console.WriteLine("10 den büyük girilen sayıların toplamı : " + toplam);
            //Console.ReadKey();

            //Örnek 5: Taban ve Kuvveti girilen sayının değerini hesaplama
            //Örn: taban:2 üs:5 girildiğinde sonuc=32 yazıdıran program.
            //int taban, us, sonuc = 1;
            //Console.WriteLine("Taban sayısını giriniz:");
            //taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kuvvet sayısını giriniz:");
            //us = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= us; i++)
            //{
            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine("Tabanı {0} ve kuvveti {1} olan sayının değeri={2}", taban, us, sonuc);
            //Console.ReadKey();

            //Örnek 6: Yazıyı tersten yazma
            //Length: Yazılan karakterleri geriye döner. Yani tersten yazar.
            //Substring: Bir string değeri içindeki harf ya da harfler grubunu seçmek için kullanılır.
            //Console.WriteLine("Herhangi Bir Yazı Giriniz  : ");
            //string yazi = Console.ReadLine();
            //int yaziuzunlugu = yazi.Length;
            //for (int i = yaziuzunlugu; i > 0; i--)
            //{
            //    Console.WriteLine(yazi.Substring(i - 1,1)); //,1 yazmamızın sebebi yazıyı tersten yazarken sırasıyla gruplayıp yazıyor. 
            //    //Örneğin;Rümeysa ismini yazdırmak isterken ,1'i koymazsak a-as-asy... şeklinde yazar. 
            //    //,1 ifadesi tek seferde yazmak için koyulur. 
            //}
            //Console.ReadKey();

            //Örnek 7: 1-100 arasındaki sayıların kullanıcının girdiği sayıya tam olarak bölünenleri ekrana yazdırma
            //Örneğin; kullanıcı 3 girdi 3,6,9,......93,96,99 tam olarak bölünür.
            //Console.WriteLine("Bölen sayıyı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % sayi == 0)
            //    {
            //        Console.WriteLine("{0} sayısı {1} ile kalansız bölünür", i,sayi);
            //    }
            //}
            //Console.ReadKey();

            //Örnek 8: Diküçgen yazdırma
            //string yildiz = "*";
            //Console.Write("Yükseklik giriniz:");
            //int yukseklik = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < yukseklik; i++)
            //{
            //    Console.WriteLine(yildiz);
            //    yildiz = yildiz+"*";
            //}
            //Console.ReadKey();

            //Örnek 9: alfabeyi sıralama
            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //Örnek 10:
            //int sayi, adet = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i + ".Sayıyı Girin : ");
            //    sayi = Int32.Parse(Console.ReadLine());
            //    if (sayi < 50)
            //    {
            //        adet++;
            //    }
            //}
            //Console.WriteLine("50 den küçük girilen sayı adeti : " + adet);
            //Console.ReadKey();
        }
    }
}
