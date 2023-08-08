int N = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] dp = new int[N];
dp[0] = inputs[0];
for (int i = 1; i < N; i++)
{
    int max = 0;
    for (int j = 0; j < i; j++)
    {
        if (inputs[j] < inputs[i])
        {
            if (max < dp[j] + inputs[i])
            {
                max = dp[j] + inputs[i];
            }
        }
        
    }

    if (max != 0)
    {
        dp[i] = max;    
    }
    else
    {
        dp[i] = inputs[i];
    }
}

Console.Write(dp.Max());