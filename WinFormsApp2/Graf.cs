using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Graf
    {
        GNode start = new GNode();
        List<GNode> Vertices = new List<GNode>();
        void AddVertex(int data)
        {
            Boolean found = false;
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].data == data)
                {
                    found = true;
                }
            }
            if(found)
            {
                return;
            }

            GNode node = new GNode();
            node.data = data;
            Vertices.Add(node);
        }
        void AddEdge(int data1, int data2)
        {
            GNode node1 = null;
            GNode node2 = null;
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].data == data1) node1 = Vertices[i];
                if (Vertices[i].data == data2) node2 = Vertices[i];
            }
            if (node1 == null || node2 == null) return;

            for (int i = 0; i < node1.neigbors.Count; i++)
            {

            }
        }

    }
}
