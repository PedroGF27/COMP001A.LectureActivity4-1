// Pedro Garcia
// COMP003A
// Johnathan Cruz
// Calculate average grades
namespace COMP001A.LectureActivity4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5]; // declare array to store 5 grades

            for (int i = 0; i < grades.Length; i++) // collect and store grades
            {
                int grade = -1; // Initialize with invalid value to ensure validation starts
                while (grade < 0 || grade > 100)
                {
                    Console.Write($"Enter grade for student {i + 1} (0=100): ");
                    if (int.TryParse(Console.ReadLine(), out grade)) // Check if input is valid integer
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            grades[i] = grade;
                        }
                        else
                        {
                            Console.WriteLine("Grade must be between 0 and 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inavlid input, please enter a valid number.");
                        grade = -1; // Reset greade to invalid value to re-enter loop
                    }
            }
        }
    }
}
