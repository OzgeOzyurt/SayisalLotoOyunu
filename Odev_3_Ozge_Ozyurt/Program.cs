using System;

namespace Odev_3_Ozge_Ozyurt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Sayısal Loto Oyununa Hoşgeldiniz! 1 ile 49 arasından 6 adet sayi girmenizi isteyeceğiz. Eğer 3 ve üzeri sayıyı tutturursanız kazanırsınız. Bol şanslar!");

            /// 6 elemanlı, loto sayılarını tutacak bir dizi oluşturuldu.
            int[] lotoSayilari = new int[6];
            Random rand = new Random();

            //Program kullanıcıdan 6 adet sayı girmesini istiyor ve bu sayılar bir dizide tutuluyor.
            int[] kullaniciSayilari = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write(i + 1 + ". Sayıyı girin:");
                kullaniciSayilari[i] = int.Parse(Console.ReadLine());

                /// 1-49 arası rastgele sayılardan oluşturulmuş elemanlar diziye atandı.
                lotoSayilari[i] = rand.Next(1, 50);
                // Loto sayılarının olduğu dizi ve kullanıcı tahminlerinin olduğu dizi karşılaştırılarak eşleşen sayı adedi bulunuyor.
                for (int l = 0; l < 6; l++)
                {
                    if (kullaniciSayilari[i] == lotoSayilari[l])
                    {                        
                        sayac++;
                        break;
                    }
                }
            }

            // Oyuncu 3’ün altında bilmişse program “Kazanamadınız.” mesajı veriyor. Diğer durumlarda “Tebrikler X adet sayı bildiniz” mesajı veriyor. 
            if (sayac < 3)
            {
                Console.WriteLine("Kazanamadınız.");
            }
            else if (sayac >= 3)
            {
                Console.WriteLine($"Tebrikler {sayac} adet sayı bildiniz.");
            }         

            //Lotodaki rastgele sayılar ekrana yazdırılıyor.
            Console.Write("Loto Sayıları: ");
            for (int l = 0; l < 6; l++)
            {
                Console.Write(lotoSayilari[l]);
                if (l < 5)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
