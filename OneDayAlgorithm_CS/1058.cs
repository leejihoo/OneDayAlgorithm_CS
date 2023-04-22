int N = int.Parse(Console.ReadLine());
string[]inputs = new string[N];
bool[,] check = new bool[N, N];
int max = 0;
for (int i = 0; i < N; i++)
{
    inputs[i] = Console.ReadLine();
}

for(int i = 0; i<N; i++){
    for (int j = 0; j < N; j++)
    {
        // 자기 자신은 친구가 아니다.
        if (i != j)
        {
            if (inputs[i][j] == 'Y' ) 
            {
                if(check[i,j] == false)
                    check[i,j] = true;
                
                for (int k = 0; k < N; k++)
                {
                    if (i != k)
                    {
                        if (inputs[j][k] == 'Y')
                        {
                            if(check[i,k] == false)
                                check[i,k] = true;
                        }
                    }
                }
            }

            
        }
    }
}

for (int i = 0; i < N; i++)
{
    int temp = 0;
    for (int j = 0; j < N; j++)
    {
        if (check[i,j])
        {
            temp++;
        }
    }

    if (temp > max)
    {
        max = temp;
    }
}

Console.Write(max);
