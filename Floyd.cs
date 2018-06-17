using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class Floyd
    {
        public static int[,] FloydAlgo(GraphDS graph)
        {
            int v = graph.numberOfVertices;

            for (int j = 0; j < v; j++)
            {
                for (int k = 0; k < v; k++)
                {
                    if (k == j)
                    {
                        graph.adjMatrix[j, k] = 0;
                    }
                }
            }

            for (int k = 0; k < v; k++)
            {
                for (int i = 0; i < v; i++)
                {
                    for (int j = 0; j < v; j++)
                    {
                        if (graph.adjMatrix[i, j] > graph.adjMatrix[i, k] + graph.adjMatrix[k, j])
                        {
                            graph.adjMatrix[i, j] = graph.adjMatrix[i, k] + graph.adjMatrix[k, j];
                        }
                    }
                }
            }
            return graph.adjMatrix;
        }
    }
}
