using System;
using System.IO;
using System.Reflection;
using creas.src;

namespace creas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ShortestRoute shortestRoute = new ShortestRoute();
            try
            {
                string path = Path.Combine("../../data/" + args[0]);
                string[] lines = System.IO.File.ReadAllLines(path);
                Console.WriteLine("File Path : " + path);
                Console.WriteLine("Processing file...");
                foreach(string line in lines)
                {
                    string source = line.Split(',')[0];
                    string destination = line.Split(',')[1];
                    string distance = line.Split(',')[2];

                    Edge edge = new Edge();
                    edge.Destination = destination;
                    edge.Distance =  Convert.ToInt32(distance);
                    edge.Source = source;
                    shortestRoute.AddNode(edge);
                }
                

                while (true)
                {
                    Console.WriteLine("What station are you getting on the train?");
                    string source = Console.ReadLine();
                    Console.WriteLine("What station are you getting off the train?");
                    string destination = Console.ReadLine();
                    if (source.Trim() == string.Empty || destination.Trim() == string.Empty)
                    {
                      Console.WriteLine("Invalid input");
                    }
                    else
                    {
                      Result result = shortestRoute.GetShortestPath(source[0], destination[0]);
                        if (result.Distance == int.MaxValue)
                        {
                            Console.WriteLine("No routes from " + source + " to " + destination);
                        }
                        else
                        {
                            Console.WriteLine("Your trip from " + source + " to " + destination + " includes " + result.FinalStops +
                                " stops and will take " + result.Distance + " minutes");
                        }
                    }
                    Console.WriteLine("Do you want to continue? Press Y to continue or Press Q to exit");
                    char ch = (char)Console.Read();
                    if (ch == 'Q')
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine();
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
