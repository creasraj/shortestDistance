using System;
namespace creas.src
{
    public class Result
    {
        public Result()
        {
        }

        public Result(long distance, int stops)
        {
            this.distance = distance;
            this.stops = stops;
        }

        private long distance;
        private int stops;
        private int finalStops;

        public long Distance
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

        public int Stops
        {
            get
            {
                return this.stops;
            }
            set
            {
                this.stops = value;
            }
        }

        public int FinalStops
        {
            get
            {
                return this.finalStops;
            }
            set
            {
                this.finalStops = value;
            }
        }
    }
}
