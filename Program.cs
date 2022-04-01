using System;

namespace trycatchfinally_mantiksalhatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                Console.WriteLine("bir sayi giriniz");
                int sayi= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girilen sayi: "+ sayi );

            }
            catch(Exception ex)
            {
                Console.WriteLine("hata: " +ex.Message.ToString());
            }
            finally
            /*{
                Console.WriteLine("islem tamamlandi.");
            }*/

            try
            {
                //int a = int.Parse(null);
                //int a=int.Parse("test");
                int a=int.Parse("-70000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz.");
                Console.WriteLine(ex);
            }          
            catch(FormatException ex)
            {
                Console.WriteLine("veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("cok kucuk yada cok buyuk deger girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("islem basariyla tamamlandi");
            }
        }
    }
}
