namespace Employee_List
{
    internal class Employee(string name, string role, string location, int yearsOfExperience)
    {
        public string Name { get; set; } = name;
        public string Role { get; set; } = role;
        public string Location { get; set; } = location;
        public int YearsOfExperience { get; set; } = yearsOfExperience;
    }
}
