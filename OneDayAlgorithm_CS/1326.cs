int N = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().TrimEnd().Split();
int[] steppingStone = Array.ConvertAll(input,int.Parse);
//int [] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
string[] story = Console.ReadLine().Split();
int start = int.Parse(story[0]);
int end = int.Parse(story[1]);
bool check = false;
Queue<int> steps = new Queue<int>();
int[] visit = new int[N];
Array.Fill(visit,-1);
steps.Enqueue(start);
visit[start - 1] = 0;

while (steps.Count > 0)
{
    int step = steps.Dequeue();

    for (int i = 1; i <= N; i++)
    {
        if (step > 0 && steppingStone[step - 1] > 0)
        {
            if (visit[i-1] == -1 && Math.Abs(i - step) / steppingStone[step - 1] > 0 && Math.Abs(i - step) % steppingStone[step - 1] == 0)
            {
                visit[i-1] = visit[step-1] + 1;
                if (i == end)
                {
                    Console.WriteLine(visit[i-1]);
                    check = true;
                    break;
                }
            
                steps.Enqueue(i);
            
            }
        }
        
    }

    if (check)
    {
        break;
    }

    if (steps.Count == 0 && !check )
    {
        Console.WriteLine(-1);
    }
}
