string str = Console.ReadLine();
HashSet<string> diffStr = new HashSet<string>();
int length = str.Length;
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length-i; j++)
    {
        diffStr.Add(str.Substring(i, j+1));
    }
}
Console.Write(diffStr.Count);