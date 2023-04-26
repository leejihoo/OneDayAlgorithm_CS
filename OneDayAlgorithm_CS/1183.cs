
int N = int.Parse(Console.ReadLine());
int min = 1000000000;
int[] T = new int[N];
List<int> select = new List<int>();
for (int i = 0; i < N; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    T[i] = inputs[1] - inputs[0];
}

foreach (var t in T)
{
    int sum = 0;
    foreach (var t2 in T)
    {
        sum += Math.Abs(t - t2);
    }

    if (min == sum)
    {
        select.Add(t);
    }
    else if (min > sum)
    {
        min = sum;
        select.Clear();
        select.Add(t);
    }
}

if (select.Count > 1)
{
    int max = select.Max();
    int mini = select.Min();
    
    Console.Write(max-mini+1);
}
else
{
    Console.Write(1);
}