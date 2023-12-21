using System.Runtime.CompilerServices;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

List<Node> nodes = new List<Node>();
HashSet<int> hashSet = new HashSet<int>();

int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] parent = new int[nm[0] + 1];
for (int i = 1; i < parent.Length; i++)
{
    parent[i] = i;
}

for (int i = 0; i < nm[1]; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    nodes.Add(new Node(input));
}

int[] question = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

var sorted = nodes.OrderByDescending(node => node.Cost).ToList();

foreach (var node in sorted)
{
    Union(node.Start,node.End);
    // hashSet.Add(node.Start);
    // hashSet.Add(node.End);

    // if (hashSet.Contains(question[0]) && hashSet.Contains(question[1]))
    // {
    //     sw.Write(node.Cost);
    //     break;
    // }

    if (GetParent(question[0]) == GetParent(question[1]))
    {
        sw.Write(node.Cost);
        break;
    }
}

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

    if (firstP == second)
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

public class Node
{
    public int Start;
    public int End;
    public int Cost;

    public Node(int[] input)
    {
        Start = input[0];
        End = input[1];
        Cost = input[2];
    }
    
}

