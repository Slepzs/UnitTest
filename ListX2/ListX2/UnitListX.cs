using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitListX
{
    public class ListX
    {
        // class with 6 (or 7) errors
        // HAU & TOR
        private Node list;
        private int size;

        // create a new empty list
        public ListX()
        {
            list = null;
            size = 0;
        }

        // returns the number of objects in the list  
        public int Length()
        {
            return size;
        }

        public int Length(ListX mylist)
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
            // 1. Added Size++ It did not increment. 
            size++;
        }

        // insert an object at position index
        public void Add(int index, Object obj)
        {
            // 2. Switched Index and Size. Size will always be larger than index. By 1 
            if (index < 0 || index < size ) throw new MyException("Error (Add): Invalid index: " + index);

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
            // 3. Removed Equals as it is possible to start at 0.
            if (index < 0 || size <= index ) throw new MyException("Error (Get): Invalid index: " + index);

            // 4. removed next on list. Else it would go above the wanted element. 
            Node current = list;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current.data;
        }

        // returns a reference to object number "index" from the list and removes it from the list
        public Object Remove(int index)
        {
            if (index < 0 || size <= index ) throw new MyException("Error (Remove): Invalid index: " + index);
            // 5. Setting node to be equal to list. Else we will get a ObjectReference Error. 
            Node node = list;
            Node current = list;
            if (index == 0)
            {
                list = node.next;
            }
            else
            // from a position after the first
            {
                // 6. Removed current = list. As it is redundant. 
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }
                node = current.next;
                current.next = current.next.next;
            }
            size--;
            // 7. Changed Current to Node, to get the wanted data. 
            return node.data;
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