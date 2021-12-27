int[] CreateArray(int n, int m, int k)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(m, k);
    }
    return arr;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
}


int EvenNumbersCounter(int[] list)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] OnlyEvenNumbers(int[] arr, int num)
{
    int[] newArray = new int[num];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;

}

void ShowEvenNumbersArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] arr1 = CreateArray(10, 1, 21);
ShowArray(arr1);
Console.WriteLine();
int count = EvenNumbersCounter(arr1);
int[] arr2 = OnlyEvenNumbers(arr1, count);
ShowEvenNumbersArray(arr2);

