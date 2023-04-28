string input = Console.ReadLine();
input = input.ToUpper();
int[] alphabet = new int[26];
int max = 0;
bool isTwo = false;
char answer = ' ';
for (int i = 0; i<input.Length; i++)
{
    alphabet[(input[i]-65)] += 1;
}

for (int i = 0; i < alphabet.Length; i++)
{
    if (alphabet[i] > max)
    {
        max = alphabet[i];
        answer = (char)(i + 65);
        isTwo = false;
    }
    else if (alphabet[i] == max)
    {
        isTwo = true;
    }
}

if (isTwo)
{
    Console.Write("?");    
}
else
{
    Console.Write(answer);
}
