internal class Program
{
    private static void Main(string[] args)
    {
        string entradas;

        while ((entradas = Console.ReadLine()) != null)
        {
            string[] inputs = entradas.Split(' ');

            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int M = int.Parse(inputs[2]);

            for (int i = 0; i < M; i++)
            {
                inputs = Console.ReadLine().Split(' ');

                int Xi = int.Parse(inputs[0]);
                int Yi = int.Parse(inputs[1]);

                if ((Xi <= X && Yi <= Y) || (Xi <= Y && Yi <= X))
                    Console.WriteLine("Sim");
                else Console.WriteLine("Nao");
            }
        }
    }
}