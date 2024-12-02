using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Student
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

        // Конструктор
        public Student(string lastName, string firstName, string middleName, int birthDate, string address, string phoneNumber, string faculty, int course)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.birthDate = birthDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.faculty = faculty;
            this.course = course;
        }
        // Характеристики (гетери та сетери)
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public int BirthDate { get => birthDate; set => birthDate = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public int Course { get => course; set => course = value; }

        //Метод для виводу інформації про студентів
        public void Show()
        {
            Console.WriteLine($"{LastName} {FirstName} {MiddleName}, {birthDate}, {Address}, {PhoneNumber}, Факультет: {Faculty}, Курс: {Course}");
        }

        // Метод для визначення факультета студента
        public bool IsFromFaculty(string faculty)
        {
            return this.faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int a = 0, b = 0, c = 0;
            List<Student> students = new List<Student>();

            // Генерація випадкової інформації про студентів
            Random random = new Random();
            string[] faculties = { "Інженерія", "Фізика", "Хімія", "КН" };

            for (int i = 0; i < 20; i++)
            {
                students.Add(new Student(
                    $"Прізвище_{i}",
                    $"Ім'я_{i}",
                    $"По-батькові_{i}",
                    random.Next(2000, 2030),
                    $"Адреса_{i}",
                    $"123-456-{i:D4}",
                    faculties[random.Next(faculties.Length)],
                    random.Next(1, 5)
                ));
            }
            // Додати нового студента
            Console.WriteLine("\nХочете додати нового студента? (1/0):");
            a = Convert.ToInt32( Console.ReadLine() );

            if (a == 1)
            {
                Console.WriteLine("Введіть інформацію для нового студента:");

                Console.Write("Прізвище: ");
                string lastName = Console.ReadLine();

                Console.Write("Ім'я: ");
                string firstName = Console.ReadLine();

                Console.Write("По-батькові: ");
                string middleName = Console.ReadLine();

                Console.Write("Рік народження: ");
                int birthDate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Адреса: ");
                string address = Console.ReadLine();

                Console.Write("Телефонний номер: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Факультет: ");
                string faculty = Console.ReadLine();

                Console.Write("Курс: ");
                int course = Convert.ToInt32(Console.ReadLine());

                // Додаємо нового студента до списку
                students.Add(new Student(lastName, firstName, middleName, birthDate, address, phoneNumber, faculty, course));

                Console.WriteLine("\nНового студента додано!");
            }

            // Вивід всіх студентів
            Console.WriteLine("Всі студенти:");
            students.ForEach(s => s.Show());

            // Редагування студента за номером у списку
            Console.WriteLine("\nХочете редагувати студента? (1/0):");
            b = Convert.ToInt32(Console.ReadLine());

            if (b == 1)
            {
                Console.WriteLine("Введіть номер студента (від 0 до {0}):", students.Count - 1);
                int studentIndex = Convert.ToInt32(Console.ReadLine());

                // Перевірка на правильність введеного індексу
                if (studentIndex >= 0 && studentIndex < students.Count)
                {
                    // Показуємо поточні дані студента
                    Student studentToEdit = students[studentIndex];
                    Console.WriteLine("\nПоточні дані студента:");
                    studentToEdit.Show();

                    Console.WriteLine("\nРедагуйте інформацію:");

                    Console.Write("Прізвище ({0}): ", studentToEdit.LastName);
                    string newLastName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newLastName)) studentToEdit.LastName = newLastName;

                    Console.Write("Ім'я ({0}): ", studentToEdit.FirstName);
                    string newFirstName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newFirstName)) studentToEdit.FirstName = newFirstName;

                    Console.Write("По-батькові ({0}): ", studentToEdit.MiddleName);
                    string newMiddleName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newMiddleName)) studentToEdit.MiddleName = newMiddleName;

                    Console.Write("Рік народження ({0}): ", studentToEdit.BirthDate);
                    string newBirthDate = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newBirthDate)) studentToEdit.BirthDate = Convert.ToInt32(newBirthDate);

                    Console.Write("Адреса ({0}): ", studentToEdit.Address);
                    string newAddress = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newAddress)) studentToEdit.Address = newAddress;

                    Console.Write("Телефонний номер ({0}): ", studentToEdit.PhoneNumber);
                    string newPhoneNumber = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newPhoneNumber)) studentToEdit.PhoneNumber = newPhoneNumber;

                    Console.Write("Факультет ({0}): ", studentToEdit.Faculty);
                    string newFaculty = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newFaculty)) studentToEdit.Faculty = newFaculty;

                    Console.Write("Курс ({0}): ", studentToEdit.Course);
                    string newCourse = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newCourse)) studentToEdit.Course = Convert.ToInt32(newCourse);

                    Console.WriteLine("\nДані студента оновлені!");

                    // Показуємо оновлені дані студента
                    studentToEdit.Show();
                }
                else
                {
                    Console.WriteLine("Невірний номер студента.");
                }
            }

            // Вивід всіх студентів
            Console.WriteLine("Всі студенти:");
            students.ForEach(s => s.Show());

            // Видалення студентів за роком народження
            Console.WriteLine("\nХочете видалити студентів за роком народження? (1/0):");
            c = Convert.ToInt32(Console.ReadLine());

            if (c == 1)
            {
                Console.WriteLine("Введіть рік народження студентів для видалення:");
                int yearToDelete = Convert.ToInt32(Console.ReadLine());

                // Видаляємо студентів, рік народження яких дорівнює введеному
                int initialCount = students.Count;
                students.RemoveAll(s => s.BirthDate == yearToDelete);

                int deletedCount = initialCount - students.Count;
                if (deletedCount > 0)
                {
                    Console.WriteLine($"\nВидалено {deletedCount} студентів, народжених в {yearToDelete} році.");
                }
                else
                {
                    Console.WriteLine("Не знайдено студентів з таким роком народження.");
                }
            }

            // Вивід всіх студентів
            Console.WriteLine("Всі студенти:");
            students.ForEach(s => s.Show());


            // Пошук по факультету
            Console.WriteLine("\nВведіть факультет:");
            string inputFaculty = Console.ReadLine();
            var facultyStudents = students.Where(s => s.IsFromFaculty(inputFaculty)).ToList();

            if (facultyStudents.Any())
            {
                Console.WriteLine($"\nСтуденти факультету {inputFaculty}:");
                facultyStudents.ForEach(s => s.Show());
            }
            else
            {
                Console.WriteLine($"Студентів не знайдено {inputFaculty}.");
            }

            // Пошук по факультету та курсу
            Console.WriteLine("\nВведіть факультет:");
            string inputFacultyForCourse = Console.ReadLine();

            Console.WriteLine("Введіть курс:");
            int inputCourse = Convert.ToInt32(Console.ReadLine());

            var facultyAndCourseStudents = students.Where(s => s.IsFromFaculty(inputFacultyForCourse) && s.Course == inputCourse).ToList();

            if (facultyAndCourseStudents.Any())
            {
                Console.WriteLine($"\nСтуденти факультету {inputFacultyForCourse} та курсу {inputCourse}:");
                facultyAndCourseStudents.ForEach(s => s.Show());
            }
            else
            {
                Console.WriteLine($"Студентів не знайдено на факультеті {inputFacultyForCourse} та {inputCourse} курсі.");
            }


            // Народилися після 2024 року
            int year = 2024;
            var bornAfterYear = students.Where(s => s.BirthDate > year).ToList();

            if (bornAfterYear.Any())
            {
                Console.WriteLine($"\nСтуденти народжені після {year} року:");
                bornAfterYear.ForEach(s => s.Show());
            }
            else
            {
                Console.WriteLine($"Немає студентів народжених після {year} року.");
            }

            Console.ReadLine();
        }
    }
}
