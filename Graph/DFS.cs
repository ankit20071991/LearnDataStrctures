using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class DFS
    {
        public static void DepthFirstSearch(string source, GraphDS graph)
        {

            Console.WriteLine(source);

            graph.vertices[graph.GetIndexOfVertex(source)].isVisited = true;

            GraphNode[] adjNodes = graph.GetAdjacentVertex(source);

            foreach (var node in adjNodes)
            {
                if (!node.isVisited)
                    DepthFirstSearch(node.label, graph);
            }
        }
    }
}
