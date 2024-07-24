StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

var ve = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

int[,] graph = new int[ve[0], ve[0]];
int INF = 4000001;

for (int i = 0; i < ve[0]; i++)
{
    for (int j = 0; j < ve[0]; j++)
    {
        if (i == j)
        {
            continue;
        }

        graph[i, j] = INF;
    }
}

for (int i = 0; i < ve[1]; i++)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    graph[input[0]-1, input[1]-1] = input[2];
}

for (int i = 0; i < ve[0]; i++)
{
    for (int j = 0; j < ve[0]; j++)
    {
        for (int k = 0; k < ve[0]; k++)
        {
            if (graph[j, k] > graph[j, i] + graph[i, k])
            {
                graph[j, k] = graph[j, i] + graph[i, k];
            }
        }
    }
}

int answer = INF*2;
for (int i = 0; i < ve[0]; i++)
{
    for (int j = i + 1; j < ve[0]; j++)
    {
        if (graph[i, j] != 0 && graph[i, j] < INF && graph[j,i] < INF)
        {
            if (answer > graph[i, j] + graph[j, i])
            {
                answer = graph[i, j] + graph[j, i];
            }
        }
    }
}

if (answer == INF*2)
{
    answer = -1;
}

sw.Write(answer);
sw.Flush();
sw.Close();
sr.Close();