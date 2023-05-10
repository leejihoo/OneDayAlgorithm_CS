int[][] graphOrigin = new int[5][];
for (int i = 0; i < 5; i++)
{
    graphOrigin[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}
int [] start = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
bool check = false;

if (graphOrigin[start[0]][start[1]] == 1)
{
    Dfs(start[0],start[1],0,1, graphOrigin);
}
else if(graphOrigin[start[0]][start[1]] == 0)
{
    Dfs(start[0],start[1],0,0, graphOrigin);
}

if (check)
{
    Console.Write(1);
}
else
{
    Console.Write(0);
}

void Dfs(int row, int col, int count, int apple, int[][] graph)
{
    //graph[row][col] = -1;
    int[][] temp = new int[5][];

    for (int i = 0; i < 5; i++)
    {
        temp[i] = new int[5];
    }

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            temp[i][j] = graph[i][j];
        }
    }
    
    temp[row][col] = -1;
    
    if (count > 3)
    {
        return;
    }

    if (apple >= 2)
    {
        check = true;
        return;
    }
    
    //상
    if (row - 1 >= 0)
    {
        if (temp[row - 1][col] == 0)
        {
            Dfs(row-1,col,count+1, apple, temp);
        }
        else if (temp[row - 1][col] == 1)
        {
            Dfs(row-1,col,count+1,apple+1, temp);
        }
    }
    //하
    if (row + 1 < 5)
    {
        if (temp[row + 1][col] == 0)
        {
            Dfs(row+1,col,count+1, apple, temp);
        }
        else if (temp[row + 1][col] == 1)
        {
            Dfs(row+1,col,count+1,apple+1, temp);
        }
    }
    //좌
    if (col - 1 >= 0)
    {
        if (temp[row][col-1] == 0)
        {
            Dfs(row,col-1,count+1, apple, temp);
        }
        else if (temp[row][col-1] == 1)
        {
            Dfs(row,col-1,count+1,apple+1, temp);
        }
    }
    //우
    if (col + 1 < 5)
    {
        if (temp[row][col+1] == 0)
        {
            Dfs(row,col+1,count+1, apple, temp);
        }
        else if (temp[row][col+1] == 1)
        {
            Dfs(row,col+1,count+1,apple+1, temp);
        }
    }
}