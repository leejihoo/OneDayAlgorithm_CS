using System.Runtime.InteropServices.ComTypes;

int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
List<int>[] graph = new List<int>[inputs[0]+1];
bool[] check = new bool[inputs[0] + 1];
Queue<int> queue = new Queue<int>();
int count = 0;
for (int i = 0; i <= inputs[0]; i++)
{
    graph[i] = new List<int>();
}

for (int i = 0; i < inputs[1]; i++)
{
    int[] nodes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[nodes[0]].Add(nodes[1]);
}
queue.Enqueue(inputs[3]);
check[inputs[3]] = true;
while (true)
{
    int num = queue.Count;

    if (count == inputs[2] || num == 0)
    {
        break;
    }
    
    for (int i = 0; i < num; i++)
    {
        int node = queue.Dequeue();

        for (int j = 0; j < graph[node].Count; j++)
        {
            if (check[graph[node][j]])
            {
                continue;
            }

            check[graph[node][j]] = true;
            queue.Enqueue(graph[node][j]);
        }
    }

    count++;
}

var answers = queue.ToList();
answers.Sort();

if (answers.Count == 0)
{
    Console.Write(-1);
}
else
{
    foreach (var i in answers)
    {
        Console.WriteLine(i);
    }
}



