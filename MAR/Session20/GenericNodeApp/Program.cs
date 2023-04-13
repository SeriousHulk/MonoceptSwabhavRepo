using GenericNodeApp.Model;

namespace GenericNodeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Node<int>();
            var node2 = new Node<int>();
            var node3 = new Node<int>();
            node1.Data = 10;
            node2.Data = 20;
            node3.Data = 30;
            node1.Next = node2;
            node2.Next = node3;

            var nodeA = new Node<string>();
            var nodeB = new Node<string>();
            var nodeC = new Node<string>();
            nodeA.Data = "A";
            nodeB.Data = "B";
            nodeC.Data = "C";
            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            PrintNodeDetails<int>(node1);
            PrintNodeDetails<string>(nodeA);
        }

        private static void PrintNodeDetails<T>(Node<string> node)
        {
            while (node != null)
            {
                if (node.Next != null)
                {
                    Console.WriteLine($"{node.Data}'s Next is {node.Next.Data}");
                }
                else
                {
                    Console.WriteLine($"{node.Data} has no next node");
                }
                node = node.Next;
            }
        }

        private static void PrintNodeDetails<T>(Node<int> node)
        {
            while (node != null)
            {
                if (node.Next != null)
                {
                    Console.WriteLine($"{node.Data}'s Next is {node.Next.Data}");
                }
                else
                {
                    Console.WriteLine($"{node.Data} has no next node");
                }
                node = node.Next;
            }
        }
    }
}