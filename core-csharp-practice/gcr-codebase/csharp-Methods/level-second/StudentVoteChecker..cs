class StudentVoteChecker{
  public static bool CanStudentVote(int age){
     if(age<0){
       return false;
     }else if(age>=18){
       return true;
     }else{
       return false;
     }
  }
  static void Main() {
    int []ages = new int[10];
    for(int i=0;i<10;i++){
      Console.WriteLine("Enter Age");
      ages[i] = Convert.ToInt32(Console.ReadLine());
    }

    for(int j=0;j<10;j++){
      if(CanStudentVote(ages[j])){
        Console.WriteLine("Age : {0} , Eligible for Vote",ages[j]);
      }else{
         Console.WriteLine("Age : {0} , Not Eligible for Vote",ages[j]);
      }
    }
    
  }
}
