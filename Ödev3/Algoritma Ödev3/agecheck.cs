namespace Algoritma_Ödev3;

public class agecheck
{
    public static int age_selected_check()
    {
        int age_selected = process.seelected_year();
        Console.WriteLine(age_selected+"Yaşından daha yaşlı  görünüyorsunuz");
        return age_selected;
    }
        
}