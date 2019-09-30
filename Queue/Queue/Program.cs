using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Queue Program!");
            bool rerun = true;
            var queue = new Queue();

            do
            {
                PrintMenu();
                var choice = UsersChoice(Console.ReadLine());

                if (choice == 1)
                    queue.Print();
                else if (choice == 2)
                {
                    Console.WriteLine("What element would you like to add?");
                    queue.Enqueue(Convert.ToInt32(Console.ReadLine()));               
                }
                else if (choice == 3)
                    queue.Dequeue();                   
                else if (choice == 4)
                    rerun = false;
                else
                    Console.WriteLine("Please enter a valid option.");

            } while (rerun);
        }

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1- Print Elements");
            Console.WriteLine("2- Add Element");
            Console.WriteLine("3- Remove Element");
            Console.WriteLine("4- End Program");
        }

        static int UsersChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                default:
                    return 0;
            }
        }
    }
    public class Node
    {
        private int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public int GetData()
        {
            return Data;
        }
    }
    public class Queue
    {
        private Node head;
        private Node tail;
        private int count;
        public Queue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("The queue is empty...");
            }
            else
            {
                Console.WriteLine("Here are the elements in queue:");
                var current = head;

                while (current != null)
                {
                    Console.WriteLine(current.GetData());
                    current = current.Next;
                }

                Console.WriteLine("There are {0} elements.", Count());
            }
        }

        public void Enqueue(int data)
        {
            if (head == null)
            {
                var node = new Node(data);
                head = node;
                tail = node;
                count++;
                Console.WriteLine("Item added to queue!");
            }
            else
            {
                tail.Next = new Node(data);
                tail = tail.Next;
                count++;
                Console.WriteLine("Item added to queue!");
            }
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The queue is empty...");
            }
            else
            {
                head = head.Next;
                count--;
                Console.WriteLine("First Element Removed.");
            }
        }
    }
}
