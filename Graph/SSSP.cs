using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class SSSP
    {
        public static int[] SSSPBFS(string source, GraphDS graph)
        {
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(graph.vertices[graph.GetIndexOfVertex(source)]);
            int[] distance = new int[graph.vertices.Length];
            distance[graph.GetIndexOfVertex(graph.vertices[graph.GetIndexOfVertex(source)].label)] = 0;
            while (q.Count > 0)
            {
                GraphNode current = q.Dequeue();
                current.isVisited = true;
                GraphNode[] adjNodes = graph.GetAdjacentVertex(current.label);
                foreach (var node in adjNodes)
                {
                    if (!node.isVisited)
                    {
                        q.Enqueue(node);
                        node.isVisited = true;
                        distance[graph.GetIndexOfVertex(node.label)] = distance[graph.GetIndexOfVertex(current.label)] + 1;
                    }
                }
            }
            return distance;
        }
    }
}
