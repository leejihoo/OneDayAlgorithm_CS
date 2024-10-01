var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

bool[] check = new bool[input[0]+1];
int answer = 0;
int count = 0;
bool isFind = false;
for (int i = 2; i < input[0]+1; i++)
{
    for (int j = 1; i*j < input[0]+1; j++)
    {
        if (check[i * j] == false)
        {
            count++;
            check[i * j] = true;

            if (count == input[1])
            {
                answer = i * j;
                isFind = true;
                break;
            }
        }
    }

    if (isFind)
    {
        break;
    }
}

Console.WriteLine(answer);