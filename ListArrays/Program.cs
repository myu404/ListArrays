using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrays
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static List<int> merge(List<int> left, List<int> right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            List<int> mergedList = new List<int>(left.Capacity + right.Capacity);

            for (int i = 0; i < mergedList.Capacity; i++)
            {
                mergedList[i] = (rightIndex >= right.Capacity || leftIndex < left.Capacity && left[leftIndex] <= right[rightIndex]) ? left[leftIndex++] : right[rightIndex++];
            }

            return mergedList;
        }
    }

    // Singly Linked List Node
    class Node
    {
        public int data;
        public Node next;

        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public Node(int data) : this(data, null) { }

        public Node() : this(0, null) { }
    }

    class LinkedListInt
    {
        public Node Front { get; private set; };

        public LinkedListInt() { Front = null; }

        // LinkedListInt instance/object methods
        public void Add(int value)
        {
            if (Front == null) Front.next = new Node(value);
            else
            {
                Node current = Front;
                while (current.next != null) current = current.next;
                current.next = new Node(value);
            }
        }

        public void DeleteNode(int value)
        {
            Node prev = null;
            Node current = Front;
            while (current.next != null || current.data != value)
            {
                prev = current;
                current = current.next;
            }

            if(current.data == value) prev.next = current.next;            
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = Front;

            while(current != null)
            {
                Front = current.next;
                current.next = prev;
                prev = current;
                current = Front;
            }
            Front = prev;
        }

        public void ReversePrint()
        {
            Reverse();
            Node current = Front;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }


}
