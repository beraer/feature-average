static double returnAverage(int[] arr)
{
    int summm = 0;
    for (int i = 0; i < arr.Length; i++)
    {   summm += arr[i]; }
    return summm / arr.Length;
}

int[] arr = {1,2,3,4,5,6,7,8,9};
Console.WriteLine(returnAverage(arr));

static int returnnMax(int[] ar)
{
    return ar.Max();
}
Console.WriteLine(returnnMax(arr));