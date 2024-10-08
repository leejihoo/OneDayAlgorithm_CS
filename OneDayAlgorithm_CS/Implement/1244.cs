int count = int.Parse(Console.ReadLine());
var switches = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int studentNum = int.Parse(Console.ReadLine());

for (int i = 0; i < studentNum; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    // 남학생
    if (input[0] == 1)
    {
        for (int j = 1; j <= count; j++)
        {
            int index = input[1] * j;
            if (index > count)
            {
                break;
            }

            if (switches[index-1] == 0)
            {
                switches[index-1] = 1;
            }
            else
            {
                switches[index-1] = 0;
            }
        }
    }
    else
    {
        // 여학생
        int min = input[1] -1;
        int max = input[1] -1;
        for (int j = 1; j <= count; j++)
        {
            if (input[1] - j - 1 >= 0 && input[1] + j - 1 < count && switches[input[1] - j - 1] == switches[input[1] + j - 1])
            {
                min = input[1] - j - 1;
                max = input[1] + j - 1;
            }
            else
            {
                break;
            }
        }

        for (int k = min; k <= max; k++)
        {
            if (switches[k] == 0)
            {
                switches[k] = 1;
            }
            else
            {
                switches[k] = 0;
            }
        }
    }
}

for (int i = 0; i < switches.Length; i++)
{
    
    Console.Write(switches[i] + " ");
    if ((i + 1) % 20 == 0)
    {
        Console.WriteLine();
    }
}
