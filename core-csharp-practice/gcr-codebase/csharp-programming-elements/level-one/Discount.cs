class Discount{
	public static void Main(string[] args){
        int fee = Convert.ToInt32(Console.ReadLine());
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        double discountAmount = (fee * discountPercent)/100;
        Console.WriteLine("The discount amount is INR {0} and final discounted fee is INR {1}",discountAmount,fee-discountAmount);
	}
}