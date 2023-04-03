// See https://aka.ms/new-console-template for more information

int T; // case 갯수
string[] startAndEnd = new string[4]; // 출발점
int n; // 행성 갯수
string[] info = new string[3];
int answer = 0;
List<int> output = new List<int>();
T = int.Parse(Console.ReadLine());
while (T > 0)
{
    T--;
    startAndEnd = Console.ReadLine().Split();
    n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        double distance;
        bool check = false;
        info = Console.ReadLine().Split();
        for (int j = 0; j < 2; j++)
        {
            // 출발점&도착점 과의 거리 및 반지름과 비교
            distance = Math.Sqrt(Math.Pow(int.Parse(startAndEnd[j*2]) - int.Parse(info[0]), 2) +
                                 Math.Pow(int.Parse(startAndEnd[j*2+1]) - int.Parse(info[1]), 2));
            if (distance < Double.Parse(info[2]))
                check = !check;
            if (j == 1 & check)
            {
                answer++;
            }
        }
    }
    output.Add(answer);
    answer = 0;
}

foreach (var i in output)
{
    Console.WriteLine(i);
}