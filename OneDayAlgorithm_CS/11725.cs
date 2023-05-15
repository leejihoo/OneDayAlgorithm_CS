using System.Text;

int N = int.Parse(Console.ReadLine());
List<List<int>> graph = new List<List<int>>();
bool[] check = new bool[N];
int[] parent = new int[N];
parent[0] = 1;
Queue<int> bfs = new Queue<int>();
StringBuilder stringBuilder = new StringBuilder();

for (int i = 0; i < N; i++)
{
    graph.Add(new List<int>());
}

for (int i = 0; i < N-1; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[input[0]-1].Add(input[1]);    
    graph[input[1]-1].Add(input[0]);
}

// bfs 풀이 
bfs.Enqueue(1);
while (bfs.Count > 0)
{
    int start = bfs.Dequeue();
    if (!check[start - 1])
    {
        check[start - 1] = true;
        foreach (var node in graph[start-1])
        {
            if (parent[node - 1] == 0)
            {
                parent[node-1] = start;
            }
            bfs.Enqueue(node);
        }
    }
}


// 공통 출력부
for (int i = 1; i < parent.Length; i++)
{
    if (i == parent.Length - 1)
    {
        stringBuilder.Append(parent[i]);
        break;
    }
    stringBuilder.Append(parent[i] + "\n");
}

Console.Write(stringBuilder);



