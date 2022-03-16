using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Prog7312POE
{
    public class DeweyDecimalTree
    {
        private List<DeweyDecimalTreeNode> nodes;
        public DeweyDecimalTree()
        {
            this.nodes = new List<DeweyDecimalTreeNode>();

        }
        public void addNode(DeweyDecimal node) 
        {
            //determine at which layer to put the node
            int callNumber = Int32.Parse(node.getCallNumber());
            //100  110  111
            //0     10   11
            //200  210  223
            //0     10   23
            //000 100 200 300 400 500


            //        500
            //500 510 520 530 540 550 560
            //501 502 503 .... 509, 511 512 513 514 55, 521 522 523 524

            //100 - OK
            //110 - OK
            //111 - OK
            //101 - 109
            //100 200 300 400 500 600 700 800 900

            if (callNumber % 100 == 0)
            {
                //We know this is a tier 1 node
                int pos = 0;
                foreach (DeweyDecimalTreeNode treenode in nodes)
                {
                    if (callNumber > treenode.getNodeCallNumber())
                    {
                        pos++;
                    }
                }

                DeweyDecimalTreeNode newNode = new DeweyDecimalTreeNode(node);
                newNode.addChild(node);
                this.nodes.Insert(pos, newNode);

            }
            else if (callNumber % 10 == 0)
            {
                //We know that this is a tier 2 node
                int newCallnumber = Int32.Parse(node.getCallNumber().Substring(0, 1) + "00");
                foreach (DeweyDecimalTreeNode treenode in nodes)
                {
                    if (newCallnumber == treenode.getNodeCallNumber())
                    {
                        treenode.addChild(node);
                    }
                }
            }
            else
            {
                //We know that this is a tier 3 node                
                int newCallnumber = Int32.Parse(node.getCallNumber().Substring(0, 1) + "00");
                foreach (DeweyDecimalTreeNode treenode in nodes)
                {
                    if (newCallnumber == treenode.getNodeCallNumber())
                    {
                        treenode.addChildrenChild(node);
                    }
                }
            }
        }

        public DeweyDecimalTreeNode getRandomChild(Random rnd) 
        {
            
            int child = rnd.Next(nodes.Count);
            return nodes.ElementAt<DeweyDecimalTreeNode>(child);   
        }

        public List<int> getRandomChildren(Random rnd)
        {
            var randomChildren = Enumerable.Range(0, this.nodes.Count).OrderBy(x => rnd.Next()).Take(this.nodes.Count).ToList();
            return randomChildren;
        }
        public DeweyDecimalTreeNode getChild(int pos)
        {
            return this.nodes.ElementAt<DeweyDecimalTreeNode>(pos);
        }
    }
}
