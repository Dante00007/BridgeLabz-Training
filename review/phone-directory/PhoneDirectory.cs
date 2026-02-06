
using System.ComponentModel.DataAnnotations;

class PhoneDirectory
{
    private int size;
    private string[] Name;
    private string[] Number;
    private string[] City;
    private char[] Gender;

    public PhoneDirectory(int n)
    {
        size = n;
        Name = new string[n];
        Number = new string[n];
        City = new string[n];
        Gender = new char[n];
    }

    public void Display(int index)
    {
        if (index == -1)
        {
            Console.WriteLine("There is no value");
            return;
        }
        Console.WriteLine($"Name : {Name[index]}");
        Console.WriteLine($"Number : {Number[index]}");
        Console.WriteLine($"City : {City[index]}");
    }
    public void CreateEntry()
    {
        for (int i = 0; i < size; i++)
        {
            if (Name[i] == null)
            {
                Console.Write("Enter the Name: ");
                Name[i] = Console.ReadLine();
                Console.Write("Enter The Number: ");
                Number[i] = Console.ReadLine();
                Console.Write("Enter The City: ");
                City[i] = Console.ReadLine();
                Console.Write("Enter The Gender: ");
                Gender[i] = Console.ReadLine()[0];
                return;
            }
        }
        Console.WriteLine("Directory is Full");
    }


    public int Search(int searchBy,string key)
    {
        int ans = -1;
        if(searchBy==1){
            for(int i = 0; i < this.size; i++)
            {

                if(Name[i]!=null && Name[i].ToLower().Contains(key.ToLower()))
                    ans = i;
            }
        }
        else if(searchBy==2){
            for(int i = 0; i < size; i++)
            {
                if(Number[i]!=null && Number[i]==key)
                    ans = i;
            }
        }
        else if(searchBy==3){
            for(int i = 0; i < size; i++)
            {
                if(City[i]!=null && City[i].ToLower().Contains(key.ToLower()))
                    ans = i;
            }
        }else
        {
            Console.WriteLine("Search By valid methods");
        }
        Display(ans);
        return ans;
    
    }
    public void SearchEntry()
    {
        Console.WriteLine("Enter the What you want to Search");
        Console.WriteLine("1.Search by Name");
        Console.WriteLine("2.Search by Number");
        Console.WriteLine("3.Search by City");
        int searchBy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value to search");;
        string key = Console.ReadLine();
        int index = Search(searchBy,key);
        Display(index);
    }
    public void DeleteEntry()
    {
        Console.WriteLine("Enter the What you want to delete");
        Console.WriteLine("1.To delete by Name");
        Console.WriteLine("2.To delete by Number");

        int deleteBy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value");
        string key = Console.ReadLine();
     
        int index = Search(deleteBy,key);
        if(index==-1){
            Console.WriteLine("The Entry is not in directory");
            return;
        }
        Name[index] = null;
        Number[index] = null;
        City[index]=null;
        Gender[index] = ' ';
        Console.WriteLine("The entry is deleted");
    }
    public void UpdateEntry()
    {   
        Console.WriteLine("Enter the What you want to upadate");
        Console.WriteLine("1.To update Name");
        Console.WriteLine("2.To Update Number");
        Console.WriteLine("3.To Update City");
        int categoryToUpdate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the old value");
        string entryToUpdate = Console.ReadLine();
        Console.WriteLine("Enter the New value");
        string value = Console.ReadLine();
        int index = Search(categoryToUpdate,entryToUpdate);
        if(index==-1){
            Console.WriteLine("The Entry is not in directory");
            return;
        }
        Console.WriteLine("Before Update");
        Display(index);
        if (categoryToUpdate == 1)
        {
            Name[index] = value;
        }
        else if(categoryToUpdate==2)
        {
            Number[index] = value;
        }
        else if(categoryToUpdate==3)
        {
            City[index] = value;
        }
        else
        {
            Console.WriteLine("Valid Category");
        }
        Console.WriteLine("After update");
        Display(index);
    }
    
    static void Main()
    {
        PhoneDirectory dir = new PhoneDirectory(10);

       
        int choice = -1;
        do
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1.To Create Entry");
            Console.WriteLine("2.Update Entry");
            Console.WriteLine("3.Search Entry");
            Console.WriteLine("4.Delete Entry");
            Console.WriteLine("5.Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: dir.CreateEntry();
                        break;
                case 2: dir.UpdateEntry();
                        break;
                case 3: dir.SearchEntry();
                        break;
                case 4: dir.DeleteEntry();
                        break;
                case 5: break;
                default:
                    Console.WriteLine("Enter valid value");
                    break;
            }
        }while(choice!=5);

    }
}