namespace Homework4_Q2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a number:");
        int num = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Left or right?");
        string shape = Console.ReadLine();

        while (shape != "left" && shape != "Left" && shape != "right" && shape != "Right"){
            Console.WriteLine("Wrong input. Please input left or right:");
            shape = Console.ReadLine();
        }

        TriangleShape(num, shape);
    }

    static void TriangleShape(int a, string b) 
    {
        if (b == "left" || b == "Left"){
            for (int i=1; i<=a; i++){
                for (int l=a-i; l<a; l++){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        else if (b == "right" || b == "Right"){
            for (int i=1; i<=a; i++){
                for (int l=1; l<=a; l++){
                    if (l<=(a-i)){
                        Console.Write(" ");
                    }
                    else{
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}