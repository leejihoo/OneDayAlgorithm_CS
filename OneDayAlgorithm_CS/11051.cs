int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
long[,] dp = new long[1001,1001];


long binomialCoefficient(int n, int k)
{
    if (dp[n, k] != 0)
    {
        return dp[n, k];
    }

    // if (n < k)
    // {
    //     return dp[n, k] = 0;
    // }
    
    if (k == 0 || n == k)
    {
        return dp[n, k] = 1;
    }
    
    if (k == 1)
    {
        return dp[n, k] = n;
    }

    return dp[n, k] = (binomialCoefficient(n-1,k-1) + binomialCoefficient(n-1,k)) % 10007;
}

long factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }
    
    return factorial(n - 1) * n;
}

Console.Write(binomialCoefficient(inputs[0],inputs[1]));