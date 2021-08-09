using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalInSpiralOrder
{
    class TraversalInSpiral
    {
       public void InSpiralOrder(Node root)
        {
            Stack<Node> S1 = new Stack<Node>();
            Stack<Node> S2 = new Stack<Node>();

            S1.Push(root);
            
            while (S1.Count != 0 || S2.Count != 0)
            {
                Console.WriteLine();
                while (S1.Count != 0)
                {
                    root = S1.Pop();
                    Console.Write(root.data + " , ");
                    
                    if (root.left != null)
                        S2.Push(root.left);
                    if (root.right != null)
                        S2.Push(root.right);

                }

                Console.WriteLine();

                while (S2.Count != 0)
                {
                    root = S2.Pop();
                    Console.Write(root.data + " , ");

                    
                    if (root.right != null)
                        S1.Push(root.right);
                    if (root.left != null)
                        S1.Push(root.left);

                }
            }

            

        }
    }
}
