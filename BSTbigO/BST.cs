using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTbigO
{
    class BST
    {
        public Node RootNode;
        public Node ParentNode;

        public BST()
        {
            
        }


        public void AddNode(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                ParentNode = RootNode;
                RootNode = nodeToAdd;
            }
            while (RootNode != null)
            {
                Node childNode = RootNode;
                RootNode = childNode;
                if (nodeToAdd.Data > RootNode.Data)
                {
                    RootNode.Right = nodeToAdd;
                    ParentNode = RootNode.Right;
                    break;
                }
                else
                {
                    RootNode.Left = nodeToAdd;
                    ParentNode = RootNode.Left;
                    break;
                }
            }
            
        }

        public bool SearchNode(Node nodeToAdd, int dataToFind)
        {
        
            if (dataToFind < nodeToAdd.Data)
            {
                return SearchNode(nodeToAdd.Left, dataToFind);
            }
            else if (dataToFind > nodeToAdd.Data)
            {
                return SearchNode(nodeToAdd.Right, dataToFind);
            }
            else
            {
                return false;
            }
        }
        
    }
}
