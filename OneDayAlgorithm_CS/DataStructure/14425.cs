int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
HashSet<string> setS = new HashSet<string>();
List<string> inspectingStr = new List<string>();
int count = 0;

for (int i = 0; i < inputs[0]; i++)
{
    setS.Add(Console.ReadLine());
}
for (int i = 0; i < inputs[1]; i++)
{
    inspectingStr.Add(Console.ReadLine());
}

foreach (var str in inspectingStr)
{
    if (setS.Contains(str))
    {
        count++;
    }
}

Console.Write(count);


