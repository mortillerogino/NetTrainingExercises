namespace GreatestProductOf20x20
{
    partial class Program
    {
        public static class StringParser
        {
            public static int[] ParseToIntArray(string text, char separator)
            {
                string[] separatedText = text.Split(separator);
                int[] retVal = new int[separatedText.Length];

                for (int i = 0; i < separatedText.Length; i++)
                {
                    int n = int.MinValue;
                    if (int.TryParse(separatedText[i], out n))
                    {
                        retVal[i] = n;
                    }
                }

                return retVal;
            }
        }
    }
}
