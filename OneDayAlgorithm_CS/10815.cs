int N = int.Parse(Console.ReadLine());
int[] cards = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int M = int.Parse(Console.ReadLine());
int[] question = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
HashSet<int> hashSetCards = cards.ToHashSet();

for (int i = 0; i < question.Length; i++)
{
    if (hashSetCards.Contains(question[i]))
    { 
        question[i] = 1;
    }
    else
    {
        question[i] = 0;
    }
}

Console.Write(string.Join(" ", question));

    
    
