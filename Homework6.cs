namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.salary = 9000;

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.salary = 8000;

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.studentGrade = 90;

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.studentGrade = 80;

        p1.profInfo();
        p2.profInfo();
        s1.studentInfo();
        s2.studentInfo();
        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: " + (p1.salary - p2.salary));
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: " + (s1.studentGrade + s2.studentGrade));
    }
}

class Professor {
    public string profName;
    public string classTeach;
    public double salary {set;get;}

    public void profInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
    }
}

class Student {
    public string studentName;
    public string classEnroll;
    public double studentGrade {set;get;}

    public void studentInfo(){
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
    }
}