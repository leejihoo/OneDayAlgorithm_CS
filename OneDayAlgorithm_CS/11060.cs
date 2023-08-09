int N = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[]dp = new int[N];
for (int i = 1; i < N; i++)
{
    int min = 1000;
    for (int j = 0; j < i; j++)
    {
        
        if (i - j <= inputs[j] && dp[j] >= 0)
        {
            if (min > dp[j] + 1)
            {
                min = dp[j] + 1;
            }
        }
    }
    
    if (min == 1000)
    {
        dp[i] = -1;
    }
    else
    {
        dp[i] = min;
    }
}

Console.Write(dp[N-1]);