StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

PriorityQueue<int,double> maxHeap = new PriorityQueue<int, double>();

int count = int.Parse(sr.ReadLine());

for (int i = 0; i < count; i++)
{
    int input = int.Parse(sr.ReadLine());
    
    if (input == 0)
    {
        if (maxHeap.Count == 0)
        {
            sw.WriteLine(0);
            continue;
        }
        
        sw.WriteLine(maxHeap.Dequeue());
        continue;
    }
    
    maxHeap.Enqueue(input, 1 / (double)input);
}

sw.Flush();
sw.Close();
sr.Close();