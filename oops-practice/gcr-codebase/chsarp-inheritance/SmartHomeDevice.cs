

class Device
{
    private string deviceId;
    private bool status;

    public Device(string deviceId, bool status)
    {
        SetDeviceId(deviceId);
        SetStatus(status);
    }

    public void SetDeviceId(string deviceId)
    {
        this.deviceId = deviceId;
    }

    public void SetStatus(bool status)
    {
        this.status = status;
    }   
    public string GetDeviceId()
    {
        return deviceId;
    }
    public bool GetStatus()
    {
        return status;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"\n\nDevice ID: {deviceId}, \nStatus: {(status ? "ON" : "OFF")}");
    }
}
class Thermostat : Device
{
    private double temperatureSetting;

    public Thermostat(string deviceId, bool status, double temperatureSetting) : base(deviceId, status)
    {
        this.temperatureSetting = temperatureSetting;
    }
    public void SetTemperature(double temperatureSetting)
    {
        this.temperatureSetting = temperatureSetting;
    }
    public double GetTemperature()
    {
        return temperatureSetting;
    }
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {temperatureSetting}");
    }
} 
class SmartHomeDevice {
    static void Main()
    {
        Thermostat thermostat = new Thermostat("T001", true, 72.5); 
        thermostat.DisplayStatus();
    }
}