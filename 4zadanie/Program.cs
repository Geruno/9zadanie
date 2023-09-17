void FillArray(int[,] array, int razm)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < razm * razm; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < razm - 1);
        for (k = 0; k < razm - 1; k++) array[i++, j] = value++;
        for (k = 0; k < razm - 1; k++) array[i, j--] = value++;
        for (k = 0; k < razm - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        razm = razm < 2 ? 0 : razm - 2;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int razm = 4;
int[,] number = new int[4,4];
FillArray(number, razm);
PrintArray(number);