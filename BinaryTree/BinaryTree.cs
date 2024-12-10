using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Add(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        private Node InsertRecursive(Node node, int value)
        {
            if (node == null)
                return new Node(value);

            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);
            else if (value > node.Value)
                node.Right = InsertRecursive(node.Right, value);

            return node;
        }

      
        public bool Search(int value)
        {
            return SearchRecursive(Root, value);
        }

        private bool SearchRecursive(Node node, int value)
        {
            if (node == null)
                return false;

            if (node.Value == value)
                return true;
            else if (value < node.Value)
                return SearchRecursive(node.Left, value);
            else
                return SearchRecursive(node.Right, value);
        }

        
        public void Eliminate(int valor)
        {
            Root = EliminateRecursive(Root, valor);
        }

        private Node EliminateRecursive(Node node, int value)
        {
            if (node == null)
                return node;

            if (value < node.Value)
                node.Left = EliminateRecursive(node.Left, value);
            else if (value > node.Value)
                node.Right = EliminateRecursive(node.Right, value);
            else
            {
               
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                node.Value = MinValue(node.Right);
                node.Right = EliminateRecursive(node.Right, node.Value);
            }
            return node;
        }

        private int MinValue(Node node)
        {
            int min = node.Value;
            while (node.Left != null)
            {
                min = node.Left.Value;
                node = node.Left;
            }
            return min;
        }
    }
}
