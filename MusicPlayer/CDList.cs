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
        public string getSong()
        {
            if (Tail == null)
            {
                return "No song playing";
            }
            Current = Tail;
            return Tail.Data;
        }
        public string getSong(string skipTo)
        {
            if (Current == null)
            {
                Current = Tail;
            }
            if (skipTo.Equals("next") && Current != null)
            {
                Current = Current.Next;
                return Current.Data;
            }
            else if (skipTo.Equals("prev") && Current != null)
            {
                Current = Current.Next.Previous;
                return Current.Data;
            }
            else
            {
                return "No song queued";
            }
                
        }
    }
}
