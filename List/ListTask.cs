using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class ListTask
    {
        public class Node<T>
        {
            public void SetNextNode(Node<T> _nextNode)
            {
                this.next = _nextNode;
            }
            public T Element
            {
                get
                {
                    return this.element;
                }
                set
                {
                    this.element = value;
                }
            }

            public Node<T> Next
            {
                get
                {
                    return this.next;
                }
                set
                {
                    this.next = value;
                }
            }

            public Node<T> next;
            public T element;
        }

        public class MyList<T> : IEnumerable<T>
        {
            public MyList()
            {
                this.headNode = null;
                this.tailNode = this.headNode;
                this.Length = 0;
            }
            public void Push(T _element)
            {
                if (headNode == null)
                {
                    this.headNode = new Node<T>();
                    this.headNode.Element = _element;
                    this.tailNode = this.headNode;
                    this.headNode.SetNextNode(null);
                }
                else
                {
                    Node<T> newNode = new Node<T>();
                    this.tailNode.SetNextNode(newNode);
                    this.tailNode = newNode;
                    this.tailNode.Element = _element;
                    this.tailNode.SetNextNode(null);
                }
                ++this.Length;
            }

            public bool Remove(int data)
            {
                Node<T> current = headNode;
                Node<T> previous = null;

                while (current != null)
                {
                    if (current.Element.Equals(data))
                    {
                        if (previous != null)
                        {
                            previous.next = current.next;
                            if (current.next == null)
                                tailNode = previous;
                        }
                        else
                        {
                            headNode = headNode.next;
                            if (headNode == null)
                                tailNode = null;
                        }
                        --this.Length;
                        return true;
                    }
                    previous = current;
                    current = current.next;
                }
                return false;
            }
            public bool Contains(int data)
            {
                Node<T> current = headNode;
                while (current != null)
                {
                    if (current.element.Equals(data))
                        return true;
                    current = current.next;
                }
                return false;
            }
            public void Reverse()
            {
                if (headNode != null && headNode.next != null)
                {
                    Node<T> temp = headNode;
                    Node<T> current1 = headNode;
                    Node<T> current2 = headNode.next;
                    current1.next = null;
                    //Node current3 = headNode;
                    while (current2 != null)
                    {
                        temp = current2.next;
                        current2.next = current1;
                        current1 = current2;
                        current2 = temp;
                    }
                    tailNode = headNode;
                    headNode = current1;
                }
            }

            public void Print()
            {
                Node<T> current = headNode;
                while (current != null)
                {
                    Console.Write(current.element + " ");
                    current = current.next;
                }
                Console.Write("\n");
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)this).GetEnumerator();
            }
            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                Node<T> current = headNode;
                while (current != null)
                {
                    yield return current.Element;
                    current = current.Next;
                }
            }
            public int Length { get; set; }
            public Node<T> headNode;
            public Node<T> tailNode;
        }
    }
}
