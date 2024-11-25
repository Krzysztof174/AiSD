using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Graf
    {
        GNode start = new GNode();
        List<GNode> Vertices = new List<GNode>();
        List<Edge> Edges = new List<Edge>();
        List<Graf> Grafs = new List<Graf>();
        Graf(Edge edge)
        {
            Vertices.Add(edge.start);
            Vertices.Add(edge.end);
            Edges.Add(edge);
        }
        int NewVerticesCount(Edge edge)
        {
            int firstVertex = edge.start.data;
            int lastVertex = edge.end.data;
            int found = 0;
            
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].data == firstVertex)
                {
                    found++;
                }
                if (Vertices[i].data == lastVertex)
                {
                    found++;
                }
            }
            return found;
        }
        void Add(Edge edge)
        {
            int newVerticesCount = NewVerticesCount(edge);
            if(newVerticesCount == 2)
            {
                Graf graf = new Graf(edge);
                Grafs.Add(graf);
                return;
            }
            if(newVerticesCount == 1)
            {
                Edges.Add(edge);
                Boolean foundStart = false;
                for(int i = 0; i < Vertices.Count; i++)
                {
                    if (Vertices[i].data == edge.start.data) foundStart = true;
                }
                if(foundStart)
                {
                    Vertices.Add(edge.end);
                    return;
                }
                Vertices.Add(edge.start);
            }
        }
        void Join(Graf graf)
        {
            for(int i = 0; i < graf.Edges.Count; i++)
            {
                Add(graf.Edges[i]);
            }
        }

    }
}
