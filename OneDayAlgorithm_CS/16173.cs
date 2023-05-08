int N = int.Parse(Console.ReadLine());
int[][] graph = new int[N][];
bool check = false;
bool[,] visit = new bool[N, N];
for (int i = 0; i < N; i++)
{
    graph[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

Dfs(0,0);
if (!check)
{
    Console.Write("Hing");
}
else
{
    Console.Write("HaruHaru");
}

void Dfs(int row, int col)
{
    if (check)
    {
        return;
    }
    
    if (row == N-1 && col == N-1)
    {
        check = true;
        return;
    }

    int temp = graph[row][col];
    //아래로 이동
    if (row + temp < N && !visit[row+temp,col])
    {
        visit[row + temp, col] = true;
        Dfs(row + temp,col);
    }

    //오른쪽으로 이동
    if (col + temp< N && !visit[row,col+temp])
    {
        visit[row, col + temp] = true;
        Dfs(row,col + temp);
    }
}
