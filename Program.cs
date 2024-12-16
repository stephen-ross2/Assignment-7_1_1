namespace Assignment_7_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 90, 85, 77, 65, 88, 100, 95, 75, 85, 91 };

            Console.WriteLine($"Here are the unsorted test scores:");
            PrintArray(testScores);

            SelectionSort(testScores);

            Console.WriteLine($"\nHere are the sorted test scores:");
            PrintArray(testScores);

        }

        static void SelectionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int score in array)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();
        }
    }
}











