int N = int.Parse(Console.ReadLine());
int[] dp = new int[N+1];
dp[0] = 0;

for (int i = 1; i <= N; i++)
{
    int temp1 = 1001;
    int temp2 = 1001;
    
    if (i - 1 >= 0)
    {
        temp1 = dp[i - 1] + 1;
    }

    if (i - 3 >= 0)
    {
        temp2 = dp[i - 3] + 1;
    }

    dp[i] = temp1 < temp2? temp1 : temp2;
}

Console.Write(dp[N]%2 == 0?"CY":"SK");