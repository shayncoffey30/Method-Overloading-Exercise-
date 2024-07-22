namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 9));
            Console.WriteLine(Add(4m, 3m));
            Console.WriteLine(Add(4, 8, true));




        }    
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        /*If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers 
         * plus the word "dollars" at the end of the string.*/


        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                sum = num1 + num2;

                if (sum == 1)
                {
                    response = $"{sum} dollar.";

                }
                else
                {
                    response = $"{sum} dollars.";

                }
            }

            return response;
        }

        static void main(string[] args)
        {
           Console.WriteLine(Add(0, 1, true));

            Console.WriteLine();

            Console.WriteLine(Add(5, 7, true));

            Console.WriteLine ();

            Console.WriteLine(Add(-6, 3, true));

        }
    }
}
