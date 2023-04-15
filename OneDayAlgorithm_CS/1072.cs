// string[] input = Console.ReadLine().Split();
// decimal X = decimal.Parse(input[0]);
// decimal Y = decimal.Parse(input[1]);
// int first = (int)((Y * 100/ X) );
//
// int high = 1000000000;
// int low = 0;
// int answer = (high + low) / 2;
// if ( first >= 99 )
// {
//     Console.Write(-1);    
// }
// else
// {
//     while (true)
//     {
//         int Z = (int)(((answer+Y) * 100/ (answer+X)) );
//         if (Z - first >= 1)
//         {
//             Z = (int)(((answer-1+Y) * 100/ (answer-1+X)) );
//             if (Z - first < 1)
//             {
//                 break;
//             }
//             
//             high = answer-1;
//             answer = (low + high) / 2;
//         }
//         else if (Z - first < 1)
//         {
//             low = answer + 1;
//             answer = (low + high) / 2;
//         }
//     }
//     Console.Write(answer);
// }