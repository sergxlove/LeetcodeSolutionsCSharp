namespace Solutions
{
    public class Solution0812
    {
        public double LargestTriangleArea(int[][] points)
        {
            double maxArea = 0;
            int n = points.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        double area = CalculateTriangleArea(
                            points[i][0], points[i][1],
                            points[j][0], points[j][1],
                            points[k][0], points[k][1]
                        );

                        if (area > maxArea) maxArea = area;
                    }
                }
            }
            return maxArea;
        }

        private double CalculateTriangleArea(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return 0.5 * Math.Abs(
                x1 * (y2 - y3) +
                x2 * (y3 - y1) +
                x3 * (y1 - y2)
            );
        }
    }
}
