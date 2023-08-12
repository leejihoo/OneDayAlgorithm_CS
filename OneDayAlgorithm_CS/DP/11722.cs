int N = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] dp = new int[N];
Array.Fill(dp,1);
int min = 1001;

for (int i = 1; i < N; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (inputs[j] > inputs[i])
        {
            if (dp[i] < dp[j] + 1)
            {
                dp[i] = dp[j] + 1;
            }
        }
    }
}

Console.WriteLine(dp.Max());