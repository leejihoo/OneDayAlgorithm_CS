StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int N;
N = int.Parse(sr.ReadLine());
List<Tuple<int,int>>[] users = new List<Tuple<int,int>>[N + 1];
int INF = 50;
int[] score = new int[N + 1];
score[0] = 50;

for (int i = 1; i < N+1; i++)
{
    users[i] = new List<Tuple<int, int>>();
}

while (true)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    if (input[0] == -1)
    {
        break;
    }
    
    users[input[0]].Add(new Tuple<int, int>(input[1], 1));
    users[input[1]].Add(new Tuple<int,int>(input[0], 1));
}

for (int i = 1; i < N+1; i++)
{
    int[] shortDistance = new int[N+1];
    Array.Fill(shortDistance,INF);
    PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
    priorityQueue.Enqueue(i,0);
    shortDistance[0] = 0;
    shortDistance[i] = 0;
    
    while (priorityQueue.Count > 0)
    {
        if (priorityQueue.TryDequeue(out int num, out int cost))
        {
            if (shortDistance[num] < cost) return;
            foreach (var pair in users[num])
            {
                int next = pair.Item1;
                int nextCost = pair.Item2 + cost;
                if (nextCost < shortDistance[next])
                {
                    shortDistance[next] = nextCost;
                    priorityQueue.Enqueue(next,nextCost);
                }
            }
        }
    }

    score[i] = shortDistance.Max();
}

int minScore = score.Min();
int chairmanCount = 0;
List<int> chairmanList = new List<int>();

for (int i = 1; i < N+1; i++)
{
    if (score[i] == minScore)
    {
        chairmanCount++;
        chairmanList.Add(i);
    }
}

sw.WriteLine(minScore+ " " + chairmanCount);
sw.WriteLine(String.Join(" ",chairmanList));
sw.Flush();
sw.Close();
