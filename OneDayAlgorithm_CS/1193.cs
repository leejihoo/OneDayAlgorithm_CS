string[,] fractions = new string[3163,3163];

// for (int i = 0; i < 3163; i++)
// {
//     for (int j = 0; j < 3163; j++)
//     {
//         fractions[i, j] = (i+1) + "/" + (j+1);
//     }
// }

var order = int.Parse(Console.ReadLine());
int x = 0;
int y = 0;

if (order != 1)
{
    for (int i = 1; i < order; i++)
    {
        if (x == 0)
        {
            // 동
            if (y % 2 == 0)
            {
                y += 1;
                continue;
            }
            
            // 남서
            y -= 1;
            x += 1;
            continue;
        }

        if (y == 0)
        {
            // 북동
            if (x % 2 == 0)
            {
                x -= 1;
                y += 1;
                continue;
            }
            
            // 남
            x += 1;
            continue;
        }

        if ((x + y) % 2 == 0)
        {
            x -= 1;
            y += 1;
            continue;
        }

        x += 1;
        y -= 1;
    }
}

//Console.WriteLine(fractions[x,y]);
Console.WriteLine((x+1)+"/"+(y+1));
