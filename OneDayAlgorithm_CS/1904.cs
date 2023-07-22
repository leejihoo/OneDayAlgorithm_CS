﻿int N = int.Parse(Console.ReadLine());
int[] dp = new int[1000001];
dp[0] = 0;
dp[1] = 1;
dp[2] = 2;
for (int i = 3; i <= N; i++)
{
    dp[i] = (dp[i - 1] + dp[i - 2]) %15746;
}
Console.Write(dp[N]);