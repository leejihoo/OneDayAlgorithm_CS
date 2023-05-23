int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
string[] graph = new string[inputs[0]];
bool[,] check = new bool[inputs[0], inputs[0]];
//int max = 0;
int count = 0;
int number = 0;
bool isNumberChecked = false;
List<int> house = new List<int>();

for (int i = 0; i < inputs[0]; i++)
{
    graph[i] = Console.ReadLine();
}

for(int i = 0; i<inputs[0]; i++){
    for (int j = 0; j < inputs[0]; j++)
    {
        Dfs(i,j);
        // if (max < count)
        // {
        //     max = count;
        // }
        if(count != 0)
            house.Add(count);
        isNumberChecked = false;
        count = 0;
    }
}

Console.WriteLine(number);
house.Sort();
foreach (var home in house)
{
    Console.WriteLine(home);
}

void Dfs(int row, int col)
{
    if (check[row, col] == false && graph[row][col] == '1')
    {
        if (!isNumberChecked)
        {
            isNumberChecked = true;
            number++;
        }
        check[row, col] = true;
        count++;
        if (row-1 >= 0)
        {
            Dfs(row-1,col);
        }

        if (col-1 >= 0)
        {
            
            Dfs(row,col-1);
        }

        if (row+1 < inputs[0])
        {
            Dfs(row+1,col);
        }

        if (col+1 < inputs[0])
        {
            Dfs(row,col+1);
        }
    }
}