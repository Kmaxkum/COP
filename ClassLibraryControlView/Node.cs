using System.Collections.Generic;

namespace ClassLibraryControlView
{
    public class Node
    {
        public List<Node> Nodes;

        public string Value;

        public Node(string value)
        {
            Value = value;
            Nodes = new List<Node>();
        }


        public Node(string value, List<Node> nodes)
        {
            Value = value;
            Nodes = nodes;
        }

        public void AddSubNode(Node node)
        {
            Nodes.Add(node);
        }
    }
}
