using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    internal class ValueTypes
    {
        static void Main(string[] args)
        {
            //Value Types-Veri Tipleri
            
            int number1 = 2147483647;//Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.647 arasında değer alır.
            Console.WriteLine("Number1 is {0}",number1);
            long number2 = 9223372036854775807;//Uzunluğu 8 byte’tır, -10 üzeri 20 ile 10 üzeri 20 arasında değer alır.
            Console.WriteLine("Number2 is {0}", number2);
            short number3 = 32767;//Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.
            Console.WriteLine("Number3 is {0}", number3);
            byte number4 = 255;//;Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.
            Console.WriteLine("Number4 is {0}", number4);
            double number5 = 10.4;//Uzunluğu 8 byte’tır, 5.0 x 10-324 ile 1.7 x 10308 arasında değer alır.
            Console.WriteLine("Number5 is {0}", number5);
            decimal number6 = 10;//Uzunluğu 12 byte’tır, ±1.0 x 10-28 ile ±7.9 x 1028 arasında değer alır.
            Console.WriteLine("Number6 is {0}", number6); 
            bool condition = false;//True – false değer tutan tiptir.
            Console.WriteLine("Condittion is {0}",condition);
            char character = 'A';//Uzunluğu 2 byte’tır, Bütün ınicode karakterleri kapsar.
            Console.WriteLine("Character is {0}",(int)character);
            string name = "Gizem";//Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır.
            Console.WriteLine("Name is {0}",name);
            
            Console.ReadKey();
        }
    }
}
