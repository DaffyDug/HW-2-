namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n,m;
            int[] array = new int[10];
            MIN_MAX_ARR_OUT(array, out n, out m);

            Console.WriteLine('\n');

            ARR_SUM(array, out n);
        }
        static void ARR_RANDOM(int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(20);
            }
        }// это просто метод рандом
        static int ARR_SUM(int[] arr, out int sum)
        {
            sum = 0;
            ARR_RANDOM(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
                sum += arr[i];
            }
            Console.WriteLine('\n');
            Console.WriteLine("sum: "+sum);
            return sum;
        }
        static void MIN_MAX_ARR_OUT(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            ARR_RANDOM(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
                if (arr[i] > max)
                {
                    max = arr[i];

                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine('\n');
            Console.WriteLine("max: " + max);
            Console.WriteLine("min: " + min);
        }
    }
}
