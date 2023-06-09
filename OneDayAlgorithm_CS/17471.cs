int N = int.Parse(Console.ReadLine());
int[] population = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
List<int>[] graph = new List<int>[N+1];
bool[] check = new bool[N + 1];
char[] colors = new char[N + 1];
int redPopulation = 0;
int bluePopulation = 0;
int min = 1000;
int count = 0;
bool isCounted = false;

check[0] = true;

for (int i = 0; i < N + 1; i++)
{
    graph[i] = new List<int>();
}

for (int i = 1; i <= N; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 1; j <= input[0]; j++)
    {
        graph[i].Add(input[j]);
    }
}

Divide(0,'n',colors);

if (min != 1000)
{
    Console.WriteLine(min);
}
else
{
    Console.WriteLine(-1);
}

void Divide(int cur, char color, char[] next)
{
    char[] temp = new char[N + 1];
    
    for (int i = 1; i <= N; i++)
    {
        temp[i] = next[i];
    }
    temp[cur] = color;
    
    if (cur == N)
    {
        colors = temp;
        for (int i = 1; i <= N; i++)
        {
            Dfs(i,'r');
            Dfs(i,'b');
            isCounted = false;
        }
        Array.Fill(check,false);
        
        if (count == 2)
        {
            int diff = Math.Abs(redPopulation - bluePopulation);
            if (diff < min)
            {
                min = diff;
            }
        }

        redPopulation = 0;
        bluePopulation = 0;
        count = 0;
    }
    else
    {
        Divide(cur+1,'r',temp);
        Divide(cur+1,'b',temp);
    }
}

void Dfs(int start, char color)
{
    if (check[start] || color != colors[start])
    {
        return;
    }

    if (!isCounted)
    {
        isCounted = true;
        count++;
    }

    if (color == 'r')
    {
        redPopulation += population[start-1];
    }
    else
    {
        bluePopulation += population[start-1];
    }
    
    check[start] = true;

    for (int i = 0; i < graph[start].Count; i++)
    {
        Dfs(graph[start][i],color);
    }
}

