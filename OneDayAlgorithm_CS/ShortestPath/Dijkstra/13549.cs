StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int answer = 100001;
PriorityQueue<int,int> priorityQueue = new PriorityQueue<int, int>();
bool[] check = new bool[100001];

Array.Fill(check,false);

var nm = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);

priorityQueue.Enqueue(nm[0],0);

while (priorityQueue.Count > 0)
{
    priorityQueue.TryDequeue(out int next, out int priority);

    if (next > 100000 || next < 0)
    {
        continue;
    }
    
    if (check[next])
    {
        continue;
    }

    check[next] = true;
    
    if (priority >= answer)
    {
        break;
    }
    
    if (nm[1] == next)
    {
        answer = priority;
    }
    else if (nm[1] > next)
    {
        priorityQueue.Enqueue(next+1,priority+1);
        priorityQueue.Enqueue(next-1,priority+1);
        priorityQueue.Enqueue(next*2,priority);
    }
    else
    {
        if (next - nm[1] + priority < answer)
        {
            answer = next - nm[1] + priority;
        }
    }
}

sw.Write(answer);
sw.Flush();
sw.Close();