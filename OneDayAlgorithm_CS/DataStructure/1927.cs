PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int temp = int.Parse(Console.ReadLine());

    if (temp == 0)
    {
        if (priorityQueue.Count == 0)
        {
            sw.WriteLine(0);
            continue;
        }

        sw.WriteLine(priorityQueue.Dequeue());
    }
    else
    {
        priorityQueue.Enqueue(temp,temp);
    }
    
}

sw.Flush();
sw.Close();