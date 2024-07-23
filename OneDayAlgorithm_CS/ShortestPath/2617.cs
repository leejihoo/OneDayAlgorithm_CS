StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

var NM = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
bool[,]graph = new bool[NM[0],NM[0]];

for (int i = 0; i < NM[1]; i++)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
    graph[input[0] - 1, input[1] - 1] = true;
}

for (int i = 0; i < NM[0]; i++)
{
    for (int j = 0; j < NM[0]; j++)
    {
        for (int k = 0; k < NM[0]; k++)
        {
            if (graph[j, k] == false)
            {
                if (graph[j, i] && graph[i, k])
                {
                    graph[j, k] = true;
                }
            }
        }
    }
}

int answer = 0;
for (int i = 0; i < NM[0]; i++)
{
    int lightMarble = 0;
    int heavyMarble = 0;
    for (int j = 0; j < NM[0]; j++)
    {
        if (graph[i, j])
        {
            heavyMarble++;
        }

        if (graph[j, i])
        {
            lightMarble++;
        }
    }

    if (heavyMarble >= (NM[0] + 1) / 2 || lightMarble >= (NM[0] + 1) / 2)
    {
        answer++;
    }
}

sw.Write(answer);
sw.Flush();
sw.Close();
sr.Close();