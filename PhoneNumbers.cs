namespace SharpExercises;

public class PhoneNumbers
{
    public string CheckNumber(string number)
    {
        string output = "";
        number = number.Trim();

        foreach (char c in number)
        {
            if (Char.IsDigit(c))
            {
                output += c;
            }
        }

        if (output[0] == '0')
        {
            if (output.Length == 11)
            {
                return $"The phone number is: {output}";
            }
        }
        return "This is not a phone number.";

    }
}