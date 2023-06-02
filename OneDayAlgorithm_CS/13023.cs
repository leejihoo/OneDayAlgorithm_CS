int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
List<List<int>> graph = new List<List<int>>();
bool[] check = new bool[nm[0]];
int count = 0;
int isExist = 0;

for (int i = 0; i < nm[0]; i++)
{
    graph.Add(new List<int>());
}

for (int i = 0; i < nm[1]; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[inputs[0]].Add(inputs[1]);
    graph[inputs[1]].Add(inputs[0]);
}

for (int i = 0; i < nm[0]; i++)
{
    Dfs(i);
}

Console.WriteLine(isExist);

void Dfs(int start)
{
    if (check[start])
    {
        return;
    }

    check[start] = true;
    count++;

    if (count >= 5)
    {
        isExist = 1;
        return;
    }
    
    for (int i = 0; i < graph[start].Count; i++)
    {
        Dfs(graph[start][i]);
    }
    
    check[start] = false;
    count--;
}