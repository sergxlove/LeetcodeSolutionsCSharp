using System.Runtime.InteropServices;

namespace Solutions
{
    public class Solution1792
    {
        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            var comparer = Comparer<double>.Create((a, b) => b.CompareTo(a));
            var heap = new PriorityQueue<(int pass, int total), double>(comparer);
            foreach (var cls in classes)
            {
                int pass = cls[0];
                int total = cls[1];
                double gain = GetGain(pass, total);
                heap.Enqueue((pass, total), gain);
            }
            for (int i = 0; i < extraStudents; i++)
            {
                var current = heap.Dequeue();
                int newPass = current.pass + 1;
                int newTotal = current.total + 1;
                double newGain = GetGain(newPass, newTotal);
                heap.Enqueue((newPass, newTotal), newGain);
            }
            double totalRatio = 0;
            int count = heap.Count;
            while (heap.Count > 0)
            {
                var current = heap.Dequeue();
                totalRatio += (double)current.pass / current.total;
            }
            return totalRatio / count;
        }

        private double GetGain(int pass, int total)
        {
            double currentRatio = (double)pass / total;
            double newRatio = (double)(pass + 1) / (total + 1);
            return newRatio - currentRatio;
        }
    }
}
