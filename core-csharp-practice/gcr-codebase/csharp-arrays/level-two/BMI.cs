

class BMI{
    static void Main(){
    
        Console.WriteLine("Enter the number of people");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for(int i=0;i<n;i++){
            Console.WriteLine($"Enter the weight of person{i+1}");
            weight[i]=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter the height of person{i+1}");
            height[i]=Convert.ToDouble(Console.ReadLine());
        }

        for(int i=0;i<n;i++){
            bmi[i] = weight[i] / (height[i] * height[i]);
            if(bmi[i]<=18.4){
                status[i] = "Underweight";
            }else if((bmi[i]>=18.5)&&(bmi[i]<=24.9)){
                status[i] = "Normal";
            }else if((bmi[i]>=25)&&(bmi[i]<=29.9)){
                status[i] = "Overweight";
            }else{
                status[i] = "Obese";
            }
        }

        for(int i=0;i<n;i++){
            Console.WriteLine(i+1);
            Console.WriteLine("Height of person{0} = {1}",i+1,height[i]);
            Console.WriteLine("Weight of person{0} = {1}",i+1,weight[i]);
            Console.WriteLine("BMI of person{0} = {1}",i+1,bmi[i]);
            Console.WriteLine("Status of person{0} = {1}",i+1,status[i]);
        }
    }
}