namespace SharpExercises;

public class Program
{ 
    public static void Main() 
    { 
        // Internet trolls 
        InternetTrolls i = new InternetTrolls();
        Console.WriteLine(i.RemoveVowels("This website is for loosers!"));

        // Roman numbers conventer  
        Converter c = new Converter();

        // Phone numbers checking
        PhoneNumbers p = new PhoneNumbers();
        Console.WriteLine(p.CheckNumber("efRFS:)0207ERGQREG88349F82"));
        Console.WriteLine(p.CheckNumber("1111111EDEDEDEBGBGB232323TRTR"));

    }
}


