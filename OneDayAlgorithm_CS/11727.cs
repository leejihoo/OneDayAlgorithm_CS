int n = int.Parse(Console.ReadLine());
long[]dp= new long[n+2];
dp[0] = 0;
dp[1] = 1;
dp[2] = 3;
for (int i = 3; i < n + 1; i++)
{
    dp[i] = (dp[i - 1] + dp[i - 2] * 2) % 10007;
}

Console.Write(dp[n]);