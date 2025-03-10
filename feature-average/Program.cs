static double returnAverage(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {   sum += arr[i]; }
    return sum / arr.Length;
}

int[] arr = {1,2,3,4,5,6,7,8,9};
Console.WriteLine(returnAverage(arr));