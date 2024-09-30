var NM = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int[,] arr = new int[NM[0],NM[1]];

for (int i = 0; i < NM[0]; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    for (int j = 0; j < NM[1]; j++)
    {
        arr[i, j] = input[j];
    }
}

var K = int.Parse(Console.ReadLine());

for (int i = 0; i < K; i++)
{
    int sum = 0;
    var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    for (int j = input[0]-1; j < input[2]; j++)
    {
        for (int k = input[1]-1; k < input[3]; k++)
        {
            sum += arr[j, k];
        }
    }
    
    Console.WriteLine(sum);
}
