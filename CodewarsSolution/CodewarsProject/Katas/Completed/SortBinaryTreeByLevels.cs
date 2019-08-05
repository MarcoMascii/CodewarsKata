using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsProject
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }

    public class SortBinaryTreeByLevels
    {
        public static List<int> TreeByLevels(Node node)
        {
            Queue<Node> fifo = new Queue<Node>();
            List<int> values = new List<int>();
            fifo.Enqueue(node);

            while (fifo.Count() != 0)
            {
                Node dequeued = fifo.Dequeue();
                values.Add(dequeued.Value);
                if (dequeued.Left != null)
                {
                    fifo.Enqueue(dequeued.Left);
                }

                if (dequeued.Right != null)
                {
                    fifo.Enqueue(dequeued.Right);
                }
            }
            return values;

        }
    }


}
    