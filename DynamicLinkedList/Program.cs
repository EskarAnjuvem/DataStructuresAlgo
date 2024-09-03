using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicLinkedList
{
    public class DynamicList<T>
    {
        private class ListNode
        {
            public T Element { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(T element)
            {
                this.Element = element;
                this.NextNode = null;
            }

            public ListNode(T element, ListNode PrevNode)
            {
                this.Element = element;
                PrevNode.NextNode = this;
                this.NextNode = null;
            }

        }

        private ListNode head;
        private ListNode tail;
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(T item)
        {
            if (this.head == null)
            {
                ListNode firstNode = new ListNode(item);
                this.head = firstNode;
                this.tail = this.head;
            }
            else
            {
                ListNode newNode = new ListNode(item, this.tail);
                this.tail = newNode;

            }
            this.count++;

        }

        public T RemoveAt(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Exception: " + index);
            }

            ListNode CurrentNode = this.head;
            ListNode PrevNode = this.tail;

            //int currentIndex = 0;
            
            for (int i = 0; i < index; i++)
            {
                PrevNode = CurrentNode;
                CurrentNode = CurrentNode.NextNode;
            }

            RemoveListNode(CurrentNode, PrevNode);

            return CurrentNode.Element;
        }

        private void RemoveListNode(ListNode node, ListNode prev)
        {
            count--;

            if (count == 0)
            {
                this.head = null;
                this.tail = null;
            }
            else if (prev == this.tail)
            {
                this.head = node.NextNode;
            }

            else if (node.NextNode == null)
            {
                prev.NextNode = null;
                this.tail = prev;
            }
            else
            {
                prev.NextNode = node.NextNode;
            }
        }

        public T this[int index]
        {
            get
            {
                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                return currentNode.Element;
            }
        }

        public void DisplayList()
        {
            for (int i = 0; i < this.count; i++)
            {
                Console.WriteLine(" -> " + this[i] );
            }
        }


    }
    
}
