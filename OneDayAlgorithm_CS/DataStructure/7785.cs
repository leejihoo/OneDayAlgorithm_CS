StreamReader streamReader = new StreamReader(Console.OpenStandardInput());
StreamWriter streamWriter = new StreamWriter(Console.OpenStandardOutput());
int N = int.Parse(streamReader.ReadLine());
// Dictionary<string,string> log = new Dictionary<string,string>();
// for (int i = 0; i < N; i++)
// {
//     string[] temp = streamReader.ReadLine().Split();
//     log[temp[0]] = temp[1];
// }
//
// var result = log.Where(x => x.Value == "enter").Select(x => x.Key).ToList();
HashSet<string> ab = new HashSet<string>();

for (int i = 0; i < N; i++)
{
    string[] temp = streamReader.ReadLine().Split();
    if (!ab.Contains(temp[0]))
    {
        ab.Add(temp[0]);
    }
    else
    {
        ab.Remove(temp[0]);
    }
}

foreach (var temp in ab.OrderByDescending(x=> x))
{
    streamWriter.WriteLine(temp);
}

streamWriter.Flush();