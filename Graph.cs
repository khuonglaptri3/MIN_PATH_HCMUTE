using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIN_PATH_HCMUTE
{
    public  class Graph
    {
        public   Dictionary<string, List<(string, double)>> _adjacencyList;

        public Graph()
        {
            _adjacencyList = new Dictionary<string, List<(string, double)>>();
        }

        public void AddEdge(string u, string v, double weight)
        {
            if (!_adjacencyList.ContainsKey(u))
            {
                _adjacencyList[u] = new List<(string, double)>();
            }
            if (!_adjacencyList.ContainsKey(v))
            {
                _adjacencyList[v] = new List<(string, double)>();
            }
            _adjacencyList[u].Add((v, weight));
            _adjacencyList[v].Add((u, weight)); 
        }

        public List<string> Dijkstra(string start, string target)
        {
            var distances = new Dictionary<string, double>();
            var previousNodes = new Dictionary<string, string>();
            var priorityQueue = new SortedSet<(double, string)>();

            foreach (var node in _adjacencyList)
            {
                distances[node.Key] = double.PositiveInfinity;
            }
            distances[start] = 0;
            priorityQueue.Add((0, start));

            while (priorityQueue.Count > 0)
            {
                var (currentDistance, currentNode) = priorityQueue.Min;
                priorityQueue.Remove(priorityQueue.Min);

                if (currentNode == target) break;
                foreach (var (nextNode, weight) in _adjacencyList[currentNode])
                {
                    double newDistance = currentDistance + weight;
                    if (newDistance < distances[nextNode])
                    {
                        priorityQueue.Remove((distances[nextNode], nextNode));
                        distances[nextNode] = newDistance;
                        previousNodes[nextNode] = currentNode;
                        priorityQueue.Add((newDistance, nextNode));
                    }
                }
            }

            var path = new List<string>();
            for (var at = target; at != null; at = previousNodes.ContainsKey(at) ? previousNodes[at] : null)
            {
                path.Add(at);
                if (at == start) break;
            }
            path.Reverse();

            if (path.Count == 1 && path[0] != start)
            {
                path.Clear();
            }
            return path;
        }
    }
}
