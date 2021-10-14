using System;
using System.Collections.Generic;

namespace creas.src
{
    public class Station
    {
        public Station()
        {
            stations = new List<Edge>();
        }

        private IList<Edge> stations;

        public void AddEdge(Edge edge)
        {
            this.stations.Add(edge);
        }

        public IList<Edge> GetEdges()
        {
            return stations;
        }
    }
}
