int positivenums(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++) if(array[i]>0) result++;
    return result;
}

int[] getArray(int M)
{
    int[] array = new int[M];
    for(int i = 0; i < M; i++)
    {
        Console.Write($"{i+1} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Clear();
Console.Write("M is: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] numbers = getArray(M);
Console.WriteLine($"Answer is: {positivenums(numbers)}");