
class Fee{
    public static void Main(string[] args){
        int fee = 125000;
        double discountPercent = 10;
        double discountAmount = (fee * discountPercent)/100;
        Console.WriteLine("The discount amount is INR {0} and final discounted fee is INR {1}",discountAmount,fee-discountAmount);
    }
}