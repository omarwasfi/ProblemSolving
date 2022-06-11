using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(5);
            Node f = new Node(6);
            Node g = new Node(7);


            a.left = b;
            a.right = c;
            b.left = d;
            b.right = e;
            c.left = f;
            c.right = g;


            solution solution = new solution();

            Node resultNodel = solution.connect(a);



          

        }
    }

    public class solution
    {
        public Node connect(Node root)
        {
            if (root == null) return null;

            Queue<Node> nodeQueue = new Queue<Node>();

            int currentLevelCount = new int();


            int counter = new int();

            nodeQueue.Enqueue(root);

            while (nodeQueue.Count > 0)
            {
                Node current = nodeQueue.Dequeue();

                if(current.left != null)
                {
                    nodeQueue.Enqueue(current.left);

                }

                if (current.right != null)
                {
                    nodeQueue.Enqueue(current.right);
                }


                counter++;




                if (currentLevelCount == 0) currentLevelCount = 1;

                if (counter == currentLevelCount)
                {
                    current.next = null;
                    currentLevelCount = currentLevelCount * 2;
                    counter = 0;
                }
                else
                {
                    current.next = nodeQueue.Peek();
                }

            }


            return root;
        }
    }


    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int value)
        {
            val = value;
        }

        public Node(int value, Node left, Node right, Node next)
        {
            val = value;
            this.left = left;
            this.right = right;
            this.next = next;
        }
    }
}


