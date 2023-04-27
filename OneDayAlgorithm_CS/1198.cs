// 재귀 nCr = n-1Cr-1 + n-1Cr
int N = int.Parse(Console.ReadLine());
int[][] pos = new int[N][];
List<int[]> select = new List<int[]>();
double max = 0;
for (int i = 0; i < N; i++)
{
    pos[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

void solve(int cur, bool check, List<int[]> next)
{
    List<int[]> save = next.ToList();
    if (check && cur >= 0)
    {
        save.Add(pos[cur]);    
    }
    
    if (save.Count == 3)
    {
        int[] first = save[0];
        int[] second = save[1];
        int[] third = save[2];
        double area = Math.Abs((second[0] - first[0]) * (third[1] - first[1]) - (third[0] - first[0]) * (second[1] - first[1])) / 2.0;
        if (area > max)
        {
            max = area;
        }
        return;
    }

    if (cur == N-1)
    {
        return;
    }
    
    solve(cur+1,check,save);
    solve(cur+1,!check,save);
}

solve(-1,true,select);
Console.Write(max);