using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsImplementation
{
    class Program
    {
        public static void CommonPrint()
        {
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Remove");
            Console.WriteLine("3.Display");
            Console.WriteLine("4.Sort");
        }
        static void Main(string[] args)
        {
            int collections;
            Console.WriteLine("Implementation of Collections");
            Console.WriteLine("Press \n1 for implementation of Stack,\n2 for implementation of Queue,\n3 for implementation of Linked list\n");
            int.TryParse(Console.ReadLine(), out collections);
            Console.WriteLine("\n");
            switch (collections)
            {
                case 1:
                    Stack stack = new Stack();
                    while (true)
                    {
                        CommonPrint();
                        Console.WriteLine("5.Get stack Top\n6.Exit from Stack!\n");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the element that is to be inserted ");
                                stack.Add(int.Parse(Console.ReadLine()));
                                Console.WriteLine("Insertion successful!\n");
                                break;
                            case 2:
                                Console.WriteLine("Element removed = " + stack.Remove());
                                break;
                            case 3:
                                stack.Display();
                                break;
                            case 4:
                                stack.Sort();
                                Console.WriteLine("Sorted Stack is");
                                stack.Display();
                                break;
                            case 5:
                                Console.WriteLine("The Top element of Stack is " + stack.GetTop());
                                break;
                            case 6:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }
                    }
                    break;
            
                case 2:
                    Queue queue = new Queue();
                    while (true)
                    {
                        CommonPrint();
                        Console.WriteLine("5.Peek\n6.Check Queue is Full\n7.Check Queue is Empty\n8.Exit from Queue\n");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the Element that is to be Inserted");
                                queue.Add(int.Parse(Console.ReadLine()));
                                Console.WriteLine("Insertion successful!");
                                break;
                            case 2:
                                Console.WriteLine("Element Removed = " + queue.Remove());
                                break;
                            case 3:
                                queue.Display();
                                break;
                            case 4:
                                queue.Sort();
                                Console.WriteLine("Sorted Queue = ");
                                queue.Display();
                                break;
                            case 5:
                                Console.WriteLine("The Front Value of Queue =" + queue.Peek());
                                break;
                            case 6:
                                if (queue.IsFull())
                                    Console.WriteLine("Queue is full");
                                else
                                    Console.WriteLine("Queue is not full");
                                break;
                            case 7:
                                if (queue.IsEmpty())
                                    Console.WriteLine("Queue is empty");
                                else
                                    Console.WriteLine("Queue is not empty");
                                break;
                            case 8:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }
                    }
                    break;
                case 3:
                    LinkedList linkedList = new LinkedList();
                    while (true)
                    {
                        Console.WriteLine("1.Add element at beginning");
                        Console.WriteLine("2.Remove element at end");
                        Console.WriteLine("3.Display the list");
                        Console.WriteLine("4.Sort the list");
                        Console.WriteLine("5.Insert element at specific location");
                        Console.WriteLine("6.Remove element from specific location");
                        Console.WriteLine("7.Exit from Linked list!\n");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Element to be Inserted");
                                linkedList.Add(int.Parse(Console.ReadLine()));
                                Console.WriteLine("Inserion successful!");
                                break;
                            case 2:
                                Console.WriteLine("Element removed = " + linkedList.Remove());
                                break;
                            case 3:
                                linkedList.Display();
                                break;
                            case 4:
                                linkedList.Sort();
                                Console.WriteLine("Sorted Linked List = ");
                                linkedList.Display();
                                break;
                            case 5:
                                Console.WriteLine("Enter element to be inserted ");
                                int requestData = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter index at which you want to insert data ");
                                int index = int.Parse(Console.ReadLine());
                                linkedList.AddDataAtSpecificPosition(requestData, index);
                                Console.WriteLine("Insertion successful ! ");
                                break;
                            case 6:
                                Console.WriteLine("Enter Index from which you want to remove data ");
                                int removedElement = linkedList.RemoveAtIndex(int.Parse(Console.ReadLine()));
                                if(removedElement == -1)
                                    Console.WriteLine("Empty list !\n");
                                else
                                    Console.WriteLine("Removed successfully !\n");
                                break;
                            case 7:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }
                    }
                    break;


                default:
                    break;
            }
        }
    }
}