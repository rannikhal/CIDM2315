namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Student stu1 = new Student(111, "Alice");
        Student stu2 = new Student(222, "Bob");
        Student stu3 = new Student(333, "Cathy");
        Student stu4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(!(gradebook.ContainsKey("Tom"))){
            gradebook.Add("Tom", 3.3);
        }

        double gpa_avg=0;
        foreach(KeyValuePair<string, double> gpa in gradebook){
            gpa_avg += gpa.Value;
        }
        gpa_avg /= gradebook.Count;

        Console.WriteLine($"The average GPA is: {gpa_avg}");

        if(gradebook["Alice"]>gpa_avg){
            stu1.PrintInfo();
        }

        if(gradebook["Bob"]>gpa_avg){
            stu2.PrintInfo();
        }

        if(gradebook["Cathy"]>gpa_avg){
            stu3.PrintInfo();
        }

        if(gradebook["David"]>gpa_avg){
            stu4.PrintInfo();
        }
    }
}

class Student {
    public int studentID{set;get;}
    public string studentName{set;get;}

    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public static List<Student> studentList = new List<Student>();
    
    public Student(int studentID, string studentName){
        this.studentID = studentID;
        this.studentName = studentName;
    }
}