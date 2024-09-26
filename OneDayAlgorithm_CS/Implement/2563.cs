int count = int.Parse(Console.ReadLine());
Size[] colorPaperSizes = new Size[count];
bool[,] check = new bool[100, 100];
for (int i = 0; i < colorPaperSizes.Length; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    colorPaperSizes[i] = new Size();
    colorPaperSizes[i].x = input[0];
    colorPaperSizes[i].y = input[1];
}

for (int i = 0; i < colorPaperSizes.Length; i++)
{
    for (int x = colorPaperSizes[i].x; x < colorPaperSizes[i].x + 10; x++)
    {
        for (int y = colorPaperSizes[i].y; y < colorPaperSizes[i].y+10; y++)
        {
            check[x, y] = true;
        }
    }
}

int sum = 0;
foreach (var isOverlaped in check)
{
    if (isOverlaped)
    {
        sum += 1;
    }
}

Console.WriteLine(sum);

public class Size
{
    public int x;
    public int y;
}