namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение: ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            Random rnd = new Random ();

            for (short i = 0; i < n; i++)
                for (short j = 0; j < n; j++)
                    arr[i, j] = rnd.Next(1, 20);

            for (short i = 0; i < n; i++)
            {
                for (short j = 0; j < n; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }

            for (short i = 0; i < n; i++)
            {
                int sum = 0;
                for (short j = 0; j < n; j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine("Сумма равна: {0} Столбец: {1}", i, sum);


            }


        }
            }
        }