

class NullReference{
    static void Main(){
        string str = null;
        try{
            Console.WriteLine(str.Length);
        }
        catch(NullReferenceException e){
            Console.WriteLine(e.Message);
        }
    }
}