StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int T = int.Parse(Console.ReadLine());

Dictionary<string, int> fashion = new Dictionary<string, int>();

while (T > 0)
{
    T--;
    int n = int.Parse(Console.ReadLine());
    
    while (n > 0)
    {
        n--;
        string[] temp = Console.ReadLine().Split();
        
        if (fashion.ContainsKey(temp[1]))
        {
            fashion[temp[1]] += 1;
            continue;
        }
        
        fashion.Add(temp[1],1);    
        
    }

    if (fashion.Count > 0)
    {
        var answer = fashion.Values.Select(x=> x+1).Aggregate((x,y)=>x*y) -1;
        sw.WriteLine(answer);    
        fashion.Clear();
        continue;
    }
    
    sw.WriteLine(0);

}

sw.Close();