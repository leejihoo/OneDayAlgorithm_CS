int N = int.Parse(Console.ReadLine());
string postfix = Console.ReadLine();
int[] operand = new int[N];
Stack<decimal> stack = new Stack<decimal>();

for (int i = 0; i < N; i++)
{
    operand[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < postfix.Length; i++)
{
    var temp = postfix[i] - 'A';
    if ( temp >= 0 && temp <= 25)
    {
        stack.Push(operand[temp]);
        continue;
    }

    decimal back = stack.Pop();
    decimal front = stack.Pop();
    if (postfix[i] == '*')
    {
        stack.Push(front*back);
    }
    else if (postfix[i] == '+')
    {
        stack.Push(front+back);
    }
    else if (postfix[i] == '/')
    {
        stack.Push(front/back);
    }
    else if (postfix[i] == '-')
    {
        stack.Push(front-back);
    }
}

Console.Write(Decimal.Round(stack.Pop(),2).ToString("0.00"));
