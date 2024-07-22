using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder();
var ne = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
var start = int.Parse(sr.ReadLine());
List<Dictionary<int,int>> graph = new List<Dictionary<int,int>>();
bool[] visit = new bool[ne[0]];
int[] check = new int[ne[0]];
int INF = 200001;

PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
for (int i = 0; i < ne[0]; i++)
{
    graph.Add(new Dictionary<int, int>()); 
}

for (int i = 0; i < ne[1]; i++)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
    var value = graph[input[0] - 1].TryGetValue(input[1]-1, out int output);
    if (!value || output > input[2])
    {
        graph[input[0] - 1][input[1]-1] = input[2];
    }
    
}

for (int i = 0; i < ne[0]; i++)
{
    graph[i][i] = 0;
    check[i] = INF;
}

check[start - 1] = 0;
priorityQueue.Enqueue(start-1,0);

while (priorityQueue.Count > 0)
{
    var output = priorityQueue.Dequeue();
    if (visit[output])
    {
        continue;
    }
    
    visit[output] = true;
    var keys = graph[output].Keys;
    foreach (var key in keys)
    {
        if (visit[key])
        {
            continue;
        }
        
        var value = graph[output][key];

        if (check[key] > value + check[output])
        {
            check[key] = value + check[output];
            priorityQueue.Enqueue(key,check[key]);
        }
    }
}

foreach (var value in check)
{
    if (value == INF)
    {
        sw.WriteLine("INF");
    }
    else
    {
        sw.WriteLine(value);
    }
}

sw.Flush();
sw.Close();
    