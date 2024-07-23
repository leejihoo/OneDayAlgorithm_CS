StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

var NM = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);

int[,] graph = new int[NM[0],NM[0]];
int INF = 501;

for (int i = 0; i < NM[0]; i++)
{
    for (int j = 0; j < NM[0]; j++)
    {
        if (i == j)
        {
            continue;
        }

        graph[i, j] = INF;
    }
}

for (int i = 0; i < NM[1]; i++)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
    graph[input[0]-1, input[1]-1] = 1;
}

for (int i = 0; i < NM[0]; i++)
{
    for (int j = 0; j < NM[0]; j++)
    {
        for (int k = 0; k < NM[0]; k++)
        {
            if (graph[j, k] > graph[j, i] + graph[i, k])
            {
                graph[j, k] = graph[j, i] + graph[i, k];
            }
        }
    }
}

int answer = 0;

for (int i = 0; i < NM[0]; i++)
{
    int count = 0;
    for (int j = 0; j < NM[0]; j++)
    {
        if ((graph[i, j] != 0 && graph[i, j] != INF) || (graph[j, i] != 0 && graph[j, i] != INF))
        {
            count++;
        }
    }

    if (count == NM[0] - 1)
    {
        answer++;
    }
}

sw.Write(answer);
sw.Flush();
sw.Close();
sr.Close();