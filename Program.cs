using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    internal class Program
    {
        public static bool again = true;
        static void Main(string[] args)
        {
            for (int i = 0; i <10; i++) { 
                if (again == true)
                {
                    HesapMakinesi();
                }
            }
            Console.ReadLine();
        }

        public static void HesapMakinesi()
        {
            Console.WriteLine("Litfen birinci sayıyı giriniz:");

            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi yazınız.");
            Console.WriteLine(" + - * /");
            string islem = Console.ReadLine();

            Console.WriteLine("Lütfen ikinci sayıyı giriniz.");

            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (islem == "+")
            {
                Console.WriteLine("Sonuc: " + (sayi1 + sayi2));
            }
            if (islem == "-")
            {
                Console.WriteLine("Sonuc: " + (sayi1 - sayi2));
            }
            if (islem == "*")
            {
                Console.WriteLine("Sonuc: " + (sayi1 * sayi2));
            }
            if (islem == "/")
            {
                Console.WriteLine("Sonuc: " + (sayi1 / sayi2));
            }
            if (islem != "+" && islem != "-" && islem != "*" && islem != "/")
            {
                Console.WriteLine("Yapmak istediğniiz işlem geçerli değil.");
            }

            Console.WriteLine("Tekardan İşlem yapmak istiyorsanız 0 giriniz.");
            string yeniden = Console.ReadLine();
            if(yeniden != "0")
            {
                again = false;
            }
            
            
        }
    }
}
