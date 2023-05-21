int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[][] graph = new int[inputs[0]][];
bool[,] check = new bool[inputs[0], inputs[0]];
int max = 0;
int count = 0;
int number = 0;
 bool isNumberChecked = false;
int maxHigh = 0;
for (int i = 0; i < inputs[0]; i++)
{
    graph[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

foreach (var arr in graph)
{
    int a = arr.Max();
    if (a > maxHigh)
    {
        maxHigh = a;
    }
}

for (int k = 0; k < maxHigh; k++) {
    for(int i = 0; i<inputs[0]; i++){
        for (int j = 0; j < inputs[0]; j++) {
            Dfs(i,j, k);
            isNumberChecked = false; 
        }
    }
    
    // if (max < count) 
    // { 
    //     max = count;
    // }
    // count = 0;
    
    if (max < number) 
    { 
        max = number;
    }
    
    
    for (int i = 0; i < inputs[0]; i++)
    {
        for (int j = 0; j < inputs[0]; j++)
        {
            check[i, j] = false;
        }
    }
    number = 0;
}

//Console.WriteLine(number);
Console.Write(max);

void Dfs(int row, int col, int high)
{
    if (check[row, col] == false && graph[row][col] > high)
    {
        if (!isNumberChecked)
        {
            isNumberChecked = true;
            number++;
        }
        check[row, col] = true;
        //count++;
        if (row-1 >= 0)
        {
            Dfs(row-1,col,high);
        }

        if (col-1 >= 0)
        {
            
            Dfs(row,col-1, high);
        }

        if (row+1 < inputs[0])
        {
            Dfs(row+1,col, high);
        }

        if (col+1 < inputs[0])
        {
            Dfs(row,col+1, high);
        }
    }
}