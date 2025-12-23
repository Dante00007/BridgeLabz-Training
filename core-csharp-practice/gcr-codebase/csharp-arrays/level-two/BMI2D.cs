
class BMI2D{
	static void Main()
    {
        Console.WriteLine("Enter the number of people");
        int person = Convert.ToInt32(Console.ReadLine());
        double [,]personDesc = new double[person,3];
        string []weightstatus = new string[person];

        for(int i=0;i<person;i++)
        {
            Console.WriteLine("Enter the weight of person "+(i+1));
            personDesc[i,0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of person "+(i+1));
            personDesc[i,1] = Convert.ToDouble(Console.ReadLine());

            personDesc[i,2] = personDesc[i,0] / (personDesc[i,1] * personDesc[i,1]);
        }

        for(int j=0;j<person;j++)
        {
            if(personDesc[j,2]<18)
                weightstatus[j]="UnderWeight";
            else if(personDesc[j,2]>=18 && personDesc[j,2]<=25)
                weightstatus[j]="Normal";
            else if(personDesc[j,2]>25 && personDesc[j,2]<=30)
                weightstatus[j]="OverWeight";
            else
                weightstatus[j]="Obese";
        }

        for(int k=0;k<person;k++)
        {
            Console.WriteLine("Person "+(k+1)+" details are:");
            Console.WriteLine("Weight :"+personDesc[k,0]+" Height:"+personDesc[k,1]+" BMI:"+personDesc[k,2]+" Status:"+weightstatus[k]);
        }
    }
}