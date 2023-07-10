string[] inputs = Console.ReadLine().Split();
int repeat = inputs[1].Length - inputs[0].Length + 1;
int answer = 51;
for (int i = 0; i < repeat; i++)
{
    int diff = 0;
    for (int j = 0; j < inputs[0].Length; j++)
    {
        if (inputs[1][i + j] != inputs[0][j])
        {
            diff++;
        }
    }

    if (answer > diff)
    {
        answer = diff;
    }
}
Console.Write(answer);