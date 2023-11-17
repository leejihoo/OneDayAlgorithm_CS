using System.Text;

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StringBuilder sb = new StringBuilder();

Stack<char> front = new Stack<char>();
Stack<char> back = new Stack<char>();

int t = int.Parse(sr.ReadLine());

for (int i = 0; i < t; i++)
{
    string input = sr.ReadLine();
    foreach (var s in input)
    {
        if (s == '<')
        {
            if (front.Count > 0)
            {
                back.Push(front.Pop());
            }
        }
        else if (s == '>')
        {
            if (back.Count > 0)
            {
                front.Push(back.Pop());
            } 
        }
        else if (s == '-')
        {
            if (front.Count > 0)
            {
                front.Pop();
            }
        }
        else
        {
            front.Push(s);
        }
    }

    var reverseF = front.Reverse();
    foreach (var f in reverseF)
    {
        sb.Append(f);
    }

    foreach (var b in back)
    {
        sb.Append(b);
    }
    sw.WriteLine(sb.ToString());
    
    sb.Clear();
    front.Clear();
    back.Clear();
}

sw.Flush();
sw.Close();
sr.Close();