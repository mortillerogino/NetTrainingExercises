using System.Collections.Generic;

namespace BinaryTree
{
    public class BinaryTree
    {
        public IDictionary<int, Node> Nodes;

        public BinaryTree()
        {
            var nF = new NodeFactory();
            var n = nF.Nodes;
            nF.CreateNode(13, null, null);
            nF.CreateNode(7, null, null);
            nF.CreateNode(4, null, null);
            nF.CreateNode(1, null, null);
            nF.CreateNode(6, n[4], n[7]);
            nF.CreateNode(14, n[13], null);
            nF.CreateNode(3, n[1], n[6]);
            nF.CreateNode(10, null, n[14]);
            nF.CreateNode(8, n[3], n[10]);

            Nodes = n;
        }



        
    }

}
