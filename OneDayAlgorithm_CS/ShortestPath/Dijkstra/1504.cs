StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

var NE = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
int[,] graph = new int[NE[0], NE[0]];
int inf = 200000001;
int answer = 0;

for (int i = 0; i < NE[0]; i++)
{
    for (int j = 0; j < NE[0]; j++)
    {
        if (i == j)
        {
            continue;
        }

        graph[i, j] = inf;
    }
}

for (int i = 0; i < NE[1]; i++)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
    graph[input[0] - 1, input[1] - 1] = input[2];
    graph[input[1] - 1, input[0] - 1] = input[2];
}

var stopover = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);

var firstPath = Dijstra(1, stopover[0], NE[0]) + Dijstra(stopover[0], stopover[1], NE[0]) +
                Dijstra(stopover[1], NE[0], NE[0]);
var secondPath = Dijstra(1, stopover[1], NE[0]) + Dijstra(stopover[1], stopover[0], NE[0]) +
                Dijstra(stopover[0], NE[0], NE[0]);

var min = Math.Min(firstPath, secondPath);
if (min >= inf)
{
    answer = -1;
}
else
{
    answer = min;
}
sw.Write(answer);
sw.Flush();
sw.Close();

int Dijstra(int start, int end, int nodeCount)
{
    int[] visit = new int[nodeCount];
    // Array.Fill(visit,inf);
    // visit[0] = 0;
    
    PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
    for (int i = 0; i < nodeCount; i++)
    {
        var value = graph[start-1, i];
        visit[i] = value;
        if (value == inf || value == 0)
        {
            continue;
        }

        priorityQueue.Enqueue(i+1,value);
    }

    while (priorityQueue.Count > 0)
    {
        var output = priorityQueue.Dequeue();
        for (int i = 0; i < nodeCount; i++)
        {
            var value = graph[output-1, i];
            if (value == inf || value == 0)
            {
                continue;
            }

            if (visit[i] > visit[output-1] + value)
            {
                visit[i] = visit[output-1] + value;
                priorityQueue.Enqueue(i+1,value);
            }
        }
    }
    return visit[end-1];
}