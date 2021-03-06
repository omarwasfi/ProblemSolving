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

            List<string> bTValues = breadthFirst(a);

            foreach (string s in bTValues)
            {
                Console.WriteLine(s);

            }

        }

        static List<string> breadthFirst(Node node)
        {
            List<string> values = new List<string>();

            Queue<Node> queue = new Queue<Node>();
            
            queue.Enqueue(node);
            Node currentNode = new Node();

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                values.Add(currentNode.value);
                
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }

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