using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsImplementation
{
    class Queue : ICommonFunctions
    {
        const int maxLimit = 50;
        int[] queue = new int[maxLimit];
        int front,rear;
        public Queue()
        {
            front = -1;
            rear = -1;    
        }
        public void Add(int value)
        {
            if (rear == -1)
            {
                front = rear = 0;
                queue[rear] = value;
            }
            else if (rear + 1 >= maxLimit)
                Console.WriteLine("Queue Overflow");
            else if (rear + 1 < maxLimit)
                queue[++rear] = value;
        }
        public int Remove()
        {
            int removedElement = -1;
            if (rear == -1)
                Console.WriteLine("Queue Underflow");
            else
            {
                removedElement = queue[front];
                if (front == rear)
                    front = rear = -1;
                else
                    front++;
            }
            return removedElement;
        }
        public void Sort()
        {
            int temp;
            for (int index1 = front; index1 <= rear; index1++)
            {
                for (int index2 = front; index2 <= rear - index1 - 1; index2++)
                {
                    if (queue[index2] > queue[index2 + 1])
                    {
                        temp = queue[index2];
                        queue[index2] = queue[index2 + 1];
                        queue[index2 + 1] = temp;
                    }
                }
            }
        }
        public int Peek()
        {
            int peekElement = -1;
            if (front == -1)
                Console.WriteLine("Queue Underflow");
            else
                peekElement = queue[front];
            return peekElement;
        }
        public bool IsFull()
        {
            if (front == 0 && rear + 1 >= maxLimit)
                return true;
            else
                return false;
        }
        public bool IsEmpty()
        {
            if (front == -1)
                return true;
            else
                return false;
        }

        public void Display()
        {
            if (front == -1)
                Console.WriteLine("Queue Underflow");
            else
            {
                for (int index = front; index <= rear; index++)
                {
                    Console.Write(queue[index] + "\t");
                }
                Console.WriteLine();
            }
        }   
    }
}