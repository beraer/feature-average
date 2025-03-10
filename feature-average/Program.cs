static double returnAverage(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {   summ += arr[i]; }
    return summ / arr.Length;
}

int[] arr = {1,2,3,4,5,6,7,8,9};
Console.WriteLine(returnAverage(arr));

static int returnnMax(int[] ar)
{
    return ar.Max();
}
Console.WriteLine(returnnMax(arr));