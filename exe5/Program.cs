using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5
{
    class Node
    {
        public string val;
        public Node next;
    }
    class queue
    {
        Node prima, ramadhan;
        public queue()
        {
            prima = null;
            ramadhan = null;
        }

        public void enter()
        {
            string data;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            data = Console.ReadLine();
            newnode.val = data;
            newnode.next = null;
            if (prima == null)
            {
                prima = newnode;
                ramadhan = newnode;
                return;
            }
            ramadhan.next = newnode;
            ramadhan = newnode;
        }
        public void delete()
        {
            if (prima == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            prima = prima.next;
            if (prima == null)
                ramadhan = null;
        }
        public void display()
        {
            if (prima == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Node display;
            int Count = 1;
            for (display = prima; display != null; display = display.next)
                Console.WriteLine("Data number [" +  (Count++)+  "] is :" +display.val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement enter operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.enter();
                            break;
                        case '2':
                            q.delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}