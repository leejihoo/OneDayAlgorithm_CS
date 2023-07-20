int N = int.Parse(Console.ReadLine());
int[] dp = new int[5001];
dp[0] = 0;
dp[1] = -1;
dp[2] = -1;
dp[3] = 1;
dp[4] = -1;
dp[5] = 1;
for (int i = 6; i < N+1; i++)
{
    int temp3 = -1;
    int temp5 = -1;
    
    if (i - 3 >= 0)
    {
        if (dp[i - 3] != -1)
        {
            temp3 = dp[i - 3] + dp[3];
        }    
    }

    if (i - 5 >= 0)
    {
        if (dp[i - 5] != -1)
        {
            temp5 = dp[i - 5] + dp[5];
        }
    }

    if (temp3 != -1 && temp5 != -1)
    {
        dp[i] = temp3 < temp5? temp3:temp5;
    }
    else if (temp3 == -1 && temp5 != -1)
    {
        dp[i] = temp5;
    }
    else if (temp3 != -1 && temp5 == -1)
    {
        dp[i] = temp3;
    }
    else
    {
        dp[i] = -1;
    }
}

Console.Write(dp[N]);