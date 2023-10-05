namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                sum = a + b;

                //if (sum == 1 || sum == -1)
                //{
                    //response = $"{sum} dollar.";
                //}
                //else
                //{
                    //response = $"{sum} dollars.";

                //}
                 response = (sum == 1 || sum == -1) ? $"{sum} dollar." : $"{sum} dollars.";
                
            }
            return response;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(4, -3, true));

            Console.WriteLine();

            Console.WriteLine(Add(5, 7, true));

            Console.WriteLine();

            Console.WriteLine(Add(6, -7, true));
        }
    }
}
