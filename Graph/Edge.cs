using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class Edge
    {
        public string source;
        public string destination;
        public int cost;

        public Edge(string source, string destination, int cost)
        {
            this.source = source;
            this.destination = destination;
            this.cost = cost;
        }
    }
}
