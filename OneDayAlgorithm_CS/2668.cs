int N = int.Parse(Console.ReadLine());
List<List<int>> graph = new List<List<int>>();
SortedSet<int> answer = new SortedSet<int>();
Stack<int> temp = new Stack<int>();
bool[] check = new bool[N];

for (int i = 0; i < N; i++)
{
    graph.Add(new List<int>());
}

for (int i = 1; i <= N; i++)
{
    int input = int.Parse(Console.ReadLine());
    graph[input-1].Add(i);
}

for (int i = 1; i <= N; i++)
{
    Dfs(i,i);
    temp.Clear();
}

Console.WriteLine(answer.Count);
foreach (var node in answer)
{
    Console.WriteLine(node);
}

void Dfs(int comeback, int search)
{
    if (check[search - 1])
    {
        return;
    }
    check[search-1] = true;
    
    if (graph[search - 1].Count == 0)
    { 
        return;
    }
    
    temp.Push(search);

    for (int i = 0; i < graph[search - 1].Count; i++)
    {
        int next = graph[search - 1][i];
        
        if (comeback == next)
        {
            foreach (var node in temp)
            {
                answer.Add(node);
            }
            return;
        }
        
        Dfs(comeback,next);
    }

    temp.Pop();
}