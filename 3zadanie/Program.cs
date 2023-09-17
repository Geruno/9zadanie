
void FillArray(int[,,] array)
{
    int sum = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] += sum;
                sum += 3;
            }
        }
    }
}
void PrintArrayAndIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write(array[i, j, z] + $"({i}{j}{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] number = new int[2,2,2];
FillArray(number);
PrintArrayAndIndex(number);
