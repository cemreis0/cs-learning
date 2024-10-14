namespace CET301Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { Name = "Cem Reis", ZodiacSign = "Taurus" };
            Student student2 = new GradStudent() { Name = "Cem Reis 2", ZodiacSign = "Taurus" };
            GradStudent gradStudent1 = new GradStudent() { Name = "Cem Reis 3",ZodiacSign = "Taurus", ThesisName = "C#"};

            Console.WriteLine($"Student1: {student1}");
            Console.WriteLine($"Student2: {student2}");
            Console.WriteLine($"GradStudent1: {gradStudent1}");

            Console.WriteLine($"Student1.Id: {student1.Id}");
            Console.WriteLine($"Student2.Id: {student2.Id}");
            Console.WriteLine($"gradStudent1.Id: {gradStudent1.Id}");

            Console.WriteLine($"Student1.Name: {student1.Name}");
            Console.WriteLine($"Student2.Name: {student1.Name}");
            Console.WriteLine($"gradStudent1.Name: {gradStudent1.Name}");

            Console.WriteLine($"student1.ZodiacSign: {student1.ZodiacSign}");
            Console.WriteLine($"student2.ZodiacSign: {gradStudent1.ZodiacSign}");
            Console.WriteLine($"gradStudent1.ZodiacSign: {gradStudent1.ZodiacSign}");

            Console.WriteLine($"Student1.CalculcateGPA(): {student1.CalculateGPA():F2}");
            Console.WriteLine($"Student2.CalculcateGPA(): {student2.CalculateGPA():F2}");
            Console.WriteLine($"gradStudent1.CalculcateGPA(): {gradStudent1.CalculateGPA():F2}");

            Console.WriteLine($"gradStudent1.ThesisName: {gradStudent1.ThesisName}");
        }
    }
}
