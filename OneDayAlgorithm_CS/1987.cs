int[] rc = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
string[] graph = new string[rc[0]];
bool[,] check = new bool[rc[0], rc[1]];
int max = 0;
List<char> alphabet = new List<char>();

for (int i = 0; i < rc[0]; i++)
{
    graph[i] = Console.ReadLine();
}

Dfs(0,0,0);
Console.Write(max);

void Dfs(int row, int col, int count)
{
    if (check[row, col] || alphabet.Contains(graph[row][col]))
    {
        if (count > max)
        {
            max = count;
        }
        return;
    }
    alphabet.Add(graph[row][col]);
    count++;
    check[row, col] = true;
    
    //상
    if (row - 1 >= 0)
    {
        Dfs(row-1,col,count);
    }
    //하
    if (row + 1 < rc[0])
    {
        Dfs(row+1,col,count);
    }
    //좌
    if (col - 1 >= 0)
    {
        Dfs(row,col-1,count);
    }
    //우
    if (col + 1 < rc[1])
    {
        Dfs(row,col+1,count);
    }
    
    alphabet.Remove(graph[row][col]);
    check[row, col] = false;
}