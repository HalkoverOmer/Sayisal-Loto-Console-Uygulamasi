using System;

namespace SayısalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rastgele, sayac = 0, secim = 0, donus, temp;
            Random rand = new Random();
            int[] cekilis = new int[6];

            while (true)
            {
                Console.Clear();
                Console.Write("                     ----> Sayısal Loto Çekiliş Programı <---- \n\n" +
                                  "   1 -> 8 bölüm otomatik oynat : \n" +
                                  "   2 -> İstenilen adette bölüm otomatik oynat : \n" +
                                  "   3 -> Çıkış :\n\n" +
                                  "   (-) Seçiminizi giriniz : ");

                if (secim == 0)
                {
                    secim = int.Parse(Console.ReadLine());
                }

                if (secim == 3)
                {
                    Environment.Exit(0);
                }

                if (secim == 1)
                {
                    Console.Clear();
                    Console.Write("                     ----> Sayısal Loto Çekiliş Programı  <---- \n");


                    while (sayac < 8)
                    {
                        for (int i = 0; i < 6;)
                        {
                            rastgele = rand.Next(1, 49);
                            if (Array.IndexOf(cekilis, rastgele) == -1)
                            {
                                cekilis[i] = rastgele;
                                i++;
                            }
                        }

                        int kontrol = 0;

                        Console.Write($"\n-> {sayac + 1}.Kolon : ");
                        Array.Sort(cekilis);
                        foreach (int index in cekilis)
                        {
                            if (kontrol < 5)
                            {
                                Console.Write(index + "-");
                                kontrol++;
                            }

                            else
                            {
                                Console.Write(index);
                            }
                        }

                        sayac++;
                    }

                    Console.Write("\n\n-- Tekrar oynamak için 1, Menüye dönmek için 0 girin : ");
                    donus = int.Parse(Console.ReadLine());

                    if (donus == 1)
                    {
                        secim = 1;
                        sayac = 0;
                    }

                    else
                    {
                        secim = 0;
                    }

                }

                if (secim == 2)
                {
                    Console.Clear();
                    Console.Write("                     ----> Sayısal Loto Çekiliş Programı <---- \n\n" +
                                  "                     Kaç adeti kolon oynatmak istiyorsunuz : ");
                    temp = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.Write("                     ----> Sayısal Loto Çekiliş Programı <---- \n\n");

                    //////////////////////////////////////////////////////////////////////////////////

                    while (sayac < temp)
                    {
                        for (int i = 0; i < 6;)
                        {
                            rastgele = rand.Next(1, 49);
                            if (Array.IndexOf(cekilis, rastgele) == -1)
                            {
                                cekilis[i] = rastgele;
                                i++;
                            }
                        }

                        int kontrol = 0;

                        Console.Write($"\n-> {sayac + 1}.Kolon : ");
                        Array.Sort(cekilis);
                        foreach (int index in cekilis)
                        {
                            if (kontrol < 5)
                            {
                                Console.Write(index + "-");
                                kontrol++;
                            }

                            else
                            {
                                Console.Write(index);
                            }
                        }

                        sayac++;
                    }

                    Console.Write("\n\n-- Tekrar oynamak için 1, Menüye dönmek için 0 girin : ");
                    donus = int.Parse(Console.ReadLine());

                    if (donus == 1)
                    {
                        secim = 2;
                        sayac = 0;
                    }

                    else
                    {
                        secim = 0;
                    }

                    //////////////////////////////////////////////////////////////////////////////////

                }
            }

        }
    }
}
