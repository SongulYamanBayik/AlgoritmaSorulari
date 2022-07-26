using System;

namespace KarelerinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("ilk sayıyı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ikinci sayıyı giriniz");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int toplam = (sayi1 * sayi1) + (sayi2 * sayi2);
                Console.WriteLine("iki sayının karelerinin toplamı: " + toplam);
            }
            catch 
            {

                Console.WriteLine("Numerik bir değer girmediniz!");
            }
            

            Console.ReadKey();
        }
    }
}
