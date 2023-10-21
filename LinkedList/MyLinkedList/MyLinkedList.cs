namespace MyLinkedList
{
    public class MyLinkedList
    {
        public Node Head;
        public Node Tail;
        public int Length = 0;
        public MyLinkedList(object value)
        {
            Head = new Node(value, null);
            Tail = Head;
            Length++;
        }

        public void Append(object value)
        {
            var node = new Node(value, null);
            Tail.Next = node;
            Tail = node;
            Length++;
        }

        public void Prepend(object value)
        {
            var node = new Node(value, Head);
            Head = node;
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
            else
            {
                var node = new Node(value, null);
                int pos = 0;
                Node? currentNode = Head;
                while (pos <= index)
                {
                    if (pos == (index - 1))
                    {
                        node.Next = currentNode?.Next;
                        if (currentNode != null)
                        {
                            currentNode.Next = node;
                        }
                        Length++;
                    }
                    else
                    {
                        currentNode = currentNode?.Next;
                    }
                    pos++;
                }
            }
        }

        public object[] GetValues()
        {
            object[] array = new object[Length];
            int pos = 0;
            Node? currentNode = Head;
            while (currentNode != null)
            {
                array[pos] = currentNode.Value;
                currentNode = currentNode.Next;
                pos++;
            }

            return array;
        }
    }

    public class Node
    {
        public Object Value { get; set; }
        public Node? Next { get; set; }
        public Node(object value, Node? next)
        {
            Value = value;
            Next = next;
        }
    }
}