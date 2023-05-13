int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[,] graph = new int[input[0], input[0]];
bool[] check = new bool[input[0]];
int answer = 0;
for (int i = 0; i < input[1]; i++)
{
    int[] edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[edge[0] - 1, edge[1] - 1] = 1;
    graph[edge[1] - 1, edge[0] - 1] = 1;
}

for (int i = 0; i < input[0]; i++)
{
    if (check[i] == false)
    {
        answer++;
        check[i] = true;
        Dfs(i);
    }
}

Console.Write(answer);

void Dfs(int row)
{
    for (int i = 0; i < input[0]; i++)
    {
        if (check[i] == false && graph[row, i] == 1)
        {
            check[i] = true;
            Dfs(i);
        }
    }
}

