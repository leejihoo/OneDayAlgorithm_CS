int k = int.Parse(Console.ReadLine());
Stack<int> numbers = new Stack<int>();

while (k > 0)
{
    k--;
    
    int input = int.Parse(Console.ReadLine());
    if (input == 0)
    {
        numbers.Pop();
        continue;
    }
    
    numbers.Push(input);
}

int sum = 0;
int count = numbers.Count;

for (int i = 0; i < count; i++)
{
    int element = numbers.Pop();
    sum += element;
}

Console.WriteLine(sum);