namespace Solutions
{
    public class Solution1233
    {
        public IList<string> RemoveSubfolders(string[] folder)
        {
            Array.Sort(folder);
            List<string> result = new List<string>();
            result.Add(folder[0]);
            for (int i = 1; i < folder.Length; i++)
            {
                string prev = result.Last();
                if (!folder[i].StartsWith(prev + "/"))
                {
                    result.Add(folder[i]);
                }
            }
            return result;
        }
    }
}
