// int[] mn = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
// int[][] graph = new int[mn[1]][];
// bool[,] check = new bool[mn[1], mn[0]];
// int day = 0;
// Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
//
// for (int i = 0; i < mn[1]; i++)
// {
//     graph[i] = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
// }
//
// for (int i = 0; i < mn[1]; i++)
// {
//     for (int j = 0; j < mn[0]; j++)
//     {
//         if (graph[i][j] != 1)
//         {
//             continue;
//         }
//
//         check[i,j] = true;
//         queue.Enqueue(new Tuple<int, int>(i,j));
//     }
// }
//
// while (queue.Count > 0)
// {
//     int count = queue.Count;
//     day++;
//     for (int i = 0; i < count; i++)
//     {
//         var node = queue.Dequeue();
//         
//         //상
//         if (node.Item1 - 1 >= 0)
//         {
//             if (graph[node.Item1 - 1][node.Item2] == 0)
//             {
//                 graph[node.Item1 - 1][node.Item2] = 1;
//                 queue.Enqueue(new Tuple<int, int>(node.Item1 - 1,node.Item2));
//             }
//         }
//         //하
//         if (node.Item1 + 1 < mn[1])
//         {
//             if (graph[node.Item1 + 1][node.Item2] == 0)
//             {
//                 graph[node.Item1 + 1][node.Item2] = 1;
//                 queue.Enqueue(new Tuple<int, int>(node.Item1 + 1,node.Item2));
//             }
//         }
//         //좌
//         if (node.Item2 - 1 >= 0)
//         {
//             if (graph[node.Item1][node.Item2 - 1] == 0)
//             {
//                 graph[node.Item1][node.Item2 - 1] = 1;
//                 queue.Enqueue(new Tuple<int, int>(node.Item1,node.Item2 - 1));
//             }
//         }
//         //우
//         if (node.Item2 + 1 < mn[0])
//         {
//             if (graph[node.Item1][node.Item2 + 1] == 0)
//             {
//                 graph[node.Item1][node.Item2 + 1] = 1;
//                 queue.Enqueue(new Tuple<int, int>(node.Item1, node.Item2 + 1));
//             }
//         }
//     }
// }
//
// // 토마토가 다 익을 경우에도 반복문이 한번 더 돌아서 하루를 빼줘야 한다.
// day--;
//
// foreach (var row in graph)
// {
//     if (row.Any(x => x == 0))
//     {
//         day = -1;
//         break;
//     }
// }
//
// Console.Write(day);
//
