using System;
namespace creas.src
{
    public class Edge
    {
        public Edge()
        {
        }

        public Edge(string source, string destination, int distance)
        {
            this.source = source;
            this.destination = destination;
            this.distance = distance;
        }

        private string source;
        private string destination;
        private int distance;

        public string Source
        {
            get
            {
                return this.source;
            }
            set
            {
                this.source = value;
            }
        }

        public string Destination
        {
            get
            {
                return this.destination;
            }
            set
            {
                this.destination = value;
            }
        }

        public int Distance
        {
            get
            {
                return this.distance;
            }
            set
            {
                this.distance = value;
            }
        }
    }
}
