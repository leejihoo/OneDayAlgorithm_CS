// int T = int.Parse(Console.ReadLine());
// while (T > 0)
// {
//     string[] inputs = Console.ReadLine().Split();
//     int[,] cabbageField = new int[int.Parse(inputs[1]),int.Parse(inputs[0])];
//     int answer = 0;
//     for (int i = 0; i < int.Parse(inputs[2]); i++)
//     {
//         string[] pos = Console.ReadLine().Split();
//         cabbageField[int.Parse(pos[1]), int.Parse(pos[0])] = 1;
//     }
//
//     for (int i = 0; i < int.Parse(inputs[1]); i++)
//     {
//         for (int j = 0; j < int.Parse(inputs[0]); j++)
//         {
//             Queue<int> posX = new Queue<int>();
//             Queue<int> posY = new Queue<int>();
//             bool check = false;
//             posX.Enqueue(j);
//             posY.Enqueue(i);
//             while (posX.Count > 0)
//             {
//                 int x = posX.Dequeue();
//                 int y = posY.Dequeue();
//                 if (cabbageField[y, x] == 1)
//                 {
//                     cabbageField[y, x] = 2;
//                     // 상 +1, 0
//                     if (y + 1 < int.Parse(inputs[1]))
//                     {
//                         if (cabbageField[y + 1, x] == 1)
//                         {
//                             posX.Enqueue(x);
//                             posY.Enqueue(y+1);
//                         }
//                     }
//                     // 하 -1, 0
//                     if (y - 1 > -1)
//                     {
//                         if (cabbageField[y - 1, x] == 1)
//                         {
//                             posX.Enqueue(x);
//                             posY.Enqueue(y-1);
//                         }
//                     }
//                     // 좌 0, -1
//                     if (x - 1 > -1)
//                     {
//                         if (cabbageField[y, x-1] == 1)
//                         {
//                             posX.Enqueue(x-1);
//                             posY.Enqueue(y);
//                         }
//                     }
//                     // 우 0, +1
//                     if (x + 1 < int.Parse(inputs[0]))
//                     {
//                         if (cabbageField[y, x+1] == 1)
//                         {
//                             posX.Enqueue(x+1);
//                             posY.Enqueue(y);
//                         }
//                     }
//
//                     if (!check)
//                     {
//                         check = true;
//                         answer++;
//                     }
//                 }
//             }
//             
//         }
//     }
//     Console.WriteLine(answer);
//     T--;
// }
