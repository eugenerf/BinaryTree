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
