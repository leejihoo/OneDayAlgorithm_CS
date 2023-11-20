StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

Stack<char> stick = new Stack<char>();

string input = sr.ReadLine();
char prev = '(';
int answer = 0;

foreach (var s in input)
{
    if (s == '(')
    {
        stick.Push(s);
        prev = s;
        continue;
    }

    stick.Pop();
    
    if (prev == '(')
    {
        answer += stick.Count;
    }
    else
    {
        answer += 1;
    }
    
    prev = s;
}

sw.Write(answer);
sw.Flush();
sw.Close();
sr.Close();