using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class NodeFactory
    {
        
        public IDictionary<int, Node> Nodes { get; private set; }

        public NodeFactory()
        {
            Nodes = new Dictionary<int, Node>();
        }

        public void CreateNode(int root, Node left, Node right)
        {
            if (Nodes.ContainsKey(root))
            {
                throw new Exception("Root already exists!");
            }

            Nodes.Add(root, new Node(root, left, right));
        }

        
    }
}
