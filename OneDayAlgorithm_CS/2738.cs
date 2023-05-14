int[] length = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[][] first = new int[length[0]][];
int[][] second = new int[length[0]][];

for (int i = 0; i < length[0]; i++)
{
    first[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}
for (int i = 0; i < length[0]; i++)
{
    second[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

for (int i = 0; i < length[0]; i++)
{
    for (int j = 0; j < length[1]; j++)
    {
        Console.Write(first[i][j]+second[i][j]);
        if (j != length[1] - 1)
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}