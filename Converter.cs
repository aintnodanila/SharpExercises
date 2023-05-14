namespace SharpExercises;
public class Converter
{
    private readonly string[] _romanNumbers = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    private readonly int[] _arabicNumbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

    public int ConvertToArabic(string romanNumeral)
    {
        int arabicNumber = 0;
        int i = 0;
        
        foreach (string roman in _romanNumbers)
        {
            while (romanNumeral.StartsWith(roman))
            {
                arabicNumber += _arabicNumbers[i];
                romanNumeral = romanNumeral.Substring(roman.Length);
            }

            i++;
        }

        return arabicNumber;
    }
}

