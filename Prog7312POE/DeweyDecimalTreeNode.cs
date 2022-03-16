using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312POE
{
    public class DeweyDecimalTreeNode
    {
        private DeweyDecimal deweyDecimal;
        private DeweyDecimalTreeNode parent;
        private List<DeweyDecimalTreeNode> children;
        public DeweyDecimalTreeNode() {
            this.deweyDecimal = null;
            this.parent = null;
            this.children = new List<DeweyDecimalTreeNode>();

        }
        public DeweyDecimalTreeNode(DeweyDecimal deweyDecimal)
        {
            this.deweyDecimal = deweyDecimal;
            this.parent = null;
            this.children = new List<DeweyDecimalTreeNode>();
        }
        public DeweyDecimalTreeNode(DeweyDecimal deweyDecimal, DeweyDecimalTreeNode parent)
        {
            this.deweyDecimal = deweyDecimal;
            this.parent = parent;
            this.children = new List<DeweyDecimalTreeNode>();
        }

        public int getNodeCallNumber()
        {
            return Int32.Parse(this.deweyDecimal.getCallNumber());
        }

        public void addChild(DeweyDecimal node)
        {
            DeweyDecimalTreeNode child = new DeweyDecimalTreeNode(node, this);
            int callNumber = Int32.Parse(node.getCallNumber());
            int pos = 0;
            foreach (DeweyDecimalTreeNode treenode in this.children)
            {
                if (callNumber > treenode.getNodeCallNumber())
                {
                    pos++;
                }
            }
            children.Insert(pos, child);
        }

        public void addChildrenChild(DeweyDecimal node)
        {
            int callNumber = Int32.Parse(node.getCallNumber().Substring(0, 2) + "0");
            foreach (DeweyDecimalTreeNode treenode in this.children)
            {
                if (callNumber == treenode.getNodeCallNumber())
                {
                    treenode.addChild(node);
                    break;
                }
            }

        }
        public DeweyDecimalTreeNode getRandomChild(Random rnd)
        {
            int child = rnd.Next(this.children.Count);
            return this.children.ElementAt<DeweyDecimalTreeNode>(child);
        }
        public int getChildrenCount() {
            return this.children.Count;
        }
        public DeweyDecimalTreeNode getParent() {
            return this.parent;
        }
        public string fullToString()
        {
            return this.deweyDecimal.getCallNumber() + "\t" + this.deweyDecimal.getDefinition();
        }
        public string toString()
        {
            return this.deweyDecimal.getDefinition();
        }
        public List<int> getRandomChildren(Random rnd)
        {
            var randomChildren = Enumerable.Range(0, this.children.Count).OrderBy(x => rnd.Next()).Take(this.children.Count).ToList();
            return randomChildren;
        }
        public DeweyDecimalTreeNode getChild(int pos)
        {
            return this.children.ElementAt<DeweyDecimalTreeNode>(pos);
        }
        public int getCallNumber() 
        {
            return Int32.Parse(this.deweyDecimal.getCallNumber());
        }

        //752 - node
        //700 - parent
        //700 710 720 730 740 750 760 770
        //701 702 703 704 705 706 707
        //751 752

        public bool isChild(DeweyDecimalTreeNode node)
        {
            if (this.getCallNumber() == node.getCallNumber())
            {
                return true;
            }
            foreach(DeweyDecimalTreeNode treenode in this.children)
            {
                if (treenode.getCallNumber() == node.getCallNumber())
                {
                    return true;
                }
                else
                {
                   if (treenode.isChild(node))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public DeweyDecimalTreeNode findClosestChild(DeweyDecimalTreeNode node)
        {
            foreach(DeweyDecimalTreeNode treenode in this.children)
            {
                if (treenode.isChild(node))
                {
                    return treenode;
                }
            }

            return null;
        }
    }
}
