StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

long[] mn = Array.ConvertAll(sr.ReadLine().Split(),long.Parse);
List<long> cards = Array.ConvertAll(sr.ReadLine().Split(),long.Parse).ToList();

for (int i = 0; i < mn[1]; i++)
{
    cards.Sort();
    var sum = cards[0] + cards[1];
    cards[0] = sum;
    cards[1] = sum;
}

sw.Write(cards.Sum());
sw.Flush();
sw.Close();
sr.Close();