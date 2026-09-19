
using Method;
class Program
{
    static void Main(string[] args)
    {
        
        List<Student> students = new List<Student>
            {
                new Student(1, "Ba", 15),
                new Student(2, "Tuan", 17),
                new Student(3, "Dung", 12),
                new Student(4, "Hung", 13),
                new Student(5, "Hien", 16),
                new Student(6, "Anh", 18)
            };

        // a. In danh sach toan bo hoc sinh
        Console.WriteLine("--- a. Danh sach toan bo hoc sinh ---");
        students.ForEach(s => Console.WriteLine(s));

        // b. Tim va in ra hoc sinh co tuoi tu 15 den 18
        Console.WriteLine("\n--- b. Hoc sinh co tuoi tu 15 den 18 ---");
        var age15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        foreach (var s in age15To18)
        {
            Console.WriteLine(s);
        }

        // c. Tim va in ra hoc sinh co ten bat dau bang chu "A"
        Console.WriteLine("\n--- c. Hoc sinh co ten bat dau bang 'A' ---");
        var nameStartsWithA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var s in nameStartsWithA)
        {
            Console.WriteLine(s);
        }

        // d. Tinh tong tuoi cua tat ca hoc sinh trong danh sach
        Console.WriteLine("\n--- d. Tong tuoi cua tat ca hoc sinh ---");
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"Tong tuoi: {totalAge}");

        // e. Tim va in ra hoc sinh co tuoi lon nhat
        Console.WriteLine("\n--- e. Hoc sinh co tuoi lon nhat ---");
        int maxAge = students.Max(s => s.Age);
        var oldestStudents = students.Where(s => s.Age == maxAge);
        foreach (var s in oldestStudents)
        {
            Console.WriteLine(s);
        }

        // f. Sap xep danh sach hoc sinh theo tuoi tang dan
        Console.WriteLine("\n--- f. Danh sach hoc sinh sap xep theo tuoi tang dan ---");
        var sortedByAge = students.OrderBy(s => s.Age);
        foreach (var s in sortedByAge)
        {
            Console.WriteLine(s);
        }

        Console.ReadKey();
    }
}
