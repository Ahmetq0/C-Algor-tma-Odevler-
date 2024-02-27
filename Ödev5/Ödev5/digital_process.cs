using System.Runtime.InteropServices.JavaScript;

namespace Ödev5;

public class digital_process
{
   public static int calculator_proce()
   {
      int number1 = Number_selected.Get_Number_1();
      int number2 = Number_selected.Get_Number_2();

      int calculator_add = number1 + number2;

      Console.WriteLine("Toplama işlemi sonucu:"+calculator_add);

      return calculator_add;

   }

   public static int extraction_proce()
   {
      int number1 = Number_selected.Get_Number_1();
      int number2 = Number_selected.Get_Number_2();

      int extraction_add = number1 - number2;

      Console.WriteLine("Çıkarma işlemi sonucu:"+extraction_add);

      return extraction_add;
   }

   public static int impacth_proce()
   {
      int number1 = Number_selected.Get_Number_1();
      int number2 = Number_selected.Get_Number_2();

      int impacht_add = number1 * number2;

      Console.WriteLine("Çarpma işlemi sonucu:"+impacht_add);

      return impacht_add;
   }

   public static int divide_proce()
   {
      int number1 = Number_selected.Get_Number_1();
      int number2 = Number_selected.Get_Number_2();

      int divide_add = number1 / number2;

      Console.WriteLine("Bölme işlemi sonucu:"+divide_add);

      return divide_add;
   }

   
}