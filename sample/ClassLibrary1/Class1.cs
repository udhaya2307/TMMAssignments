namespace DebuggingSample;

class StringOp
{
    static void Main(string[] args)
    {

        string[] texts = { "WELCOME", "to introduction", "to Visual studio", "& Debugging" };
        foreach (string txt in texts)
        {
            Console.WriteLine($"Input string : {txt}");
            var reverse = Reverse(txt);
            Console.WriteLine($"Reversed string : {reverse}");
            var vowelCnt = GetVowelCnt(txt);
            Console.WriteLine($"Number of vowels in string : {vowelCnt}");
            var isPalindrome = IsPalindrome(txt);
            Console.WriteLine($"Is palindrome: {isPalindrome}");
            Console.WriteLine();
            int a = 1, b = 2, c = 30;
            for (int i = 0; i < 10; i++) { a++; b *= 2; c--; }
        }
    }

    static string Reverse(string s) => new string(s.Reverse().ToArray());

    static int GetVowelCnt(string s)
    {
        int cnt = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        foreach (char ch in s.ToLower()) if (vowels.Contains(ch)) cnt++;
        return cnt;
    }

    static bool IsPalindrome(string s) => s == Reverse(s);
}