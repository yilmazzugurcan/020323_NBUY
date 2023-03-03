using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace _020323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Roma Çarpımı
            /*    Console.WriteLine("2 tane sayı gir : ");

                int tek = 0;

                int sayi1 = Convert.ToInt32(Console.ReadLine());
                int sayi2 = Convert.ToInt32(Console.ReadLine());


                if (sayi2 % 2 != 0)
                {
                    tek += sayi1;
                }
                do
                {
                    sayi1 = sayi1 * 2;
                    sayi2 = sayi2 / 2;

                    if (sayi2 % 2 != 0)
                    {
                        tek += sayi1;
                    }



                } while (sayi2 >= 1);

                Console.WriteLine(tek); */
            #endregion;

            #region Roma Çarpımı Farklı Çözüm
            /*  int toplam = 0;
              Console.WriteLine("Birinci sayıyı giriniz=");
              int sayi1 = int.Parse(Console.ReadLine());
              Console.WriteLine("İkinci sayıyı giriniz=");
              int sayi2 = int.Parse(Console.ReadLine());
              do
              {
                  if (sayi1 % 2 == 1)
                  {
                      toplam = toplam + sayi2;
                  }
                  sayi1 = sayi1 / 2;
                  Console.WriteLine("ikiye bölüm " + sayi1);
                  sayi2 = sayi2 * 2;
                  Console.WriteLine("ikiyle çarpım " + sayi2);
              } while (sayi1 >= 1);
              Console.WriteLine("Sonuç = " + toplam);
              Console.ReadKey(); */
            #endregion

            #region girilen sayıdan aşağıdaki mükkemmel sayıları gösterme
            /*  Console.Write("Sayı: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int top;
      for (int i = 2; i < n; i++)
      {
          top = 0;
          for (int j = 1; j < i; j++)
          {
              if (i % j == 0)
                  top += j;
          }
          if (top == i)
              Console.WriteLine(i);
      }*/
            #endregion

            #region Belirli Sayının Altındaki Mükkemmel Sayıları Bulma
            /* int toplam = 0;
               Console.WriteLine("Bir sayı giriniz");
               int aralik = Convert.ToInt32(Console.ReadLine());
               for (int i = aralik; i > 0; i--)
               {
                   toplam = 0;
                   for (int j = i - 1; j > 0; j--)
                   {
                       if (i % j == 0)
                       {
                           toplam += j;
                       }
                   }
                   if (toplam == i)
                   {
                       Console.WriteLine(i + " mükemmel sayı");
                   }
               }*/

            #endregion

            #region ilce yazdırma dizi
            /*  string[] ilce = { "Beyoglu", "Kadıköy", "Maltepe", "Başakşehir", "Fatih", "Göztepe" };

       for (int i = 0; i < 6; i++)
       {
           Console.WriteLine(ilce[i]);
       }
     */
            #endregion

            #region Kullanıcıdan Alınan 5 Adet Çiçek Dizisini Ekrana Yazdırma
            /* string[] kelime = new string[5];

             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine("Çiçek Adı  Gir : ");
                 kelime[i] = (Console.ReadLine());

             }

             for (int i = 0; i < 5; i++)
             {
                 Console.Write(kelime[i] + " ");
             } */
            #endregion

            #region Diziye Rastgele 5 Sayı Atama
            /*int[] sayilar = new int[5];
    Random random = new Random();
    for (int i = 0; i < 5; i++)

    {
        sayilar[i] = random.Next();
        Console.WriteLine("Random Sayı"+" " + sayilar[i]);
    }

    for (int i = 0; i < 5; i++)
    {
        Console.Write("\n"+sayilar[i] + "\n ");
    }*/

            #endregion

            #region Random Üretilen Dizinin Ortalamasını Alma
            /*   Random rand = new Random();
               int top = 0, ort;
               int[] sade = new int[rand.Next(1, 20)];

               for (int i = 0; i < sade.Length; i++)
               {
                   sade[i] = rand.Next(1, 100);
                   top += i;
                   Console.WriteLine(i);
               }
               ort = top / sade.Length;
               Console.WriteLine("Ortalama =" + (ort)); */
            #endregion

            #region Diziye 200 adet RANDOM Atılan DEGERLERDEN CIFT SAYILARIN TOPLAMI VE TEK SAYILARIN TOPLAMININ FARKI
            /* Random rand = new Random();
             int cift = 0, tek = 0;
             int[] sade = new int[200];

             for (int i = 0; i < 200; i++)
             {
                 sade[i] = rand.Next(1, 100);

                 if (sade[i] % 2 == 0)
                 {
                     cift += sade[i];
                 }
                 else
                 {
                     tek += sade[i];
                 }

             }
             Console.WriteLine("Ciftlerin Toplamı:" + " " + cift);
             Console.WriteLine("Teklerin Toplamı:" + " " + tek);

             Console.WriteLine("FARK=" + " " + (cift - tek)); */
            #endregion

            #region Kullanıcıdan Alınan Kelimenin Son 3 Karakterini Ekrana Yazdırma
            /* 
             string kelime;

             Console.WriteLine("Kelime Girin : ");
             kelime = Console.ReadLine();

             for (int i = kelime.Length - 3; i < kelime.Length; i++)
             {
                 Console.WriteLine(i + ". Karakter " + kelime[i]);
             }*/
            #endregion

            #region Kullanıcının Girdiği Kelimeden Sesli Harfleri Bulma
            /* string kelime;
     int ses = 0;

     Console.WriteLine("Kelime Girin : ");
     kelime = Console.ReadLine();
     kelime = kelime.ToLower();

     for (int i = 0; i < kelime.Length; i++)
     {
         if (kelime[i] == 'a')
         {
             ses++;
         }
         else if (kelime[i] == 'e')
         {
             ses++;
         }
         else if (kelime[i] == 'ı')
         {
             ses++;
         }
         else if (kelime[i] == 'i')
         {
             ses++;
         }
         else if (kelime[i] == 'o')
         {
             ses++;
         }
         else if (kelime[i] == 'ö')
         {
             ses++;
         }
         else if (kelime[i] == 'u')
         {
             ses++;
         }
         else if (kelime[i] == 'ü')
         {
             ses++;
         }

     }

     Console.WriteLine("su kadar sesli harf var " + " " + ses);*/
            #endregion

                #region Dizi Elemanları Aritmetik Ortalama Hesaplama ve Elemanları Ortalamayla Karşılaştırma
          	Random rnd = new Random();
            int[] dizi = new int[20];
            double sum = 0;

            
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 100);
                Console.Write(dizi[i] + " ");
                sum += dizi[i];
            }
            double ort = sum / 20;

            int adetb = 0, adetk = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > ort)
                    adetb++;
                else
                    adetk++;
            }
            Console.WriteLine("Ortalama = " + ort);
            Console.WriteLine("Ortalamadan büyük sayı adeti = " + adetb+ "\nOrtalamadan küçük sayı adeti = " + adetk);
#endregion
        }
    }
}
