
int N = int.Parse(Console.ReadLine());
int min = 1000000000;
int[] T = new int[N];
List<int> select = new List<int>();
for (int i = 0; i < N; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    T[i] = inputs[1] - inputs[0];
}

Array.Sort(T);

if (T.Length % 2 == 0)
{
    int index = T.Length / 2 - 1;
    Console.Write(T[index+1] - T[index] + 1);
}
else
{
    Console.Write(1);
}