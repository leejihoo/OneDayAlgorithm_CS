using System.Text;

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StringBuilder sb = new StringBuilder();

int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] setArr = new int[1000001];

for (int i = 1; i <= nm[0]; i++)
{
    setArr[i] = i;
}

for (int i = 0; i < nm[1]; i++)
{
    int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

    if (inputs[0] == 0)
    {
        Union(inputs[1],inputs[2]);
        continue;
    }

    if (Find(inputs[1], inputs[2]))
    {
        sb.AppendLine("YES");
        continue;
    }

    sb.AppendLine("NO");
}

int GetParent(int index)
{
    if (index == setArr[index])
    {
        return index;
    }

    return setArr[index] = GetParent(setArr[index]);
}

void Union(int indexF, int indexS)
{
    int parentF = GetParent(indexF);
    int parentS = GetParent(indexS);

    if (parentS == parentF)
    {
        return;
    }

    if (parentS > parentF)
    {
        setArr[parentS] = parentF;
        return;
    }

    setArr[parentF] = parentS;
}

bool Find(int indexF, int indexS)
{
    int parentF = GetParent(indexF);
    int parentS = GetParent(indexS);

    if (parentS == parentF)
    {
        return true;
    }

    return false;
}

sw.Write(sb.ToString());
sw.Flush();
sw.Close();
sr.Close();