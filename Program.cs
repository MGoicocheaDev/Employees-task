using Employee_List;
using System.Collections.Generic;
using System.Linq;


namespace Employee_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the list of the Employees
            var employees = new List<Employee>
            {
                new("Manuel", "Tech-Lead", "LATAM", 10),
                new("Solange", "Food-scientist", "LATAM", 6),
                new("Jose", "Designer", "USA", 3 ),
                new("Maria", "Tester", "EUROPE", 2),
                new("Carlos", "Manager", "LATAM", 15 ),
                new("Ximena", "Cheff", "EUROPE", 4 ),
                new("Rocio", "Director", "LATAM", 18),
                new("Juan", "Developer", "USA", 5),
                new("Aldo", "Tester", "ASIA", 3 ),
            };

            // Request and validate the Location input
            Console.WriteLine("Enter a location: (e.g., 'USA', 'LATAM', 'EUROPE', or 'ASIA')");
            string location = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(location))
            {
                Console.WriteLine($"\nInvalid input for Location. Input: {location} Exiting program.");
                return;
            }

            // Request and validate the YearsOfExperience input
            Console.WriteLine("\nEnter minimum years of experience:");
            string years = Console.ReadLine().Trim();
            if (!int.TryParse(years, out int minExperience))
            {
                Console.WriteLine($"\nInvalid input for years of experience. Input: {years} Exiting program.");
                return;
            }

            // Find employees by applying the filters.
            var result = employees
                .Where(x => x.Location.Equals(location, StringComparison.OrdinalIgnoreCase)
                      && x.YearsOfExperience >= minExperience)
                .ToList();

            if (!result.Any())
            {
                Console.WriteLine("\nNo matching employees could be found.");
                return;
                
            }

            Console.WriteLine("\nMatching Employees:");
            int rowIndex = 1;
            foreach (var employee in result)
            {
                Console.WriteLine($"{rowIndex} Name: {employee.Name} Role: {employee.Role} Location: {employee.Location} Years of Experience: {employee.YearsOfExperience}");
                rowIndex++;
            }

        }
    }
}
