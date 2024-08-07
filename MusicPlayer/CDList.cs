using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MusicPlayer
{
    public class CDList
    {
        public Node Head { get; private set; }
        public Node Current { get; private set; }
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
                MessageBox.Show("List is empty");
                return;
            }
            Node temp = Tail.Next;
            do
            {
                MessageBox.Show(temp.Data + " ");
                temp = temp.Next;
            } while (temp != Tail.Next);
        }
        public void DeleteNode(string key)
        {
            if (Tail == null)
            {
                MessageBox.Show("List is empty");
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
                MessageBox.Show("Key not found in list");
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
        public string getSong()
        {
            if (Head == null)
            {
                return "No song playing";
            }
            Current = Head;
            return Head.Data;
        }
        public string getSong(string skipTo)
        {
            if (Current == null)
            {
                Current = Tail;
            }
            if (skipTo.Equals("next")) 
            {
                Current = Current.Next;
                return Current.Data;
            }
            Current = Current.Previous;
            return Current.Data;
        }
    }
}
