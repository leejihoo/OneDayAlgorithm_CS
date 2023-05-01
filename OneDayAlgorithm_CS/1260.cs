int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[,] graph = new int[inputs[0],inputs[0]];
Queue<int> bfs = new Queue<int>();
Stack<int> dfs = new Stack<int>();
bool[] check = new bool[inputs[0]];

for (int i = 0; i < inputs[1]; i++)
{
    int[] vertex = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[vertex[0] - 1, vertex[1] - 1] = 1;
    graph[vertex[1] - 1, vertex[0] - 1] = 1;
}

dfs.Push(inputs[2]);
check[inputs[2]-1] = true;
Console.Write(inputs[2]+" ");
int num = 1;

while (dfs.Count > 0)
{
    int search = dfs.Peek();
    
    bool flag = false;
    // 선입후출이기 때문에 큰 수부터 넣어야 정점 번호가 작은것부터 넣어진다. 
    for (int i = 0; i < inputs[0]; i++)
    {
        if (graph[search - 1, i] == 1)
        {
            if (!check[i])
            {
                check[i] = true;
                flag = true;
                dfs.Push(i+1);

                Console.Write((i+1) +" ");    
                
                break;
            }
        }    
    }

    if (!flag)
    {
        dfs.Pop();
    }
}
Console.WriteLine();
Array.Clear(check);

bfs.Enqueue(inputs[2]);
check[inputs[2] - 1] = true;
while (bfs.Count > 0)
{
    int search = bfs.Dequeue();
    for (int i = 0; i < inputs[0]; i++)
    {
        // 정점 번호가 작은것부터 넣어진다.
        if (graph[search - 1, i] == 1)
        {
            if (!check[i])
            {
                check[i] = true;
                bfs.Enqueue(i+1);
            }
        }    
    }

    if (bfs.Count == 0)
    {
        Console.WriteLine(search);
    }
    else
    {
        Console.Write(search+" ");
    }
}