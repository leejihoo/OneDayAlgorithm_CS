StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

var mn = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
string[] graph = new string[mn[1]];
int[,] visit = new int[mn[1],mn[0]];
int answer = 0;
for (int i = 0; i < mn[1]; i++)
{
    for (int j = 0; j < mn[0]; j++)
    {
        visit[i, j] = 10001;
    }
}

visit[0, 0] = 0;
PriorityQueue<Tuple<int, int>, int> priorityQueue = new PriorityQueue<Tuple<int, int>, int>();
for (int i = 0; i < mn[1]; i++)
{
    graph[i] = sr.ReadLine();
} 

priorityQueue.Enqueue(new Tuple<int, int>(0,0),visit[0,0]);

while (priorityQueue.Count > 0)
{
    priorityQueue.TryDequeue(out Tuple<int, int> node, out int cost);
    if (node.Item1 == mn[0] - 1 && node.Item2 == mn[1] - 1)
    {
        answer = cost;
        break;
    }
    
    // 상
    if (node.Item2 - 1 >= 0)
    {
        Move(node.Item1, node.Item2 - 1, cost);
    }
    // 하
    if (node.Item2 + 1 < mn[1])
    {
        Move(node.Item1, node.Item2 + 1, cost);
    }
    // 좌
    if (node.Item1 - 1 >= 0)
    {
        Move(node.Item1 - 1, node.Item2, cost);
    }
    // 우
    if (node.Item1 + 1 < mn[0])
    {
        Move(node.Item1 + 1, node.Item2, cost);
    }
}

sw.Write(answer);
sw.Flush();
sw.Close();

void Move(int x, int y, int cost)
{
    var row = graph[y];
    var nextCost = row[x] - '0';
    if (nextCost + cost < visit[y, x])
    {
        visit[y, x] = nextCost + cost;
        priorityQueue.Enqueue(new Tuple<int, int>(x,y), visit[y, x]);
    }
}