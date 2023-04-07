int N = 0; // 큐의 크기
int M = 0; // 뽑아낼려는 갯수
int answer = 0;
string[] input = Console.ReadLine().Split();
N = int.Parse(input[0]);
M = int.Parse(input[1]);

string [] elements = Console.ReadLine().Split();
int front = 0;
int end = elements.Length-1;

List<string> deque = new List<string>(); 
for (int i = 1; i <= N; i++)
{
    deque.Add(i.ToString());
}

foreach(string i in elements){
    for (int j = 0; j < deque.Count; j++)
    {
        if (i == deque[j])
        {
            answer += Math.Abs(j - front) <= (deque.Count - Math.Abs(j - front))? Math.Abs(j - front) : (deque.Count - Math.Abs(j - front));
            front = j;
            deque.RemoveAt(j);
            break;
        }   
    }
}

Console.Write(answer);