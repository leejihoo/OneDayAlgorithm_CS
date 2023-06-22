int[] nk = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
Queue<int> queue = new Queue<int>();
bool[] check = new bool[100001];
int answer = -1;
queue.Enqueue(nk[0]);
check[nk[0]] = true;
while (queue.Count != 0)
{
    answer++;
    int count = queue.Count;
    
    for (int i = 0; i < count; i++)
    {
        int node = queue.Dequeue();
        if (node == nk[1])
        {
            queue.Clear();
            break;
        }
        
        if (node -1 >= 0 && node -1 <= 100000 && !check[node - 1])
        {
            check[node - 1] = true;
            queue.Enqueue(node-1);
        }

        if (node + 1 >= 0 && node + 1 <= 100000 && !check[node + 1])
        {
            check[node + 1] = true;
            queue.Enqueue(node+1);
        }

        if (node * 2 >= 0 && node * 2 <= 100000 && !check[node * 2])
        {
            check[node * 2] = true;
            queue.Enqueue(node*2);
        }
    }
    
}

Console.Write(answer);