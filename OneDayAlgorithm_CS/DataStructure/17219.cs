//StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
Dictionary<string, string> program = new Dictionary<string, string>();

//int[] inputs = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

for (int i = 0; i < inputs[0]; i++)
{
    //var temp = sr.ReadLine().Split();
    var temp = Console.ReadLine().Split();
    program[temp[0]] = temp[1];
}

for (int i = 0; i < inputs[1]; i++)
{
    //var temp = sr.ReadLine();
    var temp = Console.ReadLine();
    sw.WriteLine(program[temp]);
}

sw.Close();
//sr.Close();