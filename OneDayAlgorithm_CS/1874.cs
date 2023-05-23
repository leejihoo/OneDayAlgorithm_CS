using System.Text;

int n = int.Parse(Console.ReadLine());
//Queue<int> sequence = new Queue<int>();
Stack<int> stack = new Stack<int>();
//string answer = "";
StringBuilder answer = new StringBuilder();
int start = 1;
bool check = false;
for (int i = 1; i <= n; i++)
{
    if (stack.Count == 0 && start <= n)
    {
        stack.Push(start);
        answer.Append('+');
        answer.AppendLine();
        start++;
    }

    //sequence.Enqueue(int.Parse(Console.ReadLine()));
    int peek = int.Parse(Console.ReadLine());
    
    if (stack.Count > 0)
    {
        if (stack.Peek() == peek)
        {
            answer.Append('-');
            answer.AppendLine();
            stack.Pop();
        }    
        else if (stack.Peek() < peek)
        {
            while (start <= peek)
            {
                stack.Push(start);
                start++;
                answer.Append('+');
                answer.AppendLine();
            }

            stack.Pop();
            answer.Append('-');
            answer.AppendLine();
        }
        else
        {
            check = true;
            break;
        }
    }
    
}

// stack.Push(start);
// start++;
// answer += '+';

// while (sequence.Count > 0)
// {
//     if (stack.Count > 0)
//     {
//         if (stack.Peek() == sequence.Peek())
//         {
//             answer += '-';
//             stack.Pop();
//             sequence.Dequeue();
//         }    
//         else if (stack.Peek() < sequence.Peek())
//         {
//             stack.Push(start);
//             start++;
//             answer += '+';
//         }
//         else
//         {
//             break;
//         }
//     }
//     else
//     {
//         stack.Push(start);
//         start++;
//         answer += '+';
//     }
// }

if (check)
{
    Console.Write("NO");
}
else
{
    Console.Write(answer);
}