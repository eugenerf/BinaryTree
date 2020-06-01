using System;

namespace BinaryTree
{
    class Node
    {
        public Node Left { get; private set; }
        public Node Right { get; private set; }
        public int Value { get; private set; }

        public Node(int value)
        {
            Value = value;
        }

        public Node(int[] values)
        {
            if (values == null) return;
            Value = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                AddValue(values[i]);
            }
        }

        public void ShowByLevel()
        {
            string[] levelsStrings = new string[1];
            GenerateLevelStrings(ref levelsStrings);
            for (int i = levelsStrings.Length - 1; i >= 0; i--)
            {
                Console.Write($"Level {i + 1}: ");
                Console.WriteLine(levelsStrings[i]);
            }
        }

        private void GenerateLevelStrings(ref string[] levelsStrings, int currentLevel = 0)
        {
            int currentLength = (levelsStrings == null) ? 0 : levelsStrings.Length;
            if (currentLevel >= currentLength)
            {
                Array.Resize(ref levelsStrings, currentLevel + 1);
            }
            if (levelsStrings[currentLevel] == null)
            {
                levelsStrings[currentLevel] = "";
            }
            if(levelsStrings[currentLevel].Length > 0)
            {
                levelsStrings[currentLevel] += ", ";
            }
            levelsStrings[currentLevel] += Value.ToString();
            if (Left != null)
            {
                Left.GenerateLevelStrings(ref levelsStrings, currentLevel + 1);
            }
            if (Right != null)
            {
                Right.GenerateLevelStrings(ref levelsStrings, currentLevel + 1);
            }
        }

        public void AddValue(int value)
        {
            if (value < Value)
            {
                if (Left == null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.AddValue(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.AddValue(value);
                }
            }
        }
    }
}
