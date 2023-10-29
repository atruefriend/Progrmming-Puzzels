namespace MyLinkedList
{
    public class MyDoubleLinkedList
    {
        public int Length = 0;
        public DoubleNode Head;
        public DoubleNode Tail;

        public MyDoubleLinkedList(object value)
        {
            Head = new DoubleNode(value, null, null);
            Tail = Head;
            Length++;
        }

        public void Append(object value)
        {
            var doubleNode = new DoubleNode(value, null, Tail);
            Tail.Next = doubleNode;
            Tail = doubleNode;
            Length++;
        }

        public void Prepend(object value)
        {
            var doubleNode = new DoubleNode(value, Head, null);
            Head.Previous = doubleNode;
            Head = doubleNode;
            Length++;
        }

        public void Insert(int index, object value)
        {
            if (index <= 0)
            {
                Prepend(value);
            }
            else if (index >= Length)
            {
                Append(value);
            }

            int half = Length / 2;
            if (index <= half)
            {
                DoubleNode? node = GetNodeByMovingForward(index - 1);
                DoubleNode newNode = new DoubleNode(value, node?.Next, node);
                if (node?.Next != null)
                {
                    node.Next.Previous = node;
                    node.Next = newNode;
                }

            }
            else
            {
                DoubleNode? node = GetNodeByMovingBackward(index, Length);
                DoubleNode newNode = new DoubleNode(value, node, node?.Previous);
                if (node?.Previous != null)
                {
                    node.Previous.Next = newNode;
                    node.Previous = newNode;
                }
            }

            Length++;
        }

        public object[] GetValues()
        {
            object[] array = new object[Length];
            DoubleNode? currentNode = Head;
            int pos = 0;
            while(currentNode != null)
            {
                array[pos] = currentNode.Value;
                currentNode = currentNode.Next;
                pos++;
            }

            return array;
        }

        DoubleNode? GetNodeByMovingForward(int index)
        {
            int pos = 0;
            DoubleNode? currentNode = Head;
            while (index >= pos)
            {
                if (index == pos)
                {
                    return currentNode;
                }
                currentNode = currentNode?.Next;
                pos++;
            }
            return currentNode;
        }

        DoubleNode? GetNodeByMovingBackward(int index, int Length)
        {
            int pos = Length - 1;
            DoubleNode? currentNode = Tail;
            while (index <= pos)
            {
                if (index == pos)
                {
                    return currentNode;
                }
                currentNode = currentNode?.Previous;
                pos--;
            }
            return currentNode;
        }
    }


    public class DoubleNode
    {
        public Object Value { get; set; }
        public DoubleNode? Next { get; set; }
        public DoubleNode? Previous { get; set; }
        public DoubleNode(object value, DoubleNode? next, DoubleNode? previous)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}