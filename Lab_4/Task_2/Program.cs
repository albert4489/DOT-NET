using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    // Абстрактний клас "Національність"
    abstract class Nationality
    {
        // Властивість для зберігання національності
        public abstract string Nation { get; set; }

        // Абстрактний метод для виведення інформації про національність
        public abstract void ShowNationality();
    }

    class Student : Nationality
    {
        // Приватні поля для інкапсуляції
        private string lastName;
        private string firstName;
        private string middleName;
        private int birthDate;
        private string address;
        private string phoneNumber;
        private string faculty;
        private int course;

        // Властивість для зберігання національності
        public override string Nation { get; set; }

        // Конструктор
        public Student(string lastName, string firstName, string middleName, int birthDate, string address, string phoneNumber, string faculty, int course, string nation)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.birthDate = birthDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.faculty = faculty;
            this.course = course;
            this.Nation = nation;
        }

        // Гетери та сетери
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public int BirthDate { get => birthDate; set => birthDate = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public int Course { get => course; set => course = value; }

        // Реалізація методу ShowNationality
        public override void ShowNationality()
        {
            Console.WriteLine($"Національність: {Nation}");
        }

        // Метод для виводу інформації про студентів
        public virtual void Show()
        {
            Console.WriteLine($"{LastName} {FirstName} {MiddleName}, {birthDate}, {Address}, {PhoneNumber}, Факультет: {Faculty}, Курс: {Course}");
            ShowNationality();
        }

        // Метод для визначення факультета студента
        public bool IsFromFaculty(string faculty)
        {
            return this.faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase);
        }
    }

    class AVM : Student
    {
        public double AvM { get; set; }

        public AVM(string lastName, string firstName, string middleName, int birthDate, string address, string phoneNumber, string faculty, int course, string nation, double avm)
            : base(lastName, firstName, middleName, birthDate, address, phoneNumber, faculty, course, nation)
        {
            AvM = avm;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Середній бал: {AvM:F2}");
        }
    }

    // Клас "Стипендія"
    class Scholarship : Student
    {
        public double Amount { get; set; }

        public Scholarship(string lastName, string firstName, string middleName, int birthDate, string address, string phoneNumber, string faculty, int course, string nation, double amount)
            : base(lastName, firstName, middleName, birthDate, address, phoneNumber, faculty, course, nation)
        {
            Amount = amount;
        }

        public void ShowScholarship()
        {
            Console.WriteLine($"Стипендія: {Amount} грн.");
        }

        public override void Show()
        {
            base.Show();
            ShowScholarship();
        }
    }

    // Клас "Соціальна стипендія"
    class SocialScholarship : Scholarship
    {
        public SocialScholarship(string lastName, string firstName, string middleName, int birthDate, string address, string phoneNumber, string faculty, int course, string nation, double amount)
            : base(lastName, firstName, middleName, birthDate, address, phoneNumber, faculty, course, nation, amount)
        { }

        public void SocScholarship()
        {
            Console.WriteLine($"Соціальна стипендія: {Amount} грн.");
        }

        public override void Show()
        {
            base.Show();
            SocScholarship();
        }
    }

    // Клас "Академічна стипендія"
    class AcademicScholarship : Scholarship
    {
        public AcademicScholarship(string lastName, string firstName, string middleName, int birthDate, string address, string phoneNumber, string faculty, int course, string nation, double amount)
            : base(lastName, firstName, middleName, birthDate, address, phoneNumber, faculty, course, nation, amount)
        { }

        public void AcademScholarship()
        {
            Console.WriteLine($"Академічна стипендія: {Amount} грн.");
        }

        public override void Show()
        {
            base.Show();
            AcademScholarship();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            // Студенти з різними типами стипендій
            students.Add(new AVM("Іванов", "Іван", "Іванович", 2000, "Адреса 1", "123-456-0001", "Інженерія", 2, "Українець", 4.5));
            students.Add(new SocialScholarship("Петренко", "Петро", "Петрович", 1999, "Адреса 2", "123-456-0002", "Фізика", 3, "Поляк", 1250)); // Соціальна стипендія
            students.Add(new AcademicScholarship("Сидоренко", "Сидір", "Сидорович", 2001, "Адреса 3", "123-456-0003", "Хімія", 4, "Німець", 2000)); // Академічна стипендія
            students.Add(new SocialScholarship("Коваленко", "Марія", "Олександрівна", 2002, "Адреса 4", "123-456-0004", "КН", 1, "Француз", 1250)); // Соціальна стипендія
            students.Add(new AcademicScholarship("Бондаренко", "Тарас", "Володимирович", 2003, "Адреса 5", "123-456-0005", "Фізика", 2, "Українець", 2000)); // Академічна стипендія

            // Поліморфний виклик
            Console.WriteLine("Інформація про студентів:");
            foreach (var student in students)
            {
                student.Show();
                Console.WriteLine();
            }

            // Масиви стипендій
            var socialScholarships = students.OfType<SocialScholarship>().ToList();
            var academicScholarships = students.OfType<AcademicScholarship>().ToList();

            // Виведення студентів з соціальною стипендією
            Console.WriteLine("Студенти з соціальною стипендією:");
            foreach (var student in socialScholarships)
            {
                student.Show();
            }

            // Виведення студентів з академічною стипендією
            Console.WriteLine("\nСтуденти з академічною стипендією:");
            foreach (var student in academicScholarships)
            {
                student.Show();
            }

            Console.ReadLine();
        }
    }
}
