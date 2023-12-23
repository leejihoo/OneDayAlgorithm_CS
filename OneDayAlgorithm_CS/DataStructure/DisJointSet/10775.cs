StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int G = int.Parse(sr.ReadLine());
int P = int.Parse(sr.ReadLine());
int[] parent = new int[100001];
int answer = 0;
bool isClose = false;
for (int i = 1; i < parent.Length; i++)
{
    parent[i] = i;
}

for (int i = 0; i < P; i++)
{
    int gi = int.Parse(sr.ReadLine());
    if (isClose)
    {
        continue;
    }
    
    if (GetParent(gi) != 0)
    {
        answer++;
        var p = GetParent(gi);
        Union(p,p-1);
        continue;
    }

    isClose = true;
}

sw.Write(answer);
sw.Flush();
sw.Close();
sr.Close();

int GetParent(int num)
{
    if (parent[num] == num)
    {
        return num;
    }

    return parent[num] = GetParent(parent[num]);
}

void Union(int first, int second)
{
    int firstP = GetParent(first);
    int secondP = GetParent(second);

    if (firstP == secondP)
    {
        return;
    }

    if (firstP > secondP)
    {
        parent[firstP] = secondP;
        return;
    }

    parent[secondP] = firstP;
    
}

