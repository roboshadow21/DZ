int[] FillArray(int n, int m, int k)
{
    int[] collection = new int[n];
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(m, k);
    }
    return collection;
}

void ShowCollection(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}


int LargeValueCounter(int[] col, int value=8)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > value)
        {
            count++;
        }
    }
    return count;
}

int[] SelectElements(int[] coll, int count, int value=8)
{
    int[] newCollection = new int[count];
    int j = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] > value)
        {
            newCollection[j] = coll[i];
            j++;
        }
    }
    return newCollection;

}

void ShowSelectedNumbersArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] coll = FillArray(15, 1, 15);
ShowCollection(coll);
Console.WriteLine();
int count = LargeValueCounter(coll);
int[] coll2 = SelectElements(coll, count);
ShowSelectedNumbersArray(coll2);

