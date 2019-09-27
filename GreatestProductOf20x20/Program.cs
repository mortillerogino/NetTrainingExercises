using System.Threading.Tasks;

namespace GreatestProductOf20x20
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Go().Wait();
        }

        public static async Task Go()
        {
            var grid = await FileReader.ReadGrid("grid20x20.txt");
            var greatestProduct = new GreatestProduct(grid, 4);

            // if you want to check individually
            //var greatestHorizontal = await greatestProduct.CheckHorizontal(); // ( - )
            //var greatestVertical = await greatestProduct.CheckVertical(); // ( | )
            //var greatestForwardDiagonal = await greatestProduct.CheckForwardDiagonal(); // ( / )
            //var greatestBackDiagonal = await greatestProduct.CheckBackDiagonal(); // ( \ )

            GridPrinter.PrintWithResult(grid, 4, await greatestProduct.Calculate());


        }

        
    }
}
