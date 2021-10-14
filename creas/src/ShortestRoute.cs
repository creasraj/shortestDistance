using System;
using System.Collections.Generic;
namespace creas.src
{
    public class ShortestRoute : IRoute
    {
        private Station station;
        private int[,] adjMatrix;
        private int totalStops;
        private Dictionary<PairObject<int, int>, long> cache;

        public ShortestRoute()
        {
            station = new Station();
        }

        public void AddNode(Edge edge)
        {
            station.AddEdge(edge);
        }

        public Result GetShortestPath(char source, char destination)
        { 
            int totalCount = station.GetEdges().Count;
            this.adjMatrix = new int[26, 26];
            this.cache = new Dictionary<PairObject<int, int>, long>();
            this.totalStops = 0;

            foreach(Edge edge in station.GetEdges())
            {
                this.adjMatrix[edge.Source[0] - 'A', edge.Destination[0] -'A'] = edge.Distance;
            }

            Result calculated = findShortest(source-'A', destination-'A', totalCount, 0);
            calculated.FinalStops = this.totalStops == 0 ? this.totalStops : this.totalStops - 1;
            return calculated;
        }

        private Result findShortest(int src, int dst, int n, int stops)
        {

            // No need to go any further if the destination is reached    
            if (src == dst)
            {
                return new Result((long)0, stops);
            }

            PairObject<int, int> key = new PairObject<int, int>(src, stops);


            // If the result of this state is already cached, return it
            if (this.cache.ContainsKey(key))
            {
                return new Result(this.cache[key], stops);
            }

            // Recursive calls over all the neighbors
            long ans = int.MaxValue;
            for (int neighbor = 0; neighbor <= n; ++neighbor)
            {
                int weight = this.adjMatrix[src, neighbor];

                // 0 value means no edge
                if (weight > 0)
                {
                    var result = this.findShortest(neighbor, dst, n, stops + 1);
                    ans = Math.Min(ans, result.Distance + weight);

                    if (result.Distance == 0 && ans == result.Distance + weight)
                    {
                        this.totalStops = result.Stops;
                    }

                }
            }

            // Cache the result
            if (this.cache.ContainsKey(key))
            {
                this.cache[key] = ans;
            }
            else
            {
                this.cache.Add(key, ans);
            }

            return new Result(ans, stops);
        }
    }
}

