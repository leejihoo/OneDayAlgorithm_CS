int n = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] dp = new int[n+1];
dp[1] = 1;
for (int i = 2; i <= n; i++)
{
    int max = 1;
    for (int j = 1; j < i; j++)
    {
        if (inputs[j-1] < inputs[i-1])
        {
            if (max < dp[j] + 1)
            {
                max = dp[j] + 1;
            }
        }
        // else
        // {
        //     if (max < dp[j])
        //     {
        //         max = dp[j];
        //     }
        // }
    }

    dp[i] = max;
}
Console.Write(dp.Max());