using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class BFS
    {
        public static void BreadthFirstSearch(string source, GraphDS graph)
        {
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(graph.vertices[graph.GetIndexOfVertex(source)]);

            while (q.Count > 0)
            {
                GraphNode temp = q.Dequeue();
                temp.isVisited = true;
                Console.WriteLine(temp.label);

                GraphNode[] adjNodes = graph.GetAdjacentVertex(temp.label);

                foreach (var node in adjNodes)
                {
                    if (!node.isVisited)
                        q.Enqueue(node);
                }
            }
        }
    }
}
