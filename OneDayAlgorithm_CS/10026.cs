using Microsoft.Win32;

int N = int.Parse(Console.ReadLine());
string[] graph = new string[N];
bool[,] check = new bool[N, N];
int count = 0;
bool isCounted = false;

for (int i = 0; i < N; i++)
{
    graph[i] = Console.ReadLine();
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Dfs(graph[i][j],false,i,j);
        isCounted = false;
    }
}
Console.Write(count);

for (var i = 0; i < N; i++)
{
    for (var j = 0; j < N; j++)
    {
        check[i, j] = false;
    }
}

count = 0;

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Dfs(graph[i][j],true,i,j);
        isCounted = false;
    }
}
Console.Write(" "+count);

void Dfs(char startColor, bool isColorWeakness, int row, int col)
{
    if (check[row,col])
    {
        return;
    }

    if (graph[row][col] != startColor)
    {
        if ( !(isColorWeakness && startColor != 'B' && graph[row][col] != 'B') )
        {
            return;
        }
    }

    check[row, col] = true;

    if (!isCounted)
    {
        count++;
        isCounted = true;
    }
    
    //상
    if (row + 1 < N)
    {
        Dfs(startColor,isColorWeakness,row+1,col);
    }
    //하
    if (row - 1 >= 0)
    {
        Dfs(startColor,isColorWeakness,row-1,col);
    }
    //좌
    if (col - 1 >= 0)
    {
        Dfs(startColor,isColorWeakness,row,col-1);
    }
    //우
    if (col + 1 < N)
    {
        Dfs(startColor,isColorWeakness,row,col+1);
    }
}