class ATMDispense {

    private void ScenarioA(int amount) {
    
        int[] notes = {500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int numberOfNotes = 0;
        int change = amount;
        int i=0;
        while(change > 0 && i < notes.Length){
            if(change/notes[i] != 0){
               int currentNote = (change / notes[i]);
               Console.WriteLine(notes[i]+" : "+currentNote);
               numberOfNotes+=currentNote;
               change%=notes[i];
            }else{
                i++;
            }
        }
        Console.WriteLine("Total number of Notes are : "+numberOfNotes);
    }
    private void ScenarioB(int amount)
    {
        
        int[] notes = {200, 100, 50, 20, 10, 5, 2, 1 };
        int numberOfNotes = 0;
        int change = amount;
        int i=0;
        while(change > 0 && i < notes.Length){
            if(change/notes[i] != 0){
               int currentNote = (change / notes[i]);
               Console.WriteLine(notes[i]+" : "+currentNote);
               numberOfNotes+=currentNote;
               change%=notes[i];
            }else{
                i++;
            }
        }
        Console.WriteLine("Total number of Notes are : "+numberOfNotes);
    }
    private void ScenarioC(int amount)
    {
        int[] notes = {500, 200, 100};
        int numberOfNotes = 0;
        int change = amount;
        int i=0;
        while(change > 0 && i < notes.Length){
            if(change/notes[i] != 0){
               int currentNote = (change / notes[i]);
               Console.WriteLine(notes[i]+" : "+currentNote);
               numberOfNotes+=currentNote;
               change%=notes[i];
            }else{
                i++;
            }
        }
        Console.WriteLine("Total change possible is "+(amount-change));
        Console.WriteLine("Fallback is: "+change);
    }
    public static void Main(string[] args) {
        ATMDispense atm = new ATMDispense();
        atm.ScenarioA(880);
        atm.ScenarioB(853);
        atm.ScenarioC(976);
    }
}