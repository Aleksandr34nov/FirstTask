using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class TreeTask
    {
        public class Node
        {
            public void SetNextLeftNode(Node _nextNode)
            {
                this.left = _nextNode;
            }
            public void SetNextRightNode(Node _nextNode)
            {
                this.right = _nextNode;
            }
            public int Element
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

            public Node Left
            {
                get
                {
                    return this.left;
                }
                set
                {
                    this.left = value;
                }
            }

            public Node Right
            {
                get
                {
                    return this.right;
                }
                set
                {
                    this.right = value;
                }
            }

            public Node left;
            public Node right;
            public int element;
        }

        public class Tree
        {
            public Tree()
            {
                this.headNode = null;
            }
            public void Push(int _element)
            {
                if (headNode == null)
                {
                    this.headNode = new Node();
                    this.headNode.Element = _element;
                    this.headNode.SetNextLeftNode(null);
                    this.headNode.SetNextRightNode(null);
                }
                else
                {
                    Node current = headNode;
                    Node previous = null;
                    while (current != null)
                    {
                        if (_element == current.element)
                        {
                            break;
                        }
                        if (_element > current.element)
                        {
                            previous = current;
                            current = current.right;
                        }
                        else
                        {
                            previous = current;
                            current = current.left;
                        }
                    }
                    if (current == null)
                    {
                        if (_element >= previous.element)
                        {
                            previous.right = new Node();
                            previous.right.element = _element;
                        }
                        else
                        {
                            previous.left = new Node();
                            previous.left.element = _element;
                        }
                    }
                }
            }

            public bool Remove(int data)
            {
                if (headNode == null)
                {
                    return false;
                }
                else
                {
                    Node current = headNode;
                    Node previous = null;
                    Node min = null;
                    Node min_prev = null;
                    while (current != null)
                    {
                        if (data == current.element)
                        {
                            break;
                        }

                        if (data > current.element)
                        {
                            previous = current;
                            current = current.right;
                        }
                        else
                        {
                            previous = current;
                            current = current.left;
                        }
                    }
                    if (current != null)
                    {
                        if (current.left == null && current.right == null)
                        {
                            if (current != headNode)
                            {
                                if (previous.left == current)
                                {
                                    previous.left = null;
                                }
                                else if (previous.right == current)
                                {
                                    previous.right = null;
                                }
                            }
                        }

                        if (current.left != null && current.right == null)
                        {
                            if (current != headNode)
                            {
                                if (previous.left == current)
                                {
                                    previous.left = current.left;
                                }
                                else if (previous.right == current)
                                {
                                    previous.right = current.left;
                                }
                            }
                        }

                        if (current.left == null && current.right != null)
                        {
                            if (current != headNode)
                            {
                                if (previous.left == current)
                                {
                                    previous.left = current.right;
                                }
                                else if (previous.right == current)
                                {
                                    previous.right = current.right;
                                }
                            }
                        }

                        if (current.left != null && current.right != null)
                        {
                            min = current.right;
                            min_prev = null;
                            while (min.left != null)
                            {
                                min_prev = min;
                                min = min.left;
                            }
                            if (min_prev == null)
                            {
                                if (current != headNode)
                                {
                                    if (previous.left == current)
                                    {
                                        previous.left = min;
                                        min.left = current.left;
                                    }
                                    else if (previous.right == current)
                                    {
                                        previous.right = min;
                                        min.left = current.left;
                                    }
                                }
                            }
                            else
                            {
                                if (min.right == null)
                                {
                                    min_prev.left = null;
                                }
                                else
                                {
                                    min_prev.left = min.right;
                                }

                                if (current != headNode)
                                {
                                    if (previous.left == current)
                                    {
                                        min.right = current.right;
                                        previous.left = min;
                                        min.left = current.left;
                                    }
                                    else if (previous.right == current)
                                    {
                                        min.right = current.right;
                                        previous.right = min;
                                        min.left = current.left;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }

            public bool Contains(int data)
            {
                if (headNode == null)
                {
                    return false;
                }
                else
                {
                    Node current = headNode;
                    while (current != null)
                    {
                        if (data == current.element)
                        {
                            return true;
                        }
                        else
                        {
                            if (data >= current.element)
                            {
                                current = current.right;
                            }
                            else
                            {
                                current = current.left;
                            }
                        }
                    }
                    return false;
                }
            }

            public Node headNode;
        }
    }
}
