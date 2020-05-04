using System;
using System.Runtime.InteropServices;

namespace BinaryTreeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();
            bst.Add(50);
            bst.Add(54);
            bst.Add(58);
            bst.Add(20);
            bst.Add(23);
            bst.Add(23);
            bst.Add(19);
            bst.Add(2);
            bst.Add(101);

            Node searched = bst.Search(70);
            Console.WriteLine(searched);
            searched = bst.Search(23);
            Console.WriteLine(searched.data);
        }
    }
}
