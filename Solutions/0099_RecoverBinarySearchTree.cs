namespace Solutions
{
    public class Solution0099
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        private TreeNode first;   
        private TreeNode second; 
        private TreeNode prev; 

        public void RecoverTree(TreeNode root)
        {
            first = null;
            second = null;
            prev = null;
            InorderTraversal(root);
            if (first != null && second != null)
            {
                int temp = first.val;
                first.val = second.val;
                second.val = temp;
            }
        }

        private void InorderTraversal(TreeNode node)
        {
            if (node == null) return;
            InorderTraversal(node.left);
            if (prev != null && prev.val > node.val)
            {
                if (first == null)
                {
                    first = prev;
                }
                second = node;
            }
            prev = node;
            InorderTraversal(node.right);
        }
    }
}
