using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Node a = new Node() { value = "A" };
            Node b = new Node() { value = "B" };
            Node c = new Node() { value = "C" };
            Node d = new Node() { value = "D" };
            Node e = new Node() { value = "E" };
            Node f = new Node() { value = "F" };

            a.left = b;
            a.right = c;
            b.left = d;
            b.right = e;
            c.right = f;

            List<string> bTValues = depthFirstRecurcive(a);

            foreach(string s in bTValues)
            {
                Console.WriteLine(s);

            }

        }

        static List<string> depthFirst(Node node)
        {
            List<string> values = new List<string>();

            Stack<Node> stack = new Stack<Node>();

            stack.Push(node);
            Node currentNode = new Node() ;

            while(stack.Count > 0)
            {
                currentNode = stack.Pop();
                values.Add(currentNode.value);
                if (currentNode.right != null)
                {
                    stack.Push(currentNode.right);
                }
                if (currentNode.left != null)
                {
                    stack.Push(currentNode.left);
                }

            }


            return values;
        }

        static List<string> depthFirstRecurcive(Node node)
        {
            List<string> values = new List<string>();
            values.Add(node.value);
            if(node.left != null)
            {
                values.AddRange(depthFirstRecurcive(node.left));
            }
            if(node.right != null)
            {
                values.AddRange(depthFirstRecurcive(node.right));
            }

            return values;
        }
    }

    public class Node
    {
        public Node right;
        public Node left;
        public string value;
    }
}