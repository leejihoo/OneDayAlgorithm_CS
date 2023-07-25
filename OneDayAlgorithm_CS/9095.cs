int T = int.Parse(Console.ReadLine());
int[] dp = new int[12];
dp[0] = 1;
dp[1] = 1;
dp[2] = 2;
for (int i = 3; i < 12; i++)
{
    // 맨 앞이 1일 때, 2일 때, 3일 때 
    dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
}

for (int i = 0; i < T; i++)
{
    Console.WriteLine(dp[int.Parse(Console.ReadLine())]);
}