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
            //Node node1 = new Node(60);
            //Node node2 = new Node(10);
            //Node node3 = new Node(30);
            //Node node4 = new Node(80);
            //Node node5 = new Node(40);
            //Node node6 = new Node(70);
            //Node node7 = new Node(50);
            //Node node8 = new Node(20);
            binarySearchTree.AddNode(60);
            binarySearchTree.AddNode(10);
            binarySearchTree.AddNode(30);
            binarySearchTree.AddNode(80);
            binarySearchTree.AddNode(40);
            binarySearchTree.AddNode(70);
            binarySearchTree.AddNode(50);
            binarySearchTree.AddNode(20);

           
            
            Console.ReadLine();
        }
    }
}
