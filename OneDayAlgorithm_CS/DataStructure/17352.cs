StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int N = int.Parse(sr.ReadLine());
int[] bridge = new int[N + 1];
bool isFind = false;
for (int i = 1; i < N + 1; i++)
{
    bridge[i] = i;
}

for (int i = 0; i < N - 2; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    Union(input[0],input[1]);    
}

for (int i = 1; i < N + 1; i++)
{
    for (int j = i + 1; j < N + 1; j++)
    {
        if (Find(bridge[i], bridge[j]) != 0)
        {
            sw.Write(bridge[i] + " " + bridge[j]);
            isFind = true;
            break;
        }
    }

    if (isFind)
    {
        break;
    }
}

sw.Flush();
sw.Close();
sr.Close();

int GetParent(int num)
{
    if (bridge[num] == num)
    {
        return num;
    }

    return bridge[num] = GetParent(bridge[num]);
}

int Find(int first, int second)
{
    int firstP = GetParent(first);
    int secondP = GetParent(second);

    if (firstP == secondP)
    {
        return 0;
    }
    
    if (firstP > secondP)
    {
        return 1;
    }
    
    return -1;
}

void Union(int first, int second)
{
    int findResult = Find(first, second);
    if (findResult == 0)
    {
        return;
    }
   
    if (findResult > 0)
    {
        bridge[GetParent(first)] = GetParent(second);
        return;
    }

    bridge[GetParent(second)] = GetParent(first);
}