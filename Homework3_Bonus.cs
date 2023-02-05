namespace Homework_Bonus;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("Assign an int value to N:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int row=1; row<=N; row++){
            for(int col=1; col<=N; col++){
                if (col<=(N-row)){
                Console.Write(" ");
                } else {
                Console.Write(row);
                }
            }
            Console.WriteLine("");
        }
    }
}
