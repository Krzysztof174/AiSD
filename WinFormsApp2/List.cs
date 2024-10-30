using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp2
{
    internal class List
    {
        public Node Head;
        public Node Tail;
        public int Count = 0;

        public void AddFirst(int number)
        {
            Node node = new Node();
            node.data = number;
            if (Count == 0)
            {
                Head = node;
                Tail = node;
                Count++;
                return;
            }
            node.next = Head;
            Head.prev = node;
            Head = node;
            Count++;
        }
        public void AddLast(int number)
        {
            Node node = new Node();
            node.data = number;
            if (this.Count == 0)
            {
                this.Head = node;
                this.Count++;
                return;
            }
            node.prev = this.Tail;
            this.Tail.next = node;
            this.Tail = node;
            this.Count++;
        }
        public void RemoveFirst()
        {
            if (this.Count <= 0) return;
            if (this.Count == 1)
            {
                this.Tail = new Node();
                this.Head = new Node();
                this.Count--;
                return;
            }
            this.Head = this.Head.next;
            this.Head.prev = null;
            this.Count--;
        }
        public void RemoveLast()
        {
            if (this.Count <= 0) return;
            if (this.Count == 1)
            {
                this.Tail = new Node();
                this.Head = new Node();
                this.Count--;
                return;
            }
            this.Tail = this.Tail.prev;
            this.Tail.next = null;
            this.Count--;
        }
        public string ListToString()
        {
            string concat = "";
            Node tmp = Head;
            if (Count == 0) return "";
            while (tmp != null)
            {
                concat += " " + tmp.data;
                tmp = tmp.next;
            }
            return concat;
        }
    }
}
