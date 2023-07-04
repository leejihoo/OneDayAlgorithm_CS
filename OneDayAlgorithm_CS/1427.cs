string input = Console.ReadLine();
List<int> list = new List<int>();

for (int i = 0; i < input.Length; i++)
{
    list.Add((input[i] - '0'));    
}

list.Sort();
list.Reverse();
foreach (var num in list)
{
    Console.Write(num);
}