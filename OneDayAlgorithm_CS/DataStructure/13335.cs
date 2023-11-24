using System.Globalization;

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

Queue<int> after = new Queue<int>();
Queue<int> before = new Queue<int>();

int sum = 0;
int answer = 0;
int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
var trucks = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

foreach (var t in trucks)
{
    before.Enqueue(t);
}

while (before.Count > 0)
{
    answer += 1;
    if (after.Count == input[1])
    {
        var truck = after.Dequeue();
        sum -= truck;
    }

    if (sum + before.Peek() > input[2])
    {
        after.Enqueue(0);
        continue;
    }
    var temp = before.Dequeue();
    after.Enqueue(temp);
    sum += temp;
    
}

// 길이가 w인 다리를 트럭이 건널려면 w만큼의 시간이 걸린다. 
sw.Write(answer + input[1]);
sw.Flush();
sw.Close();
sr.Close();