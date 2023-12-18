StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int[] nm = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
int[] parent = new int[nm[0]];
int answer = 0;

for (int i = 1; i < parent.Length; i++)
{
    parent[i] = i;
}

for (int i = 0; i < nm[1]; i++)
{
    int[] edge = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
    var isCircle = Union(edge[0], edge[1]);

    if (isCircle)
    {
        answer = i + 1;
        break;
    }
}

sw.Write(answer);
sw.Flush();
sw.Close();
sr.Close();

bool Union(int first, int second)
{
    int firstP = GetParent(first);
    int secondP = GetParent(second);

    if (firstP == secondP)
    {
        return true;
    }

    if (firstP > secondP)
    {
        parent[firstP] = secondP;
    }
    else
    {
        parent[secondP] = firstP;
    }
    
    return false;
}

int GetParent(int num)
{
    if (parent[num] == num)
    {
        return num;
    }

    return parent[num] = GetParent(parent[num]);
}

