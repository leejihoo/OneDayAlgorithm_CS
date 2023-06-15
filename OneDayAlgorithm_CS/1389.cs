int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
List<int>[] graph = new List<int>[nm[0]+1];
bool[] check = new bool[nm[0]+1];
Queue<int> queue = new Queue<int>();
int answer = 0;
int min = 500000;
for (int i = 0; i <= nm[0]; i++)
{
    graph[i] = new List<int>();
}

for (int i = 0; i < nm[1]; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[inputs[0]].Add(inputs[1]);
    graph[inputs[1]].Add(inputs[0]);
    
}

for (int i = 1; i <= nm[0]; i++)
{
    queue.Enqueue(i);
    check[i] = true;
    int weight = 0;
    int step = 0;
    
    while (queue.Count != 0)
    {
        int count = queue.Count;
        weight += step * count;
        step++;
        
        for (int k = 0; k < count; k++)
        {
            int node = queue.Dequeue();
            
            for (int j = 0; j < graph[node].Count; j++)
            {
                if (!check[graph[node][j]])
                {
                    queue.Enqueue(graph[node][j]);
                    check[graph[node][j]] = true;
                }
            }
        }
    }

    if (weight < min)
    {
        min = weight;
        answer = i;
    }
    else if (weight == min)
    {
        if (answer > i)
        {
            answer = i;
        }
    }
    
    Array.Fill(check,false);
}

Console.Write(answer);