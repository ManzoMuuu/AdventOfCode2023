using System.Net;
using System.Reflection.Emit;
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

    public static string LabelCreator(string newString){
        char []splitted = newString.ToCharArray();
        string label ="";
        foreach (var item in splitted){
            if (item != '=' && item != '-') label += item;
           
        }
        return label;
    }

    public static int AddOrRemove(char newString){
        if (newString == '=') return Constants.Add;
        else if(newString == '-') return Constants.Remove;
        return 0;
    }

    public static int FocusingPower (int boxNumber, int boxSlot, int focalLength){
        return (1+boxNumber) * (1+boxSlot) * focalLength;
    }
}
