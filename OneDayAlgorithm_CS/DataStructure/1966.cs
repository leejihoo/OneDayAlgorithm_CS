StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int T = int.Parse(Console.ReadLine());
Queue<int> priority = new Queue<int>();
Queue<int> index = new Queue<int>();

for (int i = 0; i < T; i++)
{
    string[] inputs = Console.ReadLine().Split();
    int answer = int.Parse(inputs[1]);
    int[] docs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = docs.Length;
    for (int j = 0; j < count; j++)
    {
        priority.Enqueue(docs[j]);
        index.Enqueue(j);
    }
    
    for (int j = 0; j < count; j++)
    {
        int max = priority.Max();

        int idx = index.Dequeue();
        int pri = priority.Dequeue();
        
        if (pri == max)
        {
            if (answer == idx)
            {
                sw.WriteLine(j+1);
                break;
            }

            continue;
        }

        j--;
        index.Enqueue(idx);
        priority.Enqueue(pri);
    }
    
    priority.Clear();
    index.Clear();
}

sw.Close();