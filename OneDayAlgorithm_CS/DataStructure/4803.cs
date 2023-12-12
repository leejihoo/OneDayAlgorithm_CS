using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder();

HashSet<int> tree = new HashSet<int>();
HashSet<int> circle = new HashSet<int>();

int caseCount = 1;
while (true)
{
    int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int[] parent = new int[501];
    
    if (nm[0] == 0 && nm[1] == 0)
    {
        break;
    }
    
    for (int i = 1; i < parent.Length; i++)
    {
        parent[i] = i;
    }

    for (int i = 0; i < nm[1]; i++)
    {
        int[] edge = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        Union(parent, edge[0], edge[1]);
    }

    for (int i = 1; i <= nm[0]; i++)
    {
        if (circle.Contains(GetParent(parent,i)))
        {
            continue;
        }

        tree.Add(parent[i]);
    }

    if (tree.Count > 1)
    {
        sb.AppendLine("Case " + caseCount + ": A forest of " + tree.Count + " trees.");
    }
    else if (tree.Count == 1)
    {
        sb.AppendLine("Case " + caseCount + ": There is one tree.");
    }
    else
    {
        sb.AppendLine("Case " + caseCount + ": No trees.");
    }

    tree.Clear();
    circle.Clear();
    caseCount++;
}

sw.Write(sb.ToString());
sw.Flush();
sw.Close();
sr.Close();

void Union(int[] parent, int first, int second)
{
    int firstP = GetParent(parent, first);
    int secondP = GetParent(parent, second);

    if (firstP == secondP)
    {
        circle.Add(firstP);
        return;
    }

    if (circle.Contains(firstP) || circle.Contains(secondP))
    {
        circle.Add(firstP);
        circle.Add(secondP);
    }

    if (firstP > secondP)
    {
        parent[firstP] = secondP;
        return;
    }

    parent[secondP] = firstP;
}

int GetParent(int[] parent,int num)
{
    if (parent[num] == num)
    {
        return num;
    }

    return parent[num] = GetParent(parent, parent[num]);
}