int[] inputs;
long[,,] dp = new long[101, 101, 101];
while (true)
{
    inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (inputs[0] == -1 && inputs[1] == -1 && inputs[2] == -1)
    {
        break;
    }
    Console.WriteLine($"w({inputs[0]}, {inputs[1]}, {inputs[2]}) = {w(inputs[0],inputs[1],inputs[2])}");
}

long w(int a, int b, int c)
{
    ref long save = ref dp[a + 50, b + 50, c + 50]; 
    if (a <= 0 || b <= 0 || c <= 0)
    {
        save = 1;
        return 1;
    }

    if (a > 20 || b > 20 || c > 20)
    {
        if (dp[70, 70, 70] == 0)
        {
            dp[70, 70, 70] = w(20, 20, 20);
            save = dp[70,70,70];
        }
        else
        {
            save = dp[70, 70, 70];
        }
        
        return save;
    }

    if (a < b && b < c)
    {
        if (dp[a + 50, b + 50, c + 49] == 0)
        {
            dp[a + 50, b + 50, c + 49] = w(a, b, c - 1);
        }
        
        if (dp[a + 50, b + 49, c + 49] == 0)
        {
            dp[a + 50, b + 49, c + 49] = w(a, b - 1, c-1);
        }
        
        if (dp[a + 50, b + 49, c + 50] == 0)
        {
            dp[a + 50, b + 49, c + 50] = w(a, b - 1, c);
        }
        
        return dp[a + 50, b + 50, c + 49] + dp[a + 50, b + 49, c + 49] - dp[a + 50, b + 49, c + 50];
        //return w(a, b, c - 1) + w(a, b - 1, c - 1) - w(a, b - 1, c);
    }
    
    if (dp[a + 49, b + 50, c + 50] == 0)
    {
        dp[a + 49, b + 50, c + 50] = w(a-1, b, c);
    }
        
    if (dp[a + 49, b + 49, c + 50] == 0)
    {
        dp[a + 49, b + 49, c + 50] = w(a-1, b - 1, c);
    }
        
    if (dp[a + 49, b + 50, c + 49] == 0)
    {
        dp[a + 49, b + 50, c + 49] = w(a - 1, b, c - 1);
    }
    
    if (dp[a + 49, b + 49, c + 49] == 0)
    {
        dp[a + 49, b + 49, c + 49] = w(a - 1, b-1, c - 1);
    }

    return dp[a + 49, b + 50, c + 50] + dp[a + 49, b + 49, c + 50] + dp[a + 49, b + 50, c + 49] - dp[a + 49, b + 49, c + 49];
}