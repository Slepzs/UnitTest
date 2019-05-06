using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitListX
{
    public class ListXz
    {
        // class with 6 (or 7) errors
        // HAU & TOR
        private Node list;
        private int size;

        // create a new empty list
        public ListXz()
        {
            list = null;
            size = 0;
        }

        // returns the number of objects in the list    
        public int Length()
        {
            return size;
        }

        // insert an object in the end of the list
        public void Add(Object obj)
        {
            Node node = new Node(obj);
            Node current;

            if (list == null) list = node;
            else
            {
                current = list;
                while (current.next != null) current = current.next;
                current.next = node;
            }
        }

        // insert an object at position index
        public void Add(int index, Object obj)
        {
            if (index < 0 || size < index) throw new MyException("Error (Add): Invalid index: " + index);

            Node node = new Node(obj);

            // on first position
            if (index == 0)
            {
                list = node;
                node.next = list;
            }
            else
            // on a position after the first
            {
                Node current = list;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }
                node.next = current.next;
                current.next = node;
            }
            size++;
        }

        // returns a reference to object number "index" from the list
        public Object Get(int index)
        {
            if (index <= 0 || size <= index) throw new MyException("Error (Get): Invalid index: " + index);

            Node current = list.next;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current.data;
        }

        // returns a reference to object number "index" from the list and removes it from the list
        public Object Remove(int index)
        {
            if (index < 0 || size <= index) throw new MyException("Error (Remove): Invalid index: " + index);
            // 
            Node node = null;
            Node current = list;
            if (index == 0)
            {
                list = node.next;
            }
            else
            // from a position after the first
            {
                current = list;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }
                node = current.next;
                current.next = current.next.next;
            }
            size--;
            // 5. Returning the wrong data. 
            return current.data;
        }

        // node in the list
        private class Node
        {
            public Object data;
            public Node next;
            public Node(Object o)
            {
                data = o;
                next = null;
            }
        }

        // exception handling index out of bound
        public class MyException : Exception
        {
            public MyException(string message) : base(message)
            {
            }
        }

    }
}