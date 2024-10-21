using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count = 0;

        public void Append(int number)
        {
            count++;
            if(count > 1)
            {
                AddFirst(number);
            }
            else
            {
                AddLast(number);
            }
        }
        public void AddFirst(int number)
        {
            Node node = new Node();
            node.data = number;
            head = node;
        }
        public void AddLast(int number)
        {
            Node node = new Node();
            node.data = number;
            node.prev = tail;
            tail = node;
        }
        public void RemoveFirst()
        {

        }
        public void RemoveLast()
        {

        }
        /*
        public void ToString()
        {

        }
        */
    }
}
