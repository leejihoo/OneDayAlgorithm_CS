StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
SortedDictionary<string,int> tree = new SortedDictionary<string, int>();
int treeCount = 0;

while (true)
{
    string treeName;

    treeName = sr.ReadLine();
    
    if(treeName == null) break;
    //if (treeName == null && sr.Peek() == -1) break;
    treeCount++;
    if (tree.ContainsKey(treeName))
    {
        tree[treeName]++;
        continue;
    }

    tree[treeName] = 1;

}

foreach (var t in tree)
{
    sw.WriteLine(t.Key + " " + ((t.Value / (float)treeCount) * 100f).ToString("F4"));
}

sw.Flush();
sr.Close();
sw.Close();