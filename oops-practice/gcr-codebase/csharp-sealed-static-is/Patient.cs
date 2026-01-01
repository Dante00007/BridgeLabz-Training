/*
 Hospital Management System
Create a Patient class with the following features:
static: 
A static variable HospitalName shared among all patients.
A static method GetTotalPatients() to count the total patients admitted.
this: 
Use this to initialize Name, Age, and Ailment in the constructor.
readonly: 
Use a readonly variable PatientID to uniquely identify each patient.
is operator: 
Check if an object is an instance of the Patient class before displaying its details.

*/

class Patient
{
    public static string HospitalName = "ABC Hospital";
    private static int totalPatients = 0;
    private  readonly int id;
    public string name;
    public int age;
    public string ailment;

    public Patient(string name, int age, string ailment, int id)
    {
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        this.id = id;
        totalPatients++;
    }
    public static int GetTotalPatients()
    {
        return totalPatients;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Patient ID: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Ailment: {ailment}");
        Console.WriteLine($"Hospital Name: {HospitalName}");
        Console.WriteLine($"Total Patients Admitted: {GetTotalPatients()}");
    }

    static void Main()
    {
        Patient p1 = new Patient("John", 25, "Fever", 1);
        if(p1 is Patient)
            p1.DisplayDetails();
    }

    
}