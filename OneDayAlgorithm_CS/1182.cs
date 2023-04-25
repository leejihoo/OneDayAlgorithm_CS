int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] sequence = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int answer = 0;

void solve(int cur, int sum)
{
    if (cur == inputs[0])
    {
        if (sum == inputs[1]) answer++;
        return;
    }
    solve(cur+1,sum);
    solve(cur+1,sum+sequence[cur]);
}

solve(0,0);
if (inputs[1] == 0) answer--;

Console.WriteLine(answer);
