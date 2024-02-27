namespace Ödev7;

public class Get_Area_And_Height
{
    public static int selected_area()
    {
        Console.WriteLine("Alanı giriniz");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int selected_height()
    {
        Console.WriteLine("Yüksekliği giriniz");
        return Convert.ToInt32(Console.ReadLine());
    }
}