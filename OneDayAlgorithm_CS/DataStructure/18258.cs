using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder();
int N = int.Parse(Console.ReadLine());
int last = 0;
Queue<int> queue = new Queue<int>();
for (int i = 0; i < N; i++)
{
    string[] temp = Console.ReadLine().Split();
    //string temp = sr.ReadLine();
    if (temp[0] == "push")
    {
        last = int.Parse(temp[1]);
        
        queue.Enqueue(int.Parse(temp[1]));    
    }
    else if (temp[0] == "front")
    {
        if (queue.Count == 0)
        {
            sb.AppendLine("-1");
            //sw.WriteLine(-1);
            continue;
        }

        sb.AppendLine(queue.Peek().ToString());
        //sw.WriteLine(queue.Peek());
        
    }
    else if (temp[0] == "back")
    {
        if (queue.Count == 0)
        {
            sb.AppendLine("-1");
            //sw.WriteLine(-1);
            continue;
        }

        sb.AppendLine(last.ToString());
        // sw.WriteLine(queue.ToArray()[queue.Count-1]);
    }
    else if (temp[0] == "size")
    {
        sb.AppendLine(queue.Count.ToString());
        // sw.WriteLine(queue.Count);
    }
    else if (temp[0] == "empty")
    {
        if (queue.Count == 0)
        {
            sb.AppendLine("1");
            // sw.WriteLine(1);
            continue;
        }

        sb.AppendLine("0");
        // sw.WriteLine(0);
    }
    else if (temp[0] == "pop")
    {
        if (queue.Count == 0)
        {
            sb.AppendLine("-1");
            // sw.WriteLine(-1);
           continue;
        }

        sb.AppendLine(queue.Dequeue().ToString());
        // sw.WriteLine(queue.Dequeue());
    }
    //sw.Flush();
    
}
sw.WriteLine(sb.ToString());
sw.Close();
