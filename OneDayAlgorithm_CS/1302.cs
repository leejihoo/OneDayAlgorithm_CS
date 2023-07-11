int N = int.Parse(Console.ReadLine());
Dictionary<string, int> pair = new Dictionary<string, int>();
int MaxCount = 0;
string answer ="";
for (int i = 0; i < N; i++)
{
    string temp = Console.ReadLine();
    if (!pair.ContainsKey(temp))
    {
        pair[temp] = 1;
        if (MaxCount < 1)
        {
            MaxCount = 1;
            answer = temp;
        }
        else if (MaxCount == 1)
        {
            int repeat = temp.Length < answer.Length ? temp.Length : answer.Length;
            for (int j = 0; j < repeat; j++)
            {
                if (temp[j] < answer[j])
                {
                    answer = temp;
                    break;
                }
                else if (temp[j] > answer[j])
                {
                    break;
                }
                
                if (j == repeat - 1)
                {
                    if (temp.Length < answer.Length)
                    {
                        answer = temp;
                    }
                }
            }
        }
    }
    else
    {
        pair[temp]++;
        if (pair[temp] > MaxCount)
        {
            MaxCount = pair[temp];
            answer = temp;
        }
        else if (pair[temp] == MaxCount)
        {
            int repeat = temp.Length < answer.Length ? temp.Length : answer.Length;
            for (int j = 0; j < repeat; j++)
            {
                if (temp[j] < answer[j])
                {
                    answer = temp;
                    break;
                }
                else if (temp[j] > answer[j])
                {
                    break;
                }

                if (j == repeat - 1)
                {
                    if (temp.Length < answer.Length)
                    {
                        answer = temp;
                    }
                }
            }
        }
    }
}

Console.Write(answer);