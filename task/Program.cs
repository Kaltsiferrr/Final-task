string[] mass1 = new string[]{"2", "task", "-8", "english", "111", "ox", "two", "csharp", "ms", "time"};
string[] mass2 = new string[mass1.Length];
void Mass1ToMass2(string[] mass1, string[] mass2)
{
    int count = 0;
    for (int i = 0;i<mass1.Length;i++)
    {
        if (mass1[i].Length<=3)
        {
            mass2[count]=mass1[i];
            count++;
        }
    }
}
void PrintMass(string[] mass)
{
     for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
Console.Clear();
Mass1ToMass2(mass1, mass2);
PrintMass(mass2);