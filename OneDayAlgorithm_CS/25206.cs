float gradeSum = 0.0f;
float Cal = 0.0f;

for (int i = 0; i < 20; i++)
{
    string[] inputs = Console.ReadLine().Split();

    if (inputs[2] != "P")
    {
        float grade = float.Parse(inputs[1]);
        gradeSum += grade;
        switch(inputs[2])
        {
            case "A+":
                Cal += 4.5f * grade;
                break;
            case "A0":
                Cal += 4.0f * grade;
                break;
            case "B+":
                Cal += 3.5f * grade;
                break;
            case "B0":
                Cal += 3.0f * grade;
                break;
            case "C+":
                Cal += 2.5f * grade;
                break;
            case "C0":
                Cal += 2.0f * grade;
                break;
            case "D+":
                Cal += 1.5f * grade;
                break;
            case "D0":
                Cal += 1.0f * grade;
                break;
            case "F":
                Cal += 0.0f * grade;
                break;

        }
    }
}

Console.Write(Cal / gradeSum);