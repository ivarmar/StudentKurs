namespace StudentKurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            static Student MakeStudent()
            {
                Console.WriteLine("Student Name:");
                var newStudentName = Console.ReadLine();
                Console.WriteLine("Student age:");
                var newStudentAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Student course:");
                var newStudentCourse = Console.ReadLine();
                Console.WriteLine($" Welcome {newStudentName}, What course would you like to enroll in? the current options are ");
                Console.WriteLine($"'1': Get Academy\n'2':SharkDiving.\n'3':Learning to get Tan behind glass.");
                var newChosenCourse = Console.ReadLine();


                return new Student (newStudentName, newStudentAge, newStudentCourse, newChosenCourse);
                
            }

            var RegisteredStudent = MakeStudent();
            Console.WriteLine($"{MakeStudent}");
        }
    }
}