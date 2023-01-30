namespace Homework2;
class Program
{
    static void Main(string[] args)
    {       
        Console.WriteLine("Please input a letter grade:");
        string userGrade = Console.ReadLine();

        if(userGrade == "A") {
            Console.WriteLine("GPA point: 4");
        } else if (userGrade == "B") {
            Console.WriteLine("GPA point: 3");
        } else if (userGrade == "C") {
            Console.WriteLine("GPA point: 2");
        } else if (userGrade == "D") {
            Console.WriteLine("GPA point: 1");
        } else if (userGrade == "F") {
            Console.WriteLine("GPA point: 0");
        } else {
            Console.WriteLine("Wrong Letter Grade!");
        }
    }
}