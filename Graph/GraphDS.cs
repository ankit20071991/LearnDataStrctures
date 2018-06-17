using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class GraphDS
    {
        public int numberOfVertices;

        public List<Edge> edges;

        public GraphNode[] vertices;

        public int[,] adjMatrix;

        public int currentNumOfVertex = 0;

        public GraphDS(int numberOfVertices)
        {
            this.numberOfVertices = numberOfVertices;
            vertices = new GraphNode[numberOfVertices];
            adjMatrix = new int[numberOfVertices, numberOfVertices];
            edges = new List<Edge>();

            for (int i = 0; i < numberOfVertices; i++)
            {
                for (int j = 0; j < numberOfVertices; j++)
                {
                    adjMatrix[i, j] = 99999;
                }
            }
        }

        public void AddVertex(GraphNode vertex)
        {
            if (currentNumOfVertex == numberOfVertices)
            {
                return;
            }
            vertices[currentNumOfVertex] = vertex;
            currentNumOfVertex++;
        }

        public void AddEdgeUndirected(string vertexStart, string vertexEnd, int distance)
        {
            int startIndex = GetIndexOfVertex(vertexStart);
            int endIndex = GetIndexOfVertex(vertexEnd);

            adjMatrix[startIndex, endIndex] = distance;
            adjMatrix[endIndex, startIndex] = distance;

            edges.Add(new Edge(vertexStart, vertexEnd, distance));
            edges.Add(new Edge(vertexEnd, vertexStart, distance));
        }

        public void AddEdgeDirected(string vertexStart, string vertexEnd, int distance)
        {
            int startIndex = GetIndexOfVertex(vertexStart);
            int endIndex = GetIndexOfVertex(vertexEnd);

            adjMatrix[startIndex, endIndex] = distance;
            edges.Add(new Edge(vertexStart, vertexEnd, distance));
        }

        public GraphNode[] GetAdjacentVertex(string vertexLabel)
        {
            int vertexIndex = GetIndexOfVertex(vertexLabel);
            List<GraphNode> adjNodes = new List<GraphNode>();

            for (int i = 0; i < numberOfVertices; i++)
            {
                if (adjMatrix[vertexIndex, i] != 99999)
                {
                    if (!adjNodes.Contains(vertices[i]))
                        adjNodes.Add(vertices[i]);
                }
            }

            return adjNodes.ToArray();
        }

        public int GetIndexOfVertex(string label)
        {
            int index = -1;
            if (!string.IsNullOrEmpty(label))
            {
                for (int i = 0; i < numberOfVertices; i++)
                {
                    if (vertices[i].label == label)
                        index = i;
                }
            }
            return index;
        }
    }
}
