int N = int.Parse(Console.ReadLine());
long[] dp = new long[N+2];
dp[0] = 1;
dp[1] = 1;
dp[2] = 1;
for (int i = 3; i <= N; i++)
{
    dp[i] = dp[i - 1] + dp[i - 2];
}
Console.Write(dp[N]);