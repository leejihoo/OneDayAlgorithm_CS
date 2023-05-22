int[] mnk = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[,] graph = new int[mnk[0],mnk[1]];
bool[,] check = new bool[mnk[0], mnk[1]];
// 빈공간의 갯수
int number = 0;
// 넓이 
int count = 0;
bool isNumberChecked = false;

List<int> area = new List<int>();
for (int k = 0; k < mnk[2]; k++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    
    // y 좌표 범위
    for (int i = inputs[1]; i < inputs[3]; i++)
    {
        //x 좌표 범위
        for (int j = inputs[0]; j < inputs[2]; j++)
        {
            graph[i, j] = 1;
        }
    }
}

for(int i = 0; i<mnk[0]; i++){
    for (int j = 0; j < mnk[1]; j++)
    {
        Dfs(i,j);
        
        // 빈 공간의 크기 추가 모눈종이를 전체를 채우는 경우는 없기 때문에 0일 수 없다.
        if(count != 0)
            area.Add(count);
        count = 0;
        isNumberChecked = false;
    }
}

area.Sort();
Console.WriteLine(number);
Console.Write(string.Join(" ", area));

void Dfs(int row, int col)
{
    if (check[row, col] == false && graph[row,col] == 0)
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

        if (row+1 < mnk[0])
        {
            Dfs(row+1,col);
        }

        if (col+1 < mnk[1])
        {
            Dfs(row,col+1);
        }
    }
}