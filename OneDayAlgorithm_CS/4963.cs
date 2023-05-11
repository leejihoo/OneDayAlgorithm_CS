while (true)
{
    int[] length = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    bool[,] check = new bool[length[1], length[0]];
    bool isCount = false;
    int answer = 0;
    if (length[0] == 0)
    {
        break;
    }

    int[][] graph = new int[length[1]][];
    for (int i = 0; i < length[1]; i++)
    {
        graph[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    }

    for (int i = 0; i < length[1]; i++)
    {
        for (int j = 0; j < length[0]; j++)
        {
            Dfs(i,j,check,length[1],length[0], graph,ref isCount);
            if (isCount)
            {
                answer++;
                isCount = false;
            }
        }
    }
    Console.WriteLine(answer);
}

void Dfs(int row, int col, bool[,] check, int maxRow, int maxCol, int[][] graph, ref bool isCounted)
{
    if (graph[row][col] == 1 && check[row, col] == false)
    {
        if (!isCounted)
        {
            isCounted = true;
        }
        check[row, col] = true;
        //좌상
        if (row - 1 >= 0 && col - 1 >= 0)
        {
            // 미리 검사할 필요가 있을까? dfs돌면 자동으로 검사하긴하는데..
            if (check[row - 1, col - 1] == false)
            {
                Dfs(row-1,col-1,check,maxRow,maxCol,graph,ref isCounted);
            }
        }
        //상
        if (row - 1 >= 0)
        {
            if (check[row - 1, col] == false)
            {
                Dfs(row-1,col,check,maxRow,maxCol,graph,ref isCounted);
            }
        }
        //우상
        if (row - 1 >= 0 && col + 1 < maxCol)
        {
            if (check[row - 1, col + 1] == false)
            {
                Dfs(row-1,col+1,check,maxRow,maxCol,graph,ref isCounted);
            }
        }
        //우
        if (col + 1 < maxCol)
        {
            if (check[row, col + 1] == false)
            {
                Dfs(row,col+1,check,maxRow,maxCol,graph,ref isCounted);
            }
        }
        //우하
        if (row + 1 < maxRow && col + 1 < maxCol)
        {
            if (check[row + 1, col + 1] == false)
            {
                Dfs(row+1,col+1,check,maxRow,maxCol,graph,ref isCounted);
            }
        }
        //하
        if (row + 1 < maxRow)
        {
            if (check[row + 1, col] == false)
            {
                Dfs(row+1,col,check,maxRow,maxCol,graph,ref isCounted);
            }
        }
        //좌하
        if (col - 1 >= 0 && row + 1 < maxRow)
        {
            if (check[row + 1, col - 1] == false)
            {
                Dfs(row+1,col-1,check,maxRow,maxCol,graph,ref isCounted);
            }
        }
        //좌
        if (col - 1 >= 0)
        {
            if (check[row, col - 1] == false)
            {
                Dfs(row,col-1,check,maxRow,maxCol,graph,ref isCounted);
            }
        }
    }
}