int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
long start = 0;
long count = 0;
bool check = false;
for (long i = inputs[1]; i <= 100; i++)
{
    // 시간 초과가 발생하는 코드
    // for (long j = 0; j < (double)inputs[0]/i; j++)
    // {
    //     if (j * i + i * (i - 1) / 2 == inputs[0])
    //     {
    //         start = j;
    //         count = i;
    //         check = true;
    //         break;
    //     }
    // }

    // https://sexycoder.tistory.com/97 참고
    if ((inputs[0] - i * (i - 1) / 2) % i == 0 && (inputs[0] - i * (i - 1) / 2) / i >= 0)
    {
        start = (inputs[0] - i * (i - 1) / 2) / i;
        count = i;
        break;  
    }
    
    // if (check)
    // {
    //     break;
    // }

    if (i == 100)
    {
        start = -1;
    }
}

if (start == -1)
{
    Console.Write(-1);
}
else
{
    for (int i = 0; i < count; i++)
    {
        if (i != count - 1)
        {
            Console.Write(start+i+" ");
        }
        else
        {
            Console.Write(start+i);
        }
    }
}