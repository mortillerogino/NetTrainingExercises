using System.Linq;
using System.Threading.Tasks;

namespace GreatestProductOf20x20
{
    public class GreatestProduct
    {
        private readonly int[][] _grid;
        private readonly int _numberOfFactors;

        public GreatestProduct(int[][] grid, int numberOfFactors)
        {
            _grid = grid;
            _numberOfFactors = numberOfFactors;
        }

        public async Task<ProductResult> CheckHorizontal()
        {
            ProductResult retVal = await Task.Run(() =>
            {
                int greatestHorizontalProduct = int.MinValue;
                int x = int.MinValue;
                int y = int.MinValue;

                for (int i = 0; i < _grid.Length; i++)
                {
                    for (int j = 0; j < _grid[i].Length - _numberOfFactors + 1; j++)
                    {
                        int product = 1;
                        for (int k = 0; k < _numberOfFactors; k++)
                        {
                            product *= _grid[i][j + k];
                        }

                        if (product > greatestHorizontalProduct)
                        {
                            greatestHorizontalProduct = product;
                            x = j + 1;
                            y = i + 1;
                        }
                    }
                }

                var result = new ProductResult
                {
                    Product = greatestHorizontalProduct,
                    Horizontal = x,
                    Vertical = y,
                    Direction = Directions.Horizontal
                };

                return result;
            }).ConfigureAwait(false);

            
            return retVal;
            
        }

        public async Task<ProductResult> CheckVertical()
        {
            ProductResult retVal = await Task.Run(() => 
            {
                int greatestVerticalProduct = int.MinValue;
                int x = int.MinValue;
                int y = int.MinValue;

                for (int i = 0; i < _grid.Length - _numberOfFactors + 1; i++)
                {
                    for (int j = 0; j < _grid[i].Length; j++)
                    {
                        int product = 1;
                        for (int k = 0; k < _numberOfFactors; k++)
                        {
                            product *= _grid[i + k][j];
                        }

                        if (product > greatestVerticalProduct)
                        {
                            greatestVerticalProduct = product;
                            x = j + 1;
                            y = i + 1;
                        }
                    }
                }

                var result = new ProductResult
                {
                    Product = greatestVerticalProduct,
                    Horizontal = x,
                    Vertical = y,
                    Direction = Directions.Vertical
                };

                return result;
            }).ConfigureAwait(false);

            return retVal;
        }

        // The diagonal shape is ( / )
        public async Task<ProductResult> CheckForwardDiagonal()
        {
            ProductResult retVal = await Task.Run(() =>
            {
                int greatestForwardDiagonalProduct = int.MinValue;
                int x = int.MinValue;
                int y = int.MinValue;

                for (int i = 0; i < _grid.Length - _numberOfFactors + 1; i++)
                {
                    for (int j = _numberOfFactors - 1; j < _grid[i].Length; j++)
                    {
                        int product = 1;
                        for (int k = 0; k < _numberOfFactors; k++)
                        {
                            product *= _grid[i + k][j - k];
                        }

                        if (product > greatestForwardDiagonalProduct)
                        {
                            greatestForwardDiagonalProduct = product;
                            x = j + 1;
                            y = i + 1;
                        }
                    }
                }

                var result = new ProductResult
                {
                    Product = greatestForwardDiagonalProduct,
                    Horizontal = x,
                    Vertical = y,
                    Direction = Directions.ForwardDiagonal
                };

                return result;
            }).ConfigureAwait(false);

            return retVal;
        }

        // The diagonal shape is ( \ )
        public async Task<ProductResult> CheckBackDiagonal()
        {
            ProductResult retVal = await Task.Run(() =>
            {
                int greatestBackDiagonalProduct = int.MinValue;
                int x = int.MinValue;
                int y = int.MinValue;

                for (int i = 0; i < _grid.Length - _numberOfFactors + 1; i++)
                {
                    for (int j = 0; j < _grid[i].Length - _numberOfFactors + 1; j++)
                    {
                        int product = 1;
                        for (int k = 0; k < _numberOfFactors; k++)
                        {
                            product *= _grid[i + k][j + k];
                        }
                        if (product > greatestBackDiagonalProduct)
                        {
                            greatestBackDiagonalProduct = product;
                            x = j + 1;
                            y = i + 1;
                        }
                    }
                }

                var result = new ProductResult
                {
                    Product = greatestBackDiagonalProduct,
                    Horizontal = x,
                    Vertical = y,
                    Direction = Directions.BackwardDiagonal
                };

                return result;
            }).ConfigureAwait(false);

            return retVal;
        }

        public async Task<ProductResult> Calculate()
        {
            Task<ProductResult>[] tasks = new Task<ProductResult>[4];

            tasks[0] = CheckHorizontal();
            tasks[1] = CheckVertical();
            tasks[2] = CheckBackDiagonal();
            tasks[3] = CheckForwardDiagonal();

            ProductResult[] results = await Task.WhenAll(tasks);
            var greatestProduct = results.OrderByDescending(a => a.Product).First();

            return greatestProduct;
        }
    }
}
