using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312POE
{
    public class GFG : IComparer<DeweyDecimalTreeNode>
    {
        public int Compare(DeweyDecimalTreeNode x, DeweyDecimalTreeNode y)
        {
            if (x == null || y == null)
            {
                return 0;
            }
            return x.getCallNumber().CompareTo(y.getCallNumber());
        }

    }
}
