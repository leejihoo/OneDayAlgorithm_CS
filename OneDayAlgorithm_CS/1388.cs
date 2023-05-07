int[] size = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
string[] floor = new string[size[0]];
bool[,] check = new bool[size[0],size[1]];
int count = 0;
for (int i = 0; i < size[0]; i++)
{
    floor[i] = Console.ReadLine();
}

for (int i = 0; i < size[0]; i++)
{
    for (int j = 0; j < size[1]; j++)
    {
        if (!check[i, j])
        {
            count++;
            dfs(i,j);
        }
    }
}

Console.Write(count);

void dfs(int row, int col)
{
    check[row, col] = true;
    if (row + 1 < size[0] && floor[row][col] == '|' && floor[row][col] == floor[row+1][col] )
    {
        dfs(row + 1, col);
    }
    else if(col + 1 < size[1] && floor[row][col] == '-' && floor[row][col] == floor[row][col+1])
    {
        dfs(row,col+1);
    }
}