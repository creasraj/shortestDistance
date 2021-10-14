using System;
using System.Collections.Generic;

namespace creas.src
{
    public interface IRoute
    {
        void AddNode(Edge edge);
        Result GetShortestPath(char source, char destination);
    }
}
