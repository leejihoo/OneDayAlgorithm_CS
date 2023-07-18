string input = Console.ReadLine();
List<string> list = new List<string>();
int count = input.Length;
for (int i = 0; i < count; i++)
{
    list.Add(input);
    input = input.Substring(1);
}
list.Sort();
foreach (var temp in list)
{
    Console.WriteLine(temp);
}