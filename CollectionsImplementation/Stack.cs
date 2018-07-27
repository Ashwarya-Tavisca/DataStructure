using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsImplementation
{

    class Stack : ICommonFunctions
    {
        const int maxLimit = 50;
        int[] stack = new int[maxLimit];
        int top;
        public Stack()
        {
            top = -1;
        }
        public void Add(int value)
        {
            if (top >= maxLimit)
                Console.WriteLine("Stack Overflow");
            else
                stack[++top] = value;
        }

        public void Display()
        {
            if (top <= -1)
                Console.WriteLine("Stack Underflow");
            else
            {
                for (int index = top; index >= 0; index--)
                {
                    Console.WriteLine(" "+stack[index]);
                }
            }
        }

        public int Remove()
        {
            int removedElement = 0;
            if (top <= -1)
                Console.WriteLine("Stack Underflow");
            else
                removedElement = stack[top--];
            return removedElement;
        }

        public void Sort()
        {
            int temp;
            for (int index1 = 0; index1 <= top; index1++)
            {
                for (int index2 = 0; index2 <= top - index1 - 1; index2++)
                {
                    if (stack[index2] > stack[index2 + 1])
                    {
                        temp = stack[index2];
                        stack[index2] = stack[index2 + 1];
                        stack[index2 + 1] = temp;
                    }
                }
            }
        }
        public int GetTop()
        {
            int topElement = -1;
            if (top <= -1)
                Console.WriteLine("Stack Underflow");
            else
                topElement = stack[top];
            return topElement;
        }
    }

}
