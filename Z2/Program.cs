int[] copyarray(int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = array[i];
    }
    return newarray;
}

int[,] copyarray_s(int[,] array)
{
    int[,] newarray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newarray[i, j] = array[i, j];
        }
    }
    return newarray;
}

void printarray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + ". ");
}

void printarray_s(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void fillarray(int[] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
}

void fillarray_s(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
}

Console.Clear();

int[] array = new int[4];
fillarray(array, -10, 10);
int[] array_c = copyarray(array);

Console.WriteLine("Original array:");
printarray(array);

Console.WriteLine();

Console.WriteLine("Copied array:");
printarray(array_c);

int[,] array2 = new int[2, 5];
fillarray_s(array2, -20, 20);
int[,] array_c2 = copyarray_s(array2);

Console.WriteLine();

Console.WriteLine("Original array:");
printarray_s(array2);

Console.WriteLine("Copied array:");
printarray_s(array_c2);