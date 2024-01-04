using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTree
{
    internal class Node<T> where T : IComparable<T>
    {
        private T data; // value that the node keeps.
        public T Data { 
            get { return data; }
            set { data = value; }   
        }

        private Node<T> left; // references left child of the current node
        public Node<T> Left
        {
            get { return left; }
            set { left = value; }
        }
        
        private Node<T> right; // references right child of the current node
        public Node<T> Right
        {
            get { return right; }
            set { right = value; }
        }

        public Node(T data)
        {
            this.Data = data;
            Left = Right = null;
        }
    }
}
