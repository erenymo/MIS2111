using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace binaryTree
{
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> root; // root node of the binary tree

        // creates a new binary tree which the root is null.
        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(T data)
        {
            this.root = Insert(root, data);
        }
        
        // Adding new node's into the binary tree
        private Node<T> Insert(Node<T> current, T data)
        {
            if (current == null)
            {
                return new Node<T>(data);
            }

            if (data.CompareTo(current.Data) < 0) // if data is less than currentData, CompareTo returns negative value
            {
                current.Left = Insert(current.Left, data);
            } 
            else if (data.CompareTo(current.Data) > 0) // if data is greater than currentData,  CompareTo returns positive value
            {
                current.Right = Insert(current.Right, data);
            }

            return current;
        }

        // In Order Traversal
        public void SortLeftToRight()
        {
            SortLeftToRight(this.root);
        }

        private void SortLeftToRight(Node<T> current)
        {
            if (current != null)
            {
                SortLeftToRight(current.Left); // moves left until the current node is null.
                Console.Write(current.Data + ", ");
                SortLeftToRight(current.Right); // moves to next right node
            }
        }

        public void SortRightToLeft()
        {
            SortRightToLeft(this.root);
        }

        // Reverse Order Traversal
        private void SortRightToLeft(Node<T> current)
        {
            if (current != null)
            {
                SortRightToLeft(current.Right); // moves right until the current node is null.
                Console.Write(current.Data + ", ");
                SortRightToLeft(current.Left); // moves to next left node
            }
        }
    }
}
