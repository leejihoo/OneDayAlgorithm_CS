int[] size = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
string[] graph = new string[size[0]];
bool check = false;
for (int i = 0; i < size[0]; i++)
{
    graph[i] = Console.ReadLine();
}

for (int i = 0; i < size[0]; i++)
{
    for (int j = 0; j < size[1]; j++)
    {
        int count = Search(i,j,0,i,j);
        if (count < 2)
        {
            check = true;
            break;
        }
    }
    if (check)
    {
        break;
    }
}

if (check)
{
    Console.Write(1);
}
else
{
    Console.Write(0);
}

int Search(int row, int col, int preDirection, int startRow, int startCol)
{
    int count = 0;
    if (graph[row][col] == '.')
    {
        
        //위로 이동
         if (row - 1 >= 0)
         {
             if (graph[row - 1][col] == '.')
             {
                 count++;
             }
         }
         
         //아래로 이동
         if (row + 1 < size[0])
         {
             if (graph[row + 1][col] == '.')
             {
                 count++;
             }
         }
         //왼쪽으로 이동
         if (col - 1 >= 0)
         {
             if (graph[row][col-1] == '.')
             {
                 count++;
             }
         }
         //오른쪽으로 이동
         if (col + 1 < size[1])
         {
             if (graph[row][col+1] == '.')
             {
                 count++;
             }
         }
    }
    else
    {
        count = 5;
    }

    return count;
}