StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(Console.ReadLine());
List<int> listN = new List<int>(); 
for (int i = 0; i < N; i++)
{
    var temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    listN.AddRange(temp);
}

listN.Sort();
listN.Reverse();

sw.WriteLine(listN[N-1]);
sw.Flush();
sw.Close();