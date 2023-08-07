int N = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] dp = new int[N+1];
Array.Fill(dp,1);

for (int i = 2; i <= N; i++)
{
    for (int j = 1; j < i; j++)
    {
        if (inputs[j-1] < inputs[i-1])
        {
            if (dp[i] < dp[j] + 1)
            {
                dp[i] = dp[j] + 1;
            }
        }
        // else
        // {
        //     if (dp[i] < dp[j])
        //     {
        //         dp[i] = dp[j];
        //     }
        // }
    }
}

Console.Write(dp.Max());
