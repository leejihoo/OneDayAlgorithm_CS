using System.Linq.Expressions;

var sw = new StreamWriter(Console.OpenStandardOutput());
var sr = new StreamReader(Console.OpenStandardInput());

List<KeyValuePair<int,int>>[] city = new List<KeyValuePair<int,int>>[1001];
PriorityQueue<int,int> priorityQueue = new PriorityQueue<int, int>();

var N = int.Parse(sr.ReadLine());
var M = int.Parse(sr.ReadLine());

bool[] visit = new bool[N+1];
int[] shortest = new int[N+1];
int INF = Int32.MaxValue;

for (int i = 0; i < shortest.Length; i++)
{
    shortest[i] = INF;
}

for (int i = 1; i <= N; i++)
{
    city[i] = new List<KeyValuePair<int, int>>();
}

for (int i = 0; i < M; i++)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    city[input[0]].Add(new KeyValuePair<int, int>(input[1], input[2]));
}

var question = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

priorityQueue.Enqueue(question[0],0);
visit[question[0]] = true;
shortest[question[0]] = 0;

while (priorityQueue.Count != 0)
{
    if (priorityQueue.TryDequeue(out int element, out int priority))
    {
        if (shortest[element] < priority)
        {
            continue;
        }

        for (int i = 0; i < city[element].Count; i++)
        {
            int next = city[element][i].Key;
            int nextDistance = priority + city[element][i].Value;
            if (nextDistance < shortest[next])
            {
                shortest[next] = nextDistance;
                priorityQueue.Enqueue(next, nextDistance);
            }
        }
    }
}

sw.Write(shortest[question[1]]);
sw.Flush();
sw.Close();