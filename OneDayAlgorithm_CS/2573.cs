int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[][]graph = new int[nm[0]][];
int[][] meltedGraph = new int[nm[0]][];
bool[,]check =new bool[nm[0],nm[1]];
int count = 0;
bool isIce = false;
bool isAllMelt = false;
int yearForMelting = 0; 
for (int i = 0; i < nm[0]; i++)
{
    graph[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    // deep copy
    meltedGraph[i] = graph[i].ToArray();

}
// shallow copy
//meltedGraph = graph.ToArray();


while (!isAllMelt)
{
    isAllMelt = true;

    for (int i = 0; i < nm[0]; i++)
    {
        for (int j = 0; j < nm[1]; j++)
        {
            Dfs(i,j);
            isIce = false;
        }
    }

    if (count >= 2)
    {
        break;
    }

    count = 0;
    
    for (int i = 0; i < nm[0]; i++)
    {
        if (!(graph[i].All(x=> x== 0)))
        {
            isAllMelt = false;
            break;
        }   
    }
    
    for (int i = 0; i < nm[0]; i++)
    {
        for (int j = 0; j < nm[1]; j++)
        {
            check[i, j] = false;
            int zeroCount = 0;

            if (graph[i][j] != 0)
            {
                //동
                if (graph[i][j + 1] == 0)
                {
                    zeroCount += 1;
                }
                //서
                if (graph[i][j - 1] == 0)
                {
                    zeroCount += 1;
                }
                //남
                if (graph[i+1][j] == 0)
                {
                    zeroCount += 1;
                }
                //북
                if (graph[i-1][j] == 0)
                {
                    zeroCount += 1;
                }
            }

            if (graph[i][j] > zeroCount)
            {
                meltedGraph[i][j] -= zeroCount;
            }
            else
            {
                meltedGraph[i][j] = 0;
            }
        }
    }
    
    for (int i = 0; i < nm[0]; i++)
    {
        for (int j = 0; j < nm[1]; j++)
        {
            graph[i][j] = meltedGraph[i][j];
        }
    }

    yearForMelting += 1;
}

if(count >= 2)
{
    Console.Write(yearForMelting);
}
else
{
    Console.Write(0);
}

void Dfs(int row, int col)
{
    if (check[row, col] || graph[row][col] == 0)
    {
        return;
    }
    
    check[row, col] = true;
    
    if (!isIce)
    {
        isIce = true;
        count++;
    }
    
    //하
    if (row + 1 < nm[0])
    {
        Dfs(row+1,col);
    }
    //상
    if (row - 1 >= 0)
    {
        Dfs(row-1,col);
    }
    //좌
    if (col - 1 >= 0)
    {
        Dfs(row,col-1);
    }
    //우
    if (col + 1 < nm[1])
    {
        Dfs(row,col+1);
    }
    
}