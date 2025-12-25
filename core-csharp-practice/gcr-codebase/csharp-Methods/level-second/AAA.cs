class AAA
{
    public static int YoungestFriend(int [,] friends){
        if(friends[0,0]<friends[1,0] && friends[0,0]<friends[2,0]){
            return 0;
        }else if(friends[1,0]<friends[0,0] && friends[1,0]<friends[2,0]){
            return 1;
        }else{
            return 2;
        }
    }
    public static int TallestFriend(int [,] friends){
        if(friends[0,1]>friends[1,1] && friends[0,1]>friends[2,1]){
            return 0;
        }else if(friends[1,1]>friends[0,1] && friends[1,1]>friends[2,1]){
            return 1;
        }else{
            return 2;
        }
    }
    static void Main()
    {
        // 0 -> Amar, 1->Akbar, 2->Anthony
        int [,] friends = new int[3,2];

        for(int i=0;i<3;i++)
        {
            for(int j=0;j<2;j++)
            {
                Console.WriteLine("Enter Age of a Friend ");
                friends[i,j]=Console.ReadLine();
                Console.WriteLine("Enter Height of a Friend in cm ");
                friends[i,j]=Console.ReadLine();
            }
        }

        int youngest=YoungestFriend(friends);
        int tallest=TallestFriend(friends);

        if(youngest==0)
        {
            Console.WriteLine("Amar is Youngest");
        }else if(youngest==1){
            Console.WriteLine("Akbar is Youngest");
        }else{
            Console.WriteLine("Anthony is Youngest");
        }

        if(tallest==0)
        {
            Console.WriteLine("Amar is Tallest");
        }else if(tallest==1){
            Console.WriteLine("Akbar is Tallest");
        }else{
            Console.WriteLine("Anthony is Tallest");
        }

    }
}