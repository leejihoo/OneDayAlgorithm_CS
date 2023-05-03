string [][] board = new string[5][];
List<string> answer = new List<string>();
for (int i = 0; i < 5; i++)
{
    board[i] = Console.ReadLine().Split();
}

void dfs(int row, int col, string cur)
{
    string numbers = cur + board[row][col];
    if (numbers.Length == 6)
    {
        if (!answer.Contains(numbers))
        {
            answer.Add(numbers);
        }
        
        return;
    }
    //위로 이동
    if (row - 1 >= 0)
    {
        dfs(row-1,col,numbers);
    }
    //아래로 이동
    if (row + 1 < 5)
    {
        dfs(row + 1, col, numbers);
    }
    //왼쪽으로 이동
    if (col - 1 >= 0)
    {
        dfs(row, col-1,numbers);
    }
    //오른쪽으로 이동
    if (col + 1 < 5)
    {
        dfs(row,col+1,numbers);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        dfs(i,j,"");
    }
}

Console.Write(answer.Count);