StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = int.Parse(sr.ReadLine());
string[] graph = new string[n];
int[,] check = new int[n, n];
int answer = n*n;
int count = 0;

PriorityQueue<Tuple<int, int>, int> priorityQueue = new PriorityQueue<Tuple<int, int>, int>();

for (int i = 0; i < n; i++)
{
    graph[i] = sr.ReadLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        check[i, j] = n * n;
    }
}

priorityQueue.Enqueue(new Tuple<int, int>(0,0),0);
while (priorityQueue.Count > 0)
{
    priorityQueue.TryDequeue(out var output, out int priority);
    if (graph[output.Item1][output.Item2] == '0')
    {
        priority++;
    }

    if (check[output.Item1, output.Item2] > priority)
    {
        check[output.Item1, output.Item2] = priority;
    }
    else
    {
        continue;
    }

    if (output.Item1 == n - 1 && output.Item2 == n - 1)
    {
        break;
    }
    
    //상
    if (output.Item1 - 1 >= 0)
    {
        priorityQueue.Enqueue(new Tuple<int,int>(output.Item1-1,output.Item2),priority);
    }
    //하
    if (output.Item1 + 1 < n)
    {
        priorityQueue.Enqueue(new Tuple<int,int>(output.Item1+1,output.Item2),priority);
    }
    //좌
    if (output.Item2 - 1 >= 0)
    {
        priorityQueue.Enqueue(new Tuple<int,int>(output.Item1, output.Item2-1),priority);
    }
    //우
    if (output.Item2 + 1 < n)
    {
        priorityQueue.Enqueue(new Tuple<int,int>(output.Item1, output.Item2+1),priority);
    }
}

sw.Write(check[n-1,n-1]);
sw.Flush();
sw.Close();
sr.Close();

