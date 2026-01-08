using System;
class CallLogs
{
  
    private string phoneNumber;
    private string message;
    private DateTime timestamp;

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public string Message
    {
        get { return message; }
        set { message = value; }
    }

    public DateTime Timestamp
    {
        get { return timestamp; }
        set { timestamp = value; }
    }

    public void DisplayCallLog()
    {
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Message: " + message);
        Console.WriteLine("Timestamp: " + timestamp);
        Console.WriteLine("----------------------------");
    }
}
class CallManager
{
    private static CallLogs[] callLogs = new CallLogs[100];
    
    public static void SearchByKeyword(CallLogs[] callLogs, string keyword)
    {
        foreach (CallLogs log in callLogs)
        {
            if (log != null && log.Message.Contains(keyword))
            {
                log.DisplayCallLog();
            }
        }
    }

    public static void FilterByTime(CallLogs[] callLogs, DateTime startTime, DateTime endTime)
    {
        foreach (CallLogs log in callLogs)
        {
            if (log != null &&log.Timestamp >= startTime && log.Timestamp <= endTime)
            {
                log.DisplayCallLog();
            }
        }
    }
    

    public static void AddCallLog(string phoneNumber, string message, DateTime timestamp)
    {
        for (int i = 0; i < callLogs.Length; i++)
        {
            if (callLogs[i] == null)
            {
                callLogs[i] = new CallLogs();
                callLogs[i].PhoneNumber = phoneNumber;
                callLogs[i].Message = message;
                callLogs[i].Timestamp = timestamp;
                break;
            }
        }
    }

    public static void Main(string[] args)
    {
        AddCallLog("98282792", "could you send me assignment?", DateTime.Now);
        AddCallLog("87811287", "I love u", DateTime.Now);
        AddCallLog("12345678", "But I hate u", DateTime.Now);

        SearchByKeyword(callLogs, "love");
        FilterByTime(callLogs, DateTime.Now.AddDays(-1), DateTime.Now);
    }
}
