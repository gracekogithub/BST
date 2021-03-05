using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTbigO
{
    public class Node
    {
        public int Data;
        public Node RightNode;
        public Node LeftNode;

       
        public void Display()
        {
            Console.WriteLine(Data + " ");
        }
        
    }
}
