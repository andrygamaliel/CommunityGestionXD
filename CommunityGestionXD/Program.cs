using CommunityGestionXD.Class;
using System;

namespace CommunityGestionXD
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("Chose an ooption:");
                Console.WriteLine("1. Add a Teacherr");
                Console.WriteLine("2. Add a Student");
                Console.WriteLine("3. Add an Administrative");
                Console.WriteLine("4. Add a Former Student");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTeacher();
                        break;

                    case "2":
                        AddStudent();
                        break;

                    case "3":
                        AddAdministrative();
                        break;

                    case "4":
                        AddFormerStudent();
                        break;

                    case "5":
                        continueProgram = false;
                        Console.WriteLine("end. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("try again XD.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddTeacher()
        {
            Console.Write("Enter teachers name!!: ");
            string name = Console.ReadLine();

            Console.Write("Enter teachers age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter teachers job title: ");
            string jobTitle = Console.ReadLine();

            Console.Write("Enteer teachers subject: ");
            string subject = Console.ReadLine();

            Teacher teacher = new Teacher
            {
                Name = name,
                Age = age,
                JobTitle = jobTitle,
                Subject = subject
            };

            Console.WriteLine("\nTeacher added successfully JJJJ:");
            teacher.ShowInfo();
            teacher.Work();
            teacher.Teach();
        }

        static void AddStudent()
        {
            Console.Write("Enter students name: ");
            string name = Console.ReadLine();

            Console.Write("Enter students age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter students grade: ");
            string grade = Console.ReadLine();

            Student student = new Student
            {
                Name = name,
                Age = age,
                Grade = grade
            };

            Console.WriteLine("\nStudent added successfully EPA!!:");
            student.ShowInfo();
            student.Study();
        }

        static void AddAdministrative()
        {
            Console.Write("Enter administratives name: ");
            string name = Console.ReadLine();

            Console.Write("Enter administratives age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter administratives job title: ");
            string jobTitle = Console.ReadLine();

            Console.Write("Enter administratives department: ");
            string department = Console.ReadLine();

            Administrative admin = new Administrative
            {
                Name = name,
                Age = age,
                JobTitle = jobTitle,
                Department = department
            };

            Console.WriteLine("\nAdministrative added successfully:");
            admin.ShowInfo();
            admin.Work();
            admin.Manage();
        }

        static void AddFormerStudent()
        {
            Console.Write("Enter former students name: ");
            string name = Console.ReadLine();

            Console.Write("Enter former students age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter former students graduation year: ");
            int graduationYear = int.Parse(Console.ReadLine());

            FormerStudent formerStudent = new FormerStudent
            {
                Name = name,
                Age = age,
                GraduationYear = graduationYear
            };

            Console.WriteLine("\nFormer Student added successfully!!:");
            formerStudent.ShowInfo();
            formerStudent.Remember();
        }
    }
}
