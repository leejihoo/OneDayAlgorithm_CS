using System.ComponentModel.Design;

int [] mn = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[,] graph = new int[mn[0],mn[0]];
bool[] check = new bool[mn[0]];
int output = 0;
// edge의 갯수는 node-1개
for (int i = 0; i < mn[0]-1; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[inputs[0] - 1, inputs[1] - 1] = inputs[2];
    graph[inputs[1] - 1, inputs[0] - 1] = inputs[2];
}

for (int i = 0; i < mn[1]; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Dfs(inputs[0],inputs[1],0);
    
    for (int j = 0; j < check.Length; j++)
    {
        check[j] = false;
    }
    Console.WriteLine(output);
}

void Dfs(int start, int end, int answer)
{
    if (!check[start-1])
    {
        check[start-1] = true;
        if (graph[start - 1, end - 1] != 0)
        {
            output = answer + graph[start - 1, end - 1];
            return;
        }
        
        for (int i = 0; i < mn[0]; i++)
        {
            if (graph[start-1, i] != 0)
            {
                Dfs(i+1, end, answer + graph[start-1, i]);
            }
        }
    }
}