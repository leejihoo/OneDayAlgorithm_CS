StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int N = int.Parse(Console.ReadLine());
List<Stick> sticks = new List<Stick>();
int answer = 0;
int leftPos = 0;
int rightPos = 0;
int minPos = 0;
int maxPos = 0;
int maxHigh = 0;
int minHigh = 0;
for (int i = 0; i < N; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    sticks.Add(new Stick(input[0], input[1]));
}

var sortedSticks = (from s in sticks
    orderby s.High descending
    select s).ToList();

leftPos = sortedSticks[0].pos;
rightPos = leftPos;
minPos = (from s in sticks select s.pos).Min();
maxPos = (from s in sticks select s.pos).Max();
maxHigh = sortedSticks[0].High;
minHigh = sortedSticks[N - 1].High;
answer = ((maxPos + 1) - minPos) * maxHigh;

foreach(var s in sortedSticks){
    if (s.pos > rightPos)
    {
        answer -= (maxHigh - s.High) * (s.pos - rightPos);
        rightPos = s.pos;
        continue;
    }

    if (s.pos < leftPos)
    {
        answer -= (maxHigh - s.High) * (leftPos - s.pos);
        leftPos = s.pos;
    }
}
sw.Write(answer);
sw.Flush();
sw.Close();

public class Stick
{
    public Stick(int p, int h)
    {
        High = h;
        pos = p;
    }
    
    public int High;
    public int pos;
}

