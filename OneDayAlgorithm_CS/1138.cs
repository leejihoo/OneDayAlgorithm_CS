int N = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] outputs = new int[N];

for (int i = 1; i <= N; i++)
{
    int count = 0;
    for (int j = 0; j < N; j++)
    {
        if (count != inputs[i - 1])
        {
            if (outputs[j] == 0)
            {
                count++;
            }
        }
        else
        {
            if (outputs[j] != 0)
            {
                continue;
            }
            outputs[j] = i;
            break;
        }
    }    
}

for (int i = 0; i < N; i++)
{
    if (i == N - 1)
    {
        Console.Write(outputs[i]);
    }
    else
    {
        Console.Write(outputs[i]+" ");
    }
}