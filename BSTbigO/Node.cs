using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTbigO
{
    class Node
    {
        public int Data;
        public Node RightNode;
        public Node LeftNode;

        public Node(int value)
        {
            Data = value;
            RightNode = new Node(value);
            LeftNode = new Node(value);
        }
        
    }
}
