using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public static class Algos
    {
        public static void DepthTraversal(Graph graph)
        {
            List<Vertex> vertex = new List<Vertex>();
            List<EdgeData> bridges = new List<EdgeData>();
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(graph.Vertexes[0]);
            //?
            GraphVisualizationData data = new GraphVisualizationData(graph);

            Visualizer.CreateBitmaps(data);
            Visualizer.AddLog("Кладём в стек первую же вершину");

            while (stack.Count != 0)
            {
                var point = stack.Pop();
                Visualizer.AddLog("Достаём из стека вершину " + (point.Number+1).ToString());

                if (!vertex.Contains(point))
                {
                    Visualizer.AddLog("Эту вершину ещё не посещали");
                    vertex.Add(point);
                }

                foreach (var edge in point.Edges)
                {
                    if (!vertex.Contains(edge.DestinationVertex))
                    {
                        Visualizer.AddLog("Находим вершину-соседа " + (edge.DestinationVertex.Number+1).ToString()
                                            + " и кладём в стек");
                        stack.Push(edge.DestinationVertex);
                        bridges.Add(edge.EdgeDataObject);
                    }
                }
            }
        }

        public static void BreadthTraversal(Graph graph)
        {
            List<Vertex> vertex = new List<Vertex>();
            var queue = new Queue<Vertex>();
            queue.Enqueue(graph.Vertexes[0]);
            while (queue.Count != 0)
            {
                var point = queue.Dequeue();
                if (!vertex.Contains(point))
                {
                    vertex.Add(point);
                }
                foreach (var edge in point.Edges)
                {
                    if (!vertex.Contains(edge.DestinationVertex))
                    {

                        queue.Enqueue(edge.DestinationVertex);
                    }
                }

            }
        }

        public static void FordFalkerson(GraphVisualizationData graph)
        {
            Vertex source = graph.RawGraph.Vertexes[0];
            Vertex sink = graph.RawGraph.Vertexes[graph.RawGraph.Vertexes.Count-1];

        }


    }
}
