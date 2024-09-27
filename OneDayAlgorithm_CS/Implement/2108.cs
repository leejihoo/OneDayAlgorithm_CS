int N = int.Parse(Console.ReadLine());

List<int> numbers = new List<int>();
Dictionary<int, int> count = new Dictionary<int, int>();
for (int i = 0; i < N; i++)
{
    var input = int.Parse(Console.ReadLine());
    numbers.Add(input);
}

numbers.Sort();

for (int i = 0; i < N; i++)
{
    if (count.ContainsKey(numbers[i]))
    {
        count[numbers[i]] += 1;
        continue;
    }
    
    count[numbers[i]] = 1;
}

int max = 0;
List<int> modes = new List<int>();
var set = numbers.ToHashSet();

foreach (var num in set)
{
    if (max < count[num])
    {
        max = count[num];
        modes.Clear();
        modes.Add(num);
        continue;
    }

    if (max == count[num])
    {
        modes.Add(num);
    }
}
modes.Sort();

var output = Math.Round((double)numbers.Sum() / N);
if (output == 0)
{
    Console.WriteLine(Math.Abs(output));
}
else
{
    Console.WriteLine(output);
}


Console.WriteLine(numbers[N/2]);

if (modes.Count > 1)
{
    Console.WriteLine(modes[1]);
}
else
{
    Console.WriteLine(modes[0]);
}

Console.WriteLine(numbers[N-1] - numbers[0]);