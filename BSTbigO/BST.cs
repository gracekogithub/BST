using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTbigO
{
    class BST
    {
        public Node Root;

        public BST()
        {
            Root = null;
        }


        public void AddNode(Node nodeToAdd)
        {
            if (nodeToAdd !=null)
            {
                nodeToAdd = new Node(Root.Data);
            }
           
            if (nodeToAdd.Data > Root.Data)
            {
                Root.Right = nodeToAdd;
                AddNode(Root.Right);

            }
            else
            {
                Root.Left = nodeToAdd;
                AddNode(Root.Left);
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
