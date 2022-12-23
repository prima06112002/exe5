using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5
{
    class Node
    {
        public string name;
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

        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            nm = Console.ReadLine();
            newnode.name = nm;
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
            int nd = 1;
            for (display = prima; display != null; display = display.next)
                Console.WriteLine(display.name);
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
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.insert();
                            break;
                        case '2':
                            q.delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                    }
                }
            }
        }
    }
}