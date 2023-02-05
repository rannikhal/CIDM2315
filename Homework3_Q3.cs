namespace Homework3_Q3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("Assign an int value to N:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i=1; i<=N; i++){
            for(int l=N-i; l<N; l++){
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
