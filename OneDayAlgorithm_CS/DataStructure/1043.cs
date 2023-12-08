StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

int[] nm = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
int[] truePeople = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
bool[] canNotExaggerate = new bool[nm[0] + 1];
int[] parent = new int[nm[0] + 1];
List<int[]> partyInfoList = new List<int[]>();
int answer = 0;
for (int i = 1; i <= nm[0]; i++)
{
    parent[i] = i;
}

for (int i = 1; i <= truePeople[0]; i++)
{
    canNotExaggerate[truePeople[i]] = true;
}

for (int i = 0; i < nm[1]; i++)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
    partyInfoList.Add(input);

    // for (int j = 2; j <= input[0]; j++)
    // {
    //     Union(input[1],input[j]);
    //
    // }

    for (int x = 1; x <= input[0]; x++)
    {
        for (int y = x + 1; y <= input[0]; y++)
        {
            Union(input[x],input[y]);
        }
    }
}

for (int i = 1; i < parent.Length; i++)
{
    int parentNum = GetParent(i); 
    if (i == parentNum)
    {
        continue;
    }

    if (canNotExaggerate[parentNum])
    {
        canNotExaggerate[i] = true;
    }

    if (canNotExaggerate[i])
    {
        canNotExaggerate[parentNum] = true;
    }
}

foreach (var party in partyInfoList)
{
    bool goToNext = false;
    for (int i = 1; i <= party[0]; i++)
    {
        if (canNotExaggerate[parent[party[i]]])
        {
            goToNext = true;
            break;
        }
    }

    if (goToNext)
    {
        continue;
    }

    answer++;
}

sw.Write(answer);
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

    if (firstP > secondP)
    {
        parent[firstP] = secondP;
        return;
    }

    parent[secondP] = firstP;
}

int GetParent(int num)
{
    if (parent[num] == num)
    {
        return num;
    }

    return parent[num] = GetParent(parent[num]);
}