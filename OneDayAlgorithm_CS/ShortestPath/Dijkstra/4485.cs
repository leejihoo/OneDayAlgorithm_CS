StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int step = 1;
while (true)
{
    var N = int.Parse(sr.ReadLine());
    if (N == 0)
    {
        break;
    }

    int[][] graph = new int[N][];
    int[,] check = new int[N,N];
    int INF = 9 * 125 * 125 + 1;
    
    for (int i = 0; i < N; i++)
    {
        graph[i] = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    }

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            check[i, j] = INF;
        }
    }

    PriorityQueue<Tuple<int, int>, int> priorityQueue = new PriorityQueue<Tuple<int, int>, int>();
    priorityQueue.Enqueue(new Tuple<int, int>(0,0),0);
    while (priorityQueue.Count > 0)
    {
        priorityQueue.TryDequeue(out var output,out int cost);
        var row = output.Item1;
        var col = output.Item2;
        if (check[row, col] > cost + graph[row][col])
        {
            check[row, col] = cost + graph[row][col];
        }
        else
        {
            continue;
        }

        if (row == N - 1 && col == N - 1)
        {
            sw.WriteLine($"Problem {step}: " + check[row, col]);
            break;
        }
        
        //상
        if (row - 1 >= 0)
        {
            priorityQueue.Enqueue(new Tuple<int, int>(row-1,col),check[row,col]);
        }
        //하
        if (row + 1 < N)
        {
            priorityQueue.Enqueue(new Tuple<int, int>(row+1,col),check[row,col]);
        }
        //좌
        if (col - 1 >= 0)
        {
            priorityQueue.Enqueue(new Tuple<int, int>(row,col-1),check[row,col]);
        }
        //우
        if (col + 1 < N)
        {
            priorityQueue.Enqueue(new Tuple<int, int>(row,col+1),check[row,col]);
        }
    }

    step++;
}

sw.Flush();
sw.Close();
sr.Close();