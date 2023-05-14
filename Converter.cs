namespace SharpExercises;
public class Converter
{
    private string[] Romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    private int[] Arabics = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

    public int ConvertToArabic(string romanNumeral)
    {
        int arabicNumber = 0;
        int index = 0;

        foreach (string roman in Romans)
        {
            while (romanNumeral.StartsWith(roman))
            {
                arabicNumber += Arabics[index];
                romanNumeral = romanNumeral.Substring(roman.Length);
            }

            index++;
        }

        return arabicNumber;
    }
}

