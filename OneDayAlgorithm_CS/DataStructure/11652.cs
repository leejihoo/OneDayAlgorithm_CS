int N = int.Parse(Console.ReadLine());
Dictionary<long,int> cards = new Dictionary<long,int>();

for (int i = 0; i < N; i++)
{
    long temp = long.Parse(Console.ReadLine());
    if (cards.ContainsKey(temp))
    {
        cards[temp] += 1;
    }
    else
    {
        cards[temp] = 1;
    }
}

var max = cards.Max(x => x.Value);
var a = cards.Where(x => x.Value >= max).Min(y => y.Key);
Console.Write(a);