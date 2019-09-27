using System.IO;
using System.Threading.Tasks;

namespace GreatestProductOf20x20
{
    partial class Program
    {
        public static class FileReader
        {
            public static async Task<int[][]> ReadGrid(string path)
            {
                if (!File.Exists(path))
                {
                    return null;
                }

                int[][] retVal = new int[20][];

                string[] textFromFile = await File.ReadAllLinesAsync(path);
                for (int i = 0; i < textFromFile.Length; i++)
                {
                    retVal[i] = StringParser.ParseToIntArray(textFromFile[i], ' ');
                }

                return retVal;
            }

            
        }
    }
}
