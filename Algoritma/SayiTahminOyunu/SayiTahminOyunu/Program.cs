using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Random randomsayi = new Random();
            int rs = randomsayi.Next(1, 100);
            int sayac = 0;

            Console.WriteLine("1 ile 100 arasında bir sayı tahmin ediniz.");
            while (rs != sayi)
            {

                

                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                    sayac++;

                    if (sayi > 100 || sayi < 1)
                    {
                        Console.WriteLine("Lütfen 1 ile 100 arasında değer giriniz! ");
                    }
                    else
                    {
                        if (sayi==rs)
                        {
                            Console.WriteLine($"Tebrikler sayı={rs}, {sayac}. adımda bildiniz.");
                            Console.WriteLine("Tekrar oynamak ister misiniz? E/H ");
                            string devam = Console.ReadLine();
                            if (devam=="e"|| devam=="E")
                            {
                                sayi = 0;
                                rs = randomsayi.Next(1, 100);
                                sayac = 0;
                                Console.WriteLine("1 ile 100 arasında bir sayı tahmin ediniz.");
                            }
                            

                        }
                        else if (sayi<rs)
                        {
                            Console.WriteLine("yukarı");
                        }
                        else
                        {
                            Console.WriteLine("aşağı");
                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Lutfen Numarik Deger Giriniz!");
                }


                

            }

           
        }
    }
}
