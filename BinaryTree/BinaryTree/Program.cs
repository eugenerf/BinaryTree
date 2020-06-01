using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(new int[] { 5, 34, 55, 6, 2, 8, 10, 4, 7, 34, 74 });
            ShowTreeByLevel(root);

            Console.ReadLine();
        }

        static int[][] TreeValues;

        private static void ShowTreeByLevel(Node node, int currentLevel = 0)
        {
            TreeValues = new int[1][];
            MakeTreeArray(node);
            for (int i = TreeValues.Length - 1; i >= 0; i--)
            {
                Console.Write("Level " + (i + 1).ToString() + ": ");
                int j;
                for (j = 0; j < TreeValues[i].Length - 1; j++)
                {
                    Console.Write(TreeValues[i][j].ToString() + ", ");
                }
                Console.WriteLine(TreeValues[i][j]);
            }
        }

        private static void MakeTreeArray(Node node, int currentLevel = 0)
        {
            if (node == null) return;
            if (TreeValues.Length <= currentLevel)
            {
                Array.Resize(ref TreeValues, currentLevel + 1);
            }
            int newLength = (TreeValues[currentLevel] == null) ? 1 : TreeValues[currentLevel].Length + 1;
            Array.Resize(ref TreeValues[currentLevel], newLength);
            int newValueIndex = TreeValues[currentLevel].Length - 1;
            TreeValues[currentLevel][newValueIndex] = node.Value;
            MakeTreeArray(node.Left, currentLevel + 1);
            MakeTreeArray(node.Right, currentLevel + 1);
        }
    }
}
