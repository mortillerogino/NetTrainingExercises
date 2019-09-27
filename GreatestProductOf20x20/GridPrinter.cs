using System;
using System.Text;

namespace GreatestProductOf20x20
{
    public static class GridPrinter
    {
        public static void PrintWithResult(int[][] grid, int numberOfFactors, ProductResult productResult)
        {
            var sb = new StringBuilder();
            int x = productResult.Horizontal - 1;
            int y = productResult.Vertical - 1;
            int countOfMarkedItems = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (x == j && y == i && countOfMarkedItems < numberOfFactors)
                    {
                        sb.Append(string.Format("{0, -5}", "!" + grid[i][j]));
                        switch (productResult.Direction)
                        {
                            case Directions.Horizontal:
                                x++;
                                break;
                            case Directions.Vertical:
                                y++;
                                break;
                            case Directions.ForwardDiagonal:
                                x--;
                                y++;
                                break;
                            case Directions.BackwardDiagonal:
                                x++;
                                y++;
                                break;
                            default:
                                break;
                        }
                        countOfMarkedItems++;
                    }
                    else
                    {
                        sb.Append(string.Format("{0, -5}", grid[i][j]));
                    }
                    
                }

                

                sb.Append("\n");
            }

            Console.WriteLine(sb.ToString());
            Console.WriteLine($"With greatest product of {string.Format("{0:n0}", productResult.Product)}");
            Console.ReadLine();
        }

    }
}
