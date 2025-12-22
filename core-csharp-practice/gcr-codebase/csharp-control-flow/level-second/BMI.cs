
class BMI{
    static void Main(){
        Console.WriteLine("Enter your weight");
        double weight=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your height");
        double height=Convert.ToDouble(Console.ReadLine());
        double bmi=(weight/(height*height));
        if(bmi<=18.4){
            Console.WriteLine("You are underweight");
        }else if((bmi>=18.5)&&(bmi<=24.9)){
            Console.WriteLine("Your weight is normal");
        }else if((bmi>=25)&&(bmi<=29.9)){
            Console.WriteLine("You are overweight");
        }else{
            Console.WriteLine("You are obese");
        }
    }
    
}