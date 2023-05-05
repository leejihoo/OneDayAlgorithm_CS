int n = int.Parse(Console.ReadLine());
int[] question = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int m = int.Parse(Console.ReadLine());
int[,] graph = new int[n,n];
bool[] isChecked = new bool[n];
bool check = false;
for (int i = 0; i < m; i++)
{
    string[] inputs  = Console.ReadLine().Split();
    graph[int.Parse(inputs[0]) - 1, int.Parse(inputs[1]) - 1] = 1;
    graph[int.Parse(inputs[1]) - 1, int.Parse(inputs[0]) - 1] = 1;
}

isChecked[question[0] - 1] = true;
dfs(question[0],question[1],0);
if (!check)
{
    Console.Write(-1);
}

void dfs(int start, int end, int depth)
{
    
    if (graph[start - 1, end - 1] == 1)
    {
        depth++;
        
        Console.Write(depth);
        check = true;
        return;
    }

    for (int i = 0; i < n; i++)
    {
        int temp = depth;
        if (graph[start-1, i] == 1 && isChecked[i] == false)
        {
            isChecked[i] = true;
            temp++;
            dfs(i + 1, end,temp);
        }

        if (i == n - 1)
        {
            return;
        }
    }
    
}