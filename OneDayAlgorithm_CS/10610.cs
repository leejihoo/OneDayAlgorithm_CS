string inputs = Console.ReadLine();
List<int> changedInputsToInt = new List<int>();
int sum = 0;
for (int i = 0; i < inputs.Length; i++)
{
    int temp = inputs[i] - '0';
    sum += temp;
    changedInputsToInt.Add(temp);
}

if (changedInputsToInt.Contains(0) && sum % 3 == 0)
{
    changedInputsToInt.Sort();
    changedInputsToInt.Reverse();
    Console.Write(String.Join("",changedInputsToInt));
}
else
{
    Console.Write(-1);
}