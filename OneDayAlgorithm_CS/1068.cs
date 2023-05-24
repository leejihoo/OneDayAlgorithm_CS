int N = int.Parse(Console.ReadLine());
int[] parent = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int deletedNode = int.Parse(Console.ReadLine());
int count = 0;
int start = 0;
List<List<int>> tree = new List<List<int>>();

for (int i = 0; i < N; i++)
{
    tree.Add(new List<int>());
}

for (int i = 0; i < N; i++)
{
    if (parent[i] != -1)
    {
        tree[parent[i]].Add(i);    
    }
    else
    {
        start = i;
    }
}

Dfs(start);
Console.Write(count);

void Dfs(int node)
{
    if (node != deletedNode)
    {
        if (tree[node].Count > 0)
        {
            for (int i = 0; i < tree[node].Count; i++)
            {
                if (tree[node].Count == 1 && tree[node][i] == deletedNode)
                {
                    count++;
                }
                Dfs(tree[node][i]); 
            }    
        }
        else
        {
            count++;
        }
    }
}