StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());
Dictionary<string, string> parent = new Dictionary<string, string>();
Dictionary<string, int> networkCount = new Dictionary<string, int>(); 
int T = int.Parse(sr.ReadLine());

while (T > 0)
{
    int F = int.Parse(sr.ReadLine());
    for (int i = 0; i < F; i++)
    {
        string[] input = sr.ReadLine().Split();
        
        if (!networkCount.ContainsKey(input[0]))
        {
            networkCount[input[0]] = 1;
            parent[input[0]] = input[0];
        }
        
        if (!networkCount.ContainsKey(input[1]))
        {
            networkCount[input[1]] = 1;
            parent[input[1]] = input[1];
        }
        Union(input[0],input[1]);
        sw.WriteLine(networkCount[GetParent(input[0])]);
    }
    
    parent.Clear();
    networkCount.Clear();
    T--;
}

sw.Flush();
sw.Close();
sr.Close();

string GetParent(string name)
{
    if (parent[name] == name)
    {
        return name;
    }

    return parent[name] = GetParent(parent[name]);
}

void Union(string first, string second)
{
    string firstP = GetParent(first);
    string secondP = GetParent(second);

    if (firstP == secondP)
    {
        return;
    }

    if (networkCount[firstP] > networkCount[secondP])
    {
        parent[secondP] = firstP;
    }
    else
    {
        parent[firstP] = secondP;
    }

    var sum = networkCount[firstP] + networkCount[secondP];
    networkCount[firstP] = sum;
    networkCount[secondP] = sum;
    
}