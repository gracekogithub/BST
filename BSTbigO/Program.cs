using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTbigO
{
    class Program
    {
        static void Main(string[] args)
        {
            BST binarySearchTree = new BST();
            Node node1 = new Node(60);
            Node node2 = new Node(10);
            Node node3 = new Node(30);
            Node node4 = new Node(80);
            Node node5 = new Node(40);
            Node node6 = new Node(70);
            Node node7 = new Node(50);
            Node node8 = new Node(20);
            binarySearchTree.AddNode(node1);
            binarySearchTree.AddNode(node2);
            binarySearchTree.AddNode(node3);
            binarySearchTree.AddNode(node4);
            binarySearchTree.AddNode(node5);
            binarySearchTree.AddNode(node6);
            binarySearchTree.AddNode(node7);
            binarySearchTree.AddNode(node8);

           
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
