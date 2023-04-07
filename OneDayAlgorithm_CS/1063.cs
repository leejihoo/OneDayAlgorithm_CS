string kingPoint = "";
string stonePoint = "";
int movingCount = 0;
string [] input = Console.ReadLine().Split();
kingPoint = input[0];
stonePoint = input[1];
movingCount = int.Parse(input[2]);
int[,] board = new int[8,8];
int kingFirst = 7 - (kingPoint[1] - 49);
int kingSecond = kingPoint[0] - 65;
int stoneFirst = 7 - (stonePoint[1] - 49);
int stoneSecond = stonePoint[0] - 65;
// 왕 위치 설정
board[kingFirst, kingSecond] = 1;
// 돌 위치 설정
board[stoneFirst, stoneSecond] = 1;

for (int i = 0; i < movingCount; i++)
{
    int temp1 = 0;
    int temp2 = 0;
    
    string direction = Console.ReadLine();
    if (direction.Contains("B"))
    {
        temp1 += 1;
    }

    if (direction.Contains("T"))
    {
        temp1 -= 1;
    }
    
    if (direction.Contains("R"))
    {
        temp2 += 1;
    }

    if (direction.Contains("L"))
    {
        temp2 -= 1;
    }

    if (kingFirst +temp1 <= 7 && kingFirst +temp1 >=0 && kingSecond + temp2 <= 7 && kingSecond +temp2 >=0)
    {
        // 왕이 움직인 곳에 돌이 없을 때
        if (board[kingFirst +temp1, kingSecond + temp2] == 0)
        {
            board[kingFirst, kingSecond] = 0;
            kingFirst += temp1;
            kingSecond += temp2;
            board[kingFirst, kingSecond] = 1;
        }
        else // 왕이 움직인 곳에 돌이 있을 때
        {
            if (stoneFirst + temp1 <= 7 && stoneFirst +temp1 >=0 && stoneSecond + temp2 <= 7 && stoneSecond +temp2 >=0)
            {
                board[stoneFirst, stoneSecond] = 0;
                stoneFirst += temp1;
                stoneSecond += temp2;
                board[stoneFirst, stoneSecond] = 1;
                
                board[kingFirst, kingSecond] = 0;
                kingFirst += temp1;
                kingSecond += temp2;
                board[kingFirst, kingSecond] = 1;
            }
        }
    }
}

Console.WriteLine((char)(kingSecond+65) + (8-kingFirst).ToString());
Console.WriteLine((char)(stoneSecond+65) + (8-stoneFirst).ToString());