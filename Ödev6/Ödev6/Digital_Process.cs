namespace Ödev6;

public class Digital_Process
{
    public static int Convert_Kelvin_and_Fahrenhayt()
    {

        int number = Selected_Number.Get_Number_1();
        
        int kelvin_process = number + 273;

        Console.WriteLine("Kelvin Hesaplandı:"+kelvin_process);

        int Fahrenhayt_process = (number * 18) / 10 + 32;

        Console.WriteLine("Fahrenhayt Hesaplandı:"+Fahrenhayt_process);

        return kelvin_process;
    }
    
}