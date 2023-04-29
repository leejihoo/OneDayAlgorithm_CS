int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
string[] castle = new string[input[0]];
int first = 0;
int second = 0;

for (int i = 0; i < input[0]; i++)
{
    castle[i] = Console.ReadLine();
}

for (int i = 0; i < input[0]; i++)
{
    bool check = false;
    for (int j = 0; j < input[1]; j++)
    {
        if (castle[i][j] == 'X')
        {
            check = true;
            break;
        }
    }

    if (!check)
    {
        first++;
    }
}

for (int i = 0; i < input[1]; i++)
{
    bool check = false;
    for (int j = 0; j < input[0]; j++)
    {
        if (castle[j][i] == 'X')
        {
            check = true;
            break;
        }
    }

    if (!check)
    {
        second++;
    }
}

Console.Write((first > second)?first:second);    