string input = Console.ReadLine();
int count = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'c')
    {
        if (i + 1 < input.Length)
        {
            if (input[i + 1] == '=' || input[i + 1] == '-')
            {
                i++;
            }
        }
    }
    else if (input[i] == 'd')
    {
        if (i + 2 < input.Length)
        {
            if (input[i + 1] == 'z' && input[i + 2] == '=')
            {
                i += 2;
            }
        }
        
        if (i + 1 < input.Length)
        {
            if (input[i + 1] == '-')
            {
                i += 1;
            }
        }
    }
    else if (input[i] == 'l')
    {
        if (i + 1 < input.Length)
        {
            if (input[i + 1] == 'j')
            {
                i++;
            }
        }
    }
    else if (input[i] == 'n')
    {
        if (i + 1 < input.Length)
        {
            if (input[i + 1] == 'j')
            {
                i++;
            }
        }
    }
    else if (input[i] == 's')
    {
        if (i + 1 < input.Length)
        {
            if (input[i + 1] == '=')
            {
                i++;
            }
        }
    }
    else if (input[i] == 'z')
    {
        if (i + 1 < input.Length)
        {
            if (input[i + 1] == '=')
            {
                i++;
            }
        }
    }

    count++;
}

Console.Write(count);