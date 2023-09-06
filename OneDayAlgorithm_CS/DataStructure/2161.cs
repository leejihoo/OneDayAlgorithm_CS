int N = int.Parse(Console.ReadLine());
Queue<int> cards = new Queue<int>();
StreamWriter streamWriter = new StreamWriter(Console.OpenStandardOutput());
for (int i = 1; i <= N; i++)
{
    cards.Enqueue(i);
}

while (cards.Count > 0)
{
    int dead = cards.Dequeue();
    
    if (cards.Count > 0)
    {
        streamWriter.Write(dead+" ");
        int move = cards.Dequeue();
        cards.Enqueue(move);
    }
    else
    {
        streamWriter.Write(dead);
    }
    
}

streamWriter.Flush();
streamWriter.Close();
