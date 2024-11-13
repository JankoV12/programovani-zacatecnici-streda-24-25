namespace Helloworld
{
    internal class Program
    {
        public static string ReplaceCharAtIndex(string input, int index, char newChar)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (index < 0 || index >= input.Length) throw new ArgumentOutOfRangeException(nameof(index));

            char[] chars = input.ToCharArray();
            chars[index] = newChar;

            return new string(chars);
        }

        public static char IncrementAlphabetChar(char input)
        {
            // Increment only alphabetic characters
            if (input >= 'a' && input < 'z')
            {
                return (char)(input + 1);
            }
            else if (input == 'z')
            {
                return 'a';
            }
            else if (input >= 'A' && input < 'Z')
            {
                return (char)(input + 1);
            }
            else if (input == 'Z')
            {
                return 'A';
            }
            else
            {
                // Return non-alphabetic characters unchanged
                return input;
            }
        }

        static void Main(string[] args)
        {
            string slovo = "hello, world!";
            string psaneSlovo = "a";
            int i = 0;

            while (true)
            {
                while (psaneSlovo != slovo)
                {
                    Console.WriteLine(psaneSlovo);
                    System.Threading.Thread.Sleep(50);

                    if (i >= psaneSlovo.Length)
                    {
                        // Extend psaneSlovo with the corresponding character from slovo
                        psaneSlovo += slovo[i] == ' ' || char.IsPunctuation(slovo[i]) ? slovo[i] : 'a';
                    }
                    else if (psaneSlovo[i] == slovo[i])
                    {
                        // Move to the next character if the current characters match
                        i++;
                    }
                    else
                    {
                        // Increment alphabetic character; leave non-alphabetic as is
                        psaneSlovo = ReplaceCharAtIndex(psaneSlovo, i, IncrementAlphabetChar(psaneSlovo[i]));
                    }
                }

                Console.WriteLine("Match found: " + psaneSlovo);
                Thread.Sleep(5000);
                psaneSlovo = "a";
                i = 0;
            }
        }
    }
}