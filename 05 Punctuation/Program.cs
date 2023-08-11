namespace _05_Punctuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentance = Console.ReadLine().ToLower();
            
            char[] chars = sentance.ToCharArray();

            int vowel = 0;
            int cons = 0;
            int dig = 0;
            int other = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                
                    if (char.IsLetter(chars[i]) &&(chars[i]=='a'| chars[i]=='e'| chars[i]=='i'| chars[i]=='o'| chars[i]=='u') )
                    {
                        vowel++;
                    }
                else if (char.IsLetter(chars[i]) && (chars[i] != 'a' | chars[i] != 'e' | chars[i] != 'i' | chars[i] != 'o' | chars[i] != 'u'))
                {
                    cons++;
                }
                else if (char.IsDigit(chars[i]))
                {
                    dig++;
                }
                else if ((int)chars[i]!=32)
                {
                    other++;
                }



            }
            Console.WriteLine(vowel);
            Console.WriteLine(cons);
            Console.WriteLine(dig);
            Console.WriteLine(other);

        }
    }
}