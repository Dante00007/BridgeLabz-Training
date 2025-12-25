
class OTP{
    public static bool IsUnique(int[] otp){
        for(int i=0;i<otp.Length;i++){
            for(int j=i+1;j<otp.Length;j++){
                if(otp[i]==otp[j])
                    return false;
            }
        }
        return true;
    }
    public static int GenerateOTP(){
        return (int)(Math.Floor(Math.Random()*1000000));
    }
    static void Main(){
        int[] otp=new int[10];
        for(int i=0;i<10;i++){
            otp[i]=GenerateOTP();
        }
        if(IsUnique(otp)){
            Console.WriteLine("OTP is unique");
        }else{
            Console.WriteLine("OTP is not unique");
        }
    }
}