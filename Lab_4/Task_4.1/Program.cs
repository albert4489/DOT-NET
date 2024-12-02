using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int BirthDate { get; set; }



        public Student(string lastName, string firstName, int birthDate)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }

        public void Show()
        {
            Console.WriteLine($"{LastName} {FirstName}, {BirthDate}");
        }
    }
    class Faculty
    {
        public string Name { get; set; }
        private List<Student> students;

        // Конструктор факультету
        public Faculty(string name)
        {
            Name = name;
            students = new List<Student>();
        }

        // Додавання студента до факультету
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Студент {student.LastName} {student.FirstName} доданий до факультету {Name}.");
        }

        // Видалення студента з факультету
        public void RemoveStudent(Student student)
        {
            if (students.Contains(student))
            {
                students.Remove(student);
                Console.WriteLine($"Студент {student.LastName} {student.FirstName} видалений з факультету {Name}.");
            }
            else
            {
                Console.WriteLine("Студент не знайдений на цьому факультеті.");
            }
        }

        // Виведення всіх студентів факультету
        public void ShowFacultyStudents()
        {
            Console.WriteLine($"\nСтуденти факультету {Name}:");
            if (students.Count > 0)
            {
                students.ForEach(s => s.Show());
            }
            else
            {
                Console.WriteLine("Немає студентів на цьому факультеті.");
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;
                // Створюємо факультет
                Faculty CSFaculty = new Faculty("КН");

                // Створюємо студентів
                Student student1 = new Student("Іванов", "Іван", 2000);
                Student student2 = new Student("Петренко", "Петро", 2001);
                Student student3 = new Student("Коваленко", "Іван", 2003);
                Student student4 = new Student("Сидоров", "Олександр", 2002);
                Student student5 = new Student("Шевченко", "Тарас", 1999);
                Student student6 = new Student("Бондаренко", "Катерина", 2004);

                // Додаємо студентів на факультет
                CSFaculty.AddStudent(student1);
                CSFaculty.AddStudent(student2);
                CSFaculty.AddStudent(student3);
                CSFaculty.AddStudent(student4);
                CSFaculty.AddStudent(student5);
                CSFaculty.AddStudent(student6);

                // Виводимо студентів факультету
                CSFaculty.ShowFacultyStudents();

                // Видаляємо двох студентів
                CSFaculty.RemoveStudent(student1);
                CSFaculty.RemoveStudent(student3);

                // Виводимо студентів після видалення
                CSFaculty.ShowFacultyStudents();

                Console.ReadLine();
            }
        }
    }
}
