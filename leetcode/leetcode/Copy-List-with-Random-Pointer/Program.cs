using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node a = new Node(7);
            Node b = new Node(13);
            Node c = new Node(11);
            Node d = new Node(10);
            Node e = new Node(1);


            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = null;

            a.random = null;
            b.random = a;
            c.random = e;
            d.random = c;
            e.random = a;

            Solution solution = new Solution();

            Node newHead = solution.CopyRandomList3(a);

            Node currentPrining = newHead;

            while(currentPrining != null)
            {
                if(currentPrining.random != null)
                    Console.WriteLine(currentPrining.val + " " + currentPrining.random.val);
                else
                    Console.WriteLine(currentPrining.val );

                currentPrining = currentPrining.next;
            }

        }
    }



    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;

            Node newHead = new Node(head.val);
            Node currentNewNode = newHead;

            Node currentNode = head.next;

            while (currentNode != null)
            {
                Node newNode = new Node(currentNode.val);
                currentNewNode.next = newNode;

                currentNode = currentNode.next;
                currentNewNode = newNode;


            }


            // Solving the random

            currentNode = head;
            currentNewNode = newHead;
            while (currentNode != null)
            {
                if (currentNode.random != null)
                {
                    Node randomNode = newHead;
                    while (randomNode.val != currentNode.random.val)
                    {
                        randomNode = randomNode.next;
                    }
                    currentNewNode.random = randomNode;
                }
                else
                {
                    currentNewNode.random = null;

                }

                currentNode = currentNode.next;
                currentNewNode = currentNewNode.next;
            }


            return newHead;
        }


        public Node CopyRandomList2(Node head)
        {
            if (head == null)
                return null;

            Node newHead = new Node(head.val);
            Node currentNewNode = newHead;

            Node currentNode = head.next;

            while (currentNode != null)
            {
                Node newNode = new Node(currentNode.val);
                currentNewNode.next = newNode;

                currentNode = currentNode.next;
                currentNewNode = newNode;


            }


            // Solving the random

            currentNode = head;
            currentNewNode = newHead;
            while (currentNode != null)
            {
                if (currentNode.random != null)
                {
                    int randomDepth = new int();
                    Node currentNodeRandomDepth = head;

                    while (currentNodeRandomDepth != currentNode)
                    {
                        randomDepth++;
                        currentNodeRandomDepth = currentNodeRandomDepth.next;
                    }

                    int randomNewNodeDepth = new int();

                    Node randomNode = newHead;
                    while(randomNode.val != currentNode.random.val && randomNewNodeDepth != randomDepth)
                    {
                        randomNewNodeDepth++;
                        randomNode = randomNode.next;
                    }
                    currentNewNode.random = randomNode;
                }
                else
                {
                    currentNewNode.random = null;

                }

                currentNode = currentNode.next;
                currentNewNode = currentNewNode.next;
            }


            return newHead;
        }


        public Node CopyRandomList3(Node head)
        {
            if (head == null) return null;

            var map = new Dictionary<Node, Node>();
            map.Add(head, new Node(head.val));

            var node = head;

            while (node != null)
            {
                var newNode = node.next == null ? null : new Node(node.next.val);
                map[node].next = newNode;

                if (node.next != null) map.Add(node.next, newNode);

                node = node.next;
            }

            node = head;

            while (node != null)
            {
                map[node].random = node.random == null ? null : map[node.random];
                node = node.next;
            }

            return map[head];
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}