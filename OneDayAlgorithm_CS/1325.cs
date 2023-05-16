int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<List<int>> graph = new List<List<int>>();
int max = 0;
int count = 0;
bool[] check = new bool[inputs[0]];
List<int> answer = new List<int>();
for (int i = 0; i < inputs[0]; i++)
{
    graph.Add(new List<int>());
}

for (int i = 0; i < inputs[1]; i++)
{
    int[] edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[edge[1]-1].Add(edge[0]);
}

for (int i = 0; i < inputs[0]; i++)
{
    Dfs(i);
    if (max < count)
    {
        max = count;
        answer.Clear();
        answer.Add(i+1);
    }
    else if (max == count)
    {
        answer.Add(i+1);
    }

    // 다음 검색을 위해 초기화
    count = 0;
    Array.Fill(check,false);
}

Console.Write(String.Join(" ",answer));

void Dfs(int start)
{
    if (check[start] == false)
    {
        check[start] = true;
        count++;
        foreach (var node in graph[start])
        {
            Dfs(node-1);
        }
    }
}