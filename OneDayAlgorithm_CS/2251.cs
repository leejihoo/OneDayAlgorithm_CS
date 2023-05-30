int[] abc = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int currentA = 0;
int currentB = 0;
int currentC = abc[2];
SortedSet<int> answer = new SortedSet<int>();
bool[,] check = new bool[201,201];

Dfs(currentA, currentB, currentC);
Console.Write(string.Join(" ", answer));

void Dfs(int a, int b, int c)
{
    if (check[a, b])
    {
        return;
    }
    
    check[a, b] = true;

    if (a == 0)
    {
        answer.Add(c);
    }

    if (a != 0)
    {
        //a에서 b
        if (abc[1] >= a + b)
        {
            Dfs(0,a+b,c);
        }
        else if (abc[1] < a + b)
        {
            Dfs(a+b-abc[1],abc[1],c);    
        }
        //a에서c
        if (abc[2] >= a + c)
        {
            Dfs(0,b,a+c);
        }
        else if (abc[2] < a + c)
        {
            Dfs(a+c-abc[2],b,abc[2]);    
        }
    }

    if (b != 0)
    {
        //b에서a
        if (abc[0] >= a + b)
        {
            Dfs(a+b,0,c);
        }
        else if (abc[0] < a + b)
        {
            Dfs(abc[0],a+b-abc[0],c);    
        }
        //b에서c
        if (abc[2] >= b + c)
        {
            Dfs(a,0,b+c);
        }
        else if (abc[2] < b + c)
        {
            Dfs(a,b+c-abc[2],abc[2]);    
        }
    }

    if (c != 0)
    {
        //c에서a
        if (abc[0] >= a + c)
        {
            Dfs(a+c,b,0);
        }
        else if (abc[0] < a + c)
        {
            Dfs(abc[0],b,a+c-abc[0]);    
        }
        //c에서b
        if (abc[1] >= b + c)
        {
            Dfs(a,b+c,0);
        }
        else if (abc[1] < b + c)
        {
            Dfs(a,abc[1],b+c-abc[1]);    
        }
    }
      
}