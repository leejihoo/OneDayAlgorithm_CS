int node =  int.Parse(Console.ReadLine());
int edge = int.Parse(Console.ReadLine());
int [,] graph = new int[node,node];
bool[] check = new bool[node];
for (int i = 0; i < edge; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[input[0] - 1, input[1] - 1] = 1;
    graph[input[1] - 1, input[0] - 1] = 1;
}

check[0] = true;
for (int i = 0; i < node; i++)
{
    Dfs(0,i);
}

Console.Write(check.Where(x => x == true).Count()-1);

void Dfs(int row, int col)
{
    if (graph[row, col] == 1 && !check[col])
    {
        check[col] = true;
        for (int i = 0; i < node; i++)
        {
            if(!check[i])
                Dfs(col,i);    
        }
    }
}