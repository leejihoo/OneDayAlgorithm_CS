using System.Buffers;

int n = int.Parse(Console.ReadLine());
// int[,] graph = new int[n + 1, n + 1];
bool[] check = new bool[n + 1];
int[] edgeNum = new int[n + 1];
List<List<Tuple<int, int>>> graph = new List<List<Tuple<int, int>>>();
for (int i = 0; i <= n; i++)
{
    graph.Add(new List<Tuple<int,int>>());
}

int max = 0;

for (int i = 0; i < n - 1; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[inputs[0]].Add(new Tuple<int, int>(inputs[1],inputs[2]));
    graph[inputs[1]].Add(new Tuple<int, int>(inputs[0],inputs[2]));
    // graph[inputs[0], inputs[1]] = inputs[2];
    // graph[inputs[1], inputs[0]] = inputs[2];
    edgeNum[inputs[0]] += 1;
    edgeNum[inputs[1]] += 1;
}
int k = 0;

foreach (var num in edgeNum)
{
    
    if (num == 1)
    {
        Dfs(k,0);
    }

    k++;
}

// for (int i = 1; i < n+1; i++)
// {
//     
// }

Console.Write(max);

void Dfs(int start, int sum)
{
    int edgeCount = 0;
    if (check[start])
    {
        return;
    }

    check[start] = true;

    for (int i = 0; i < graph[start].Count; i++)
    {
        if (graph[start][i].Item2 != 0)
        {
            edgeCount++;
            if (!check[graph[start][i].Item1])
            {
                sum += graph[start][i].Item2;
                Dfs(graph[start][i].Item1, sum);
                sum -= graph[start][i].Item2;
            }
        }
    }

    if (edgeCount == 1)
    {
        if (max < sum)
        {
            max = sum;
        }
    }

    check[start] = false;
}