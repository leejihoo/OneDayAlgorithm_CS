int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[,] graph = new int[inputs[0],inputs[1]];
bool[,] check = new bool[inputs[0], inputs[1]];
int max = 0;
int count = 0;

for (int i = 0; i < inputs[2]; i++)
{
    int[] edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    graph[edge[0]-1, edge[1]-1] = 1;
}

for(int i = 0; i<inputs[0]; i++){
    for (int j = 0; j < inputs[1]; j++)
    {
        Dfs(i,j);
        if (max < count)
        {
            max = count;
        }

        count = 0;
    }
}

Console.Write(max);

void Dfs(int row, int col)
{
    if (check[row, col] == false && graph[row,col] == 1)
    {
        check[row, col] = true;
        count++;
        if (row-1 >= 0)
        {
            Dfs(row-1,col);
        }

        if (col-1 >= 0)
        {
            
            Dfs(row,col-1);
        }

        if (row+1 < inputs[0])
        {
            Dfs(row+1,col);
        }

        if (col+1 < inputs[1])
        {
            Dfs(row,col+1);
        }
    }
}
