using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeEx
{
    class Node
    {
        // Member vars
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
