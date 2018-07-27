using System;

namespace CollectionsImplementation
{
    class Node
    {
        int _data;
        Node _next;

        public Node(int data)
        {
            this.Data = data;
        }
        public int Data {
            get => _data;
            set => _data = value;
        }
        internal Node Next {
            get => _next;
            set => _next = value;
        }
    }
    class LinkedList : ICommonFunctions
    {
        static Node head = null;

        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public int Remove()
        {
            int data = head.Data;
            head = head.Next;
            return data;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List Underflow");
            }
            Node disp = head;
            while (disp != null)
            {
                Console.WriteLine(disp.Data + "\t");
                disp = disp.Next;
            }
        }
        public static int Size()
        {
            int count = 0;
            Node temporaryNode = head;
            while (temporaryNode != null)
            {
                count++;
                temporaryNode = temporaryNode.Next;
            }
            return count;
        }
        public void Sort()
        {
            int size = Size();
            for (int index1 = 0; index1 < size; index1++)
            {
                int temp;
                Node temporaryNode = head;
                Node next = head.Next;
                for (int index2 = 0; index2 < size - 1; index2++)
                {
                    if (temporaryNode.Data > next.Data)
                    {
                        temp = temporaryNode.Data;
                        temporaryNode.Data = next.Data;
                        next.Data = temp;
                    }
                    temporaryNode = next;
                    next = next.Next;

                }
            }
        }


        public void AddDataAtSpecificPosition(int data, int index)
        {
            Node temporaryNode = head;
            if (head == null)
            {
                Add(data);
                return;
            }
            while (index > 1)
            {
                temporaryNode = temporaryNode.Next;
                index--;
            }
            Node addNode = temporaryNode.Next;
            temporaryNode.Next = new Node(data);
            temporaryNode.Next.Next = addNode;
        }
        public int RemoveAtIndex(int index)
        {
            Node removeNode = head;
            int removedElement = -1;
            if (index < 1)
            {
                Console.WriteLine("Please choose some other index ");
                return -1;
            }
            if (index == 1)
            {
                removedElement = head.Data;
                head = head.Next;
                return removedElement;
            }
            while (index > 0)
            {
                if (removeNode == null)
                    return -1;

                removeNode = removeNode.Next;
                index--;
            }
            removedElement = removeNode.Data;
            removeNode.Data = removeNode.Next.Data;
            removeNode.Next = removeNode.Next.Next;
            return removedElement;
        }
       
    }
}