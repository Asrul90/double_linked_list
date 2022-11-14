using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    internal class Node
    {
        // node class 
        public int noMhs;
        public string name;
        //
        public Node next;
        //
        public Node prev;
        static void Main(string[] args)
        {
        }
    }

    class DoubleLinkedList
    {
        Node START;

        //

        public DoubleLinkedList()
        {
            START = null;
        }

        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();  
            newNode.noMhs = nim;
            newNode.name = nm;  

            // check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicade number not allowed");
                    return;
                }   
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                return;
            }
            // if the node is to be inserted at batween two node
            Node previous, current;
            for (current = previous = START; current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate numbers not allowed: ");
                    return ;
                }
            }

        }
    }
}

