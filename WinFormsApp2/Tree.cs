using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Tree
    {
        public TNode root;

        public void Insert(int data)
        {
            if (root == null)
            {
                root = new TNode();
                root.data = data;
                return;
            }

            TNode node = root;
            while (node != null)
            {
                if(node.data >= data)
                {
                    if (node.leftChild == null)
                    {
                        node.leftChild = new TNode();
                        node.leftChild.data = data;
                        return;
                    }
                    node = node.leftChild;
                }
                if (node.data < data)
                {
                    if (node.rightChild == null)
                    {
                        node.rightChild = new TNode();
                        node.rightChild.data = data;
                        return;
                    }
                    node = node.rightChild;
                }

            }
        }
        public void Remove(int data)
        {
            if (root == null)
            {
                return;
            }
            TNode node = root;
            TNode parentNode = root;
            while (node != null)
            {
                if (node.data != data) 
                {
                    parentNode = node;
                    if (node.data >= data)
                    {
                        node = node.leftChild;
                        continue;
                    }
                    if (node.data < data)
                    {
                        node = node.rightChild;
                        continue;
                    }
                }
                break;
            }
            if (node == null) return;
            
            if (node.leftChild == null && node.rightChild == null)
            {
                if(root.data == data)
                {
                    root = null;
                }

                if (parentNode.data >= data)
                {
                    parentNode.leftChild = null;
                }
                else
                {
                    parentNode.rightChild = null;
                }
                return;
            }
            if(node.leftChild == null && node.rightChild != null)
            {
                if (root.data == data)
                {
                    root.data = root.rightChild.data;
                    root.leftChild = root.rightChild.leftChild;
                    root.rightChild = root.rightChild.rightChild;
                    return;
                }

                if (parentNode.data >= data)
                {
                    parentNode.leftChild = node.rightChild;
                }
                else
                {
                    parentNode.rightChild = node.rightChild;
                }
                return;
            }
            if(node.leftChild != null && node.rightChild == null)
            {
                if (root.data == data)
                {
                    root.data = root.leftChild.data;
                    root.rightChild = root.leftChild.rightChild;
                    root.leftChild = root.leftChild.leftChild;
                    return;
                }

                if (parentNode.data >= data)
                {
                    parentNode.leftChild = node.leftChild;
                }
                else
                {
                    parentNode.rightChild = node.leftChild;
                }
                return;
            }

            TNode smallestRightChild = node.rightChild;
            TNode smallestRightChildParent = node;
            if(smallestRightChild.leftChild == null)
            {
                node.data = smallestRightChild.data;
                node.rightChild = node.rightChild.rightChild;
                return;
            }
            while (smallestRightChild.leftChild != null)
            {
                smallestRightChildParent = smallestRightChild;
                smallestRightChild = smallestRightChild.leftChild;
            }
            node.data = smallestRightChild.data;
            smallestRightChildParent.leftChild = smallestRightChild.rightChild;
        }
        public string TreeToString(TNode node)
        {
            if (root == null) return "";
            string concat = "";
            
            if (node.leftChild != null)
            {
                concat += TreeToString(node.leftChild);
            }
            concat += node.data + " ";
            if (node.rightChild != null)
            {
                concat += TreeToString(node.rightChild);
            }

            return concat;
        }
    }
}
