using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder(); 
string oneLine = sr.ReadLine();
int count = int.Parse(sr.ReadLine());

Stack<char> left = new Stack<char>();
Stack<char> right = new Stack<char>();

foreach (var temp in oneLine)
{
    left.Push(temp);
}

for (int i = 0; i < count; i++)
{
    string command = sr.ReadLine();
    if (command[0] == 'L')
    {
        if (left.Count > 0)
        {
            right.Push(left.Pop());
        }
    }
    else if (command[0] == 'D')
    {
        if (right.Count > 0)
        {
            left.Push(right.Pop());
        }
    }
    else if (command[0] == 'B')
    {
        if (left.Count > 0)
        {
            left.Pop();
        }
    }
    else if (command[0] == 'P')
    {
        left.Push(command[2]);
    }
}

var reverse = left.Reverse();
foreach (var temp in reverse)
{
    sb.Append(temp);
}

foreach (var temp in right)
{
    sb.Append(temp);
}

sw.Write(sb.ToString());
sw.Close();
sr.Close(); 