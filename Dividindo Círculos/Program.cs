internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        if (N > 2)
        {
            long[] array1 = Enumerable.Range(1, N - 3).Select(x => (long)x).ToArray();
            long[] array2 = new long[N - 2];

            array2[0] = 1;
            for (int i = 1; i < array2.Length; i++)
                array2[i] = array2[i - 1] + array1[i - 1];

            long[] array3 = new long[N - 1];

            array3[0] = 1;
            for (int i = 1; i < array3.Length; i++)
                array3[i] = array3[i - 1] + array2[i - 1];

            long[] array4 = new long[N];

            array4[0] = 1;
            for (int i = 1; i < array4.Length; i++)
                array4[i] = array4[i - 1] + array3[i - 1];

            Console.WriteLine(array4[N - 1]);
        }
        else Console.WriteLine(N);
    }
}