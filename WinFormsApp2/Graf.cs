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
            start = edge.start;
            Vertices.Add(edge.start);
            Vertices.Add(edge.end);
            Edges.Add(edge);
        }
        int NewVerticesCount(Edge edge)
        {
            int firstVertex = edge.start.data;
            int lastVertex = edge.end.data;
            int count = 2;
            
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].data == firstVertex)
                {
                    count--;
                }
                if (Vertices[i].data == lastVertex)
                {
                    count--;
                }
            }
            return count;
        }
        void Add(Edge edge)
        {
            int newVerticesCount = 2;
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].data == firstVertex)
                {
                    newVerticesCount--;
                }
                if (Vertices[i].data == lastVertex)
                {
                    newVerticesCount--;
                }
            }
            for (int i = 0; i < Grafs.Count; i++)
            {
                for(int j = 0; j < Grafs[i].Vertices.Count; j++)
                {
                    if (Grafs[i].Vertices[j].data == edge.start.data || Grafs[i].Vertices[j].data == edge.end.data)
                    {
                        newVerticesCount--;
                    }
                }
            }

            if(newVerticesCount == 2)
            {
                Graf graf = new Graf(edge);
                Grafs.Add(graf);
                return;
            }
            if(newVerticesCount == 1)
            {
                for(int i = 0; i < Vertices.Count; ++i)
                {
                    if (Vertices[i].data == edge.start.data)
                    {
                        Edges.Add(edge);
                        Vertices.Add(edge.end);
                        return;
                    }
                    if (Vertices[i].data == edge.end.data)
                    {
                        Edges.Add(edge);
                        Vertices.Add(edge.start);
                        return;
                    }
                }
                for (int i = 0; i < Grafs.Count; i++)
                {
                    for (int j = 0; j < Grafs[i].Vertices.Count; j++)
                    {
                        if (Grafs[i].Vertices[j].data == edge.start.data)
                        {
                            Grafs[i].Edges.Add(edge);
                            Grafs[i].Vertices.Add(edge.end);
                            return;
                        }
                        if (Grafs[i].Vertices[j].data == edge.end.data)
                        {
                            Grafs[i].Edges.Add(edge);
                            Grafs[i].Vertices.Add(edge.start);
                            return;
                        }
                    }
                }
            }
            if(newVerticesCount == 0)
            {
                if (NewVerticesCount(edge) == 0) return;
                for(int i = 0; i < Grafs.Count; i++)
                {
                    if (Grafs[i].NewVerticesCount(edge) == 0) return;
                }

                if (NewVerticesCount(edge) == 1)
                {
                    int grafToJoinId = 0;
                    for (int i = 0; i < Grafs.Count; i++)
                    {
                        if (Grafs[i].NewVerticesCount(edge) == 1) grafToJoinId = i;
                    }
                    Join(Grafs[i]);
                    return;
                }

                Graf firstGrafToJoin;
                Graf secondGrafToJoin;
                for (int i = 0; i < Grafs.Count; i++)
                {
                    if (Grafs[i].NewVerticesCount(edge) == 1 && firstGrafToJoin == null)
                    {
                        firstGrafToJoin = Grafs[i];
                    }
                    else if(Grafs[i].NewVerticesCount(edge) == 1)
                    {
                        secondGrafToJoin = Grafs[i];
                        Grafs.Remove(i);
                    }
                }
                firstGrafToJoin.Edges.Add(edge);
                firstGrafToJoin.Join(secondGrafToJoin);
            }
        }
        void Join(Graf graf)
        {
            // Join 2 grafs when adding an edge across different grafs
            for(int i = 0; i < graf.Edges.Count; i++)
            {
                Edges.Add(graf.Edges[i]);
            }
            for (int i = 0; i < graf.Vertices.Count; i++)
            {
                Vertices.Add(graf.Vertices[i]);
            }
        }
    }
}
