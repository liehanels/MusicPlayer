using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class CDList
    {
        public Node Head { get; private set; }
        private Node Tail { get; set; }
        public CDList()
        {
            Tail = null;
        }
        public void AddToEmpty(string data)
        {
            if (Tail != null)
            {
                return;
            }
            Node newNode = new Node(data);
            Tail = newNode;
            Tail.Next = Tail;
        }
        public void AddToEnd(string data)
        {
            if (Tail == null)
            {
                AddToEmpty(data);
                return;
            }
            Node newNode = new Node(data);
            newNode.Next = Tail.Next;
            Tail.Next = newNode;
            Tail = newNode;
        }
        public void PrintList()
        {
            if (Tail == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node temp = Tail.Next;
            do
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
            } while (temp != Tail.Next);
            Console.WriteLine();
        }
        public void DeleteNode(string key)
        {
            if (Tail == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (Tail.Next == Tail && Tail.Data == key)
            {
                Tail = null;
                return;
            }
            Node current = Tail;
            Node prev = null;
            do
            {
                prev = current;
                current = current.Next;
                if (current.Data == key)
                {
                    break;
                }
            } while (current != Tail);
            if (current == Tail && current.Data != key)
            {
                Console.WriteLine("Key not found in list");
                return;
            }
            prev.Next = current.Next;
            if (current == Tail)
            {
                if (Tail.Next == Tail)
                {
                    Tail = null;
                }
                else
                {
                    Tail = prev;
                }
            }
        }
        public void Insert(string data)
        {
            Node newNode = new Node(data);
            if (Head != null )
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
        }
    }
}
