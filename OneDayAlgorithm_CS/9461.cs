int T = int.Parse(Console.ReadLine());
long[] dp = new long[101];
dp[0] = 0;
dp[1] = 1;
dp[2] = 1;
dp[3] = 1;
dp[4] = 2;
dp[5] = 2;
dp[6] = 3;
dp[7] = 4;
dp[8] = 5;
for (int i = 9; i < 101; i++)
{
    dp[i] = dp[i - 2] + dp[i - 3];
}

for (int i = 0; i < T; i++)
{
   Console.WriteLine(dp[int.Parse(Console.ReadLine())]); 
}