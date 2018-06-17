using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class BellmanFord
    {
        static int[] distnace;

        public static int[] BellmanFordShortPath(string source, GraphDS graph)
        {
            distnace = new int[graph.numberOfVertices];

            for (int i = 0; i < graph.numberOfVertices; i++)
            {
                distnace[i] = Int32.MaxValue;
            }
            distnace[graph.GetIndexOfVertex(source)] = 0;

            for (int i = 0; i < graph.numberOfVertices; i++)
            {
                foreach (var edge in graph.edges)
                {
                    string start = edge.source;
                    string destination = edge.destination;
                    int cost = edge.cost;

                    if (distnace[graph.GetIndexOfVertex(destination)] > distnace[graph.GetIndexOfVertex(start)] + cost)
                    {
                        distnace[graph.GetIndexOfVertex(destination)] = distnace[graph.GetIndexOfVertex(start)] + cost;
                    }
                }
            }
            foreach (var edge in graph.edges)
            {
                string start = edge.source;
                string destination = edge.destination;
                int cost = edge.cost;

                if (distnace[graph.GetIndexOfVertex(destination)] > distnace[graph.GetIndexOfVertex(start)] + cost)
                {
                    Console.WriteLine("Negative cycle found");
                    break;
                }
            }
            return distnace;
        }

    }
}
