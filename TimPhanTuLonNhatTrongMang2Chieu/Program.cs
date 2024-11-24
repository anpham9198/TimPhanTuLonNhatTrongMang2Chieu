internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the arry: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int largest = arr[0];
        int smallest = arr[0];

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
            if (arr[i] < smallest)
            {
                smallest = arr[i];
            }

        }

        Console.WriteLine($"The largest element in the array is: {largest}");
        Console.WriteLine($"The largest element in the array is: {smallest}");
    }
}