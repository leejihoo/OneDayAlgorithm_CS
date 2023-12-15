StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int[] nmk = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
int[] cost = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
int[] parent = new int[nmk[0] + 1];
HashSet<int> root = new HashSet<int>();
int sum = 0;

for (int i = 1; i < parent.Length; i++)
{
    parent[i] = i;
}

for (int i = 0; i < nmk[1]; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    Union(input[0], input[1]);
}

for (int i = 1; i < parent.Length; i++)
{
    root.Add(GetParent(i));
}

foreach (var r in root)
{
    sum += cost[r-1];
}

if (sum > nmk[2])
{
    sw.Write("Oh no");
}
else
{
    sw.Write(sum);
}

sw.Flush();
sw.Close();
sr.Close();

void Union(int first, int second)
{
    int firstP = GetParent(first);
    int secondP = GetParent(second);

    if (firstP == secondP) 
    {
        return;
    }

    if (cost[firstP - 1] > cost[secondP - 1])
    {
        parent[firstP] = secondP;
    }
    else if (cost[firstP - 1] < cost[secondP - 1])
    {
        parent[secondP] = firstP;
    }
    else
    {
        if (firstP > secondP)
        {
            parent[firstP] = secondP;
            return;
        }

        parent[secondP] = firstP;
    }
}

int GetParent(int num)
{
    if (parent[num] == num)
    {
        return num;
    }

    return parent[num] = GetParent(parent[num]);
}
