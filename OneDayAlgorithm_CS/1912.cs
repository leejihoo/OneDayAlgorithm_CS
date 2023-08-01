int N = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
long[] dp = new long[N];
long max = -1001;
dp[0] = inputs[0];
max = dp[0];

for (int i = 1; i < N; i++)
{
    long temp = dp[i - 1] + inputs[i];
    if (temp > dp[i - 1])
    {
        if (max < temp)
        {
            max = temp;
        }
        
    }
    

    if (temp < inputs[i])
    {
        dp[i] = inputs[i];
        if (inputs[i] > max)
        {
            max = inputs[i];
        }
    }
    else
    {
        dp[i] = temp;
    }
    
}

Console.Write(max);