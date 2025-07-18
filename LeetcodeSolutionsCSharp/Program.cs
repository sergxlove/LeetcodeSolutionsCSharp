using Solutions;

namespace LeetcodeSolutionsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution0054 s = new Solution0054();
            int[][] matrix = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]];
            s.SpiralOrder(matrix);
        }
    }
}
