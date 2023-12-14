using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int T = int.Parse(sr.ReadLine());
HashSet<int> groupRoot = new HashSet<int>();

while (T > 0)
{
    int N = int.Parse(sr.ReadLine());
    List<int[]> xyr = new List<int[]>();
    int[] parent = new int[3001];

    for (int i = 1; i < parent.Length; i++)
    {
        parent[i] = i;
    }
    
    for (int i = 0; i < N; i++)
    {
        xyr.Add(Array.ConvertAll(sr.ReadLine().Split(),int.Parse));
    }

    for (int i = 0; i < xyr.Count; i++)
    {
        for (int j = i + 1; j < xyr.Count; j++)
        {
            Union(xyr[i], xyr[j], parent, i + 1, j + 1);
        }
    }

    for (int i = 1; i <= xyr.Count; i++)
    {
        groupRoot.Add(GetParent(parent,i));
    }
   
    sw.WriteLine(groupRoot.Count);
    groupRoot.Clear();
    T--;
}

sw.Flush();
sw.Close();
sr.Close();

void Union(int[] firstArr, int[] secondArr, int[] parent, int first, int second)
{
    int firstP = GetParent(parent,parent[first]);
    int secondP = GetParent(parent, parent[second]);

    if (firstP == secondP)
    {
        return;
    }

    var distance = Math.Sqrt(Math.Pow(firstArr[0] - secondArr[0], 2) + Math.Pow(firstArr[1] - secondArr[1], 2));

    if (distance > firstArr[2] + secondArr[2])
    {
        return;
    }

    if (firstP > secondP)
    {
        parent[firstP] = secondP;
        return;
    }

    parent[secondP] = parent[firstP];

}

int GetParent(int[] parent, int num)
{
    if (parent[num] == num)
    {
        return num;
    }

    return parent[num] = GetParent(parent,parent[num]);
}