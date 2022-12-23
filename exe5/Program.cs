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
    }
}