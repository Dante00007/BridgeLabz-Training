
class Vote{
    static void Main(){
        int[] ages = new int[10];
        int i = 0;
        while (i<10){
            Console.WriteLine("Enter Age");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        i = 0;
        while(i<10){
            if(ages[i]<0)
                Console.WriteLine("Invalid Age");
            else if(ages[i]>=18)
                Console.WriteLine("The Student With Age {0} Can Vote", ages[i]);
            else
                Console.WriteLine("The Student With Age {0} Cannot Vote",ages[i]);
            i++;
        }
    }
}