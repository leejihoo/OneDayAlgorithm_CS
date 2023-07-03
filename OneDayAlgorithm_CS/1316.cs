int N = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < N; i++)
{
    string word = Console.ReadLine();
    char prev = '1';
    List<char> spelling = new List<char>();
    bool check = true;
    for (int j = 0; j < word.Length; j++)
    {
        if (prev != word[j])
        {
            if (spelling.Contains(word[j]))
            {
                check = false;
                break;
            }
            
            spelling.Add(word[j]); 
            prev = word[j];
            
        }
    }

    if (check)
    {
        count++;
    }
}

Console.Write(count);

