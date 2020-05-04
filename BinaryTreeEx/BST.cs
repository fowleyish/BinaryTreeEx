using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeEx
{
    class BST
    {
        // Member vars
        private Node root;

        // ctor
        public BST()
        {
            root = null;
        }

        // Methods

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (root != null)
            {
                Node thisNode = root;
                while (thisNode != null)
                {
                    if (newNode.data > thisNode.data)
                    {
                        if (thisNode.right != null)
                        {
                            thisNode = thisNode.right; 
                        }
                        else
                        {
                            thisNode.right = newNode;
                            break;
                        }
                    }
                    else
                    {
                        if (thisNode.left != null)
                        {
                            thisNode = thisNode.left;
                        }
                        else
                        {
                            thisNode.left = newNode;
                            break;
                        }
                    }
                }
            }
            else
            {
                root = new Node(data);
            }
            
        }

        public Node Search(int data)
        {
            if (root != null)
            {
                Node thisNode = root;
                while (thisNode.data != data)
                {
                    if (data > thisNode.data)
                    {
                        if (thisNode.right == null)
                        {
                            return null;
                        }
                        else
                        {
                            thisNode = thisNode.right;
                        }
                    }
                    else
                    {
                        if (thisNode.left == null)
                        {
                            return null;
                        }
                        else
                        {
                            thisNode = thisNode.left;
                        }
                    }
                }
                return thisNode;
            }
            else
            {
                return null;
            }
        }
    }
}
