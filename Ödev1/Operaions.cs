using System;

namespace Ödev1
{
    public class Operaions
    {
        public static int Opreation()
        {
            int number_1 = Get_Number.Get_Number_1();
            int number_2 = Get_Number.Get_Number_2();
            int number_3 = Get_Number.Get_Number_3();
            int number_4 = Get_Number.Get_Number_4();

            int sum = (number_1 + number_2 + number_3 + number_4) / 4;
            Console.WriteLine("Sonuç:"+sum);
            return sum;
            
        }
            
    }
}