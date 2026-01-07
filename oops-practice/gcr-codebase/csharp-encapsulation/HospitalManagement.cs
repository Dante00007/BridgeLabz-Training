using System;

public interface IMedicalRecord
{
    void AddRecord(string entry);
    void ViewRecords();
}

public abstract class Patient
{
    private string patientId;
    private string name;
    private int age;

    public string PatientId
    {
        get { return patientId; }
        set { patientId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Patient(string id, string name, int age)
    {
        this.patientId = id;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    public string GetPatientDetails()
    {
        return "ID: " + patientId + " | Name: " + name + " | Age: " + age;
    }
}

public class InPatient : Patient, IMedicalRecord
{
    private double roomCharges;
    private int daysStayed;
    private string[] medicalHistory = new string[10];
    private int recordCount = 0;

    public InPatient(string id, string name, int age, double roomRate, int days) : base(id, name, age)
    {
        this.roomCharges = roomRate;
        this.daysStayed = days;
    }

    public override double CalculateBill()
    {
        return roomCharges * daysStayed;
    }

    public void AddRecord(string entry)
    {
        if (recordCount < medicalHistory.Length)
        {
            medicalHistory[recordCount] = entry;
            recordCount = recordCount + 1;
        }
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records for " + Name + ":");
        for (int i = 0; i < recordCount; i++)
        {
            Console.WriteLine("- " + medicalHistory[i]);
        }
    }
}

public class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;
    private string diagnosis; 
    public OutPatient(string id, string name, int age, double fee, string diag) : base(id, name, age)
    {
        this.consultationFee = fee;
        this.diagnosis = diag;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string entry)
    {
        this.diagnosis = entry;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis for " + Name + ": " + diagnosis);
    }
}
class HospitalManagement
{
    static void Main()
    {
        Patient[] ward = new Patient[2];

        ward[0] = new InPatient("P001", "John Doe", 45, 500.0, 3);
        ward[1] = new OutPatient("P002", "Jane Smith", 30, 150.0, "Common Cold");

       
        if (ward[0] is IMedicalRecord patient1Records)
        {
            patient1Records.AddRecord("Surgery performed on Jan 1st");
            patient1Records.AddRecord("Prescribed antibiotics");
        }

        Console.WriteLine("--- Hospital Billing & Records ---");
        Console.WriteLine();

        for (int i = 0; i < ward.Length; i++)
        {
            Patient p = ward[i];
            
            Console.WriteLine(p.GetPatientDetails());
            Console.WriteLine("Total Bill: $" + p.CalculateBill());

            if (p is IMedicalRecord records)
            {
                records.ViewRecords();
            }

            Console.WriteLine("------------------------------------------");
        }
    }
}