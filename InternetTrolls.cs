using System.Linq;

namespace SharpExercises;
public class InternetTrolls
{
    public string RemoveVowels(string str)
    {
        string vowels = "AEIOUaeiou";
        string output = new string(str.Where(c => !vowels.Contains(c)).ToArray());
        return output;
    }
}