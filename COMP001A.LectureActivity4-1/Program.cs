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
                        grade = -1; // Reset grade to invalid value to re-enter loop
                    }
                }
            }

            double sum = 0; // calcuate average grade
            for (int i = 0; i < grades.Length; i++)
            { 
                sum += grades[i]; // add current grade to total sum
            }
            double average = sum / grades.Length;

            Console.WriteLine("\nGrades: "); // Display grades and average
            foreach (int grade in grades)
            {
                Console.WriteLine(grade); // Display grades stores in array
            }
            Console.WriteLine($"Average Grade: {average:F2}");

            List<string> studentNames = new List<string>(); // List to store students names

            for (int i = 0; i < 5; i++) // Collects the student's name
            {
                Console.Write($"Enter name for student {i + 1}: ");
                studentNames.Add(Console.ReadLine()); // Add entered name to list of students
            }

            Console.WriteLine("\nStudent Names: "); // Display student names
            for (int i = 0; i < studentNames.Count;i++) 
            {
                Console.WriteLine($"Student {i + 1}: {studentNames[i]}"); // Display each student name with their index
            }
        }
    }
}
