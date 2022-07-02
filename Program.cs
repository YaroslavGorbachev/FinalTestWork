string[] array = new string[] { "454", "8941", "4898", "2+2", "Student" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);