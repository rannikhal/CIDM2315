namespace Homework2;
class Program
{
    static void Main(string[] args)
    {       
        Console.WriteLine("Please input a year:");
        string yearString = Console.ReadLine();
        double yearNum = Convert.ToDouble(yearString);

        if ((yearNum / 4) % 1 == 0) {
            if (((yearNum / 100) % 1 != 0) || ((yearNum / 400) % 1 == 0)) {
                Console.WriteLine($"{yearNum} is a Leap Year.");
            } else {
                Console.WriteLine($"{yearNum} is not a Leap Year.");
            }
        } else {
            Console.WriteLine($"{yearNum} is not a Leap Year.");
        }
    }
}