int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
string[] graph = new string[nm[0]];
Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
bool[,] check = new bool[nm[0],nm[1]];
int weight = 0;
for (int i = 0; i < nm[0]; i++)
{
    graph[i] = Console.ReadLine();
}

queue.Enqueue(new Tuple<int, int>(0,0));
check[0,0] = true;

while (queue.Count != 0)
{
    int qCount = queue.Count;
    weight++;
    
    for (int i = 0; i < qCount; i++)
    {
        var node = queue.Dequeue();

        if (node.Item1 == nm[0] - 1 && node.Item2 == nm[1] - 1)
        {
            queue.Clear();
            break;
        }
        
        //상
        if (node.Item1 - 1 >= 0)
        {
            if (!check[node.Item1 - 1, node.Item2] && graph[node.Item1 - 1][node.Item2] == '1')
            {
                queue.Enqueue(new Tuple<int, int>(node.Item1 - 1,node.Item2));
                check[node.Item1 - 1, node.Item2] = true;
            }
        }
        //하
        if (node.Item1 + 1 < nm[0])
        {
            if (!check[node.Item1 + 1, node.Item2] && graph[node.Item1 + 1][node.Item2] == '1')
            {
                queue.Enqueue(new Tuple<int, int>(node.Item1 + 1,node.Item2));
                check[node.Item1 + 1, node.Item2] = true;
            }
        }
        //좌
        if (node.Item2 - 1 >= 0)
        {
            if (!check[node.Item1,node.Item2 - 1] && graph[node.Item1][node.Item2 - 1] == '1')
            {
                queue.Enqueue(new Tuple<int, int>(node.Item1,node.Item2 - 1));
                check[node.Item1, node.Item2 - 1] = true;
            }
        }
        //우
        if (node.Item2 + 1 < nm[1])
        {
            if (!check[node.Item1,node.Item2 + 1] && graph[node.Item1][node.Item2 + 1] == '1')
            {
                queue.Enqueue(new Tuple<int, int>(node.Item1,node.Item2 + 1));
                check[node.Item1, node.Item2 + 1] = true;
            }
        }
    }
}

Console.Write(weight);