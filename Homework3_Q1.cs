namespace Homework3_Q1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer:");
        double n = Convert.ToDouble(Console.ReadLine());

        for (double i=2; i<=n; i++){
            if (i==n) {
                Console.WriteLine($"{n} is prime");
                break;
            } else if ((n/i) % 1 == 0){
                Console.WriteLine($"{n} is non-prime");
                break;
            } else {
                continue;
            }
        }
    }
}
