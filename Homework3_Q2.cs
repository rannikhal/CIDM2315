namespace Homework3_Q2;

class Program 
{
  static void Main (string[] args) 
  {
    Console.WriteLine ("Assign an int value to N:");
    int N = Convert.ToInt32(Console.ReadLine());

    for (int row=0; row<N; row++){
      for(int col=0; col<N; col++){
        Console.Write("#");
      }
      Console.WriteLine("");
    }
  }
}