namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Task 1!");

            Student student1 = new Student();
            student1.studentName = "Ashok";
            student1.studentAge = 20;
            student1.studentRollNumber = 1; // first student in the list

            Student student2 = new Student();
            student2.studentName = "Bimal";
            student2.studentAge = 21;
            student2.studentRollNumber = 2; // second student in the list

            Console.WriteLine($"Student Name: {student1.studentName}");
            Console.WriteLine($"Student Age: {student1.studentAge}");
            Console.WriteLine($"Student Roll Number: {student1.studentRollNumber}");

            Console.WriteLine();

            Console.WriteLine($"Student Name 2: {student2.studentName}");
            Console.WriteLine($"Student Age 2: {student2.studentAge}");
            Console.WriteLine($"Student Roll Number 2: {student2.studentRollNumber}");
        }
    }
}
