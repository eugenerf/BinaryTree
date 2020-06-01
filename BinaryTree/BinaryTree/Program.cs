using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(new int[] { 5, 34, 55, 6, 2, 8, 10, 4, 7, 34, 74 });
            root.ShowByLevel();

            Console.ReadLine();
        }
    }
}
