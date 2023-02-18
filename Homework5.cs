namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3, num4;

        // Q1
        Console.WriteLine("Input the first number:");
        num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input the second number:");
        num2 = Convert.ToInt16(Console.ReadLine());

        int largerNum = LargerNum(num1, num2);

        Console.WriteLine($"a={num1}; b={num2}");
        Console.WriteLine($"The largest number is {largerNum}");



        // Q2
        Console.WriteLine("Input the first number:");
        num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input the second number:");
        num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input the third number:");
        num3 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input the fourth number:");
        num4 = Convert.ToInt16(Console.ReadLine());
        
        int max1 = LargerNum(num1, num2);
        int max2 = LargerNum(num3, num4);
        int max = LargerNum(max1, max2);

        Console.WriteLine($"a={num1}; b={num2}; c={num3}; d={num4}");
        Console.WriteLine($"The largest number is {max}");


        // Q3
        createAccount();
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

    static bool checkAge(int birth_year)
    {
        int age = 2022-birth_year;
        return age>=18 ? true : false;
    } 

    static void createAccount()
    {
        Console.WriteLine("Input Your Username:");
        string username = Console.ReadLine();

        Console.WriteLine("Input Your Password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Input Your Password Again:");
        string password2 = Console.ReadLine();

        Console.WriteLine("Input Your Birthyear:");
        int birthyear = Convert.ToInt16(Console.ReadLine());
        
        bool ageChecker = checkAge(birthyear);

        if (checkAge(birthyear) == true) 
        {
            // A loop to give the user 2 chances to input the same password twice
            // If the passwords still don't match, it will continue to the next if statement
            int i=0;
            while (password1 != password2 && i<2)
            {
                Console.WriteLine("Wrong password, please verify (Chances left: " + (3-i) + ")");
                Console.WriteLine("Input Your Password:");
                password1 = Console.ReadLine();
                Console.WriteLine("Input Your Password Again:");
                password2 = Console.ReadLine();
                i++;
            }

            if (password1 != password2)
            {
                Console.WriteLine("Wrong password");
            }
            else
            {
                Console.WriteLine("Account is created successfully");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }

}
