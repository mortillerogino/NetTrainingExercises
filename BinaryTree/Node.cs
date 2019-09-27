namespace BinaryTree
{
    public class Node
    {
        public Node(int root, Node left, Node right)
        {
            Root = root;
            Left = left;
            Right = right;
        }
        public int Root { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        private int TotalRecursive()
        {
            var total = 0;
            if (Left != null)
            {
                total += Left.TotalRecursive();
            }

            if (Right != null)
            {
                total += Right.TotalRecursive();
            }

            total += Root;

            return total;
        }

        public static int Total(Node root)
        {
            return root.TotalRecursive();
        }

    }


}
