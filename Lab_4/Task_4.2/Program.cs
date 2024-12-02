using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._2
{
    class Grade
    {
        public string Subject { get; set; }
        public int GradeValue { get; set; }

        // Конструктор
        public Grade(string subject, int gradeValue)
        {
            Subject = subject;
            GradeValue = gradeValue;
        }

        // Метод для виведення оцінки
        public void ShowGrade()
        {
            Console.WriteLine($"Дисципліна: {Subject}, Оцінка: {GradeValue}");
        }
    }
    class Student
    {
        private string firstName;
        private string lastName;
        private int birthDate;

        // Список оцінок (композиція)
        private List<Grade> grades;

        public Student(string firstName, string lastName, int birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            grades = new List<Grade>(); // ініціалізація списку оцінок
        }
        // Методи для роботи з оцінками
        public void AddGrade(string subject, int grade)
        {
            grades.Add(new Grade(subject, grade));
        }

        public void ShowGrades()
        {
            Console.WriteLine("\nОцінки студента:");
            foreach (var grade in grades)
            {
                grade.ShowGrade();
            }
        }
        public void Show()
        {
            Console.WriteLine($"{lastName} {firstName}, {birthDate}");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Student student1 = new Student("Іванов", "Іван", 2000);
            Student student2 = new Student("Петренко", "Петро", 2001);
            Student student3 = new Student("Коваленко", "Іван", 2003);
            Student student4 = new Student("Сидоров", "Олександр", 2002);
            Student student5 = new Student("Шевченко", "Тарас", 1999);
            Student student6 = new Student("Бондаренко", "Катерина", 2004);

            // Додавання оцінок
            student1.AddGrade("Математика", 5);
            student1.AddGrade("Фізика", 4);

            student2.AddGrade("Математика", 3);
            student2.AddGrade("Біологія", 4);

            student3.AddGrade("Математика", 5);
            student3.AddGrade("Фізика", 4);

            student4.AddGrade("Фізика", 3);
            student4.AddGrade("Інформатика", 4);

            student5.AddGrade("Хімія", 5);
            student5.AddGrade("Біологія", 5);

            student6.AddGrade("Інформатика", 4);
            student6.AddGrade("Математика", 3);

            // Виведення інформації про студентів і їх оцінки
            student1.Show();
            student1.ShowGrades();
            Console.WriteLine();

            student2.Show();
            student2.ShowGrades();
            Console.WriteLine();

            student3.Show();
            student3.ShowGrades();
            Console.WriteLine();

            student4.Show();
            student4.ShowGrades();
            Console.WriteLine();

            student5.Show();
            student5.ShowGrades();
            Console.WriteLine();

            student6.Show();
            student6.ShowGrades();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
