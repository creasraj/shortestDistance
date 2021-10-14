using creas.src;
using NUnit.Framework;
namespace creas.tests
{
    [TestFixture()]
    public class ShortestTime
    {
        



        [Test()]
        public void IndirectPath()
        {
            ShortestRoute shortestRoute = new ShortestRoute();
            // Arrange
            shortestRoute.AddNode(new Edge("A", "B", 10));
           shortestRoute.AddNode(new Edge("B", "C", 20));

            //Act
            Result result = shortestRoute.GetShortestPath('A', 'C');


            //Assert
            Assert.AreEqual(result.Distance, 30);
            Assert.AreEqual(result.FinalStops, 1);
        
        }

        [Test()]
        public void DirectPath()
        {
            ShortestRoute shortestRoute = new ShortestRoute();
            // Arrange
            shortestRoute.AddNode(new Edge("A", "B", 10));
            shortestRoute.AddNode(new Edge("B", "C", 20));

            //Act
            Result result = shortestRoute.GetShortestPath('A', 'B');


            //Assert
            Assert.AreEqual(result.Distance, 10);
            Assert.AreEqual(result.FinalStops, 0);

        }

        [Test()]
        public void InValidPath()
        {
            ShortestRoute shortestRoute = new ShortestRoute();
            // Arrange
            shortestRoute.AddNode(new Edge("A", "B", 10));
            shortestRoute.AddNode(new Edge("B", "C", 20));

            //Act
            Result result = shortestRoute.GetShortestPath('A', 'D');


            //Assert
            Assert.AreEqual(result.Distance, int.MaxValue);
            Assert.AreEqual(result.FinalStops, 0);

        }
    }
}
