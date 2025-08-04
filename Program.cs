namespace Assignment5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter number {0}:", i + 1);
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("The sum of the four numbers is: " + sum);
        }
    }
}
