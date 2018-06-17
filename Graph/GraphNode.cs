using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class GraphNode
    {
        public bool isVisited;
        public string label;

        public GraphNode(bool isVisited, string label)
        {
            this.isVisited = isVisited;
            this.label = label;
        }
    }
}
