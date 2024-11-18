using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class GNode
    {
        public List<GNode> neighbors = new List<GNode>();
        public int data;
    }
}
