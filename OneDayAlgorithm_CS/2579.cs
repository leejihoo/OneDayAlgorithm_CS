int N = int.Parse(Console.ReadLine());
long[] dp = new long[N + 2];
int[] score = new int[N + 2];
score[0] = 0;
for (int i = 1; i < N+1; i++)
{
    score[i] = int.Parse(Console.ReadLine());
}

dp[0] = 0;
dp[1] = score[1];
dp[2] = score[1] + score[2];

for (int i = 3; i < N + 1; i++)
{
    dp[i] = Math.Max(score[i - 1] + dp[i - 3], dp[i - 2]) + score[i];
}

Console.Write(dp[N]);