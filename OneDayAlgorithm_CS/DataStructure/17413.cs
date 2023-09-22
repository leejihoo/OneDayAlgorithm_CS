using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();
string S = Console.ReadLine();
Queue<char> queue = new Queue<char>();
Stack<char> stack = new Stack<char>();
bool isTag = false;
for (int i = 0; i < S.Length; i++)
{
    if ((S[i] >= 'a' && S[i] <= 'z') || (S[i] >= '0' && S[i] <= '9'))
    {
        if (isTag)
        {
            sb.Append(S[i]);
            continue;
        }
        
        stack.Push(S[i]);
        if (i == S.Length - 1)
        {
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
        }
    }
    else if (S[i] == '<')
    {
        isTag = true;

        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }

        sb.Append('<');
    }
    else if (S[i] == '>')
    {
        isTag = false;
        sb.Append('>');
    }
    else if (S[i] == ' ')
    {
        if (isTag)
        {
            sb.Append(S[i]);
            continue;
        }
        
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }

        sb.Append(' ');
    }
}

sw.Write(sb.ToString());
sw.Close();