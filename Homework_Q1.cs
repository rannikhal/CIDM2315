namespace Homework4_Q1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input the first number:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input the second number:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        int largerNum = LargerNum(num1, num2);

        Console.WriteLine($"The largest number is {largerNum}");

    }

    static int LargerNum (int a, int b)
    {
        if (a>b){
            return a;
        }
        else{
            return b;
        }
    }
}