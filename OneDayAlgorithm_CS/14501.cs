int N = int.Parse(Console.ReadLine());
int[,] inputs = new int[N+1,2];
int[] dp = new int[N+1];
inputs[0,0] = dp[0] = 0;
inputs[0,1] = dp[1] = 0;
int max = 0;

for (int i = 1; i < N + 1; i++)
{
    var temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    inputs[i, 0] = temp[0];
    inputs[i, 1] = temp[1];
}

void Dfs(int day, int sum)
{
    //쉴 때
    if (day + 1 <= N)
    {
        Dfs(day + 1, sum);        
    }

    //안 쉴 때
    if (day + inputs[day, 0] <= N + 1)
    {
        if (day + inputs[day, 0] == N + 1)
        {
            sum += inputs[day, 1];
        }
        else
        {
            Dfs(day + inputs[day, 0], sum + inputs[day,1]);
        }
    }

    if (max < sum)
    {
        max = sum;
    }
    
}
Dfs(1,0);
Console.Write(max);