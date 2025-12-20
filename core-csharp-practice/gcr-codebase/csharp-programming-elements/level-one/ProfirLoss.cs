class ProfirLoss{
    public static void Main(string[] args){
        int cp=129;
        int sp=191;
        Console.WriteLine("The Cost Price is INR {0} and Selling Price is INR {1}",cp,sp);
        int p=sp-cp;
        float pp=(float)p/(float)cp*100;
        Console.WriteLine("The Profit is INR {0} and the Profit Percentage is {1}",p,pp);
    }
}