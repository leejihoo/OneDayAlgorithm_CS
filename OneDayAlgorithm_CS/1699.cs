int N = int.Parse(Console.ReadLine());
long[]dp = new long[N+2];
dp[0] = 0;
dp[1] = 1;
dp[2] = 2;
for (int i = 3; i < N + 1; i++)
{
    long min = 100000;
    double sqrtVar = Math.Sqrt(i);
    if (sqrtVar - (int)sqrtVar == 0)
    {
        dp[i] = 1;
        continue;
    }
    
    for (int j = i - 1; j >= i / 2.0; j--)
    {
        long temp = dp[j] + dp[i - j];
        if (min > temp)
        {
            min = temp;
        }
    }

    dp[i] = min;
}

Console.Write(dp[N]);