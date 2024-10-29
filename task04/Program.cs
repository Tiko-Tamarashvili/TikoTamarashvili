string[] students = new string[3];
for (int i = 0; i < students.Length; i++) 
    {
        students[i] = Console.ReadLine();
    }

for (int i = 0; i < students.Length; i++)
    {
        Console.Write(students[i] + " ");
    }

Console.WriteLine();


int[,] grades = new int[3, 2];
for (int i = 0; i < grades.GetLength(0); i++)
    {
        Console.WriteLine("shemoitanet " + students[i] + "s qulebi");
        for (int j = 0; j < grades.GetLength(1); j++)
            {
                grades [i,j] = int.Parse(Console.ReadLine());
            }
    }


for (int i = 0; i < students.Length; i++)
    {
        Console.Write(students[i] + " ");
        for (int j = 0; j < grades.GetLength(1); j++)
            {
            Console.Write(grades[i, j] + " ");
            }   
        Console.WriteLine();
    }



