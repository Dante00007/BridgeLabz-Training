using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Dept { get; set; }
    public double Salary { get; set; }
}

class SerializationHandling
{
    static void Main(string[] args)
    {
        string file = "employees.json";
        List<Employee> employees = new List<Employee> {
            new Employee { Id = 1, Name = "Alice", Dept = "IT", Salary = 75000 }
        };
       
        try
        {

            string jsonString = JsonSerializer.Serialize(employees);
            File.WriteAllText(file, jsonString);

            string readJson = File.ReadAllText(file);
            var deserializedList = JsonSerializer.Deserialize<List<Employee>>(readJson);

            foreach (var emp in deserializedList)
                Console.WriteLine($"{emp.Name} from {emp.Dept}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Serialization error: " + ex.Message);
        }
    }
}