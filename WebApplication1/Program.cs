using testunit;

class Program
{
    static void Main()
    {
        var sortingApp = new SortingService();
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        int[] sortedArray = sortingApp.BubbleSort(array);
        Console.WriteLine("Sorted array: ");
        foreach (int item in sortedArray)
        {
            System.Console.Write(item + " ");
        }
    }
}