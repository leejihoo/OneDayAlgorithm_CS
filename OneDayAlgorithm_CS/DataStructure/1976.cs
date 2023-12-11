StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int[] city = new int[201];
int N = int.Parse(sr.ReadLine());
int M = int.Parse(sr.ReadLine());
int[] plan;
bool canPlan = true;

for (int i = 1; i < city.Length; i++)
{
    city[i] = i;
}

for (int i = 1; i < N+1; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for (int j = 0; j < input.Length; j++)
    {
        if (input[j] == 1)
        {
            Union(i,j+1);
        }
    }
}

plan = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

for (int i = 1; i < plan.Length; i++)
{
    if (getParent(plan[0]) != getParent(plan[i]))
    {
        canPlan = false;
        break;
    }
}

if (canPlan)
{
    sw.WriteLine("YES");
}
else
{
    sw.WriteLine("NO");
}

sw.Flush();
sw.Close();
sr.Close();

void Union(int first, int second)
{
    int firstP = getParent(first);
    int secondP = getParent(second);

    if (firstP == secondP)
    {
        return;
    }

    if (firstP > secondP)
    {
        city[firstP] = secondP;
        return;
    }

    city[secondP] = firstP;
}

int getParent(int index)
{
    if (city[index] == index)
    {
        return index;
    }

    return city[index] = getParent(city[index]);
}