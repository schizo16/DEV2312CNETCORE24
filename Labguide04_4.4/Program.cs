namespace Labguide04_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Tuan Anh",
                Phone = "023828312",
                Email = "tuananh@gmail.com",
                Enrolled = "Computer Science"
            };

            Staff staffMember = new Staff
            {
                Name = "Tuan",
                Phone = "0923782123",
                Email = "tuananh@yahoo.com",
                Salary = 50000,
                Department = "Human Resources",
                DateHired = DateTime.Now,
                Title = "HR Specialist"
            };
            Faculty facultyMember = new Faculty
            {
                Name = "Nguyen Tuan Anh",
                Phone = "0293923231",
                Email = "tuananh@example.com",
                Salary = 80000,
                Department = "Computer Science",
                DateHired = DateTime.Now,
                OfficeHours = "Monday-Friday, 9:00 AM - 5:00 PM",
                Rank = "Associate Professor"
            };

            DisplayPersonInfo(student);
            DisplayPersonInfo(staffMember);
            DisplayPersonInfo(facultyMember);

            Console.WriteLine($"Staff Bonus: {staffMember.CalculateBonus()}");
            Console.WriteLine($"Staff Vacation: {staffMember.CalculateVacation()} days");
            Console.WriteLine($"Faculty Bonus: {facultyMember.CalculateBonus()}");
            Console.WriteLine($"Faculty Vacation: {facultyMember.CalculateVacation()} days");

            

        }
        static void DisplayPersonInfo(Person person)
        {
            
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Phone: {person.Phone}");
            Console.WriteLine($"Email: {person.Email}");

            if (person is Student student)
            {
                Console.WriteLine($"Enrolled: {student.Enrolled}");
            }
            else if (person is Staff staff)
            {
                Console.WriteLine($"Salary: {staff.Salary}");
                Console.WriteLine($"Department: {staff.Department}");
                Console.WriteLine($"Date Hired: {staff.DateHired}");
                Console.WriteLine($"Title: {staff.Title}");
            }
            else if (person is Faculty faculty)
            {
                Console.WriteLine($"Salary: {faculty.Salary}");
                Console.WriteLine($"Department: {faculty.Department}");
                Console.WriteLine($"Date Hired: {faculty.DateHired}");
                Console.WriteLine($"Office Hours: {faculty.OfficeHours}");
                Console.WriteLine($"Rank: {faculty.Rank}");
            }

            Console.WriteLine();
        }
    }
}
