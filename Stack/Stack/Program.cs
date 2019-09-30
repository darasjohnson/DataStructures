using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            var rerun = true;

            Console.WriteLine("Welcome to the Stack Program!");

            do
            {
                PrintMenu();
                var choice = Console.ReadLine();
                var intChoice = UsersChoice(choice);

                if (intChoice == 1)
                    stack.Print();
                else if (intChoice == 2)
                {
                    Console.WriteLine("Which element would you like to add?");
                    var entry = Console.ReadLine();

                    stack.Push(Convert.ToInt32(entry));
                }
                else if (intChoice == 3)
                    stack.Pop();
                else if (intChoice == 4)
                    rerun = false;
                else
                    Console.WriteLine("Please enter a valid option.");
            } while (rerun);
            

        }

        public static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1- Print Elements");
            Console.WriteLine("2- Add Element");
            Console.WriteLine("3- Pop Last Element");
            Console.WriteLine("4- End Program");
        }

        public static int UsersChoice(string choice)
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

    public class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        public Stack()
        {
            top = -1;
        }

        public bool IsEmpty()
        {
            if (top < 0)
                return true;
            else
                return false;
        }

        public void Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack is full...");
            }
            else
            {
                top++;
                stack[top] = data;
                Console.WriteLine("Item Added!");
            }
        }

        public void Print()
        {
            if (!this.IsEmpty())
            {
                Console.WriteLine("The stack elements are: ");
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(stack[i]);
                }
                Console.WriteLine("There are {0} elements.", this.Count());
            }
            else
            {
                Console.WriteLine("The stack is empty...");
            }

        }

        public void Pop()
        {
            if (this.IsEmpty())
                Console.WriteLine("The stack is empty...");
            else
            {
                top--;
                Console.WriteLine("Last Item Deleted!");
            }
        }

        public int Count()
        {
            return top + 1;
        }
    }
}
