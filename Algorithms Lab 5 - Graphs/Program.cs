using System;
using System.IO;

namespace Graphs
{
    static class Program
    {
        public static Graph ActiveGraph { get; set; }
        static void Main(string[] args)
        {
            Screen.Setup();

            //Graph graph = Graph.FromCSV(File.ReadAllLines(@"test2.csv"), '\t');
            //GraphVisualizationData data = new GraphVisualizationData(graph)
            //    .WithHighlightedEdges(graph.Edges[2])
            //    .WithHighlightedVertexes(graph.Vertexes[0], graph.Vertexes[^1]);
            //Visualizer.CreateBitmaps(data);
            //graph.SaveJSON("test2.json");
            //graph.SaveCSV(@"graph1.csv");
            //graph.SaveJSON(@"graph1.json");
        }
    }
}
