int N = int.Parse(Console.ReadLine());
BodyInfo[] bodyInfos = new BodyInfo[N];
int[] rank = new int[N];
Array.Fill(rank,1);

for (int i = 0; i < N; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    bodyInfos[i] = new BodyInfo();
    bodyInfos[i].weight = input[0];
    bodyInfos[i].height = input[1];
}

for (int i = 0; i < N; i++)
{
    for (int j = i+1; j < N; j++)
    {
        if (bodyInfos[i].weight > bodyInfos[j].weight && bodyInfos[i].height > bodyInfos[j].height)
        {
            rank[j] += 1;
            continue;
        }
        
        if (bodyInfos[i].weight < bodyInfos[j].weight && bodyInfos[i].height < bodyInfos[j].height)
        {
            rank[i] += 1;
        }
    }
}

Console.WriteLine(String.Join(" ", rank));


public class BodyInfo
{
    public int weight;
    public int height;
}