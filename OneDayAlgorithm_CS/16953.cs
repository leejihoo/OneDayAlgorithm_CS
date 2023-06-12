long[] ab = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
Queue<long> graph = new Queue<long>();
int count = 0;
bool check = false;
graph.Enqueue(ab[0]);
while (true)
{
    count++;
    int repeat = graph.Count;
    for (int i = 0; i < repeat; i++)
    {
        long node = graph.Dequeue();

        if (node > ab[1])
        {
            continue;
        }
        
        if (node == ab[1])
        {
            check = true;
            break;
        }
        
        graph.Enqueue(node * 10 + 1);
        graph.Enqueue(node * 2);
    }

    if (check || repeat == 0)
    {
        break;
    }
}

if(check)
{
    Console.Write(count);
}
else
{
    Console.Write(-1);
}