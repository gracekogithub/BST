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
        public BST()
        {
            RootNode = null;
        }
        public void AddNode(int value)
        {
            Node currentNode = new Node();
            currentNode.Data = value;

            if (RootNode == null)
            {
                RootNode = currentNode;
            }
            else
            {
                Node CurrentNode = RootNode;
               
            }
            while (RootNode != null)
            {
                if (value > RootNode.Data)
                {
                    currentNode = currentNode.LeftNode;
                    break;
                }
                if(value < RootNode.Data)
                {
                    currentNode = RootNode.RightNode;
                    break;

                }
            }
        
        }

        public int SearchNode(int[] array, int dataToFind)
        {
            int left = 0;
            int right = array.Length - 1;
            while(left <= right)
            {
                var mid = (left + right) / 2;
                if (array [mid] == dataToFind)
                {
                    dataToFind = mid;
                }
                if (dataToFind < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
             
            }
            return -1;
            
        }
        
    }
}
