string input = Console.ReadLine();
int zeroSequenceCount = 0;
int oneSequenceCount = 0;
char prev = 'n';
for (int i = 0; i < input.Length; i++)
{
    if (prev == 'n')
    {
        prev = input[i];
    }

    if (prev != input[i])
    {
        if (prev == '0')
        {
            zeroSequenceCount++;
        }
        else
        {
            oneSequenceCount++;
        }

        prev = input[i];
    }

    if (i == input.Length - 1)
    {
        if (input[i] == '0')
        {
            zeroSequenceCount++;
        }
        else
        {
            oneSequenceCount++;
        }
    }
}

if (zeroSequenceCount * oneSequenceCount == 0)
{
    Console.Write(0);
}
else
{
    if (zeroSequenceCount > oneSequenceCount)
    {
        Console.Write(oneSequenceCount);
    }
    else
    {
        Console.Write(zeroSequenceCount);
    }
}