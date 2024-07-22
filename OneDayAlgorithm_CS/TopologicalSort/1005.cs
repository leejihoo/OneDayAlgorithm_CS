StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int T = int.Parse(sr.ReadLine());

while (T > 0)
{
    var nk = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    var delay = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    //var deley
    int[] degree = new int[nk[0] + 1];
    int[,] graph = new int[nk[0], nk[0]];
    
    for (int i = 0; i < nk[1]; i++)
    {
        var edge = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        graph[edge[0]-1, edge[1]-1] = 1;
        degree[edge[1]] += 1;
        
    }
    
    var target = int.Parse(sr.ReadLine());

    Queue<int> queue = new Queue<int>();
    
    for (int i = 1; i < degree.Length; i++)
    {
        if (degree[i] == 0)
        {
            queue.Enqueue(i-1);
        }
    }
    
    int[] sum = new int[nk[0]];
    for (int i = 0; i < sum.Length; i++)
    {
        sum[i] = delay[i];
    }
    
    while (queue.Count > 0)
    {
        var output = queue.Dequeue();
        for (int i = 0; i < nk[0]; i++)
        {
            var value = graph[output, i];
            // 연결 안됨
            if (value == 0)
            {
                continue;
            }

            degree[i+1]--;
            if (degree[i+1] == 0)
            {
                queue.Enqueue(i);
            }
            
            if (sum[i] < delay[i] + sum[output])
            {
                sum[i] = delay[i] + sum[output];
            }
        }
        
    }
    
    sw.WriteLine(sum[target-1]);
    T--;
}

sw.Flush();
sw.Close();