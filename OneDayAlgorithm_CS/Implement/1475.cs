string input = Console.ReadLine();
int[] counts = new int[9];

foreach (var num in input)
{
    if (num == '6' || num == '9')
    {
        counts[6] += 1;
        continue;
    }

    counts[num - '0'] += 1;
}

int maxCount = 0;
int index = 0;
foreach (var count in counts)
{
    if (count > maxCount)
    {
        if (index == 6)
        {
            if ((count + 1) / 2 > maxCount)
            {
                maxCount = (count + 1) / 2;
            }
        }
        else
        {
            maxCount = count;
        }
    }

    index++;
}

Console.WriteLine(maxCount);
