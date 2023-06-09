// int N = int.Parse(Console.ReadLine());
// int[] population = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
// List<int>[] graph = new List<int>[N+1];
// bool[] check = new bool[N + 1];
// int redPopulation = 0;
// int bluePopulation = 0;
// int min = 1000;
// check[0] = true;
//
// for (int i = 0; i < N + 1; i++)
// {
//     graph[i] = new List<int>();
// }
//
// for (int i = 1; i <= N; i++)
// {
//     int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//     for (int j = 1; j <= input[0]; j++)
//     {
//         graph[i].Add(input[j]);
//     }
// }
//
// for (int i = 1; i <= N; i++)
// {
//     DfsRed(i);
// }
//
// if (min != 1000)
// {
//     Console.WriteLine(min);
// }
// else
// {
//     Console.WriteLine(-1);
// }
//
// void DfsRed(int start)
// {
//     bool[] temp = new bool[N + 1];
//     
//     if (check[start])
//     {
//         return;
//     }
//
//     redPopulation += population[start-1];
//     check[start] = true;
//     for (int i = 0; i < N+1; i++)
//     {
//         temp[i] = check[i];
//     }
//     
//     for (int i = 1; i <= N; i++)
//     {
//         if (!check[i])
//         {
//             DfsBlue(i);
//             break;
//         }
//     }
//
//     bluePopulation = 0;
//     for (int i = 0; i < N+1; i++)
//     {
//         check[i] = temp[i];
//     }
//     
//     for (int i = 0; i < graph[start].Count; i++)
//     {
//         DfsRed(graph[start][i]);
//     }
//     
//     redPopulation -= population[start-1];
//     check[start] = false;
// }
//
// void DfsBlue(int start)
// {
//     
//     
//     if (check[start])
//     {
//         return;
//     }
//
//     bluePopulation += population[start-1];
//     check[start] = true;
//     
//     if (!check.Contains(false))
//     {
//         int diff = Math.Abs(bluePopulation - redPopulation);
//         if (diff < min)
//         {
//             min = diff;
//         }
//     }
//     else
//     {
//         for (int i = 0; i < graph[start].Count; i++)
//         {
//             DfsBlue(graph[start][i]);
//         }
//     }
//     
// }
