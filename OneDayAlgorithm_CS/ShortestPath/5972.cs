// StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
// StreamReader sr = new StreamReader(Console.OpenStandardInput());
//
// var input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
// int[] cost = new int[input[0]+1];
// bool[] check = new bool[input[0]+1];
// List<Tuple<int, int>>[] graph = new List<Tuple<int, int>>[input[0]+1];
// PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
//
// Array.Fill(cost,50000001);
//
// for (int i = 0; i < input[0] + 1; i++)
// {
//     graph[i] = new List<Tuple<int, int>>();
// }
//
// for (int i = 0; i < input[1]; i++)
// {
//     var edge = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
//     graph[edge[0]].Add(new Tuple<int, int>(edge[1], edge[2]));
//     graph[edge[1]].Add(new Tuple<int, int>(edge[0], edge[2]));
// }
//
// cost[1] = 0;
// priorityQueue.Enqueue(1,0);
//
// while (priorityQueue.Count > 0)
// {
//     priorityQueue.TryDequeue(out int element, out int priority);
//
//     if (check[element])
//     {
//         continue;
//     }
//
//     check[element] = true;
//
//     for (int i = 0; i < graph[element].Count; i++)
//     {
//         var next = graph[element][i].Item1;
//         var nextCost = graph[element][i].Item2;
//         if (priority + nextCost < cost[next])
//         {
//             cost[next] = priority + nextCost;
//             priorityQueue.Enqueue(next,cost[next]);
//         }
//     }
// }
//
// sw.Write(cost[input[0]]);
// sw.Flush();
// sw.Close();