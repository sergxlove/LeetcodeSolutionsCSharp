namespace Solutions
{
    public class Solution0020
    {
        public bool IsValid(string s)
        {
            Stack<char> parentheses = new Stack<char>();
            Dictionary<char, bool> isExitsParentheses = new Dictionary<char, bool>()
            {
                { '(', false },
                { ')', true },
                { '[', false },
                { ']', true },
                { '{', false },
                { '}', true }
            };
            Dictionary<char, char> varParentheses = new Dictionary<char, char>()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };
            for (int i = 0; i < s.Length; i++)
            {
                if (!isExitsParentheses[s[i]])
                {
                    parentheses.Push(s[i]);
                }
                else
                {
                    try
                    {
                        if (parentheses.Peek() == varParentheses[s[i]])
                        {
                            parentheses.Pop();
                        }
                        else
                        {
                            parentheses.Push(s[i]);
                        }
                    }
                    catch 
                    {
                        parentheses.Push(s[i]);
                    }
                }
            }
            if (parentheses.Count == 0) return true;
            return false;
        }
    }
}
