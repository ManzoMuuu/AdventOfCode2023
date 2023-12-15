using System.Text;

static class Function{

    //Holiday ASCII String Helper algorithm
    public static int HASHA(string input){
    
        int currentValue = Constants.Reset;
        
        currentValue = Constants.Reset;
        byte[] asciiBytes = Encoding.ASCII.GetBytes(input);
        foreach(byte asciiValue in asciiBytes){
            currentValue += asciiValue;
            currentValue *= Constants.Multiplier;
            currentValue %= Constants.Remainder;
        }

        
        return currentValue;
    }
}
