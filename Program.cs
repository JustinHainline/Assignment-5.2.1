namespace Assignment_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence.");
            string inputSentence = Console.ReadLine();
            int lengthOfLastWord = LengthOfLastWord(inputSentence);
            Console.WriteLine($"The last word is {lengthOfLastWord} characters long.");
        }
        static int LengthOfLastWord( string s)
        {
            s = s.Trim();
            string[] words = s.Split();
            string lastWord = words.Length > 0 ? words[words.Length - 1] : "";
            return lastWord.Length;
        }

    }
}
