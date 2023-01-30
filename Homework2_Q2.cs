namespace Homework2_Q2;
class Program
{
    static void Main(string[] args)
    {       
        Console.WriteLine("Please input the first num:");
        string user_num1 = Console.ReadLine();
        Console.WriteLine("Please input the second num:");
        string user_num2 = Console.ReadLine();
        Console.WriteLine("Please input the third num:");
        string user_num3 = Console.ReadLine();

        int num1 = Convert.ToInt16(user_num1);
        int num2 = Convert.ToInt16(user_num2);
        int num3 = Convert.ToInt16(user_num3);

        if (num1 < num2) {
            if (num1 < num3) {
                Console.WriteLine($"The smallest value is: {num1}");
            } else {
                Console.WriteLine($"The smallest value is: {num3}");
            }
        } else if (num2 < num3) {
            Console.WriteLine($"The smallest value is: {num2}");
        } else {
            Console.WriteLine($"The smallest value is: {num3}");
        }
    }
}