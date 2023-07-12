string document = Console.ReadLine();
string word = Console.ReadLine();
int answer = 0;
for (int i = 0; i < document.Length; i++)
{
    // 탐색할려는 단어보다 남은 문자열이 짧음
    if (document.Length - i < word.Length)
    {
        break;
    }

    for (int j = 0; j < word.Length; j++)
    {
        if (word[j] != document[j + i])
        {
            break;
        }

        if (j == word.Length - 1)
        {
            answer++;
            //반복문에서 +1 해주기 때문에 -1을 해줘야한다.
            i += word.Length-1;
        }
    }
}

Console.Write(answer);

