int N  = int.Parse(Console.ReadLine());
int answer = 0;
Stack<char> report = new Stack<char>();

for (int i = 0; i < N; i++)
{
    
    string temp = Console.ReadLine();
    for (int j = 0; j < temp.Length; j++)
    {
        if (report.Count > 0)
        {
            if (report.Peek() == temp[j])
            {
                report.Pop();
            }
            else
            {
                report.Push(temp[j]);
            }
        }
        else
        {
            report.Push(temp[j]);
        }
    }

    if (report.Count == 0)
    {
        answer++;
    }
    report.Clear();
}

Console.Write(answer);